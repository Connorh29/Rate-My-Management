﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Options;
using RateMyManagement.Data;

namespace RMM.Data.EntityFramework
{
    public class AuthorizationOptionsConfigurer
    {
        public static void Configure(AuthorizationOptions options)
        {
            options.AddPolicy(PolicyTypes.Admin.ToString(), policy =>
            {
                policy.RequireAuthenticatedUser();
                policy.RequireRole("Administrator");
            });
            options.AddPolicy(PolicyTypes.CompanyManager.ToString(), policy =>
            {
                policy.RequireAuthenticatedUser();
                policy.AddRequirements(new IdMatchesCompanyRequirement());
            });
            options.AddPolicy(PolicyTypes.LocationManager.ToString(), policy =>
            {
                policy.RequireAuthenticatedUser();
                policy.AddRequirements(new IdMatchesLocationRequirement());
            });
            options.AddPolicy(PolicyTypes.AuthorizedUser.ToString(), policy =>
            {
                policy.RequireAuthenticatedUser();
            });
        }
    }
}
