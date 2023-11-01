using BenchmarkDotNet.Running;
using EnumPerformance;

BenchmarkRunner.Run<Benchmarks>();

return;
var monday = Day.Monday;

var toString = monday.ToString();
var toStringFast = monday.ToStringFast();

var isDefined = Enum.IsDefined(monday);
var isDefinedFast = DayExtensions.IsDefined(monday);

var name = Enum.GetName(monday);

var names = Enum.GetNames<Day>();

var namesFast = DayExtensions.GetNames();

var values = Enum.GetValues<Day>();

var valuesFast = DayExtensions.GetValues();

var parsed = Enum.TryParse<Day>("Monday", out var day1);

var parsedFast = DayExtensions.TryParse("Monday", out var day2);
