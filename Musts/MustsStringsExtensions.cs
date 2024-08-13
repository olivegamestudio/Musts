namespace Musts;

public static class MustsStringsExtensions
{
    public static void MustBeNullOrEmpty(this string value)
    {
        if (!string.IsNullOrEmpty(value))
        {
            throw new MustsException();
        }
    }

    public static void MustBeSame(this string value, string result)
    {
        if (value != result)
        {
            throw new MustsException();
        }
    }
}
