namespace Musts;

/// <summary>
/// Provides extension methods for boolean values to enforce certain conditions.
/// </summary>
public static class MustsBoolExtensions
{
    /// <summary>
    /// Ensures that the boolean value is true. Throws a <see cref="MustsException"/> if the value is false.
    /// </summary>
    /// <param name="value">The boolean value to check.</param>
    /// <exception cref="MustsException">Thrown when the boolean value is false.</exception>
    public static void MustBeTrue(this bool value)
    {
        if (!value)
        {
            throw new MustsException();
        }
    }

    /// <summary>
    /// Ensures that the boolean value is false. Throws a <see cref="MustsException"/> if the value is true.
    /// </summary>
    /// <param name="value">The boolean value to check.</param>
    /// <exception cref="MustsException">Thrown when the boolean value is true.</exception>
    public static void MustBeFalse(this bool value)
    {
        if (value)
        {
            throw new MustsException();
        }
    }
}