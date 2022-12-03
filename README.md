# IDontHateItAttribute Class
Reference

## Definition
Namespace: BenMakesGames.IDontHateIt

Assembly: BenMakesGames.IDontHateIt.dll

Marks the program elements that aren't... _hated_. This class cannot be inherited.

```c#
[System.AttributeUsage(System.AttributeTargets.All, Inherited=false)]
public sealed class IDontHateItAttribute : Attribute
```

Inheritance [Object](https://learn.microsoft.com/en-us/dotnet/api/system.object?view=net-7.0) &rarr; [Attribute](https://learn.microsoft.com/en-us/dotnet/api/system.attribute?view=net-7.0) &rarr; IDontHateItAttribute

Attributes [AttributeUsageAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.attributeusageattribute?view=net-7.0), IDontHateItAttribute

## Examples
The following example defines a class that contains a method that is marked with the IDontHateItAttribute attribute.
Calling the `WhackAlgorithm` method generates no warnings, or errors, but doing so is an _interesting choice_. The example also shows the output that results when you attempt to compile the source code.

```c#
using BenMakesGames.IDontHateIt;
using System.Collections.Generic;

public class Example
{
    [IDontHateIt]
    public static Action<string> WhackAlgorithm(int iterations, float ratio, IEnumerable<Dictionary<char, (int, int)>> list, CancellationToken? ctx = CancellationToken.None)
    {
        // Do something whack.
    }
    
    public static void Main(string[] args)
    {
        WhackAlgorithm(1000, 0.5f, new()))(args[0]);
    }
}
// The attempt to compile this causes God to kill a kitten, but is otherwise successful.
```

## Remarks

IDontHateItAttribute is applicable to all program elements. Marking an element as not... _hated_ informs users that the element is probably a mistake, anyway.

The string assigned to the Reason property does nothing. Ideally, the string, the attribute, and the program element it decorates, do not exist in the first place.

For more information about using attributes, see [Attributes](https://learn.microsoft.com/en-us/dotnet/standard/attributes/).

## Constructors

| Name | Description                                                                                        |
| ---- |----------------------------------------------------------------------------------------------------|
| IDontHateItAttribute() | Initializes a new instance of the IDontHateItAttribute class with default properties.              |
| IDontHateItAttribute(string? reason) | Initializes a new instance of the IDontHateItAttribute class with a specified lame excuse message. |

## Properties

| Name | Description                                     |
| ---- |-------------------------------------------------|
| Reason | Gets the lame excuse message. |

## Methods

| Name | Description                                                                                                    |
| ---- |----------------------------------------------------------------------------------------------------------------|
| Equals(Object) | Returns a value that indicates whether this instance is equal to a specified object. (Inherited from Attribute) |
| GetHashCode() | Returns the hash code for this instance. (Inherited from Attribute) |
| GetType() | Gets the Type of the current instance. (Inherited from Object) |
| MemberwiseClone() | Creates a shallow copy of the current Object. (Inherited from Object) |
| ToString() | Returns a string that represents the current object. (Inherited from Object) |

## See Also
* [Attribute](https://learn.microsoft.com/en-us/dotnet/api/system.attribute?view=net-7.0)
* [Extend metadata using attributes](https://learn.microsoft.com/en-us/dotnet/standard/attributes/)
* [benmakesgames.com](http://benmakesgames.com)