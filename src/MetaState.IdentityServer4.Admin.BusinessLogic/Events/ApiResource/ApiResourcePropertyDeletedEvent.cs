﻿using Skoruba.AuditLogging.Events;
using MetaState.IdentityServer4.Admin.BusinessLogic.Dtos.Configuration;

namespace MetaState.IdentityServer4.Admin.BusinessLogic.Events.ApiResource
{
    public class ApiResourcePropertyDeletedEvent : AuditEvent
    {
        public ApiResourcePropertyDeletedEvent(ApiResourcePropertiesDto apiResourceProperty)
        {
            ApiResourceProperty = apiResourceProperty;
        }

        public ApiResourcePropertiesDto ApiResourceProperty { get; set; }
    }
}