using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using NetDaemon.Common;
using NetDaemon.Common.Reactive;
using NetDaemon.Common.Fluent;

namespace Netdaemon.Generated.Reactive
{
    public class GeneratedAppBase : NetDaemonRxApp
    {
        public ScriptEntity Script => new ScriptEntity(this, new string[]{""});
        public WeatherEntities Weather => new WeatherEntities(this);
        public DeviceTrackerEntities DeviceTracker => new DeviceTrackerEntities(this);
        public SensorEntities Sensor => new SensorEntities(this);
        public BinarySensorEntities BinarySensor => new BinarySensorEntities(this);
        public MediaPlayerEntities MediaPlayer => new MediaPlayerEntities(this);
        public SwitchEntities Switch => new SwitchEntities(this);
        public GroupEntities Group => new GroupEntities(this);
        public ProximityEntities Proximity => new ProximityEntities(this);
        public SceneEntities Scene => new SceneEntities(this);
        public SunEntities Sun => new SunEntities(this);
        public InputTextEntities InputText => new InputTextEntities(this);
        public CoverEntities Cover => new CoverEntities(this);
        public CameraEntities Camera => new CameraEntities(this);
        public LightEntities Light => new LightEntities(this);
        public PersonEntities Person => new PersonEntities(this);
        public ZoneEntities Zone => new ZoneEntities(this);
        public AutomationEntities Automation => new AutomationEntities(this);
        public LockEntities Lock => new LockEntities(this);
        public InputNumberEntities InputNumber => new InputNumberEntities(this);
        public TimerEntities Timer => new TimerEntities(this);
        public NetdaemonEntities Netdaemon => new NetdaemonEntities(this);
        public InputSelectEntities InputSelect => new InputSelectEntities(this);
        public CalendarEntities Calendar => new CalendarEntities(this);
        public InputBooleanEntities InputBoolean => new InputBooleanEntities(this);
        public RemoteEntities Remote => new RemoteEntities(this);
    }

