using GarageGroup.Infra;
using System;

namespace GarageGroup.Internal.Timesheet;

using static LastProjectSetGetMetadata;

public readonly record struct LastProjectSetGetIn
{
    public LastProjectSetGetIn(
        [ClaimIn] Guid systemUserId,
        [QueryIn, SwaggerDescription(In.TopDescription), IntegerExample(In.TopExample)] int? top)
    {
        SystemUserId = systemUserId;
        Top = top;
    }

    public Guid SystemUserId { get; }

    public int? Top { get; }
}