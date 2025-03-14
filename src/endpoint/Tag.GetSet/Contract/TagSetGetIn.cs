using GarageGroup.Infra;
using System;

namespace GarageGroup.Internal.Timesheet;

using static TagSetGetMetadata;

public sealed record class TagSetGetIn
{
    public TagSetGetIn(
        [ClaimIn] Guid systemUserId,
        [RouteIn, SwaggerDescription(In.ProjectTypeDescription), StringExample(In.ProjectTypeExample)] ProjectType projectType,
        [RouteIn, SwaggerDescription(In.ProjectIdDescription), StringExample(In.ProjectIdExample)] Guid projectId)
    {
        SystemUserId = systemUserId;
        ProjectType = projectType;
        ProjectId = projectId;
    }

    public Guid SystemUserId { get; }

    public ProjectType ProjectType { get; }

    public Guid ProjectId { get; }
}