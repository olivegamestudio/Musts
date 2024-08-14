using Utility;

namespace Musts;

public static class MustResultExtensions
{
    public static void MustBeSuccess(this Result result)
    {
        if (result.IsFailure)
        {
            throw new MustsException();
        }
    }
    public static void MustBeFailure(this Result result)
    {
        if (result.Success)
        {
            throw new MustsException();
        }
    }
}
