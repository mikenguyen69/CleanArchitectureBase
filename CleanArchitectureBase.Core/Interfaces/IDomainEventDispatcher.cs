using CleanArchitectureBase.Core.SharedKernel;

namespace CleanArchitectureBase.Core.Interfaces
{
    public interface IDomainEventDispatcher
    {
        void Dispatch(BaseDomainEvent domainEvent);
    }
}
