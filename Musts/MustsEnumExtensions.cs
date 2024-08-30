namespace Musts;

/// <summary>
/// Provides extension methods for enum values to enforce certain conditions.
/// </summary>
public static class MustsEnumExtensions
{
    /// <summary>
    /// Ensures that the enum value is equal to the specified expected value. Throws a <see cref="MustsException"/> if the values are not equal.
    /// </summary>
    /// <typeparam name="TEnum">The type of the enum.</typeparam>
    /// <param name="value">The enum value to check.</param>
    /// <param name="expected">The expected enum value.</param>
    /// <exception cref="MustsException">Thrown when the enum values are not equal.</exception>
    public static void MustBe<TEnum>(this TEnum value, TEnum expected) where TEnum : Enum
    {
        if (!value.Equals(expected))
        {
            throw new MustsException();
        }
    }

    /// <summary>
    /// Ensures that the enum value is not equal to the specified expected value. Throws a <see cref="MustsException"/> if the values are equal.
    /// </summary>
    /// <typeparam name="TEnum">The type of the enum.</typeparam>
    /// <param name="value">The enum value to check.</param>
    /// <param name="expected">The expected enum value.</param>
    /// <exception cref="MustsException">Thrown when the enum values are equal.</exception>
    public static void MustNotBe<TEnum>(this TEnum value, TEnum expected) where TEnum : Enum
    {
        if (value.Equals(expected))
        {
            throw new MustsException();
        }
    }
}
