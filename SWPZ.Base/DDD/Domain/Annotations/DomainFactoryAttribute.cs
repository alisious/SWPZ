﻿using System;

namespace SWPZ.Base.DDD.Domain.Annotations
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class DomainFactoryAttribute : Attribute
    {
    }
}
