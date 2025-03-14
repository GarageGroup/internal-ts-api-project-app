using GarageGroup.Infra;
using System;

namespace GarageGroup.Internal.Timesheet;

public readonly record struct ProjectSetGetIn
{
    public ProjectSetGetIn([ClaimIn] Guid systemUserId)
        =>
        SystemUserId = systemUserId;
    
    public Guid SystemUserId { get; }
}