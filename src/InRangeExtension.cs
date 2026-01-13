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
    /// Determines whether the specified index is within the valid range of the <see cref="List{T}"/>.
    /// </summary>
    /// <typeparam name="T">The type of the elements.</typeparam>
    /// <param name="list">The list.</param>
    /// <param name="index">The index to check.</param>
    /// <returns>True if the index is valid; otherwise, false.</returns>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static bool InRange<T>(this List<T> list, int index)
        => InRange(index, list?.Count);

    /// <summary>
    /// Determines whether the specified index is within the valid range of the <see cref="ArraySegment{T}"/>.
    /// </summary>
    /// <typeparam name="T">The type of the elements.</typeparam>
    /// <param name="segment">The array segment.</param>
    /// <param name="index">The index to check.</param>
    /// <returns>True if the index is valid; otherwise, false.</returns>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static bool InRange<T>(this ArraySegment<T> segment, int index)
        => InRange(index, segment.Count);

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

    /// <summary>
    /// Determines whether the specified range [start, end) is within the valid range of the <see cref="IQueryable{T}"/>.
    /// </summary>
    /// <typeparam name="T">The type of the elements.</typeparam>
    /// <param name="ts">The queryable collection.</param>
    /// <param name="start">The start index (inclusive).</param>
    /// <param name="end">The end index (exclusive).</param>
    /// <returns>True if the range is valid; otherwise, false.</returns>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static bool InRange<T>(this IQueryable<T> ts, int start, int end)
        => InRange(start, end, ts?.Count());

    /// <summary>
    /// Determines whether the specified range [start, end) is within the valid range of the <see cref="IEnumerable{T}"/>.
    /// </summary>
    /// <typeparam name="T">The type of the elements.</typeparam>
    /// <param name="ts">The enumerable collection.</param>
    /// <param name="start">The start index (inclusive).</param>
    /// <param name="end">The end index (exclusive).</param>
    /// <returns>True if the range is valid; otherwise, false.</returns>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static bool InRange<T>(this IEnumerable<T> ts, int start, int end)
        => InRange(start, end, ts?.Count());

    /// <summary>
    /// Determines whether the specified range [start, end) is within the valid range of the <see cref="ICollection{T}"/>.
    /// </summary>
    /// <typeparam name="T">The type of the elements.</typeparam>
    /// <param name="collection">The collection.</param>
    /// <param name="start">The start index (inclusive).</param>
    /// <param name="end">The end index (exclusive).</param>
    /// <returns>True if the range is valid; otherwise, false.</returns>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static bool InRange<T>(this ICollection<T> collection, int start, int end)
        => InRange(start, end, collection?.Count);

    /// <summary>
    /// Determines whether the specified range [start, end) is within the valid range of the <see cref="IList{T}"/>.
    /// </summary>
    /// <typeparam name="T">The type of the elements.</typeparam>
    /// <param name="list">The list.</param>
    /// <param name="start">The start index (inclusive).</param>
    /// <param name="end">The end index (exclusive).</param>
    /// <returns>True if the range is valid; otherwise, false.</returns>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static bool InRange<T>(this IList<T> list, int start, int end)
        => InRange(start, end, list?.Count);

    /// <summary>
    /// Determines whether the specified range [start, end) is within the valid range of the array.
    /// </summary>
    /// <typeparam name="T">The type of the elements.</typeparam>
    /// <param name="array">The array.</param>
    /// <param name="start">The start index (inclusive).</param>
    /// <param name="end">The end index (exclusive).</param>
    /// <returns>True if the range is valid; otherwise, false.</returns>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static bool InRange<T>(this T[] array, int start, int end)
        => InRange(start, end, array?.Length);

    /// <summary>
    /// Determines whether the specified range [start, end) is within the valid range of the <see cref="List{T}"/>.
    /// </summary>
    /// <typeparam name="T">The type of the elements.</typeparam>
    /// <param name="list">The list.</param>
    /// <param name="start">The start index (inclusive).</param>
    /// <param name="end">The end index (exclusive).</param>
    /// <returns>True if the range is valid; otherwise, false.</returns>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static bool InRange<T>(this List<T> list, int start, int end)
        => InRange(start, end, list?.Count);

    /// <summary>
    /// Determines whether the specified range [start, end) is within the valid range of the <see cref="ArraySegment{T}"/>.
    /// </summary>
    /// <typeparam name="T">The type of the elements.</typeparam>
    /// <param name="segment">The array segment.</param>
    /// <param name="start">The start index (inclusive).</param>
    /// <param name="end">The end index (exclusive).</param>
    /// <returns>True if the range is valid; otherwise, false.</returns>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static bool InRange<T>(this ArraySegment<T> segment, int start, int end)
        => InRange(start, end, segment.Count);

    /// <summary>
    /// Determines whether the specified range [start, end) is within the valid range for a collection of the given count.
    /// </summary>
    /// <param name="start">The start index (inclusive).</param>
    /// <param name="end">The end index (exclusive).</param>
    /// <param name="count">The number of elements in the collection.</param>
    /// <returns>True if the range is valid; otherwise, false.</returns>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static bool InRange(int start, int end, int? count)
        => count != null && start >= 0 && end >= start && end <= count;

    /// <summary>
    /// Determines whether the specified indices are within the valid range of the 2D array.
    /// </summary>
    /// <typeparam name="T">The type of the elements.</typeparam>
    /// <param name="array">The 2D array.</param>
    /// <param name="i">The first dimension index.</param>
    /// <param name="j">The second dimension index.</param>
    /// <returns>True if the indices are valid; otherwise, false.</returns>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static bool InRange<T>(this T[,] array, int i, int j)
        => array != null && i >= 0 && i < array.GetLength(0) && j >= 0 && j < array.GetLength(1);

    /// <summary>
    /// Determines whether the specified index ranges [iStart, iEnd), [jStart, jEnd) are within the valid range of the 2D array.
    /// </summary>
    /// <typeparam name="T">The type of the elements.</typeparam>
    /// <param name="array">The 2D array.</param>
    /// <param name="iStart">The start index for the first dimension (inclusive).</param>
    /// <param name="iEnd">The end index for the first dimension (exclusive).</param>
    /// <param name="jStart">The start index for the second dimension (inclusive).</param>
    /// <param name="jEnd">The end index for the second dimension (exclusive).</param>
    /// <returns>True if the ranges are valid; otherwise, false.</returns>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static bool InRange<T>(this T[,] array, int iStart, int iEnd, int jStart, int jEnd)
        => array != null && iStart >= 0 && iEnd >= iStart && iEnd <= array.GetLength(0)
           && jStart >= 0 && jEnd >= jStart && jEnd <= array.GetLength(1);

    /// <summary>
    /// Determines whether the specified indices are within the valid range of the 3D array.
    /// </summary>
    /// <typeparam name="T">The type of the elements.</typeparam>
    /// <param name="array">The 3D array.</param>
    /// <param name="i">The first dimension index.</param>
    /// <param name="j">The second dimension index.</param>
    /// <param name="k">The third dimension index.</param>
    /// <returns>True if the indices are valid; otherwise, false.</returns>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static bool InRange<T>(this T[,,] array, int i, int j, int k)
        => array != null && i >= 0 && i < array.GetLength(0)
           && j >= 0 && j < array.GetLength(1)
           && k >= 0 && k < array.GetLength(2);

    /// <summary>
    /// Determines whether the specified index ranges [iStart, iEnd), [jStart, jEnd), [kStart, kEnd) are within the valid range of the 3D array.
    /// </summary>
    /// <typeparam name="T">The type of the elements.</typeparam>
    /// <param name="array">The 3D array.</param>
    /// <param name="iStart">The start index for the first dimension (inclusive).</param>
    /// <param name="iEnd">The end index for the first dimension (exclusive).</param>
    /// <param name="jStart">The start index for the second dimension (inclusive).</param>
    /// <param name="jEnd">The end index for the second dimension (exclusive).</param>
    /// <param name="kStart">The start index for the third dimension (inclusive).</param>
    /// <param name="kEnd">The end index for the third dimension (exclusive).</param>
    /// <returns>True if the ranges are valid; otherwise, false.</returns>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static bool InRange<T>(this T[,,] array, int iStart, int iEnd, int jStart, int jEnd, int kStart, int kEnd)
        => array != null && iStart >= 0 && iEnd >= iStart && iEnd <= array.GetLength(0)
           && jStart >= 0 && jEnd >= jStart && jEnd <= array.GetLength(1)
           && kStart >= 0 && kEnd >= kStart && kEnd <= array.GetLength(2);

#if !NET35 && !NET40

    /// <summary>
    /// Determines whether the specified index is within the valid range of the <see cref="IReadOnlyList{T}"/>.
    /// </summary>
    /// <typeparam name="T">The type of the elements.</typeparam>
    /// <param name="list">The read-only list.</param>
    /// <param name="index">The index to check.</param>
    /// <returns>True if the index is valid; otherwise, false.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool InRange<T>(this IReadOnlyList<T> list, int index)
        => InRange(index, list?.Count);

    /// <summary>
    /// Determines whether the specified range [start, end) is within the valid range of the <see cref="IReadOnlyList{T}"/>.
    /// </summary>
    /// <typeparam name="T">The type of the elements.</typeparam>
    /// <param name="list">The read-only list.</param>
    /// <param name="start">The start index (inclusive).</param>
    /// <param name="end">The end index (exclusive).</param>
    /// <returns>True if the range is valid; otherwise, false.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool InRange<T>(this IReadOnlyList<T> list, int start, int end)
        => InRange(start, end, list?.Count);

#endif
}
