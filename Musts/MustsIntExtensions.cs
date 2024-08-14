namespace Musts;

public static class MustsIntExtensions
{
    public static void MustBeZero(this int value)
    {
        if (value != 0)
        {
            throw new MustsException();
        }
    }

    public static void MustBeEqual(this int value, int compare)
    {
        if (value != compare)
        {
            throw new MustsException();
        }
    }

    public static void MustBeNotEqual(this int value, int compare)
    {
        if (value == compare)
        {
            throw new MustsException();
        }
    }

    public static void MustBeGreaterThanZero(this int value)
    {
        if (value <= 0)
        {
            throw new MustsException();
        }
    }

    public static void MustBeLessThanZero(this int value)
    {
        if (value >= 0)
        {
            throw new MustsException();
        }
    }

    public static void MustBeNotZero(this int value)
    {
        if (value == 0)
        {
            throw new MustsException();
        }
    }
}
