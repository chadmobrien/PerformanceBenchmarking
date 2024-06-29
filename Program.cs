using System;
using System.Security.Cryptography;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Collections;
using System.Collections.Specialized;

public class Progam
{
    public static void Main(String[] args)
    {
        var summary = BenchmarkRunner.Run<PrettifyTests>();

        // var p = new PrettifyTests();
        // Console.WriteLine(p.PrettifyNameROS());
        // Console.WriteLine(p.PrettifyNameString());
        // Console.WriteLine(p.PrettifyNameSTACK());

    }
}



[MemoryDiagnoser]
public class PrettifyTests
{
    string name = string.Empty;
    public PrettifyTests()
    {
        name = "myMomToldMeImTheBest";
    }

    [Benchmark]
    public string PrettifyNameString() => StringHelpers.PrettifyNameString(name);

    [Benchmark]
    public string PrettifyNameROS() => StringHelpers.PrettifyNameSpan(name);

    [Benchmark]
    public string PrettifyNameSTACK() => StringHelpers.PrettifyNameSTACK(name);

}

public static class StringHelpers
{
    const char space = ' ';
    public static string PrettifyNameString(string name)
    {
        StringBuilder sb = new StringBuilder(name);
        int truePosition = 0;
        for (int i = 0; i < name.Length; i++)
        {
            if (name[i] < 91 && i > 0)
            {
                sb.Insert(truePosition, space);
                truePosition++;
            }
            truePosition++;

        }
        return sb.ToString();
    }

    public static string PrettifyNameSpan(ReadOnlySpan<char> name)
    {
        StringBuilder sb = new StringBuilder(name.Length);
        for (int i = 0; i < name.Length; i++)
        {
            if (name[i] < 91 && i > 0)
                sb.Append(space);
            sb.Append(name[i]);

        }
        return sb.ToString();
    }

    public static string PrettifyNameSTACK(ReadOnlySpan<char> name)
    {
        int capCount = 0;
        for (int i = 0; i < name.Length; i++)
        {
            if (name[i] < 91) capCount++;
        }

        Span<char> endString = stackalloc char[name.Length + capCount];
        int pos = 0;
        for (int i = 0; i < name.Length; i++)
        {
            if (name[i] < 91 && i > 0)
            {
                endString[pos] = space;
                pos++;
            }
            endString[pos] = name[i];
            pos++;
        }
        return new string(endString);
    }

   
}
