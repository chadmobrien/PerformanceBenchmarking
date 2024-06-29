```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish) WSL
Intel Core i7-7500U CPU 2.70GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.105
  [Host]     : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2


```
| Method             | Mean      | Error     | StdDev    | Median    | Gen0   | Allocated |
|------------------- |----------:|----------:|----------:|----------:|-------:|----------:|
| PrettifyNameString | 563.68 ns | 32.584 ns | 92.963 ns | 523.05 ns | 0.3901 |     816 B |
| PrettifyNameROS    | 145.58 ns |  4.461 ns | 12.508 ns | 145.82 ns | 0.1452 |     304 B |
| PrettifyNameSTACK  |  71.68 ns |  1.497 ns |  1.947 ns |  71.66 ns | 0.0381 |      80 B |
