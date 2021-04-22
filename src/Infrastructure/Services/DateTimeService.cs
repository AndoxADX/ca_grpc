using clean_architecture_grpc.Application.Common.Interfaces;
using System;

namespace clean_architecture_grpc.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