    public partial class ScriptEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public ScriptEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void MorningScene(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "morning_scene", serviceData);
        }

        public void DayScene(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "day_scene", serviceData);
        }

        public void EveningScene(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "evening_scene", serviceData);
        }

        public void ColorScene(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "color_scene", serviceData);
        }

        public void CleaningScene(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "cleaning_scene", serviceData);
        }

        public void NightScene(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "night_scene", serviceData);
        }

        public void TvScene(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "tv_scene", serviceData);
        }

        public void FilmScene(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "film_scene", serviceData);
        }

        public void TvOffScene(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "tv_off_scene", serviceData);
        }

        public void S1586350051032(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "1586350051032", serviceData);
        }

        public void Setnightmode(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "setnightmode", serviceData);
        }

        public void Zigbee2mqttRename(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "zigbee2mqtt_rename", serviceData);
        }

        public void Zigbee2mqttRemove(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "zigbee2mqtt_remove", serviceData);
        }

        public void Notify(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "notify", serviceData);
        }

        public void NotifyGreet(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "notify_greet", serviceData);
        }

        public void Reload(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "reload", serviceData);
        }
    }

    public partial class WeatherEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public WeatherEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }
    }

    public partial class DeviceTrackerEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public DeviceTrackerEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void See(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("device_tracker", "see", serviceData);
        }
    }

    public partial class SensorEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public SensorEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }
    }

    public partial class BinarySensorEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public BinarySensorEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }
    }

    public partial class MediaPlayerEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public MediaPlayerEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void VolumeUp(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "volume_up", serviceData);
        }

        public void VolumeDown(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "volume_down", serviceData);
        }

        public void MediaPlayPause(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "media_play_pause", serviceData);
        }

        public void MediaPlay(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "media_play", serviceData);
        }

        public void MediaPause(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "media_pause", serviceData);
        }

        public void MediaStop(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "media_stop", serviceData);
        }

        public void MediaNextTrack(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "media_next_track", serviceData);
        }

        public void MediaPreviousTrack(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "media_previous_track", serviceData);
        }

        public void ClearPlaylist(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "clear_playlist", serviceData);
        }

        public void VolumeSet(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "volume_set", serviceData);
        }

        public void VolumeMute(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "volume_mute", serviceData);
        }

        public void MediaSeek(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "media_seek", serviceData);
        }

        public void SelectSource(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "select_source", serviceData);
        }

        public void SelectSoundMode(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "select_sound_mode", serviceData);
        }

        public void PlayMedia(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "play_media", serviceData);
        }

        public void ShuffleSet(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "shuffle_set", serviceData);
        }

        public void RepeatSet(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "repeat_set", serviceData);
        }
    }

    public partial class SwitchEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public SwitchEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }
    }

    public partial class GroupEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public GroupEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void Reload(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("group", "reload", serviceData);
        }

        public void Set(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("group", "set", serviceData);
        }

        public void Remove(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("group", "remove", serviceData);
        }
    }

    public partial class ProximityEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public ProximityEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }
    }

    public partial class SceneEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public SceneEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void Reload(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("scene", "reload", serviceData);
        }

        public void Apply(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("scene", "apply", serviceData);
        }

        public void Create(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("scene", "create", serviceData);
        }
    }

    public partial class SunEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public SunEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }
    }

    public partial class InputTextEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public InputTextEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void Reload(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("input_text", "reload", serviceData);
        }

        public void SetValue(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("input_text", "set_value", serviceData);
        }
    }

    public partial class CoverEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public CoverEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void OpenCover(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("cover", "open_cover", serviceData);
        }

        public void CloseCover(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("cover", "close_cover", serviceData);
        }

        public void SetCoverPosition(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("cover", "set_cover_position", serviceData);
        }

        public void StopCover(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("cover", "stop_cover", serviceData);
        }

        public void OpenCoverTilt(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("cover", "open_cover_tilt", serviceData);
        }

        public void CloseCoverTilt(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("cover", "close_cover_tilt", serviceData);
        }

        public void StopCoverTilt(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("cover", "stop_cover_tilt", serviceData);
        }

        public void SetCoverTiltPosition(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("cover", "set_cover_tilt_position", serviceData);
        }

        public void ToggleCoverTilt(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("cover", "toggle_cover_tilt", serviceData);
        }
    }

    public partial class CameraEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public CameraEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void EnableMotionDetection(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("camera", "enable_motion_detection", serviceData);
        }

        public void DisableMotionDetection(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("camera", "disable_motion_detection", serviceData);
        }

        public void Snapshot(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("camera", "snapshot", serviceData);
        }

        public void PlayStream(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("camera", "play_stream", serviceData);
        }

        public void Record(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("camera", "record", serviceData);
        }
    }

    public partial class LightEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public LightEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }
    }

    public partial class PersonEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public PersonEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void Reload(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("person", "reload", serviceData);
        }
    }

    public partial class ZoneEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public ZoneEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void Reload(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("zone", "reload", serviceData);
        }
    }

    public partial class AutomationEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public AutomationEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void Trigger(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("automation", "trigger", serviceData);
        }

        public void Reload(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("automation", "reload", serviceData);
        }
    }

    public partial class LockEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public LockEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void Unlock(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("lock", "unlock", serviceData);
        }

        public void Lock(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("lock", "lock", serviceData);
        }

        public void Open(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("lock", "open", serviceData);
        }
    }

    public partial class InputNumberEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public InputNumberEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void Reload(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("input_number", "reload", serviceData);
        }

        public void SetValue(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("input_number", "set_value", serviceData);
        }

        public void Increment(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("input_number", "increment", serviceData);
        }

        public void Decrement(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("input_number", "decrement", serviceData);
        }
    }

    public partial class TimerEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public TimerEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void Reload(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("timer", "reload", serviceData);
        }

        public void Start(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("timer", "start", serviceData);
        }

        public void Pause(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("timer", "pause", serviceData);
        }

        public void Cancel(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("timer", "cancel", serviceData);
        }

        public void Finish(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("timer", "finish", serviceData);
        }
    }

    public partial class NetdaemonEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public NetdaemonEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void RegisterService(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("netdaemon", "register_service", serviceData);
        }

        public void ReloadApps(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("netdaemon", "reload_apps", serviceData);
        }

        public void WebhookmanagerOnwebhook(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("netdaemon", "webhookmanager_onwebhook", serviceData);
        }

        public void DebugappCallmefromhass(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("netdaemon", "debugapp_callmefromhass", serviceData);
        }
    }

    public partial class InputSelectEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public InputSelectEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void Reload(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("input_select", "reload", serviceData);
        }

        public void SelectOption(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("input_select", "select_option", serviceData);
        }

        public void SelectNext(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("input_select", "select_next", serviceData);
        }

        public void SelectPrevious(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("input_select", "select_previous", serviceData);
        }

        public void SetOptions(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("input_select", "set_options", serviceData);
        }
    }

    public partial class CalendarEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public CalendarEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }
    }

    public partial class InputBooleanEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public InputBooleanEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void Reload(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("input_boolean", "reload", serviceData);
        }
    }

    public partial class RemoteEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public RemoteEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void SendCommand(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("remote", "send_command", serviceData);
        }

        public void LearnCommand(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("remote", "learn_command", serviceData);
        }

        public void DeleteCommand(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("remote", "delete_command", serviceData);
        }
    }

    public partial class ScriptEntities
    {
        private readonly NetDaemonRxApp _app;
        public ScriptEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public ScriptEntity TvOffScene => new ScriptEntity(_app, new string[]{"script.tv_off_scene"});
        public ScriptEntity MorningScene => new ScriptEntity(_app, new string[]{"script.morning_scene"});
        public ScriptEntity EveningScene => new ScriptEntity(_app, new string[]{"script.evening_scene"});
        public ScriptEntity Zigbee2mqttRename => new ScriptEntity(_app, new string[]{"script.zigbee2mqtt_rename"});
        public ScriptEntity CleaningScene => new ScriptEntity(_app, new string[]{"script.cleaning_scene"});
        public ScriptEntity FilmScene => new ScriptEntity(_app, new string[]{"script.film_scene"});
        public ScriptEntity Setnightmode => new ScriptEntity(_app, new string[]{"script.setnightmode"});
        public ScriptEntity TvScene => new ScriptEntity(_app, new string[]{"script.tv_scene"});
        public ScriptEntity NightScene => new ScriptEntity(_app, new string[]{"script.night_scene"});
        public ScriptEntity Zigbee2mqttRemove => new ScriptEntity(_app, new string[]{"script.zigbee2mqtt_remove"});
        public ScriptEntity Notify => new ScriptEntity(_app, new string[]{"script.notify"});
        public ScriptEntity NotifyGreet => new ScriptEntity(_app, new string[]{"script.notify_greet"});
        public ScriptEntity DayScene => new ScriptEntity(_app, new string[]{"script.day_scene"});
        public ScriptEntity ColorScene => new ScriptEntity(_app, new string[]{"script.color_scene"});
        public ScriptEntity E1586350051032 => new ScriptEntity(_app, new string[]{"script.1586350051032"});
    }

    public partial class WeatherEntities
    {
        private readonly NetDaemonRxApp _app;
        public WeatherEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public WeatherEntity SmhiHemma => new WeatherEntity(_app, new string[]{"weather.smhi_hemma"});
    }

    public partial class DeviceTrackerEntities
    {
        private readonly NetDaemonRxApp _app;
        public DeviceTrackerEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public DeviceTrackerEntity TomasGalaxyWifiOld => new DeviceTrackerEntity(_app, new string[]{"device_tracker.tomas_galaxy_wifi_old"});
        public DeviceTrackerEntity YeelinkLightColor1Miio867704 => new DeviceTrackerEntity(_app, new string[]{"device_tracker.yeelink_light_color1_miio867704"});
        public DeviceTrackerEntity GoogleHomeMini5 => new DeviceTrackerEntity(_app, new string[]{"device_tracker.google_home_mini_5"});
        public DeviceTrackerEntity Harmony => new DeviceTrackerEntity(_app, new string[]{"device_tracker.harmony"});
        public DeviceTrackerEntity Piserver3 => new DeviceTrackerEntity(_app, new string[]{"device_tracker.piserver_3"});
        public DeviceTrackerEntity GalaxyS8 => new DeviceTrackerEntity(_app, new string[]{"device_tracker.galaxy_s8"});
        public DeviceTrackerEntity Sallygps => new DeviceTrackerEntity(_app, new string[]{"device_tracker.sallygps"});
        public DeviceTrackerEntity EmelieIphone => new DeviceTrackerEntity(_app, new string[]{"device_tracker.emelie_iphone"});
        public DeviceTrackerEntity TomasIpad3 => new DeviceTrackerEntity(_app, new string[]{"device_tracker.tomas_ipad_3"});
        public DeviceTrackerEntity Raspberrypi2 => new DeviceTrackerEntity(_app, new string[]{"device_tracker.raspberrypi_2"});
        public DeviceTrackerEntity Uppe => new DeviceTrackerEntity(_app, new string[]{"device_tracker.uppe"});
        public DeviceTrackerEntity Octopi => new DeviceTrackerEntity(_app, new string[]{"device_tracker.octopi"});
        public DeviceTrackerEntity SmG986b => new DeviceTrackerEntity(_app, new string[]{"device_tracker.sm_g986b"});
        public DeviceTrackerEntity E1921681104F83f512eB4E6 => new DeviceTrackerEntity(_app, new string[]{"device_tracker.192_168_1_104_f8_3f_51_2e_b4_e6"});
        public DeviceTrackerEntity SallyHuaweiWifi => new DeviceTrackerEntity(_app, new string[]{"device_tracker.sally_huawei_wifi"});
        public DeviceTrackerEntity GalaxyS10 => new DeviceTrackerEntity(_app, new string[]{"device_tracker.galaxy_s10"});
        public DeviceTrackerEntity NestAudio2 => new DeviceTrackerEntity(_app, new string[]{"device_tracker.nest_audio_2"});
        public DeviceTrackerEntity Piserver7 => new DeviceTrackerEntity(_app, new string[]{"device_tracker.piserver_7"});
        public DeviceTrackerEntity Tomass8 => new DeviceTrackerEntity(_app, new string[]{"device_tracker.tomass8"});
        public DeviceTrackerEntity ElinsIpad => new DeviceTrackerEntity(_app, new string[]{"device_tracker.elins_ipad"});
        public DeviceTrackerEntity Unifi2c2617B78551Default => new DeviceTrackerEntity(_app, new string[]{"device_tracker.unifi_2c_26_17_b7_85_51_default"});
        public DeviceTrackerEntity Chromecast2 => new DeviceTrackerEntity(_app, new string[]{"device_tracker.chromecast_2"});
        public DeviceTrackerEntity Melkergps => new DeviceTrackerEntity(_app, new string[]{"device_tracker.melkergps"});
        public DeviceTrackerEntity GoogleHomeMini2 => new DeviceTrackerEntity(_app, new string[]{"device_tracker.google_home_mini_2"});
        public DeviceTrackerEntity TomasIpad6 => new DeviceTrackerEntity(_app, new string[]{"device_tracker.tomas_ipad_6"});
        public DeviceTrackerEntity ElinsIpad3 => new DeviceTrackerEntity(_app, new string[]{"device_tracker.elins_ipad_3"});
        public DeviceTrackerEntity ElinsIpad2 => new DeviceTrackerEntity(_app, new string[]{"device_tracker.elins_ipad_2"});
        public DeviceTrackerEntity Unifi04D3B0632d29Default => new DeviceTrackerEntity(_app, new string[]{"device_tracker.unifi_04_d3_b0_63_2d_29_default"});
        public DeviceTrackerEntity NintendoWiiU => new DeviceTrackerEntity(_app, new string[]{"device_tracker.nintendo_wii_u"});
        public DeviceTrackerEntity Piserver8 => new DeviceTrackerEntity(_app, new string[]{"device_tracker.piserver_8"});
        public DeviceTrackerEntity Ipad => new DeviceTrackerEntity(_app, new string[]{"device_tracker.ipad"});
        public DeviceTrackerEntity SallyIphone2 => new DeviceTrackerEntity(_app, new string[]{"device_tracker.sally_iphone_2"});
        public DeviceTrackerEntity Shelly1 => new DeviceTrackerEntity(_app, new string[]{"device_tracker.shelly_1"});
        public DeviceTrackerEntity GoogleMaps115932713534918928318 => new DeviceTrackerEntity(_app, new string[]{"device_tracker.google_maps_115932713534918928318"});
        public DeviceTrackerEntity EspA82880 => new DeviceTrackerEntity(_app, new string[]{"device_tracker.esp_a82880"});
        public DeviceTrackerEntity Chromecast5 => new DeviceTrackerEntity(_app, new string[]{"device_tracker.chromecast_5"});
        public DeviceTrackerEntity Samsunggalaxys7 => new DeviceTrackerEntity(_app, new string[]{"device_tracker.samsunggalaxys7"});
        public DeviceTrackerEntity GoogleMapsTomash277hassioGmailCom => new DeviceTrackerEntity(_app, new string[]{"device_tracker.google_maps_tomash277hassio_gmail_com"});
        public DeviceTrackerEntity NestAudio => new DeviceTrackerEntity(_app, new string[]{"device_tracker.nest_audio"});
        public DeviceTrackerEntity Elinsipad => new DeviceTrackerEntity(_app, new string[]{"device_tracker.elinsipad"});
        public DeviceTrackerEntity MelkerHuaweiWifi => new DeviceTrackerEntity(_app, new string[]{"device_tracker.melker_huawei_wifi"});
        public DeviceTrackerEntity Piserver6 => new DeviceTrackerEntity(_app, new string[]{"device_tracker.piserver_6"});
        public DeviceTrackerEntity Tomasipad => new DeviceTrackerEntity(_app, new string[]{"device_tracker.tomasipad"});
        public DeviceTrackerEntity SallyPresence => new DeviceTrackerEntity(_app, new string[]{"device_tracker.sally_presence"});
        public DeviceTrackerEntity GoogleHomeMini4 => new DeviceTrackerEntity(_app, new string[]{"device_tracker.google_home_mini_4"});
        public DeviceTrackerEntity SamsungGalaxyS7 => new DeviceTrackerEntity(_app, new string[]{"device_tracker.samsung_galaxy_s7"});
        public DeviceTrackerEntity HuaweiMate10LiteD2b0a => new DeviceTrackerEntity(_app, new string[]{"device_tracker.huawei_mate_10_lite_d2b0a"});
        public DeviceTrackerEntity GoogleMaps118123190245690142371 => new DeviceTrackerEntity(_app, new string[]{"device_tracker.google_maps_118123190245690142371"});
        public DeviceTrackerEntity Chromecast3 => new DeviceTrackerEntity(_app, new string[]{"device_tracker.chromecast_3"});
        public DeviceTrackerEntity XboxSystemos => new DeviceTrackerEntity(_app, new string[]{"device_tracker.xbox_systemos"});
        public DeviceTrackerEntity TomasGamlaPad => new DeviceTrackerEntity(_app, new string[]{"device_tracker.tomas_gamla_pad"});
        public DeviceTrackerEntity E0024E451550a => new DeviceTrackerEntity(_app, new string[]{"device_tracker.00_24_e4_51_55_0a"});
        public DeviceTrackerEntity ElinGalaxyWifiOld => new DeviceTrackerEntity(_app, new string[]{"device_tracker.elin_galaxy_wifi_old"});
        public DeviceTrackerEntity Piserver2 => new DeviceTrackerEntity(_app, new string[]{"device_tracker.piserver_2"});
        public DeviceTrackerEntity Unifi862c82A4F469Default => new DeviceTrackerEntity(_app, new string[]{"device_tracker.unifi_86_2c_82_a4_f4_69_default"});
        public DeviceTrackerEntity ElinGalaxyWifiOldOold => new DeviceTrackerEntity(_app, new string[]{"device_tracker.elin_galaxy_wifi_old_oold"});
        public DeviceTrackerEntity UnifiC417Fe4d8f42Default => new DeviceTrackerEntity(_app, new string[]{"device_tracker.unifi_c4_17_fe_4d_8f_42_default"});
        public DeviceTrackerEntity Piserver5 => new DeviceTrackerEntity(_app, new string[]{"device_tracker.piserver_5"});
        public DeviceTrackerEntity GoogleHomeMini3 => new DeviceTrackerEntity(_app, new string[]{"device_tracker.google_home_mini_3"});
        public DeviceTrackerEntity Chromecast4 => new DeviceTrackerEntity(_app, new string[]{"device_tracker.chromecast_4"});
        public DeviceTrackerEntity Piserver => new DeviceTrackerEntity(_app, new string[]{"device_tracker.piserver"});
        public DeviceTrackerEntity EspD6983d => new DeviceTrackerEntity(_app, new string[]{"device_tracker.esp_d6983d"});
        public DeviceTrackerEntity GalaxyTabA3 => new DeviceTrackerEntity(_app, new string[]{"device_tracker.galaxy_tab_a_3"});
        public DeviceTrackerEntity Raspberrypi3 => new DeviceTrackerEntity(_app, new string[]{"device_tracker.raspberrypi_3"});
        public DeviceTrackerEntity GoogleHomeMini => new DeviceTrackerEntity(_app, new string[]{"device_tracker.google_home_mini"});
        public DeviceTrackerEntity Piserver4 => new DeviceTrackerEntity(_app, new string[]{"device_tracker.piserver_4"});
        public DeviceTrackerEntity Raspberrypi => new DeviceTrackerEntity(_app, new string[]{"device_tracker.raspberrypi"});
        public DeviceTrackerEntity TomasGalaxyWifi => new DeviceTrackerEntity(_app, new string[]{"device_tracker.tomas_galaxy_wifi"});
        public DeviceTrackerEntity Googlehome2 => new DeviceTrackerEntity(_app, new string[]{"device_tracker.googlehome_2"});
        public DeviceTrackerEntity GoogleMaps110786808112177763666 => new DeviceTrackerEntity(_app, new string[]{"device_tracker.google_maps_110786808112177763666"});
        public DeviceTrackerEntity ElgatoKeyLightAirA847 => new DeviceTrackerEntity(_app, new string[]{"device_tracker.elgato_key_light_air_a847"});
        public DeviceTrackerEntity GalaxywatchBc7b => new DeviceTrackerEntity(_app, new string[]{"device_tracker.galaxywatch_bc7b"});
        public DeviceTrackerEntity EspKamera1 => new DeviceTrackerEntity(_app, new string[]{"device_tracker.esp_kamera_1"});
        public DeviceTrackerEntity ElgatoKeyLightAirAcae => new DeviceTrackerEntity(_app, new string[]{"device_tracker.elgato_key_light_air_acae"});
        public DeviceTrackerEntity Xboxsystemos => new DeviceTrackerEntity(_app, new string[]{"device_tracker.xboxsystemos"});
        public DeviceTrackerEntity Unifi0024E451550aDefault => new DeviceTrackerEntity(_app, new string[]{"device_tracker.unifi_00_24_e4_51_55_0a_default"});
        public DeviceTrackerEntity TomasPresence => new DeviceTrackerEntity(_app, new string[]{"device_tracker.tomas_presence"});
        public DeviceTrackerEntity HuaweiMate20Pro3c5327 => new DeviceTrackerEntity(_app, new string[]{"device_tracker.huawei_mate_20_pro_3c5327"});
        public DeviceTrackerEntity E5cg709284w => new DeviceTrackerEntity(_app, new string[]{"device_tracker.5cg709284w"});
        public DeviceTrackerEntity ElinGalaxyWifi => new DeviceTrackerEntity(_app, new string[]{"device_tracker.elin_galaxy_wifi"});
        public DeviceTrackerEntity GoogleMaps113728439587103002947 => new DeviceTrackerEntity(_app, new string[]{"device_tracker.google_maps_113728439587103002947"});
        public DeviceTrackerEntity Dafang => new DeviceTrackerEntity(_app, new string[]{"device_tracker.dafang"});
        public DeviceTrackerEntity Hpg2e024 => new DeviceTrackerEntity(_app, new string[]{"device_tracker.hpg2e024"});
        public DeviceTrackerEntity Ipad2 => new DeviceTrackerEntity(_app, new string[]{"device_tracker.ipad_2"});
        public DeviceTrackerEntity GalaxyTabA2 => new DeviceTrackerEntity(_app, new string[]{"device_tracker.galaxy_tab_a_2"});
        public DeviceTrackerEntity EspKamera12 => new DeviceTrackerEntity(_app, new string[]{"device_tracker.esp_kamera_1_2"});
        public DeviceTrackerEntity TomasIpad => new DeviceTrackerEntity(_app, new string[]{"device_tracker.tomas_ipad"});
        public DeviceTrackerEntity Googlehome3 => new DeviceTrackerEntity(_app, new string[]{"device_tracker.googlehome_3"});
        public DeviceTrackerEntity MelkerGalaxyWifi => new DeviceTrackerEntity(_app, new string[]{"device_tracker.melker_galaxy_wifi"});
        public DeviceTrackerEntity UnifiAcFdCe031c4aDefault => new DeviceTrackerEntity(_app, new string[]{"device_tracker.unifi_ac_fd_ce_03_1c_4a_default"});
        public DeviceTrackerEntity Tomasgps => new DeviceTrackerEntity(_app, new string[]{"device_tracker.tomasgps"});
        public DeviceTrackerEntity SallyIphone => new DeviceTrackerEntity(_app, new string[]{"device_tracker.sally_iphone"});
        public DeviceTrackerEntity GalaxyTabA => new DeviceTrackerEntity(_app, new string[]{"device_tracker.galaxy_tab_a"});
        public DeviceTrackerEntity E5cg81709hj => new DeviceTrackerEntity(_app, new string[]{"device_tracker.5cg81709hj"});
        public DeviceTrackerEntity TomasIpad4 => new DeviceTrackerEntity(_app, new string[]{"device_tracker.tomas_ipad_4"});
        public DeviceTrackerEntity Nere => new DeviceTrackerEntity(_app, new string[]{"device_tracker.nere"});
        public DeviceTrackerEntity ElinPresence => new DeviceTrackerEntity(_app, new string[]{"device_tracker.elin_presence"});
        public DeviceTrackerEntity MelkerPresence => new DeviceTrackerEntity(_app, new string[]{"device_tracker.melker_presence"});
        public DeviceTrackerEntity UnifiE0D4E80330F9Default => new DeviceTrackerEntity(_app, new string[]{"device_tracker.unifi_e0_d4_e8_03_30_f9_default"});
        public DeviceTrackerEntity SonoffTest => new DeviceTrackerEntity(_app, new string[]{"device_tracker.sonoff_test"});
        public DeviceTrackerEntity SmG975f => new DeviceTrackerEntity(_app, new string[]{"device_tracker.sm_g975f"});
        public DeviceTrackerEntity Tomaspc => new DeviceTrackerEntity(_app, new string[]{"device_tracker.tomaspc"});
        public DeviceTrackerEntity NintendoWiiU2 => new DeviceTrackerEntity(_app, new string[]{"device_tracker.nintendo_wii_u_2"});
        public DeviceTrackerEntity TomasIpad2 => new DeviceTrackerEntity(_app, new string[]{"device_tracker.tomas_ipad_2"});
        public DeviceTrackerEntity E5cg8292f67 => new DeviceTrackerEntity(_app, new string[]{"device_tracker.5cg8292f67"});
        public DeviceTrackerEntity TomasIpad5 => new DeviceTrackerEntity(_app, new string[]{"device_tracker.tomas_ipad_5"});
        public DeviceTrackerEntity Chromecast => new DeviceTrackerEntity(_app, new string[]{"device_tracker.chromecast"});
        public DeviceTrackerEntity Sonoff1 => new DeviceTrackerEntity(_app, new string[]{"device_tracker.sonoff1"});
        public DeviceTrackerEntity GoogleHome => new DeviceTrackerEntity(_app, new string[]{"device_tracker.google_home"});
        public DeviceTrackerEntity Esp12Test => new DeviceTrackerEntity(_app, new string[]{"device_tracker.esp_12_test"});
        public DeviceTrackerEntity EfraimsIphone => new DeviceTrackerEntity(_app, new string[]{"device_tracker.efraims_iphone"});
    }

    public partial class SensorEntities
    {
        private readonly NetDaemonRxApp _app;
        public SensorEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public SensorEntity GymLedLinkquality => new SensorEntity(_app, new string[]{"sensor.gym_led_linkquality"});
        public SensorEntity SmG975fBatteryLevel => new SensorEntity(_app, new string[]{"sensor.sm_g975f_battery_level"});
        public SensorEntity MyfitnesspalHelto4real => new SensorEntity(_app, new string[]{"sensor.myfitnesspal_helto4real"});
        public SensorEntity SovrumPirRequestedBrightnessPercent => new SensorEntity(_app, new string[]{"sensor.sovrum_pir_requested_brightness_percent"});
        public SensorEntity SallysRumHum => new SensorEntity(_app, new string[]{"sensor.sallys_rum_hum"});
        public SensorEntity TvrumRullgardinVansterLinkquality => new SensorEntity(_app, new string[]{"sensor.tvrum_rullgardin_vanster_linkquality"});
        public SensorEntity E0x00158d00020b7df4Linkquality => new SensorEntity(_app, new string[]{"sensor.0x00158d00020b7df4_linkquality"});
        public SensorEntity SovrumPirUpdateState => new SensorEntity(_app, new string[]{"sensor.sovrum_pir_update_state"});
        public SensorEntity TomasRumPirBattery => new SensorEntity(_app, new string[]{"sensor.tomas_rum_pir_battery"});
        public SensorEntity TomasRumPirLinkquality => new SensorEntity(_app, new string[]{"sensor.tomas_rum_pir_linkquality"});
        public SensorEntity KokFonsterLillaLinkquality => new SensorEntity(_app, new string[]{"sensor.kok_fonster_lilla_linkquality"});
        public SensorEntity Viking028119700RssiNumeric => new SensorEntity(_app, new string[]{"sensor.viking_02811_97_00_rssi_numeric"});
        public SensorEntity SmG986bPressureSensor => new SensorEntity(_app, new string[]{"sensor.sm_g986b_pressure_sensor"});
        public SensorEntity SovrumFonsterUpdateState => new SensorEntity(_app, new string[]{"sensor.sovrum_fonster_update_state"});
        public SensorEntity JulbelysningTvrummetLinkquality => new SensorEntity(_app, new string[]{"sensor.julbelysning_tvrummet_linkquality"});
        public SensorEntity SovrumTemp => new SensorEntity(_app, new string[]{"sensor.sovrum_temp"});
        public SensorEntity LightOutsideIlluminance => new SensorEntity(_app, new string[]{"sensor.light_outside_illuminance"});
        public SensorEntity LasUppeBattery => new SensorEntity(_app, new string[]{"sensor.las_uppe_battery"});
        public SensorEntity E0x00158d0001c09b01Linkquality => new SensorEntity(_app, new string[]{"sensor.0x00158d0001c09b01_linkquality"});
        public SensorEntity TvrummVaggUpdateState => new SensorEntity(_app, new string[]{"sensor.tvrumm_vagg_update_state"});
        public SensorEntity TvrumPirBattery => new SensorEntity(_app, new string[]{"sensor.tvrum_pir_battery"});
        public SensorEntity MelkersRumTempLinkquality => new SensorEntity(_app, new string[]{"sensor.melkers_rum_temp_linkquality"});
        public SensorEntity HumOutside => new SensorEntity(_app, new string[]{"sensor.hum_outside"});
        public SensorEntity VardagsrumVansterLinkquality => new SensorEntity(_app, new string[]{"sensor.vardagsrum_vanster_linkquality"});
        public SensorEntity Viking028119700Temperature => new SensorEntity(_app, new string[]{"sensor.viking_02811_97_00_temperature"});
        public SensorEntity VardagsrumMittenLinkquality => new SensorEntity(_app, new string[]{"sensor.vardagsrum_mitten_linkquality"});
        public SensorEntity Ac294734615RssiNumeric => new SensorEntity(_app, new string[]{"sensor.ac_2947346_15_rssi_numeric"});
        public SensorEntity TomasRumPirUpdateState => new SensorEntity(_app, new string[]{"sensor.tomas_rum_pir_update_state"});
        public SensorEntity ConnectionType => new SensorEntity(_app, new string[]{"sensor.connection_type"});
        public SensorEntity Ac93bc0cfe2RssiNumeric => new SensorEntity(_app, new string[]{"sensor.ac_93bc0cfe_2_rssi_numeric"});
        public SensorEntity VardagsrumPirTemperature => new SensorEntity(_app, new string[]{"sensor.vardagsrum_pir_temperature"});
        public SensorEntity Activity => new SensorEntity(_app, new string[]{"sensor.activity"});
        public SensorEntity SmG986bDoNotDisturbSensor => new SensorEntity(_app, new string[]{"sensor.sm_g986b_do_not_disturb_sensor"});
        public SensorEntity FrysnereTemperature => new SensorEntity(_app, new string[]{"sensor.frysnere_temperature"});
        public SensorEntity Bssid => new SensorEntity(_app, new string[]{"sensor.bssid"});
        public SensorEntity CoordinatorVersion => new SensorEntity(_app, new string[]{"sensor.coordinator_version"});
        public SensorEntity Ac50bc0cfe8RssiNumeric => new SensorEntity(_app, new string[]{"sensor.ac_50bc0cfe_8_rssi_numeric"});
        public SensorEntity Ac55bc0cfe7RssiNumeric => new SensorEntity(_app, new string[]{"sensor.ac_55bc0cfe_7_rssi_numeric"});
        public SensorEntity KokPirLinkquality => new SensorEntity(_app, new string[]{"sensor.kok_pir_linkquality"});
        public SensorEntity Viking0203502038B700Temperature => new SensorEntity(_app, new string[]{"sensor.viking_0203502038_b7_00_temperature"});
        public SensorEntity FarstukvistLedUpdateState => new SensorEntity(_app, new string[]{"sensor.farstukvist_led_update_state"});
        public SensorEntity KokPirBattery => new SensorEntity(_app, new string[]{"sensor.kok_pir_battery"});
        public SensorEntity TomasIpadSsid => new SensorEntity(_app, new string[]{"sensor.tomas_ipad_ssid"});
        public SensorEntity PlexPlex => new SensorEntity(_app, new string[]{"sensor.plex_plex"});
        public SensorEntity KokFrysTemp => new SensorEntity(_app, new string[]{"sensor.kok_frys_temp"});
        public SensorEntity KokFonsterLinkquality => new SensorEntity(_app, new string[]{"sensor.kok_fonster_linkquality"});
        public SensorEntity TvrumRullgardinHogerUpdateState => new SensorEntity(_app, new string[]{"sensor.tvrum_rullgardin_hoger_update_state"});
        public SensorEntity JulbelysningKokVVoltage => new SensorEntity(_app, new string[]{"sensor.julbelysning_kok_v_voltage"});
        public SensorEntity MelkersRumPirOccupancyLinkquality => new SensorEntity(_app, new string[]{"sensor.melkers_rum_pir_occupancy_linkquality"});
        public SensorEntity TvrumRullgardinHogerLinkquality => new SensorEntity(_app, new string[]{"sensor.tvrum_rullgardin_hoger_linkquality"});
        public SensorEntity TrappPirIlluminance => new SensorEntity(_app, new string[]{"sensor.trapp_pir_illuminance"});
        public SensorEntity Load1m => new SensorEntity(_app, new string[]{"sensor.load_1m"});
        public SensorEntity MelkersRumTempBattery => new SensorEntity(_app, new string[]{"sensor.melkers_rum_temp_battery"});
        public SensorEntity Viking02811A700Temperature => new SensorEntity(_app, new string[]{"sensor.viking_02811_a7_00_temperature"});
        public SensorEntity SovrumPirRequestedBrightnessLevel => new SensorEntity(_app, new string[]{"sensor.sovrum_pir_requested_brightness_level"});
        public SensorEntity Viking02811A700BatteryNumeric => new SensorEntity(_app, new string[]{"sensor.viking_02811_a7_00_battery_numeric"});
        public SensorEntity LightOutside => new SensorEntity(_app, new string[]{"sensor.light_outside"});
        public SensorEntity LasUppeLinkquality => new SensorEntity(_app, new string[]{"sensor.las_uppe_linkquality"});
        public SensorEntity Zigbee2mqttVersion => new SensorEntity(_app, new string[]{"sensor.zigbee2mqtt_version"});
        public SensorEntity TvrumPirLinkquality => new SensorEntity(_app, new string[]{"sensor.tvrum_pir_linkquality"});
        public SensorEntity CarDepartureTime => new SensorEntity(_app, new string[]{"sensor.car_departure_time"});
        public SensorEntity JulbelysningVardagsrumHPowerOnBehavior => new SensorEntity(_app, new string[]{"sensor.julbelysning_vardagsrum_h_power_on_behavior"});
        public SensorEntity TomasIpadConnectionType => new SensorEntity(_app, new string[]{"sensor.tomas_ipad_connection_type"});
        public SensorEntity Ac72bc0cfe2RssiNumeric => new SensorEntity(_app, new string[]{"sensor.ac_72bc0cfe_2_rssi_numeric"});
        public SensorEntity JulbelysningKokVCurrent => new SensorEntity(_app, new string[]{"sensor.julbelysning_kok_v_current"});
        public SensorEntity KokFrysTempHumidity => new SensorEntity(_app, new string[]{"sensor.kok_frys_temp_humidity"});
        public SensorEntity Ac18ce36212RssiNumeric => new SensorEntity(_app, new string[]{"sensor.ac_18ce362_12_rssi_numeric"});
        public SensorEntity DiskUsePercentHome => new SensorEntity(_app, new string[]{"sensor.disk_use_percent_home"});
        public SensorEntity SmG986bGeocodedLocation => new SensorEntity(_app, new string[]{"sensor.sm_g986b_geocoded_location"});
        public SensorEntity Ac15bc0cfe1RssiNumeric => new SensorEntity(_app, new string[]{"sensor.ac_15bc0cfe_1_rssi_numeric"});
        public SensorEntity MelkersFonsterLinkquality => new SensorEntity(_app, new string[]{"sensor.melkers_fonster_linkquality"});
        public SensorEntity TomasIpadStorage => new SensorEntity(_app, new string[]{"sensor.tomas_ipad_storage"});
        public SensorEntity Ac51bc0cfe8RssiNumeric => new SensorEntity(_app, new string[]{"sensor.ac_51bc0cfe_8_rssi_numeric"});
        public SensorEntity JulbelysningTvrummetCurrent => new SensorEntity(_app, new string[]{"sensor.julbelysning_tvrummet_current"});
        public SensorEntity SmG986bNextAlarm => new SensorEntity(_app, new string[]{"sensor.sm_g986b_next_alarm"});
        public SensorEntity Ac63bc0cfe9RssiNumeric => new SensorEntity(_app, new string[]{"sensor.ac_63bc0cfe_9_rssi_numeric"});
        public SensorEntity JulbelysningHogerLinkquality => new SensorEntity(_app, new string[]{"sensor.julbelysning_hoger_linkquality"});
        public SensorEntity TomasRumPirRequestedBrightnessPercent => new SensorEntity(_app, new string[]{"sensor.tomas_rum_pir_requested_brightness_percent"});
        public SensorEntity SallysRumPirUpdateState => new SensorEntity(_app, new string[]{"sensor.sallys_rum_pir_update_state"});
        public SensorEntity TvrumCube => new SensorEntity(_app, new string[]{"sensor.tvrum_cube"});
        public SensorEntity UteTempLinkquality => new SensorEntity(_app, new string[]{"sensor.ute_temp_linkquality"});
        public SensorEntity SallysRumPirRequestedBrightnessPercent => new SensorEntity(_app, new string[]{"sensor.sallys_rum_pir_requested_brightness_percent"});
        public SensorEntity JulbelysningKokVLinkquality => new SensorEntity(_app, new string[]{"sensor.julbelysning_kok_v_linkquality"});
        public SensorEntity SallysRumPirRequestedBrightnessLevel => new SensorEntity(_app, new string[]{"sensor.sallys_rum_pir_requested_brightness_level"});
        public SensorEntity YtMe4le => new SensorEntity(_app, new string[]{"sensor.yt_me4le"});
        public SensorEntity JulbelysningVardagsrumVLinkquality => new SensorEntity(_app, new string[]{"sensor.julbelysning_vardagsrum_v_linkquality"});
        public SensorEntity TvrumCubeLinkquality => new SensorEntity(_app, new string[]{"sensor.tvrum_cube_linkquality"});
        public SensorEntity VardagsrumPirIlluminanceLux => new SensorEntity(_app, new string[]{"sensor.vardagsrum_pir_illuminance_lux"});
        public SensorEntity GymLedUpdateState => new SensorEntity(_app, new string[]{"sensor.gym_led_update_state"});
        public SensorEntity TrappPirLinkquality => new SensorEntity(_app, new string[]{"sensor.trapp_pir_linkquality"});
        public SensorEntity SnapshotBackup => new SensorEntity(_app, new string[]{"sensor.snapshot_backup"});
        public SensorEntity VardagsrumTempBattery => new SensorEntity(_app, new string[]{"sensor.vardagsrum_temp_battery"});
        public SensorEntity VardagsrumTempHumidity => new SensorEntity(_app, new string[]{"sensor.vardagsrum_temp_humidity"});
        public SensorEntity Load5m => new SensorEntity(_app, new string[]{"sensor.load_5m"});
        public SensorEntity LastBoot => new SensorEntity(_app, new string[]{"sensor.last_boot"});
        public SensorEntity DiodTemp => new SensorEntity(_app, new string[]{"sensor.diod_temp"});
        public SensorEntity HouseMode => new SensorEntity(_app, new string[]{"sensor.house_mode"});
        public SensorEntity Ac34bc0cfe6RssiNumeric => new SensorEntity(_app, new string[]{"sensor.ac_34bc0cfe_6_rssi_numeric"});
        public SensorEntity VardagsrumFonsterVansterUpdateState => new SensorEntity(_app, new string[]{"sensor.vardagsrum_fonster_vanster_update_state"});
        public SensorEntity HobbyrumTempBattery => new SensorEntity(_app, new string[]{"sensor.hobbyrum_temp_battery"});
        public SensorEntity Ac51bc0cfe4RssiNumeric => new SensorEntity(_app, new string[]{"sensor.ac_51bc0cfe_4_rssi_numeric"});
        public SensorEntity Viking028119700 => new SensorEntity(_app, new string[]{"sensor.viking_02811_97_00"});
        public SensorEntity VardagsrumPirLinkquality => new SensorEntity(_app, new string[]{"sensor.vardagsrum_pir_linkquality"});
        public SensorEntity BatteryState => new SensorEntity(_app, new string[]{"sensor.battery_state"});
        public SensorEntity HallDorrLinkquality => new SensorEntity(_app, new string[]{"sensor.hall_dorr_linkquality"});
        public SensorEntity FarstukvistLedLinkquality => new SensorEntity(_app, new string[]{"sensor.farstukvist_led_linkquality"});
        public SensorEntity JulbelysningVardagsrumVUpdateState => new SensorEntity(_app, new string[]{"sensor.julbelysning_vardagsrum_v_update_state"});
        public SensorEntity KrisinformationVasternorrland => new SensorEntity(_app, new string[]{"sensor.krisinformation_vasternorrland"});
        public SensorEntity Zigbee2mqttBridgeState => new SensorEntity(_app, new string[]{"sensor.zigbee2mqtt_bridge_state"});
        public SensorEntity MotorvarmareHogerUpdateState => new SensorEntity(_app, new string[]{"sensor.motorvarmare_hoger_update_state"});
        public SensorEntity TrappPirBattery => new SensorEntity(_app, new string[]{"sensor.trapp_pir_battery"});
        public SensorEntity VardagsrumHogerLinkquality => new SensorEntity(_app, new string[]{"sensor.vardagsrum_hoger_linkquality"});
        public SensorEntity VardagsrumPirIlluminance => new SensorEntity(_app, new string[]{"sensor.vardagsrum_pir_illuminance"});
        public SensorEntity MelkersFonsterUpdateState => new SensorEntity(_app, new string[]{"sensor.melkers_fonster_update_state"});
        public SensorEntity Ac2bc0cfe1RssiNumeric => new SensorEntity(_app, new string[]{"sensor.ac_2bc0cfe_1_rssi_numeric"});
        public SensorEntity JulbelysningTvrummetEnergy => new SensorEntity(_app, new string[]{"sensor.julbelysning_tvrummet_energy"});
        public SensorEntity SmG975fWifiConnection => new SensorEntity(_app, new string[]{"sensor.sm_g975f_wifi_connection"});
        public SensorEntity TvrumRullgardinVansterUpdateState => new SensorEntity(_app, new string[]{"sensor.tvrum_rullgardin_vanster_update_state"});
        public SensorEntity MelkersRumPirOccupancyRequestedBrightnessPercent => new SensorEntity(_app, new string[]{"sensor.melkers_rum_pir_occupancy_requested_brightness_percent"});
        public SensorEntity VardagsrumTempLinkquality => new SensorEntity(_app, new string[]{"sensor.vardagsrum_temp_linkquality"});
        public SensorEntity SmG986bWifiConnection => new SensorEntity(_app, new string[]{"sensor.sm_g986b_wifi_connection"});
        public SensorEntity TvrumFonsterHogerUpdateState => new SensorEntity(_app, new string[]{"sensor.tvrum_fonster_hoger_update_state"});
        public SensorEntity HallByraUpdateState => new SensorEntity(_app, new string[]{"sensor.hall_byra_update_state"});
        public SensorEntity VardagsrumPirBattery => new SensorEntity(_app, new string[]{"sensor.vardagsrum_pir_battery"});
        public SensorEntity JulbelysningHogerUpdateState => new SensorEntity(_app, new string[]{"sensor.julbelysning_hoger_update_state"});
        public SensorEntity E0x00158d00020b7df4Battery => new SensorEntity(_app, new string[]{"sensor.0x00158d00020b7df4_battery"});
        public SensorEntity TvrumBakgrundTvLinkquality => new SensorEntity(_app, new string[]{"sensor.tvrum_bakgrund_tv_linkquality"});
        public SensorEntity LightOutsideBattery => new SensorEntity(_app, new string[]{"sensor.light_outside_battery"});
        public SensorEntity Ac81bc0cfe1RssiNumeric => new SensorEntity(_app, new string[]{"sensor.ac_81bc0cfe_1_rssi_numeric"});
        public SensorEntity ProcessorUse => new SensorEntity(_app, new string[]{"sensor.processor_use"});
        public SensorEntity JulbelysningTvrummetPower => new SensorEntity(_app, new string[]{"sensor.julbelysning_tvrummet_power"});
        public SensorEntity TvrumRullgardinVansterBattery => new SensorEntity(_app, new string[]{"sensor.tvrum_rullgardin_vanster_battery"});
        public SensorEntity KokPirIlluminance => new SensorEntity(_app, new string[]{"sensor.kok_pir_illuminance"});
        public SensorEntity GeocodedLocation => new SensorEntity(_app, new string[]{"sensor.geocoded_location"});
        public SensorEntity Ac18ce36211RssiNumeric => new SensorEntity(_app, new string[]{"sensor.ac_18ce362_11_rssi_numeric"});
        public SensorEntity UteTemp => new SensorEntity(_app, new string[]{"sensor.ute_temp"});
        public SensorEntity YtQg8r => new SensorEntity(_app, new string[]{"sensor.yt_qg8r"});
        public SensorEntity SallysRumPirBattery => new SensorEntity(_app, new string[]{"sensor.sallys_rum_pir_battery"});
        public SensorEntity SmG986bBatteryLevel => new SensorEntity(_app, new string[]{"sensor.sm_g986b_battery_level"});
        public SensorEntity YtPewdiepie => new SensorEntity(_app, new string[]{"sensor.yt_pewdiepie"});
        public SensorEntity JulbelysningTomasRumLinkquality => new SensorEntity(_app, new string[]{"sensor.julbelysning_tomas_rum_linkquality"});
        public SensorEntity VardagsrumFonsterMittenUpdateState => new SensorEntity(_app, new string[]{"sensor.vardagsrum_fonster_mitten_update_state"});
        public SensorEntity TomasIpadBatteryState => new SensorEntity(_app, new string[]{"sensor.tomas_ipad_battery_state"});
        public SensorEntity UteHum => new SensorEntity(_app, new string[]{"sensor.ute_hum"});
        public SensorEntity SovrumTempBattery => new SensorEntity(_app, new string[]{"sensor.sovrum_temp_battery"});
        public SensorEntity Hacs => new SensorEntity(_app, new string[]{"sensor.hacs"});
        public SensorEntity TomasIpadBssid => new SensorEntity(_app, new string[]{"sensor.tomas_ipad_bssid"});
        public SensorEntity Viking0203502038B700HumidityStatus => new SensorEntity(_app, new string[]{"sensor.viking_0203502038_b7_00_humidity_status"});
        public SensorEntity SmG986bLightSensor => new SensorEntity(_app, new string[]{"sensor.sm_g986b_light_sensor"});
        public SensorEntity TomasIpadActivity => new SensorEntity(_app, new string[]{"sensor.tomas_ipad_activity"});
        public SensorEntity TvrumPirIlluminance => new SensorEntity(_app, new string[]{"sensor.tvrum_pir_illuminance"});
        public SensorEntity SmG986bBatteryHealth => new SensorEntity(_app, new string[]{"sensor.sm_g986b_battery_health"});
        public SensorEntity SmG986bBluetoothConnection => new SensorEntity(_app, new string[]{"sensor.sm_g986b_bluetooth_connection"});
        public SensorEntity Load15m => new SensorEntity(_app, new string[]{"sensor.load_15m"});
        public SensorEntity Viking0203502038B700BatteryNumeric => new SensorEntity(_app, new string[]{"sensor.viking_0203502038_b7_00_battery_numeric"});
        public SensorEntity SallysFonsterPowerOnBehavior => new SensorEntity(_app, new string[]{"sensor.sallys_fonster_power_on_behavior"});
        public SensorEntity Ac39bc0cfe7RssiNumeric => new SensorEntity(_app, new string[]{"sensor.ac_39bc0cfe_7_rssi_numeric"});
        public SensorEntity TvrumCubeBatt => new SensorEntity(_app, new string[]{"sensor.tvrum_cube_batt"});
        public SensorEntity TomasRumPirRequestedBrightnessLevel => new SensorEntity(_app, new string[]{"sensor.tomas_rum_pir_requested_brightness_level"});
        public SensorEntity MelkersRumTemp => new SensorEntity(_app, new string[]{"sensor.melkers_rum_temp"});
        public SensorEntity JulbelysningKokHPowerOnBehavior => new SensorEntity(_app, new string[]{"sensor.julbelysning_kok_h_power_on_behavior"});
        public SensorEntity TempOutside => new SensorEntity(_app, new string[]{"sensor.temp_outside"});
        public SensorEntity MelkersRumPirUpdateState => new SensorEntity(_app, new string[]{"sensor.melkers_rum_pir_update_state"});
        public SensorEntity JulbelysningKokHLinkquality => new SensorEntity(_app, new string[]{"sensor.julbelysning_kok_h_linkquality"});
        public SensorEntity VardagsrumPirOccupancyTimeout => new SensorEntity(_app, new string[]{"sensor.vardagsrum_pir_occupancy_timeout"});
        public SensorEntity SmG975fBatteryState => new SensorEntity(_app, new string[]{"sensor.sm_g975f_battery_state"});
        public SensorEntity Viking0203502038B700 => new SensorEntity(_app, new string[]{"sensor.viking_0203502038_b7_00"});
        public SensorEntity BatteryLevel => new SensorEntity(_app, new string[]{"sensor.battery_level"});
        public SensorEntity HobbyrumTempLinkquality => new SensorEntity(_app, new string[]{"sensor.hobbyrum_temp_linkquality"});
        public SensorEntity MelkersRumTempHumidity => new SensorEntity(_app, new string[]{"sensor.melkers_rum_temp_humidity"});
        public SensorEntity SallysFonsterUpdateState => new SensorEntity(_app, new string[]{"sensor.sallys_fonster_update_state"});
        public SensorEntity SmG975fGeocodedLocation => new SensorEntity(_app, new string[]{"sensor.sm_g975f_geocoded_location"});
        public SensorEntity TomasRumUpdateState => new SensorEntity(_app, new string[]{"sensor.tomas_rum_update_state"});
        public SensorEntity TvrumRullgardinHogerBattery => new SensorEntity(_app, new string[]{"sensor.tvrum_rullgardin_hoger_battery"});
        public SensorEntity SovrumFonsterLinkquality => new SensorEntity(_app, new string[]{"sensor.sovrum_fonster_linkquality"});
        public SensorEntity SmG986bProximitySensor => new SensorEntity(_app, new string[]{"sensor.sm_g986b_proximity_sensor"});
        public SensorEntity MelkersRumPirOccupancyBattery => new SensorEntity(_app, new string[]{"sensor.melkers_rum_pir_occupancy_battery"});
        public SensorEntity Ac44bc0cfe1RssiNumeric => new SensorEntity(_app, new string[]{"sensor.ac_44bc0cfe_1_rssi_numeric"});
        public SensorEntity HobbyrumTemp => new SensorEntity(_app, new string[]{"sensor.hobbyrum_temp"});
        public SensorEntity SallysRumTempBatt => new SensorEntity(_app, new string[]{"sensor.sallys_rum_temp_batt"});
        public SensorEntity TvrumHogerLinkquality => new SensorEntity(_app, new string[]{"sensor.tvrum_hoger_linkquality"});
        public SensorEntity SmG986bBatteryState => new SensorEntity(_app, new string[]{"sensor.sm_g986b_battery_state"});
        public SensorEntity VardagsrumTemp => new SensorEntity(_app, new string[]{"sensor.vardagsrum_temp"});
        public SensorEntity Ac36bc0cfe8RssiNumeric => new SensorEntity(_app, new string[]{"sensor.ac_36bc0cfe_8_rssi_numeric"});
        public SensorEntity SovrumByraUpdateState => new SensorEntity(_app, new string[]{"sensor.sovrum_byra_update_state"});
        public SensorEntity VardagsrumPirMotionSensitivity => new SensorEntity(_app, new string[]{"sensor.vardagsrum_pir_motion_sensitivity"});
        public SensorEntity UteTempBattery => new SensorEntity(_app, new string[]{"sensor.ute_temp_battery"});
        public SensorEntity JulbelysningKokHUpdateState => new SensorEntity(_app, new string[]{"sensor.julbelysning_kok_h_update_state"});
        public SensorEntity SovrumPirLinkquality => new SensorEntity(_app, new string[]{"sensor.sovrum_pir_linkquality"});
        public SensorEntity HallDorrUpdateState => new SensorEntity(_app, new string[]{"sensor.hall_dorr_update_state"});
        public SensorEntity NetworkOutWlp2s0 => new SensorEntity(_app, new string[]{"sensor.network_out_wlp2s0"});
        public SensorEntity TvrummVaggLinkquality => new SensorEntity(_app, new string[]{"sensor.tvrumm_vagg_linkquality"});
        public SensorEntity TomasIpadStorage2 => new SensorEntity(_app, new string[]{"sensor.tomas_ipad_storage_2"});
        public SensorEntity SmG986bChargerType => new SensorEntity(_app, new string[]{"sensor.sm_g986b_charger_type"});
        public SensorEntity HobbyrumTempHum => new SensorEntity(_app, new string[]{"sensor.hobbyrum_temp_hum"});
        public SensorEntity MemoryUsePercent => new SensorEntity(_app, new string[]{"sensor.memory_use_percent"});
        public SensorEntity YtHelto => new SensorEntity(_app, new string[]{"sensor.yt_helto"});
        public SensorEntity Ssid => new SensorEntity(_app, new string[]{"sensor.ssid"});
        public SensorEntity Viking0203502038B700RssiNumeric => new SensorEntity(_app, new string[]{"sensor.viking_0203502038_b7_00_rssi_numeric"});
        public SensorEntity TvrumFonsterVansterUpdateState => new SensorEntity(_app, new string[]{"sensor.tvrum_fonster_vanster_update_state"});
        public SensorEntity SallysFonsterLinkquality => new SensorEntity(_app, new string[]{"sensor.sallys_fonster_linkquality"});
        public SensorEntity JulbelysningTvrummetVoltage => new SensorEntity(_app, new string[]{"sensor.julbelysning_tvrummet_voltage"});
        public SensorEntity TomasIpadGeocodedLocation => new SensorEntity(_app, new string[]{"sensor.tomas_ipad_geocoded_location"});
        public SensorEntity KokFonsterUpdateState => new SensorEntity(_app, new string[]{"sensor.kok_fonster_update_state"});
        public SensorEntity MotorvarmareHogerLinkquality => new SensorEntity(_app, new string[]{"sensor.motorvarmare_hoger_linkquality"});
        public SensorEntity JulbelysningKokVEnergy => new SensorEntity(_app, new string[]{"sensor.julbelysning_kok_v_energy"});
        public SensorEntity SmG986bLastReboot => new SensorEntity(_app, new string[]{"sensor.sm_g986b_last_reboot"});
        public SensorEntity Viking02811A700RssiNumeric => new SensorEntity(_app, new string[]{"sensor.viking_02811_a7_00_rssi_numeric"});
        public SensorEntity Viking0203502038B700Humidity => new SensorEntity(_app, new string[]{"sensor.viking_0203502038_b7_00_humidity"});
        public SensorEntity TvrumBakgrundTvUpdateState => new SensorEntity(_app, new string[]{"sensor.tvrum_bakgrund_tv_update_state"});
        public SensorEntity VardagsrumFonsterHogerUpdateState => new SensorEntity(_app, new string[]{"sensor.vardagsrum_fonster_hoger_update_state"});
        public SensorEntity KokFrysTempBattery => new SensorEntity(_app, new string[]{"sensor.kok_frys_temp_battery"});
        public SensorEntity SmG986bAudioSensor => new SensorEntity(_app, new string[]{"sensor.sm_g986b_audio_sensor"});
        public SensorEntity SovrumTempLinkquality => new SensorEntity(_app, new string[]{"sensor.sovrum_temp_linkquality"});
        public SensorEntity LightOutsideLinkquality => new SensorEntity(_app, new string[]{"sensor.light_outside_linkquality"});
        public SensorEntity Ac52bc0cfe1RssiNumeric => new SensorEntity(_app, new string[]{"sensor.ac_52bc0cfe_1_rssi_numeric"});
        public SensorEntity TvrumVansterLinkquality => new SensorEntity(_app, new string[]{"sensor.tvrum_vanster_linkquality"});
        public SensorEntity Ac29bc0cfe6RssiNumeric => new SensorEntity(_app, new string[]{"sensor.ac_29bc0cfe_6_rssi_numeric"});
        public SensorEntity JulbelysningKokVPower => new SensorEntity(_app, new string[]{"sensor.julbelysning_kok_v_power"});
        public SensorEntity Ac294734616RssiNumeric => new SensorEntity(_app, new string[]{"sensor.ac_2947346_16_rssi_numeric"});
        public SensorEntity JulbelysningTomasRumUpdateState => new SensorEntity(_app, new string[]{"sensor.julbelysning_tomas_rum_update_state"});
        public SensorEntity SovrumPirBattery => new SensorEntity(_app, new string[]{"sensor.sovrum_pir_battery"});
        public SensorEntity SovrumByraLinkquality => new SensorEntity(_app, new string[]{"sensor.sovrum_byra_linkquality"});
        public SensorEntity SallysRumTemp => new SensorEntity(_app, new string[]{"sensor.sallys_rum_temp"});
        public SensorEntity TomasIpadLastUpdateTrigger => new SensorEntity(_app, new string[]{"sensor.tomas_ipad_last_update_trigger"});
        public SensorEntity TomasIpadBatteryLevel => new SensorEntity(_app, new string[]{"sensor.tomas_ipad_battery_level"});
        public SensorEntity JulbelysningVardagsrumVPowerOnBehavior => new SensorEntity(_app, new string[]{"sensor.julbelysning_vardagsrum_v_power_on_behavior"});
        public SensorEntity Ac67bc0cfe4RssiNumeric => new SensorEntity(_app, new string[]{"sensor.ac_67bc0cfe_4_rssi_numeric"});
        public SensorEntity SmG986bStorageSensor => new SensorEntity(_app, new string[]{"sensor.sm_g986b_storage_sensor"});
        public SensorEntity LastUpdateTrigger => new SensorEntity(_app, new string[]{"sensor.last_update_trigger"});
        public SensorEntity Ac294734614RssiNumeric => new SensorEntity(_app, new string[]{"sensor.ac_2947346_14_rssi_numeric"});
        public SensorEntity TomasRumLinkquality => new SensorEntity(_app, new string[]{"sensor.tomas_rum_linkquality"});
        public SensorEntity VardagsrumPirUpdateState => new SensorEntity(_app, new string[]{"sensor.vardagsrum_pir_update_state"});
        public SensorEntity SovrumTempHumidity => new SensorEntity(_app, new string[]{"sensor.sovrum_temp_humidity"});
        public SensorEntity SallysRumPirLinkquality => new SensorEntity(_app, new string[]{"sensor.sallys_rum_pir_linkquality"});
        public SensorEntity MelkersRumPirOccupancyRequestedBrightnessLevel => new SensorEntity(_app, new string[]{"sensor.melkers_rum_pir_occupancy_requested_brightness_level"});
        public SensorEntity MelkersFonsterPowerOnBehavior => new SensorEntity(_app, new string[]{"sensor.melkers_fonster_power_on_behavior"});
        public SensorEntity KokFrysTempLinkquality => new SensorEntity(_app, new string[]{"sensor.kok_frys_temp_linkquality"});
        public SensorEntity JulbelysningTomasRumPowerOnBehavior => new SensorEntity(_app, new string[]{"sensor.julbelysning_tomas_rum_power_on_behavior"});
        public SensorEntity HallByraLinkquality => new SensorEntity(_app, new string[]{"sensor.hall_byra_linkquality"});
        public SensorEntity KokFonsterLillaUpdateState => new SensorEntity(_app, new string[]{"sensor.kok_fonster_lilla_update_state"});
        public SensorEntity Viking028119700BatteryNumeric => new SensorEntity(_app, new string[]{"sensor.viking_02811_97_00_battery_numeric"});
    }

    public partial class BinarySensorEntities
    {
        private readonly NetDaemonRxApp _app;
        public BinarySensorEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public BinarySensorEntity JulbelysningTomasRumUpdateAvailable => new BinarySensorEntity(_app, new string[]{"binary_sensor.julbelysning_tomas_rum_update_available"});
        public BinarySensorEntity SweRecyclingMatfors => new BinarySensorEntity(_app, new string[]{"binary_sensor.swe_recycling_matfors"});
        public BinarySensorEntity Ac51bc0cfe4 => new BinarySensorEntity(_app, new string[]{"binary_sensor.ac_51bc0cfe_4"});
        public BinarySensorEntity Kamera3MotionDetected => new BinarySensorEntity(_app, new string[]{"binary_sensor.kamera_3_motion_detected"});
        public BinarySensorEntity MelkersRumPirOccupancyUpdateAvailable => new BinarySensorEntity(_app, new string[]{"binary_sensor.melkers_rum_pir_occupancy_update_available"});
        public BinarySensorEntity Sonoff1Button => new BinarySensorEntity(_app, new string[]{"binary_sensor.sonoff1_button"});
        public BinarySensorEntity SovrumPir => new BinarySensorEntity(_app, new string[]{"binary_sensor.sovrum_pir"});
        public BinarySensorEntity SovrumPirUpdateAvailable => new BinarySensorEntity(_app, new string[]{"binary_sensor.sovrum_pir_update_available"});
        public BinarySensorEntity Ac39bc0cfe7 => new BinarySensorEntity(_app, new string[]{"binary_sensor.ac_39bc0cfe_7"});
        public BinarySensorEntity Ac72bc0cfe2 => new BinarySensorEntity(_app, new string[]{"binary_sensor.ac_72bc0cfe_2"});
        public BinarySensorEntity SmG986bIsCharging => new BinarySensorEntity(_app, new string[]{"binary_sensor.sm_g986b_is_charging"});
        public BinarySensorEntity Ac44bc0cfe1 => new BinarySensorEntity(_app, new string[]{"binary_sensor.ac_44bc0cfe_1"});
        public BinarySensorEntity TvrumHogerUpdateAvailable => new BinarySensorEntity(_app, new string[]{"binary_sensor.tvrum_hoger_update_available"});
        public BinarySensorEntity HallDorrUpdateAvailable => new BinarySensorEntity(_app, new string[]{"binary_sensor.hall_dorr_update_available"});
        public BinarySensorEntity SovrumByraUpdateAvailable => new BinarySensorEntity(_app, new string[]{"binary_sensor.sovrum_byra_update_available"});
        public BinarySensorEntity Ac81bc0cfe1 => new BinarySensorEntity(_app, new string[]{"binary_sensor.ac_81bc0cfe_1"});
        public BinarySensorEntity VardagsrumPir => new BinarySensorEntity(_app, new string[]{"binary_sensor.vardagsrum_pir"});
        public BinarySensorEntity TvrumRullgardinHogerUpdateAvailable => new BinarySensorEntity(_app, new string[]{"binary_sensor.tvrum_rullgardin_hoger_update_available"});
        public BinarySensorEntity TvrumRullgardinVansterUpdateAvailable => new BinarySensorEntity(_app, new string[]{"binary_sensor.tvrum_rullgardin_vanster_update_available"});
        public BinarySensorEntity MelkersFonsterUpdateAvailable => new BinarySensorEntity(_app, new string[]{"binary_sensor.melkers_fonster_update_available"});
        public BinarySensorEntity Ac63bc0cfe9 => new BinarySensorEntity(_app, new string[]{"binary_sensor.ac_63bc0cfe_9"});
        public BinarySensorEntity KokPir => new BinarySensorEntity(_app, new string[]{"binary_sensor.kok_pir"});
        public BinarySensorEntity TvrummVaggUpdateAvailable => new BinarySensorEntity(_app, new string[]{"binary_sensor.tvrumm_vagg_update_available"});
        public BinarySensorEntity Ac55bc0cfe7 => new BinarySensorEntity(_app, new string[]{"binary_sensor.ac_55bc0cfe_7"});
        public BinarySensorEntity JulbelysningVardagsrumVUpdateAvailable => new BinarySensorEntity(_app, new string[]{"binary_sensor.julbelysning_vardagsrum_v_update_available"});
        public BinarySensorEntity Ac294734614 => new BinarySensorEntity(_app, new string[]{"binary_sensor.ac_2947346_14"});
        public BinarySensorEntity HallByraUpdateAvailable => new BinarySensorEntity(_app, new string[]{"binary_sensor.hall_byra_update_available"});
        public BinarySensorEntity Updater => new BinarySensorEntity(_app, new string[]{"binary_sensor.updater"});
        public BinarySensorEntity TvrumBakgrundTvUpdateAvailable => new BinarySensorEntity(_app, new string[]{"binary_sensor.tvrum_bakgrund_tv_update_available"});
        public BinarySensorEntity TomasRumPirUpdateAvailable => new BinarySensorEntity(_app, new string[]{"binary_sensor.tomas_rum_pir_update_available"});
        public BinarySensorEntity SnapshotsStale => new BinarySensorEntity(_app, new string[]{"binary_sensor.snapshots_stale"});
        public BinarySensorEntity VardagsrumVansterUpdateAvailable => new BinarySensorEntity(_app, new string[]{"binary_sensor.vardagsrum_vanster_update_available"});
        public BinarySensorEntity Ac36bc0cfe8 => new BinarySensorEntity(_app, new string[]{"binary_sensor.ac_36bc0cfe_8"});
        public BinarySensorEntity KokFonsterLillaUpdateAvailable => new BinarySensorEntity(_app, new string[]{"binary_sensor.kok_fonster_lilla_update_available"});
        public BinarySensorEntity Ac294734616 => new BinarySensorEntity(_app, new string[]{"binary_sensor.ac_2947346_16"});
        public BinarySensorEntity SallysRumPirUpdateAvailable => new BinarySensorEntity(_app, new string[]{"binary_sensor.sallys_rum_pir_update_available"});
        public BinarySensorEntity Ac18ce36212 => new BinarySensorEntity(_app, new string[]{"binary_sensor.ac_18ce362_12"});
        public BinarySensorEntity SallysRumPir => new BinarySensorEntity(_app, new string[]{"binary_sensor.sallys_rum_pir"});
        public BinarySensorEntity SallysFonsterUpdateAvailable => new BinarySensorEntity(_app, new string[]{"binary_sensor.sallys_fonster_update_available"});
        public BinarySensorEntity SweRecyclingVattjom => new BinarySensorEntity(_app, new string[]{"binary_sensor.swe_recycling_vattjom"});
        public BinarySensorEntity VardagsrumMittenUpdateAvailable => new BinarySensorEntity(_app, new string[]{"binary_sensor.vardagsrum_mitten_update_available"});
        public BinarySensorEntity JulbelysningKokHUpdateAvailable => new BinarySensorEntity(_app, new string[]{"binary_sensor.julbelysning_kok_h_update_available"});
        public BinarySensorEntity Ac50bc0cfe8 => new BinarySensorEntity(_app, new string[]{"binary_sensor.ac_50bc0cfe_8"});
        public BinarySensorEntity Ac51bc0cfe8 => new BinarySensorEntity(_app, new string[]{"binary_sensor.ac_51bc0cfe_8"});
        public BinarySensorEntity TrappPir => new BinarySensorEntity(_app, new string[]{"binary_sensor.trapp_pir"});
        public BinarySensorEntity Ac29bc0cfe6 => new BinarySensorEntity(_app, new string[]{"binary_sensor.ac_29bc0cfe_6"});
        public BinarySensorEntity Ac52bc0cfe1 => new BinarySensorEntity(_app, new string[]{"binary_sensor.ac_52bc0cfe_1"});
        public BinarySensorEntity JulbelysningHogerUpdateAvailable => new BinarySensorEntity(_app, new string[]{"binary_sensor.julbelysning_hoger_update_available"});
        public BinarySensorEntity Ac2bc0cfe1 => new BinarySensorEntity(_app, new string[]{"binary_sensor.ac_2bc0cfe_1"});
        public BinarySensorEntity Ac67bc0cfe4 => new BinarySensorEntity(_app, new string[]{"binary_sensor.ac_67bc0cfe_4"});
        public BinarySensorEntity FarstukvistLedUpdateAvailable => new BinarySensorEntity(_app, new string[]{"binary_sensor.farstukvist_led_update_available"});
        public BinarySensorEntity MelkersRumPirOccupancy => new BinarySensorEntity(_app, new string[]{"binary_sensor.melkers_rum_pir_occupancy"});
        public BinarySensorEntity Ac15bc0cfe1 => new BinarySensorEntity(_app, new string[]{"binary_sensor.ac_15bc0cfe_1"});
        public BinarySensorEntity Ac18ce36211 => new BinarySensorEntity(_app, new string[]{"binary_sensor.ac_18ce362_11"});
        public BinarySensorEntity Ac34bc0cfe6 => new BinarySensorEntity(_app, new string[]{"binary_sensor.ac_34bc0cfe_6"});
        public BinarySensorEntity VardagsrumHogerUpdateAvailable => new BinarySensorEntity(_app, new string[]{"binary_sensor.vardagsrum_hoger_update_available"});
        public BinarySensorEntity TomasRumPir => new BinarySensorEntity(_app, new string[]{"binary_sensor.tomas_rum_pir"});
        public BinarySensorEntity SwInput => new BinarySensorEntity(_app, new string[]{"binary_sensor.sw_input"});
        public BinarySensorEntity KokFonsterUpdateAvailable => new BinarySensorEntity(_app, new string[]{"binary_sensor.kok_fonster_update_available"});
        public BinarySensorEntity TvrumVansterUpdateAvailable => new BinarySensorEntity(_app, new string[]{"binary_sensor.tvrum_vanster_update_available"});
        public BinarySensorEntity VardagsrumPirUpdateAvailable => new BinarySensorEntity(_app, new string[]{"binary_sensor.vardagsrum_pir_update_available"});
        public BinarySensorEntity SovrumFonsterUpdateAvailable => new BinarySensorEntity(_app, new string[]{"binary_sensor.sovrum_fonster_update_available"});
        public BinarySensorEntity TvrumPir => new BinarySensorEntity(_app, new string[]{"binary_sensor.tvrum_pir"});
        public BinarySensorEntity GymLedUpdateAvailable => new BinarySensorEntity(_app, new string[]{"binary_sensor.gym_led_update_available"});
        public BinarySensorEntity Ac93bc0cfe2 => new BinarySensorEntity(_app, new string[]{"binary_sensor.ac_93bc0cfe_2"});
        public BinarySensorEntity HallDorr => new BinarySensorEntity(_app, new string[]{"binary_sensor.hall_dorr"});
        public BinarySensorEntity Ac294734615 => new BinarySensorEntity(_app, new string[]{"binary_sensor.ac_2947346_15"});
        public BinarySensorEntity TomasRumUpdateAvailable => new BinarySensorEntity(_app, new string[]{"binary_sensor.tomas_rum_update_available"});
        public BinarySensorEntity MotorvarmareHogerUpdateAvailable => new BinarySensorEntity(_app, new string[]{"binary_sensor.motorvarmare_hoger_update_available"});
    }

    public partial class MediaPlayerEntities
    {
        private readonly NetDaemonRxApp _app;
        public MediaPlayerEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public MediaPlayerEntity Kok => new MediaPlayerEntity(_app, new string[]{"media_player.kok"});
        public MediaPlayerEntity PlexPlexWebChromeLinux2 => new MediaPlayerEntity(_app, new string[]{"media_player.plex_plex_web_chrome_linux_2"});
        public MediaPlayerEntity PlexChrome2 => new MediaPlayerEntity(_app, new string[]{"media_player.plex_chrome_2"});
        public MediaPlayerEntity TvNere => new MediaPlayerEntity(_app, new string[]{"media_player.tv_nere"});
        public MediaPlayerEntity PlexPlexCastChromecast => new MediaPlayerEntity(_app, new string[]{"media_player.plex_plex_cast_chromecast"});
        public MediaPlayerEntity ShieldTv => new MediaPlayerEntity(_app, new string[]{"media_player.shield_tv"});
        public MediaPlayerEntity Vardagsrum => new MediaPlayerEntity(_app, new string[]{"media_player.vardagsrum"});
        public MediaPlayerEntity Sovrum => new MediaPlayerEntity(_app, new string[]{"media_player.sovrum"});
        public MediaPlayerEntity PlexChrome3 => new MediaPlayerEntity(_app, new string[]{"media_player.plex_chrome_3"});
        public MediaPlayerEntity TvRummetGh => new MediaPlayerEntity(_app, new string[]{"media_player.tv_rummet_gh"});
        public MediaPlayerEntity PlexChrome => new MediaPlayerEntity(_app, new string[]{"media_player.plex_chrome"});
        public MediaPlayerEntity Huset => new MediaPlayerEntity(_app, new string[]{"media_player.huset"});
        public MediaPlayerEntity PlexChromecast => new MediaPlayerEntity(_app, new string[]{"media_player.plex_chromecast"});
        public MediaPlayerEntity MelkersTv => new MediaPlayerEntity(_app, new string[]{"media_player.melkers_tv"});
        public MediaPlayerEntity Gym => new MediaPlayerEntity(_app, new string[]{"media_player.gym"});
        public MediaPlayerEntity TvUppe => new MediaPlayerEntity(_app, new string[]{"media_player.tv_uppe"});
        public MediaPlayerEntity PlexPlexWebChrome => new MediaPlayerEntity(_app, new string[]{"media_player.plex_plex_web_chrome"});
        public MediaPlayerEntity Nestaudio0573 => new MediaPlayerEntity(_app, new string[]{"media_player.nestaudio0573"});
        public MediaPlayerEntity PlexPlexForAndroidTvShieldAndroidTv => new MediaPlayerEntity(_app, new string[]{"media_player.plex_plex_for_android_tv_shield_android_tv"});
        public MediaPlayerEntity Shield => new MediaPlayerEntity(_app, new string[]{"media_player.shield"});
        public MediaPlayerEntity PlexPlexWebChromeLinux => new MediaPlayerEntity(_app, new string[]{"media_player.plex_plex_web_chrome_linux"});
        public MediaPlayerEntity PlexTomasIpad => new MediaPlayerEntity(_app, new string[]{"media_player.plex_tomas_ipad"});
        public MediaPlayerEntity SallysHogtalare => new MediaPlayerEntity(_app, new string[]{"media_player.sallys_hogtalare"});
        public MediaPlayerEntity TvGym => new MediaPlayerEntity(_app, new string[]{"media_player.tv_gym"});
        public MediaPlayerEntity MelkersRum => new MediaPlayerEntity(_app, new string[]{"media_player.melkers_rum"});
        public MediaPlayerEntity PlexKodiAddOnLibreelec => new MediaPlayerEntity(_app, new string[]{"media_player.plex_kodi_add_on_libreelec"});
    }

    public partial class SwitchEntities
    {
        private readonly NetDaemonRxApp _app;
        public SwitchEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public SwitchEntity Ac51bc0cfe8 => new SwitchEntity(_app, new string[]{"switch.ac_51bc0cfe_8"});
        public SwitchEntity MelkersRumFonster => new SwitchEntity(_app, new string[]{"switch.melkers_rum_fonster"});
        public SwitchEntity Ac44bc0cfe1 => new SwitchEntity(_app, new string[]{"switch.ac_44bc0cfe_1"});
        public SwitchEntity NetdaemonWebhook => new SwitchEntity(_app, new string[]{"switch.netdaemon_webhook"});
        public SwitchEntity NetdaemonHacsNotifyOnUpdate => new SwitchEntity(_app, new string[]{"switch.netdaemon_hacs_notify_on_update"});
        public SwitchEntity Ac29bc0cfe6 => new SwitchEntity(_app, new string[]{"switch.ac_29bc0cfe_6"});
        public SwitchEntity Ac34bc0cfe6 => new SwitchEntity(_app, new string[]{"switch.ac_34bc0cfe_6"});
        public SwitchEntity NetdaemonRoomSpecific => new SwitchEntity(_app, new string[]{"switch.netdaemon_room_specific"});
        public SwitchEntity Ac294734616 => new SwitchEntity(_app, new string[]{"switch.ac_2947346_16"});
        public SwitchEntity ShellyRelay => new SwitchEntity(_app, new string[]{"switch.shelly_relay"});
        public SwitchEntity Switch8MelkersTv => new SwitchEntity(_app, new string[]{"switch.switch8_melkers_tv"});
        public SwitchEntity NetdaemonDebugApp => new SwitchEntity(_app, new string[]{"switch.netdaemon_debug_app"});
        public SwitchEntity Ac51bc0cfe4 => new SwitchEntity(_app, new string[]{"switch.ac_51bc0cfe_4"});
        public SwitchEntity Ac18ce36211 => new SwitchEntity(_app, new string[]{"switch.ac_18ce362_11"});
        public SwitchEntity NetdaemonFrys => new SwitchEntity(_app, new string[]{"switch.netdaemon_frys"});
        public SwitchEntity Tv => new SwitchEntity(_app, new string[]{"switch.tv"});
        public SwitchEntity Zigbee2mqttMainJoin => new SwitchEntity(_app, new string[]{"switch.zigbee2mqtt_main_join"});
        public SwitchEntity JulbelysningKokV => new SwitchEntity(_app, new string[]{"switch.julbelysning_kok_v"});
        public SwitchEntity JulbelysningVardagsrumH => new SwitchEntity(_app, new string[]{"switch.julbelysning_vardagsrum_h"});
        public SwitchEntity Ac81bc0cfe1 => new SwitchEntity(_app, new string[]{"switch.ac_81bc0cfe_1"});
        public SwitchEntity Ac55bc0cfe7 => new SwitchEntity(_app, new string[]{"switch.ac_55bc0cfe_7"});
        public SwitchEntity Film => new SwitchEntity(_app, new string[]{"switch.film"});
        public SwitchEntity Ac36bc0cfe8 => new SwitchEntity(_app, new string[]{"switch.ac_36bc0cfe_8"});
        public SwitchEntity JulbelysningTomasRum => new SwitchEntity(_app, new string[]{"switch.julbelysning_tomas_rum"});
        public SwitchEntity Ac93bc0cfe2 => new SwitchEntity(_app, new string[]{"switch.ac_93bc0cfe_2"});
        public SwitchEntity Ac67bc0cfe4 => new SwitchEntity(_app, new string[]{"switch.ac_67bc0cfe_4"});
        public SwitchEntity NetdaemonMotorvarmare => new SwitchEntity(_app, new string[]{"switch.netdaemon_motorvarmare"});
        public SwitchEntity ComputerTomas => new SwitchEntity(_app, new string[]{"switch.computer_tomas"});
        public SwitchEntity Kodi => new SwitchEntity(_app, new string[]{"switch.kodi"});
        public SwitchEntity NetdaemonHouseStateManager => new SwitchEntity(_app, new string[]{"switch.netdaemon_house_state_manager"});
        public SwitchEntity JulbelysningVardagsrumV => new SwitchEntity(_app, new string[]{"switch.julbelysning_vardagsrum_v"});
        public SwitchEntity Ac294734614 => new SwitchEntity(_app, new string[]{"switch.ac_2947346_14"});
        public SwitchEntity Ac18ce36212 => new SwitchEntity(_app, new string[]{"switch.ac_18ce362_12"});
        public SwitchEntity Ac52bc0cfe1 => new SwitchEntity(_app, new string[]{"switch.ac_52bc0cfe_1"});
        public SwitchEntity MotorvarmareHoger => new SwitchEntity(_app, new string[]{"switch.motorvarmare_hoger"});
        public SwitchEntity Ac294734615 => new SwitchEntity(_app, new string[]{"switch.ac_2947346_15"});
        public SwitchEntity SallysRumFonster => new SwitchEntity(_app, new string[]{"switch.sallys_rum_fonster"});
        public SwitchEntity JulbelysningKokH => new SwitchEntity(_app, new string[]{"switch.julbelysning_kok_h"});
        public SwitchEntity Sonoff1Relay => new SwitchEntity(_app, new string[]{"switch.sonoff1_relay"});
        public SwitchEntity ADiod => new SwitchEntity(_app, new string[]{"switch.a_diod"});
        public SwitchEntity NetdaemonPersistantApp => new SwitchEntity(_app, new string[]{"switch.netdaemon_persistant_app"});
        public SwitchEntity TvrumVagg => new SwitchEntity(_app, new string[]{"switch.tvrum_vagg"});
        public SwitchEntity NetdaemonCalendarTrash => new SwitchEntity(_app, new string[]{"switch.netdaemon_calendar_trash"});
        public SwitchEntity NetdaemonMagicCube => new SwitchEntity(_app, new string[]{"switch.netdaemon_magic_cube"});
        public SwitchEntity NetdaemonHelloWorldApp => new SwitchEntity(_app, new string[]{"switch.netdaemon_hello_world_app"});
        public SwitchEntity Ac50bc0cfe8 => new SwitchEntity(_app, new string[]{"switch.ac_50bc0cfe_8"});
        public SwitchEntity NetdaemonWelcomeHome => new SwitchEntity(_app, new string[]{"switch.netdaemon_welcome_home"});
        public SwitchEntity Ac2bc0cfe1 => new SwitchEntity(_app, new string[]{"switch.ac_2bc0cfe_1"});
        public SwitchEntity JulbelysningTvrummet => new SwitchEntity(_app, new string[]{"switch.julbelysning_tvrummet"});
        public SwitchEntity NetdaemonTv => new SwitchEntity(_app, new string[]{"switch.netdaemon_tv"});
        public SwitchEntity NetdaemonLightManager => new SwitchEntity(_app, new string[]{"switch.netdaemon_light_manager"});
        public SwitchEntity Ac39bc0cfe7 => new SwitchEntity(_app, new string[]{"switch.ac_39bc0cfe_7"});
        public SwitchEntity Ac15bc0cfe1 => new SwitchEntity(_app, new string[]{"switch.ac_15bc0cfe_1"});
        public SwitchEntity NetdaemonMotion => new SwitchEntity(_app, new string[]{"switch.netdaemon_motion"});
    }

    public partial class GroupEntities
    {
        private readonly NetDaemonRxApp _app;
        public GroupEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public GroupEntity SallysDevices => new GroupEntity(_app, new string[]{"group.sallys_devices"});
        public GroupEntity Remotes => new GroupEntity(_app, new string[]{"group.remotes"});
        public GroupEntity LowBatteryDevices => new GroupEntity(_app, new string[]{"group.low_battery_devices"});
        public GroupEntity Presence => new GroupEntity(_app, new string[]{"group.presence"});
        public GroupEntity PeopleStatus => new GroupEntity(_app, new string[]{"group.people_status"});
        public GroupEntity Kodis => new GroupEntity(_app, new string[]{"group.kodis"});
        public GroupEntity Cameras => new GroupEntity(_app, new string[]{"group.cameras"});
        public GroupEntity Googlehomes => new GroupEntity(_app, new string[]{"group.googlehomes"});
        public GroupEntity KameraUppe => new GroupEntity(_app, new string[]{"group.kamera_uppe"});
        public GroupEntity MelkersDevices => new GroupEntity(_app, new string[]{"group.melkers_devices"});
        public GroupEntity SystemMetrix => new GroupEntity(_app, new string[]{"group.system_metrix"});
        public GroupEntity ElinsDevices => new GroupEntity(_app, new string[]{"group.elins_devices"});
        public GroupEntity Climate => new GroupEntity(_app, new string[]{"group.climate"});
        public GroupEntity Dummy => new GroupEntity(_app, new string[]{"group.dummy"});
        public GroupEntity TomasDevices => new GroupEntity(_app, new string[]{"group.tomas_devices"});
        public GroupEntity Chromecasts => new GroupEntity(_app, new string[]{"group.chromecasts"});
    }

    public partial class ProximityEntities
    {
        private readonly NetDaemonRxApp _app;
        public ProximityEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public ProximityEntity ProxHomeTomas => new ProximityEntity(_app, new string[]{"proximity.prox_home_tomas"});
        public ProximityEntity ProxHomeElin => new ProximityEntity(_app, new string[]{"proximity.prox_home_elin"});
        public ProximityEntity ProxHomeSally => new ProximityEntity(_app, new string[]{"proximity.prox_home_sally"});
        public ProximityEntity ProxHomeMelker => new ProximityEntity(_app, new string[]{"proximity.prox_home_melker"});
    }

    public partial class SceneEntities
    {
        private readonly NetDaemonRxApp _app;
        public SceneEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public SceneEntity Kvall => new SceneEntity(_app, new string[]{"scene.kvall"});
        public SceneEntity Morgon => new SceneEntity(_app, new string[]{"scene.morgon"});
        public SceneEntity Natt => new SceneEntity(_app, new string[]{"scene.natt"});
        public SceneEntity Stadning => new SceneEntity(_app, new string[]{"scene.stadning"});
        public SceneEntity Dag => new SceneEntity(_app, new string[]{"scene.dag"});
    }

    public partial class SunEntities
    {
        private readonly NetDaemonRxApp _app;
        public SunEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public SunEntity Sun => new SunEntity(_app, new string[]{"sun.sun"});
    }

    public partial class InputTextEntities
    {
        private readonly NetDaemonRxApp _app;
        public InputTextEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public InputTextEntity Zigbee2mqttRemove => new InputTextEntity(_app, new string[]{"input_text.zigbee2mqtt_remove"});
        public InputTextEntity Zigbee2mqttOldName => new InputTextEntity(_app, new string[]{"input_text.zigbee2mqtt_old_name"});
        public InputTextEntity Zigbee2mqttNewName => new InputTextEntity(_app, new string[]{"input_text.zigbee2mqtt_new_name"});
    }

    public partial class CoverEntities
    {
        private readonly NetDaemonRxApp _app;
        public CoverEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public CoverEntity TvrumRullgardinHoger => new CoverEntity(_app, new string[]{"cover.tvrum_rullgardin_hoger"});
        public CoverEntity TvrumRullgardinVanster => new CoverEntity(_app, new string[]{"cover.tvrum_rullgardin_vanster"});
        public CoverEntity Tvrum => new CoverEntity(_app, new string[]{"cover.tvrum"});
    }

    public partial class CameraEntities
    {
        private readonly NetDaemonRxApp _app;
        public CameraEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public CameraEntity FramsidanProfile000Mainstream => new CameraEntity(_app, new string[]{"camera.framsidan_profile000_mainstream"});
        public CameraEntity MyCamera => new CameraEntity(_app, new string[]{"camera.my_camera"});
        public CameraEntity FramsidanProfile000Mainstream2 => new CameraEntity(_app, new string[]{"camera.framsidan_profile000_mainstream_2"});
        public CameraEntity KameraStream => new CameraEntity(_app, new string[]{"camera.kamera_stream"});
        public CameraEntity Cam1 => new CameraEntity(_app, new string[]{"camera.cam1"});
        public CameraEntity Kamera3 => new CameraEntity(_app, new string[]{"camera.kamera_3"});
    }

    public partial class LightEntities
    {
        private readonly NetDaemonRxApp _app;
        public LightEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public LightEntity Tvrummet => new LightEntity(_app, new string[]{"light.tvrummet"});
        public LightEntity HallDorr => new LightEntity(_app, new string[]{"light.hall_dorr"});
        public LightEntity MelkersRumFonster => new LightEntity(_app, new string[]{"light.melkers_rum_fonster"});
        public LightEntity KokFonster => new LightEntity(_app, new string[]{"light.kok_fonster"});
        public LightEntity TvrumFonsterHoger => new LightEntity(_app, new string[]{"light.tvrum_fonster_hoger"});
        public LightEntity GymLed => new LightEntity(_app, new string[]{"light.gym_led"});
        public LightEntity JulbelysningTomasRum => new LightEntity(_app, new string[]{"light.julbelysning_tomas_rum"});
        public LightEntity TvrumFonsterVanster => new LightEntity(_app, new string[]{"light.tvrum_fonster_vanster"});
        public LightEntity TomasRumFonster => new LightEntity(_app, new string[]{"light.tomas_rum_fonster"});
        public LightEntity Kok => new LightEntity(_app, new string[]{"light.kok"});
        public LightEntity KokLillaFonster => new LightEntity(_app, new string[]{"light.kok_lilla_fonster"});
        public LightEntity JulbelysningKokV => new LightEntity(_app, new string[]{"light.julbelysning_kok_v"});
        public LightEntity JulbelysningKokH => new LightEntity(_app, new string[]{"light.julbelysning_kok_h"});
        public LightEntity HallByra => new LightEntity(_app, new string[]{"light.hall_byra"});
        public LightEntity SallysRum => new LightEntity(_app, new string[]{"light.sallys_rum"});
        public LightEntity FarstukvistLed => new LightEntity(_app, new string[]{"light.farstukvist_led"});
        public LightEntity TvrumVagg => new LightEntity(_app, new string[]{"light.tvrum_vagg"});
        public LightEntity SovrumByra => new LightEntity(_app, new string[]{"light.sovrum_byra"});
        public LightEntity JulbelysningVardagsrumH => new LightEntity(_app, new string[]{"light.julbelysning_vardagsrum_h"});
        public LightEntity Sovrum => new LightEntity(_app, new string[]{"light.sovrum"});
        public LightEntity Farstukvisten => new LightEntity(_app, new string[]{"light.farstukvisten"});
        public LightEntity TvrumBakgrundTv => new LightEntity(_app, new string[]{"light.tvrum_bakgrund_tv"});
        public LightEntity Vardagsrum => new LightEntity(_app, new string[]{"light.vardagsrum"});
        public LightEntity VardagsrumFonsterHoger => new LightEntity(_app, new string[]{"light.vardagsrum_fonster_hoger"});
        public LightEntity SallysRumFonster => new LightEntity(_app, new string[]{"light.sallys_rum_fonster"});
        public LightEntity MelkersRum => new LightEntity(_app, new string[]{"light.melkers_rum"});
        public LightEntity TomasRum => new LightEntity(_app, new string[]{"light.tomas_rum"});
        public LightEntity VardagsrumFonsterVanster => new LightEntity(_app, new string[]{"light.vardagsrum_fonster_vanster"});
        public LightEntity JulbelysningTvrummet => new LightEntity(_app, new string[]{"light.julbelysning_tvrummet"});
        public LightEntity VardagsrumFonsterMitten => new LightEntity(_app, new string[]{"light.vardagsrum_fonster_mitten"});
        public LightEntity Ambient => new LightEntity(_app, new string[]{"light.ambient"});
        public LightEntity SovrumFonster => new LightEntity(_app, new string[]{"light.sovrum_fonster"});
        public LightEntity JulbelysningSovrum => new LightEntity(_app, new string[]{"light.julbelysning_sovrum"});
        public LightEntity JulbelysningVardagsrumV => new LightEntity(_app, new string[]{"light.julbelysning_vardagsrum_v"});
    }

    public partial class PersonEntities
    {
        private readonly NetDaemonRxApp _app;
        public PersonEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public PersonEntity Melker => new PersonEntity(_app, new string[]{"person.melker"});
        public PersonEntity Tomas => new PersonEntity(_app, new string[]{"person.tomas"});
        public PersonEntity Sally => new PersonEntity(_app, new string[]{"person.sally"});
        public PersonEntity Elin => new PersonEntity(_app, new string[]{"person.elin"});
    }

    public partial class ZoneEntities
    {
        private readonly NetDaemonRxApp _app;
        public ZoneEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public ZoneEntity Spv => new ZoneEntity(_app, new string[]{"zone.spv"});
        public ZoneEntity Garn => new ZoneEntity(_app, new string[]{"zone.garn"});
        public ZoneEntity Sjukhuset => new ZoneEntity(_app, new string[]{"zone.sjukhuset"});
        public ZoneEntity Svarmor => new ZoneEntity(_app, new string[]{"zone.svarmor"});
        public ZoneEntity Home => new ZoneEntity(_app, new string[]{"zone.home"});
        public ZoneEntity Vardinge => new ZoneEntity(_app, new string[]{"zone.vardinge"});
    }

    public partial class AutomationEntities
    {
        private readonly NetDaemonRxApp _app;
        public AutomationEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public AutomationEntity Automation3 => new AutomationEntity(_app, new string[]{"automation.automation_3"});
        public AutomationEntity SetThemeAtStartup => new AutomationEntity(_app, new string[]{"automation.set_theme_at_startup"});
        public AutomationEntity ZigbeeJoinDisabled => new AutomationEntity(_app, new string[]{"automation.zigbee_join_disabled"});
        public AutomationEntity ZigbeeJoinEnabled => new AutomationEntity(_app, new string[]{"automation.zigbee_join_enabled"});
        public AutomationEntity Zigbee2mqttLogLevel => new AutomationEntity(_app, new string[]{"automation.zigbee2mqtt_log_level"});
    }

    public partial class LockEntities
    {
        private readonly NetDaemonRxApp _app;
        public LockEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public LockEntity LasUppe => new LockEntity(_app, new string[]{"lock.las_uppe"});
    }

    public partial class InputNumberEntities
    {
        private readonly NetDaemonRxApp _app;
        public InputNumberEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public InputNumberEntity CarHeaterDepTimeMinutes => new InputNumberEntity(_app, new string[]{"input_number.car_heater_dep_time_minutes"});
        public InputNumberEntity CarHeaterDepTimeHour => new InputNumberEntity(_app, new string[]{"input_number.car_heater_dep_time_hour"});
    }

    public partial class TimerEntities
    {
        private readonly NetDaemonRxApp _app;
        public TimerEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public TimerEntity ZigbeePermitJoin => new TimerEntity(_app, new string[]{"timer.zigbee_permit_join"});
    }

    public partial class NetdaemonEntities
    {
        private readonly NetDaemonRxApp _app;
        public NetdaemonEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public NetdaemonEntity Status => new NetdaemonEntity(_app, new string[]{"netdaemon.status"});
    }

    public partial class InputSelectEntities
    {
        private readonly NetDaemonRxApp _app;
        public InputSelectEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public InputSelectEntity HouseModeSelect => new InputSelectEntity(_app, new string[]{"input_select.house_mode_select"});
        public InputSelectEntity Zigbee2mqttLogLevel => new InputSelectEntity(_app, new string[]{"input_select.zigbee2mqtt_log_level"});
        public InputSelectEntity HouseModeSelectTest => new InputSelectEntity(_app, new string[]{"input_select.house_mode_select_test"});
    }

    public partial class CalendarEntities
    {
        private readonly NetDaemonRxApp _app;
        public CalendarEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public CalendarEntity FamiljenHellstrom => new CalendarEntity(_app, new string[]{"calendar.familjen_hellstrom"});
        public CalendarEntity TaUtSopor => new CalendarEntity(_app, new string[]{"calendar.ta_ut_sopor"});
        public CalendarEntity Tomash277GmailCom => new CalendarEntity(_app, new string[]{"calendar.tomash277_gmail_com"});
        public CalendarEntity SundsvallsFotoklubb => new CalendarEntity(_app, new string[]{"calendar.sundsvalls_fotoklubb"});
    }

    public partial class InputBooleanEntities
    {
        private readonly NetDaemonRxApp _app;
        public InputBooleanEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public InputBooleanEntity ScheduleOnWeekends => new InputBooleanEntity(_app, new string[]{"input_boolean.schedule_on_weekends"});
        public InputBooleanEntity GoodNightHouse => new InputBooleanEntity(_app, new string[]{"input_boolean.good_night_house"});
    }

    public partial class RemoteEntities
    {
        private readonly NetDaemonRxApp _app;
        public RemoteEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public RemoteEntity Tvrummet => new RemoteEntity(_app, new string[]{"remote.tvrummet"});
    }
}