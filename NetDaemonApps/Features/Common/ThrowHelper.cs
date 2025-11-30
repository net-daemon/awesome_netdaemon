using NetDaemon.HassModel.Entities;

namespace AwesomeNetdaemon.Features.Common;

public static class ThrowHelper
{
    public static void ThrowIfDuplicate<TEntity>(TEntity[] entities) where TEntity : IEntityCore
    {
        if (entities.Select(x => x.EntityId).Distinct().Count() != entities.Length)
            throw new InvalidOperationException($"Found duplicate entity ids in {string.Join(',', entities.Select(x => x.EntityId))}");
    }
}
