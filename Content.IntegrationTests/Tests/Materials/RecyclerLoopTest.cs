using Content.IntegrationTests.Tests.Interaction;
using Content.Server.Materials;
using Content.Shared.Materials;

using Content.IntegrationTests.Utility;
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
    private static string[] _materials = GameDataScrounger.EntitiesWithComponent("Healing");
    private static string[] _topicalsToBeTested = GameDataScrounger.EntitiesWithComponent("Healing");
}
