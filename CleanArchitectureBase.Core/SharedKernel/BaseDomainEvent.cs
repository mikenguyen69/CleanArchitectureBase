using System;

namespace CleanArchitectureBase.Core.SharedKernel
{
    public abstract class BaseDomainEvent
    {
        public DateTime DateOccurred { get; protected set; } = DateTime.Now;
    }
}
