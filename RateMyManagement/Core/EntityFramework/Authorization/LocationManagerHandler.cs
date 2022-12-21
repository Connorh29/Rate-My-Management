﻿using Microsoft.AspNetCore.Authorization;
using RateMyManagement.Data;

namespace RateMyManagement.Core.EntityFramework.Authorization
{
    public class LocationManagerHandler : AuthorizationHandler<IdMatchesLocationRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, IdMatchesLocationRequirement requirement)
        {
            if (context.Resource is Location location)
            {
                if (context.User.IsInRole("Administrator") || context.User.HasClaim(
                       claim => claim.Type == ClaimTypes.EditLocation.ToString()
                                && claim.Value == location.Id || context.User.HasClaim(
                                    claim => claim.Type == ClaimTypes.EditCompany.ToString()
                                             && claim.Value == location.CompanyId)))
                {
                    context.Succeed(requirement);
                }
                else
                {
                    context.Fail(new AuthorizationFailureReason(this, "Claim was not present"));
                }
            }
            else
            {
                context.Fail();
            }
            return Task.CompletedTask;
        }
    }
}
