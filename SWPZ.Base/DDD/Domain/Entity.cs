using SWPZ.Base.DDD.Domain.Annotations;

namespace SWPZ.Base.DDD.Domain
{
    [DomainEntity]
    public abstract class Entity
    {
        public int Id { get; private set; }
        public EntityStatus Status { get; private set; }

        public void MarkAsRemoved()
        {
            Status = EntityStatus.Archived;
        }
    }
}