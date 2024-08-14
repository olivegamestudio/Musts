namespace Musts;

public static class MustsBoolExtensions
{
    public static void MustBeTrue(this bool value)
    {
        if (!value)
        {
            throw new MustsException();
        }
    }

    public static void MustBeFalse(this bool value)
    {
        if (value)
        {
            throw new MustsException();
        }
    }
}
