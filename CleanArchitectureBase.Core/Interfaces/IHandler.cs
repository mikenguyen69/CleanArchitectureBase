using CleanArchitectureBase.Core.SharedKernel;

namespace CleanArchitectureBase.Core.Interfaces
{
    public interface IHandler<T> where T: BaseDomainEvent
    {
        void Handle(T domainEvent);
    }
}
