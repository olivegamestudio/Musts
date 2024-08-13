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
