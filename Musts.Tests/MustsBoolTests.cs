using System.Globalization;

namespace Musts.Tests;

public class MustsBoolTests
{
    [Test]
    public void TestTrueIsTrue()
    {
        true.MustBeTrue();
    }

    [Test]
    public void TestFalseIsFalse()
    {
        false.MustBeFalse();
    }

    [Test]
    public void TestTrueIsNotFalse()
    {
        Assert.Throws<MustsException>(() => true.MustBeFalse());
    }

    [Test]
    public void TestFalseIsNotTrue()
    {
        Assert.Throws<MustsException>(() => false.MustBeTrue());
    }
}
