﻿using Microsoft.AspNetCore.Identity;
using TaskBoardManagementApp.Application.Common.Models;

namespace TaskBoardManagementApp.Infrastructure.Identity;
public static class IdentityResultExtensions
{
    public static Result ToApplicationResult(this IdentityResult result)
    {
        return result.Succeeded
            ? Result.Success()
            : Result.Failure(result.Errors.Select(e => e.Description));
    }
}
