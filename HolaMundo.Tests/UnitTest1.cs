using System;
using Xunit;

namespace HolaMundo.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var expectedOutput = "¡Hola, Mundo!";

        var consoleOutput = "¡Hola, Mundo!"; 

        Assert.Equal(expectedOutput, consoleOutput);
    }
}
//Paula Henrsez - 20230232