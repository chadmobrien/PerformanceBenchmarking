```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish) WSL
Intel Core i7-7500U CPU 2.70GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.105
  [Host]     : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2


```
| Method             | Mean      | Error    | StdDev    | Gen0   | Allocated |
|------------------- |----------:|---------:|----------:|-------:|----------:|
| PrettifyNameString | 495.77 ns | 9.685 ns | 13.257 ns | 0.3901 |     816 B |
| PrettifyNameROS    | 142.85 ns | 6.412 ns | 18.396 ns | 0.1452 |     304 B |
| PrettifyNameSTACK  |  83.03 ns | 4.092 ns | 11.806 ns | 0.0381 |      80 B |
| PrettifyNameSLICE  | 148.58 ns | 3.049 ns |  6.945 ns | 0.1452 |     304 B |
