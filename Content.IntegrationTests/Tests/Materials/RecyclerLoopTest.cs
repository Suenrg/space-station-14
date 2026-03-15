using Content.IntegrationTests.Tests.Interaction;
using Content.Server.Materials;
using Content.Shared.Materials;

using Content.IntegrationTests.Utility;
using Robust.Shared.Prototypes;

namespace Content.IntegrationTests.Tests.Materials;
//ProtoIDs we may need
// private static readonly EntProtoId DefibrillatorProtoId = "Defibrillator";

/// <summary>
/// Tests to prevent Recycler loops, where the product of one recycling can be recycled again.
/// </summary>
[TestOf(typeof(MaterialReclaimerSystem))]
[TestOf(typeof(MaterialReclaimerComponent))]
public sealed class RecyclingLoopTest : InteractionTest
{
    private static string[] _recyleables = GameDataScrounger.EntitiesWithComponent("PhysicalCompositionComponent");
    private static string[] _reclaimers = GameDataScrounger.EntitiesWithComponent("MaterialReclaimerComponent");

    /// <summary>
    /// For each entity that recycles into materials, recycle it and check that
    /// </summary>
    [Test]
    public async Task RecyclerLoopTest([ValueSource(nameof(_recyleables))] string reclaimerID, [ValueSource(nameof(_recyleables))] string recyclableID)
    {
        //yippee
    }
}
