using Xunit;
using Models;
using System.Globalization;

namespace Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Inventory testInventoory = new Inventory();

        testInventoory.Title = "Test Title";

        Assert.Equal("Test Title", testInventoory.Title);
    }
}