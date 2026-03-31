using BenchmarkDotNet.Attributes;

namespace Maple.Models.Benchmarks;

public class MapleModelsBench
{
    [Benchmark]
    public void Empty() => MapleModels.Empty();
}
