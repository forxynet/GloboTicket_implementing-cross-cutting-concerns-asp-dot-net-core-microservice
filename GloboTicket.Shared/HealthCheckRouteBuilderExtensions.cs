using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Text;

namespace GloboTicket.Shared {
    public static class HealthCheckRouteBuilderExtensions {
        public static IEndpointRouteBuilder MapDefaultHealthChecks(this IEndpointRouteBuilder endpoints) {
            endpoints.MapHealthChecks("/health/live", new HealthCheckOptions 
            { 
                Predicate = _ => false 
            });
            endpoints.MapHealthChecks("/health/ready");

            return endpoints;
        }
    }
}
