﻿using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace GloboTicket.Shared {
    public static class HealtCheckExtentions {
        public static IHealthChecksBuilder AddAzureServiceBusTopicHealthCheck(this IHealthChecksBuilder builder, 
            string connectionString,
            string topicName,
            string name = default,
            HealthStatus failureStatus = HealthStatus.Degraded,
            IEnumerable<string> tags = default,
            TimeSpan? timeout = default) {
            return builder.AddCheck(name ?? $"Azure Service Bus:{topicName}",
                new AzureServiceBusHealthChack(connectionString, topicName), failureStatus, tags, timeout);
        }
    }
}
