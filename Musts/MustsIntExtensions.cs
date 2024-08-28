
namespace Musts;

/// <summary>  
/// Provides extension methods for integer values to enforce certain conditions.  
/// </summary>  
public static class MustsIntExtensions
{
    /// <summary>  
    /// Ensures that the integer value is zero. Throws a <see cref="MustsException"/> if the value is not zero.  
    /// </summary>  
    /// <param name="value">The integer value to check.</param>  
    /// <exception cref="MustsException">Thrown when the integer value is not zero.</exception>  
    public static void MustBeZero(this int value)
    {
        if (value != 0)
        {
            throw new MustsException();
        }
    }

    /// <summary>  
    /// Ensures that the integer value is equal to the specified value. Throws a <see cref="MustsException"/> if the values are not equal.  
    /// </summary>  
    /// <param name="value">The integer value to check.</param>  
    /// <param name="compare">The value to compare against.</param>  
    /// <exception cref="MustsException">Thrown when the integer values are not equal.</exception>  
    public static void MustBeEqual(this int value, int compare)
    {
        if (value != compare)
        {
            throw new MustsException();
        }
    }

    /// <summary>  
    /// Ensures that the integer value is not equal to the specified value. Throws a <see cref="MustsException"/> if the values are equal.  
    /// </summary>  
    /// <param name="value">The integer value to check.</param>  
    /// <param name="compare">The value to compare against.</param>  
    /// <exception cref="MustsException">Thrown when the integer values are equal.</exception>  
    public static void MustBeNotEqual(this int value, int compare)
    {
        if (value == compare)
        {
            throw new MustsException();
        }
    }

    /// <summary>  
    /// Ensures that the integer value is greater than zero. Throws a <see cref="MustsException"/> if the value is less than or equal to zero.  
    /// </summary>  
    /// <param name="value">The integer value to check.</param>  
    /// <exception cref="MustsException">Thrown when the integer value is less than or equal to zero.</exception>  
    public static void MustBeGreaterThanZero(this int value)
    {
        if (value <= 0)
        {
            throw new MustsException();
        }
    }

    /// <summary>  
    /// Ensures that the integer value is less than zero. Throws a <see cref="MustsException"/> if the value is greater than or equal to zero.  
    /// </summary>  
    /// <param name="value">The integer value to check.</param>  
    /// <exception cref="MustsException">Thrown when the integer value is greater than or equal to zero.</exception>  
    public static void MustBeLessThanZero(this int value)
    {
        if (value >= 0)
        {
            throw new MustsException();
        }
    }

    /// <summary>  
    /// Ensures that the integer value is not zero. Throws a <see cref="MustsException"/> if the value is zero.  
    /// </summary>  
    /// <param name="value">The integer value to check.</param>  
    /// <exception cref="MustsException">Thrown when the integer value is zero.</exception>  
    public static void MustBeNotZero(this int value)
    {
        if (value == 0)
        {
            throw new MustsException();
        }
    }
}
