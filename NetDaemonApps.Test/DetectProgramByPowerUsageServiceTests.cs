﻿using MyNetdaemonSmarthome.Services;

namespace MyNetdaemonSmarthome.Test;

public class DetectProgramByPowerUsageServiceTests(DetectProgramByPowerUsageService sut, StateChangeManager state, TestEntityBuilder entityBuilder)
{
    [Fact]
    public void ProgramStart_ProgramEnd_TimeAndConsumedPowerAreCorrect()
    {
        //ARRANGE
        var (currentPowerSensor, totalPowerSensor) = CreateEntities();

        //ACT
        sut.GenerateObservable(currentPowerSensor, totalPowerSensor, x => x > 3)
            .SubscribeAndCapture(out var detectedPrograms);

        state
            .Change(totalPowerSensor, 10)
            .Change(currentPowerSensor, 5)
            .Change(totalPowerSensor, 20)
            .Change(currentPowerSensor, 10)
            .AdvanceDays(1)
            .Change(currentPowerSensor, 2);

        //ASSERT
        detectedPrograms.Should().BeEquivalentTo(new List<DetectedProgram>
        {
            new(TimeSpan.FromDays(1), 10)
        });
    }

    [Fact]
    public void NetDaemonStartsAfterProgramStart_IgnoresProgram()
    {
        //ARRANGE
        var (currentPowerSensor, totalPowerSensor) = CreateEntities();

        state
            .Change(currentPowerSensor, 5);

        //ACT
        sut.GenerateObservable(currentPowerSensor, totalPowerSensor, x => x > 3)
            .SubscribeAndCapture(out var detectedPrograms);

        state
            .Change(currentPowerSensor, 5)
            .Change(currentPowerSensor, 2);

        //ASSERT
        detectedPrograms.Should().BeEmpty();
    }

    [Fact]
    public void NetDaemonStartsBeforeProgramStart_DetectsProgram()
    {
        //ARRANGE
        var (currentPowerSensor, totalPowerSensor) = CreateEntities();

        //ACT
        sut.GenerateObservable(currentPowerSensor, totalPowerSensor, x => x > 3)
            .SubscribeAndCapture(out var detectedPrograms);

        state
            .Change(currentPowerSensor, 5)
            .Change(currentPowerSensor, 2);

        //ASSERT
        detectedPrograms.Should().BeEquivalentTo(new List<DetectedProgram>
        {
            new(TimeSpan.FromDays(0), 0)
        });
    }

    [Fact]
    public void MultiplePrograms_DetectsAllPrograms()
    {
        //ARRANGE
        var (currentPowerSensor, totalPowerSensor) = CreateEntities();

        //ACT
        sut.GenerateObservable(currentPowerSensor, totalPowerSensor, x => x > 3)
            .SubscribeAndCapture(out var detectedPrograms);

        state
            .Change(currentPowerSensor, 5)
            .Change(totalPowerSensor, 20)
            .AdvanceDays(1)
            .Change(currentPowerSensor, 2);

        state
            .Change(currentPowerSensor, 5)
            .Change(totalPowerSensor, 60)
            .AdvanceDays(2)
            .Change(currentPowerSensor, 2);

        state
            .Change(currentPowerSensor, 5)
            .Change(totalPowerSensor, 120)
            .AdvanceDays(4)
            .Change(currentPowerSensor, 2);

        //ASSERT
        detectedPrograms.Should().BeEquivalentTo(new List<DetectedProgram>
        {
            new(TimeSpan.FromDays(1), 20),
            new(TimeSpan.FromDays(2), 40),
            new(TimeSpan.FromDays(4), 60)
        });
    }

    private (NumericSensorEntity currentPowerSensor, NumericSensorEntity totalPowerSensor) CreateEntities()
    {
        var currentPowerSensor = entityBuilder.CreateNumericEntity("sensor.currentPower");
        var totalPowerSensor = entityBuilder.CreateNumericEntity("sensor.totalPower");
        return (currentPowerSensor, totalPowerSensor);
    }
}
