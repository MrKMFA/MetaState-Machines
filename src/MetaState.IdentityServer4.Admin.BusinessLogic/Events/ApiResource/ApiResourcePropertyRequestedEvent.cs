﻿using Skoruba.AuditLogging.Events;
using MetaState.IdentityServer4.Admin.BusinessLogic.Dtos.Configuration;

namespace MetaState.IdentityServer4.Admin.BusinessLogic.Events.ApiResource
{
    public class ApiResourcePropertyRequestedEvent : AuditEvent
    {
        public ApiResourcePropertyRequestedEvent(int apiResourcePropertyId, ApiResourcePropertiesDto apiResourceProperties)
        {
            ApiResourcePropertyId = apiResourcePropertyId;
            ApiResourceProperties = apiResourceProperties;
        }

        public int ApiResourcePropertyId { get; }
        public ApiResourcePropertiesDto ApiResourceProperties { get; set; }
    }
}