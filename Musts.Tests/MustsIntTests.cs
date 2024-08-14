using System.Globalization;

namespace Musts.Tests;

public class MustsIntTests
{
    [Test]
    public void TestZeroIsZero()
    {
        0.MustBeZero();
    }

    [Test]
    public void TestNumberIsEquals()
    {
        0.MustBeEqual(0);
    }

    [Test]
    public void TestNumberIsNotEquals()
    {
        0.MustBeNotEqual(1);
    }

    [Test]
    public void Test1IsGreaterThanZero()
    {
        1.MustBeGreaterThanZero();
    }

    [Test]
    public void Test1IsLessThanZero()
    {
        (-1).MustBeLessThanZero();
    }

    [Test]
    public void Test1IsNotZero()
    {
        1.MustBeNotZero();
    }
}
