using Utility;

namespace Musts.Tests;

public class MustsResultTests
{
    [Test]
    public void TestOkResultIsSuccess()
    {
        Result.Ok().MustBeSuccess();
    }

    [Test]
    public void TestFailureIsFailure()
    {
        Result.Fail("Failed").MustBeFailure();
    }
}
