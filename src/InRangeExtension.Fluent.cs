using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace System.InRange;

public static partial class InRangeExtension
{
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static IQueryable<T> WithInRange<T>(this IQueryable<T> source, int index, out bool result)
    {
        result = InRange(index, source?.Count());
        return source!;
    }
}
