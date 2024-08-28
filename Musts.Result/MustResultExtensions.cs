using Utility;

namespace Musts;

/// <summary>  
/// Provides extension methods for <see cref="Result"/> objects to enforce certain conditions.  
/// </summary>  
public static class MustResultExtensions
{
    /// <summary>  
    /// Ensures that the <see cref="Result"/> object represents a success. Throws a <see cref="MustsException"/> if the result is a failure.  
    /// </summary>  
    /// <param name="result">The <see cref="Result"/> object to check.</param>  
    /// <exception cref="MustsException">Thrown when the result is a failure.</exception>  
    public static void MustBeSuccess(this Result result)
    {
        if (result.IsFailure)
        {
            throw new MustsException();
        }
    }

    /// <summary>  
    /// Ensures that the <see cref="Result"/> object represents a failure. Throws a <see cref="MustsException"/> if the result is a success.  
    /// </summary>  
    /// <param name="result">The <see cref="Result"/> object to check.</param>  
    /// <exception cref="MustsException">Thrown when the result is a success.</exception>  
    public static void MustBeFailure(this Result result)
    {
        if (result.Success)
        {
            throw new MustsException();
        }
    }
}
