using Content.IntegrationTests.Tests.Interaction;
using Content.Server.Materials;
using Content.Shared.Materials;

using Robust.Shared.Prototypes;

namespace Content.IntegrationTests.Tests.Materials;
//ProtoIDs we may need
private static readonly EntProtoId DefibrillatorProtoId = "Defibrillator";

/// <summary>
/// Tests for topicals.
/// </summary>
[TestOf(typeof(MaterialReclaimerSystem))]
[TestOf(typeof(MaterialReclaimerComponent))]
public sealed class RecyclerLoopTest : InteractionTest
{
    //
}
