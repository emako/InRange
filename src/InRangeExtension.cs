using System.Collections.Generic;
using System.Linq;

#if !NET35 && !NET40

using System.Runtime.CompilerServices;

#endif

namespace System.InRange;

/// <summary>
/// Provides extension methods for checking if an index is within the valid range of various collection types.
/// </summary>
public static class InRangeExtension
{
    /// <summary>
    /// Determines whether the specified index is within the valid range of the <see cref="IQueryable{T}"/>.
    /// </summary>
    /// <typeparam name="T">The type of the elements.</typeparam>
    /// <param name="ts">The queryable collection.</param>
    /// <param name="index">The index to check.</param>
    /// <returns>True if the index is valid; otherwise, false.</returns>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static bool InRange<T>(this IQueryable<T> ts, int index)
        => InRange(index, ts?.Count());

    /// <summary>
    /// Determines whether the specified index is within the valid range of the <see cref="IEnumerable{T}"/>.
    /// </summary>
    /// <typeparam name="T">The type of the elements.</typeparam>
    /// <param name="ts">The enumerable collection.</param>
    /// <param name="index">The index to check.</param>
    /// <returns>True if the index is valid; otherwise, false.</returns>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static bool InRange<T>(this IEnumerable<T> ts, int index)
        => InRange(index, ts?.Count());

    /// <summary>
    /// Determines whether the specified index is within the valid range of the <see cref="ICollection{T}"/>.
    /// </summary>
    /// <typeparam name="T">The type of the elements.</typeparam>
    /// <param name="collection">The collection.</param>
    /// <param name="index">The index to check.</param>
    /// <returns>True if the index is valid; otherwise, false.</returns>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static bool InRange<T>(this ICollection<T> collection, int index)
        => InRange(index, collection?.Count);

    /// <summary>
    /// Determines whether the specified index is within the valid range of the <see cref="IList{T}"/>.
    /// </summary>
    /// <typeparam name="T">The type of the elements.</typeparam>
    /// <param name="list">The list.</param>
    /// <param name="index">The index to check.</param>
    /// <returns>True if the index is valid; otherwise, false.</returns>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static bool InRange<T>(this IList<T> list, int index)
        => InRange(index, list?.Count);

    /// <summary>
    /// Determines whether the specified index is within the valid range of the array.
    /// </summary>
    /// <typeparam name="T">The type of the elements.</typeparam>
    /// <param name="array">The array.</param>
    /// <param name="index">The index to check.</param>
    /// <returns>True if the index is valid; otherwise, false.</returns>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static bool InRange<T>(this T[] array, int index)
        => InRange(index, array?.Length);

    /// <summary>
    /// Determines whether the specified index is within the valid range for a collection of the given count.
    /// </summary>
    /// <param name="index">The index to check.</param>
    /// <param name="count">The number of elements in the collection.</param>
    /// <returns>True if the index is valid; otherwise, false.</returns>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static bool InRange(int index, int? count)
        => count != null && index >= 0 && index < count;
}
