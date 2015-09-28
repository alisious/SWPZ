using System;

namespace SWPZ.Base.DDD.Domain.Annotations
{
    [AttributeUsage(AttributeTargets.Class)]
    public class DomainAggregateRootAttribute : DomainEntityAttribute
    {
    }
}