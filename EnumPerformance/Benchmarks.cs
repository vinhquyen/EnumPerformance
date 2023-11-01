using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace EnumPerformance;

[MemoryDiagnoser(false)]
[HideColumns("Job", "RatioSD", "Error")]
public class Benchmarks
{
    private readonly Day _monday = Day.Monday;

    [Benchmark]
    public bool IsDefined_Fast()
    {
        return DayExtensions.IsDefined(_monday);
    }

    [Benchmark]
    public string[] GetNames_Fast()
    {
        return DayExtensions.GetNames();
    }

    [Benchmark]
    public Day[] GetValues_Fast()
    {
        return DayExtensions.GetValues();
    }
    
    [Benchmark]
    public string? Enum_ToString_Fast()
    {
        return _monday.ToStringFast();
    }

    [Benchmark]
    public (bool, Day) TryParse_Fast()
    {
        var parsed = DayExtensions.TryParse("Monday", out var day);
        return (parsed, day);
    }
}
