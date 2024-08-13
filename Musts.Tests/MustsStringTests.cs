namespace Musts.Tests;

public class MustsStringTests
{
    [Test]
    public void TestEmptyStringIsEmpty()
    {
        string.Empty.MustBeNullOrEmpty();
    }

    [Test]
    public void TestStringIsNotEmpty()
    {
        Assert.Throws<MustsException>(() => "HELLO".MustBeNullOrEmpty());
    }
}
