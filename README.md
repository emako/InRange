![logo](https://raw.githubusercontent.com/emako/InRange/refs/heads/master/branding/icon.png)

[![GitHub license](https://img.shields.io/github/license/emako/InRange)](https://github.com/emako/InRange/blob/master/LICENSE) [![NuGet](https://img.shields.io/nuget/v/InRange.svg)](https://nuget.org/packages/InRange) [![Actions](https://github.com/emako/InRange/actions/workflows/library.nuget.yml/badge.svg)](https://github.com/emako/InRange/actions/workflows/library.nuget.yml)

# InRange

Lightweight C# extension library for checking if an index is within the valid range of arrays and collections. This repository provides extension methods for `IEnumerable<T>`, `ICollection<T>`, `IList<T>`, `IQueryable<T>`, arrays (including multi-dimensional), and a static helper for index validation.

## Project layout

- `src/InRangeExtension.cs` - core extension methods for index range checking on collections and arrays
- `src/InRangeExtension.WithInRange.cs` - fluent-style `WithInRange` extension methods (including multi-dimensional arrays)
- `src/InRangeExtension.CheckInRange.cs` - `CheckInRange` extension methods that throw on out-of-range
- `tests/` - unit tests (`System.InRange.Tests`)

## Namespace and public types

- Namespace: `System.InRange`
- Static class: `InRangeExtension`
- Key methods (overview):
  - `bool InRange(this IEnumerable<T> source, int index)`
  - `bool InRange(this ICollection<T> source, int index)`
  - `bool InRange(this IList<T> source, int index)`
  - `bool InRange(this IQueryable<T> source, int index)`
  - `bool InRange(this T[] source, int index)`
  - `bool InRange(this T[,] source, int i, int j)`
  - `bool InRange(this T[,,] source, int i, int j, int k)`
  - `bool InRange(int index, int? count)`
  - `TSource WithInRange(..., out bool result)` (all above types, including multi-dimensional arrays)
  - `void CheckInRange(...);` (all above types, throws on out-of-range)

## Behavior and features

- Returns `true` if the index is within `[0, source.Count)`; otherwise, returns `false`
- Handles `null` collections gracefully (returns `false`)
- Supports all major .NET collection interfaces and arrays, including multi-dimensional arrays
- Compatible with a wide range of .NET targets (see below)
- Aggressive inlining for performance on supported platforms
- **Performance Note:** For `IEnumerable<T>` and `IQueryable<T>`, calling `Count()` will enumerate the entire collection if it does not implement `ICollection<T>`, `IReadOnlyCollection<T>`, or similar. For best performance, prefer using overloads for `ICollection<T>`, `IReadOnlyCollection<T>`, `IList<T>`, `IReadOnlyList<T>`, `List<T>`, or arrays whenever possible.

## Examples

```csharp
using System.InRange;

var arr = new[] { 10, 20, 30 };
bool valid = arr.InRange(1); // true
bool invalid = arr.InRange(3); // false

IList<string> list = new List<string> { "a", "b" };
bool validList = list.InRange(0); // true

IEnumerable<int> enumerable = new List<int> { 1, 2, 3 };
bool validEnum = enumerable.InRange(2); // true

IQueryable<int> queryable = enumerable.AsQueryable();
bool validQueryable = queryable.InRange(1); // true

// Multi-dimensional arrays
int[,] arr2d = new int[3, 2];
bool valid2d = arr2d.InRange(2, 1); // true
bool invalid2d = arr2d.InRange(3, 0); // false

// Fluent WithInRange usage
arr.WithInRange(1, out var ok1); // returns arr, ok1 == true
arr2d.WithInRange(2, 1, out var ok2d); // returns arr2d, ok2d == true

// Throws if out of range
arr.CheckInRange(1); // ok
// arr.CheckInRange(3); // throws ArgumentOutOfRangeException

bool staticValid = InRangeExtension.InRange(0, 3); // true
bool staticInvalid = InRangeExtension.InRange(3, 3); // false
```

## Supported target frameworks

The project in `src/System.InRange.csproj` is multi-targeted and aims to be widely compatible. The repository includes support for many targets (examples):

- .NET Standard 1.0 → 2.1
- .NET Framework 3.5 → 4.8.1
- .NET Core 1.0 → 3.1
- .NET 5 → 10

Pick the appropriate target when referencing the library.

## Build and test

Requires the .NET SDK. Recommended: .NET 7 or later.

From the repository root:

```bash
dotnet restore
dotnet build
dotnet test
```

## License

[MIT](LICENSE)

