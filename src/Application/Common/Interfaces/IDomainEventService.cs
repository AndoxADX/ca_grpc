using clean_architecture_grpc.Domain.Common;
using System.Threading.Tasks;

namespace clean_architecture_grpc.Application.Common.Interfaces
{
    public interface IDomainEventService
    {
        Task Publish(DomainEvent domainEvent);
    }
}
