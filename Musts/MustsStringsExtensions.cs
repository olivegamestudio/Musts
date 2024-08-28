namespace Musts;

/// <summary>
/// Provides extension methods for string values to enforce certain conditions.
/// </summary>
public static class MustsStringsExtensions
{
    /// <summary>
    /// Ensures that the string value is null or empty. Throws a <see cref="MustsException"/> if the value is not null or empty.
    /// </summary>
    /// <param name="value">The string value to check.</param>
    /// <exception cref="MustsException">Thrown when the string value is not null or empty.</exception>
    public static void MustBeNullOrEmpty(this string value)
    {
        if (!string.IsNullOrEmpty(value))
        {
            throw new MustsException();
        }
    }

    /// <summary>
    /// Ensures that the string value is the same as the specified value. Throws a <see cref="MustsException"/> if the values are not the same.
    /// </summary>
    /// <param name="value">The string value to check.</param>
    /// <param name="result">The value to compare against.</param>
    /// <exception cref="MustsException">Thrown when the string values are not the same.</exception>
    public static void MustBeSame(this string value, string result)
    {
        if (value != result)
        {
            throw new MustsException();
        }
    }
}
