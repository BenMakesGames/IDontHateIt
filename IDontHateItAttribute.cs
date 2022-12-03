using System;

namespace BenMakesGames.IDontHateIt;

/// <summary>
/// Marks the program elements that aren't... <em>hated</em>. This class cannot be inherited.
/// </summary>
[AttributeUsage(AttributeTargets.All, Inherited = false)]
[IDontHateIt]
public sealed class IDontHateItAttribute: Attribute
{
    /// <summary>
    /// Gets the lame excuse message.
    /// </summary>
    public string? Reason { get; }

    /// <summary>
    /// Initializes a new instance of the IDontHateItAttribute class with a specified lame excuse message.
    /// </summary>
    /// <param name="reason">The text string that describes the lame excuse.</param>
    public IDontHateItAttribute(string? reason = "🤷")
    {
        Reason = reason;
    }
}
