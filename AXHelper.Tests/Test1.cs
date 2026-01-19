using AXHelper.Extensions;
using static AXHelper.Helpers.StringHelper ;
namespace AXHelper.Tests;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void TestMethod1()
    {
        Console.WriteLine("Hi".JoinWith(',', "my","name","is","your mum."));
    }
    [TestMethod]
    public void TestMethod2()
    {
        Console.WriteLine("Hi".JoinWith(", ", "my","name","is","your mum."));
    }
    [TestMethod]
    public void TestMethod3()
    {
        
        Console.WriteLine("Hi".JoinWith(1, "my","name","is","your mum."));
    }

    [TestMethod]
    public void StringFormatTest()
    {
        "Hello, {0}.".PrintLn("brother");
    }

    [TestMethod]
    public void AlphabeticalShiftTest()
    {
        var s = "Hello, world. ";
        s.AlphabeticalShift(2).PrintLn();
    }
    [TestMethod]
    public void RandStr()
    {
        RandomString(2000).PrintLn();
    }

    [TestMethod]
    public void RemoveLastTest()
    {
        var s = new[]{1, 2, 3, 4, 45, 5};
        foreach (var i in s.RemoveLast())
        {
            i.ToString().Print();
        }
    }
}