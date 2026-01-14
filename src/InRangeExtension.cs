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
    #region IQueryable<T>

    /// <summary>
    /// Determines whether the specified index is within the valid range of the <see cref="IQueryable{T}"/>.
    /// </summary>
    /// <typeparam name="T">The type of the elements.</typeparam>
    /// <param name="source">The queryable collection.</param>
    /// <param name="index">The index to check.</param>
    /// <returns>True if the index is valid; otherwise, false.</returns>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static bool InRange<T>(this IQueryable<T> source, int index)
        => InRange(index, source?.Count());

    /// <summary>
    /// Determines whether the specified range [start, end) is within the valid range of the <see cref="IQueryable{T}"/>.
    /// </summary>
    /// <typeparam name="T">The type of the elements.</typeparam>
    /// <param name="source">The queryable collection.</param>
    /// <param name="start">The start index (inclusive).</param>
    /// <param name="end">The end index (exclusive).</param>
    /// <returns>True if the range is valid; otherwise, false.</returns>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static bool InRange<T>(this IQueryable<T> source, int start, int end)
        => InRange(start, end, source?.Count());

    /// <summary>
    /// Determines whether the specified range [start, start+length) is within the valid range of the <see cref="IQueryable{T}"/>.
    /// </summary>
    /// <typeparam name="T">The type of the elements.</typeparam>
    /// <param name="source">The queryable collection.</param>
    /// <param name="start">The start index (inclusive).</param>
    /// <param name="length">The length of the range.</param>
    /// <returns>True if the range is valid; otherwise, false.</returns>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static bool InRangeLength<T>(this IQueryable<T> source, int start, int length)
        => InRange(start, start + length, source?.Count());

    #endregion IQueryable<T>

    #region IEnumerable<T>

    /// <summary>
    /// Determines whether the specified index is within the valid range of the <see cref="IEnumerable{T}"/>.
    /// </summary>
    /// <typeparam name="T">The type of the elements.</typeparam>
    /// <param name="source">The enumerable collection.</param>
    /// <param name="index">The index to check.</param>
    /// <returns>True if the index is valid; otherwise, false.</returns>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static bool InRange<T>(this IEnumerable<T> source, int index)
        => InRange(index, source?.Count());

    /// <summary>
    /// Determines whether the specified range [start, end) is within the valid range of the <see cref="IEnumerable{T}"/>.
    /// </summary>
    /// <typeparam name="T">The type of the elements.</typeparam>
    /// <param name="source">The enumerable collection.</param>
    /// <param name="start">The start index (inclusive).</param>
    /// <param name="end">The end index (exclusive).</param>
    /// <returns>True if the range is valid; otherwise, false.</returns>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static bool InRange<T>(this IEnumerable<T> source, int start, int end)
        => InRange(start, end, source?.Count());

    /// <summary>
    /// Determines whether the specified range [start, start+length) is within the valid range of the <see cref="IEnumerable{T}"/>.
    /// </summary>
    /// <typeparam name="T">The type of the elements.</typeparam>
    /// <param name="source">The enumerable collection.</param>
    /// <param name="start">The start index (inclusive).</param>
    /// <param name="length">The length of the range.</param>
    /// <returns>True if the range is valid; otherwise, false.</returns>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static bool InRangeLength<T>(this IEnumerable<T> source, int start, int length)
        => InRange(start, start + length, source?.Count());

    #endregion IEnumerable<T>

    #region ICollection<T>

    /// <summary>
    /// Determines whether the specified index is within the valid range of the <see cref="ICollection{T}"/>.
    /// </summary>
    /// <typeparam name="T">The type of the elements.</typeparam>
    /// <param name="source">The collection.</param>
    /// <param name="index">The index to check.</param>
    /// <returns>True if the index is valid; otherwise, false.</returns>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static bool InRange<T>(this ICollection<T> source, int index)
        => InRange(index, source?.Count);

    /// <summary>
    /// Determines whether the specified range [start, end) is within the valid range of the <see cref="ICollection{T}"/>.
    /// </summary>
    /// <typeparam name="T">The type of the elements.</typeparam>
    /// <param name="source">The collection.</param>
    /// <param name="start">The start index (inclusive).</param>
    /// <param name="end">The end index (exclusive).</param>
    /// <returns>True if the range is valid; otherwise, false.</returns>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static bool InRange<T>(this ICollection<T> source, int start, int end)
        => InRange(start, end, source?.Count);

    /// <summary>
    /// Determines whether the specified range [start, start+length) is within the valid range of the <see cref="ICollection{T}"/>.
    /// </summary>
    /// <typeparam name="T">The type of the elements.</typeparam>
    /// <param name="source">The collection.</param>
    /// <param name="start">The start index (inclusive).</param>
    /// <param name="length">The length of the range.</param>
    /// <returns>True if the range is valid; otherwise, false.</returns>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static bool InRangeLength<T>(this ICollection<T> source, int start, int length)
        => InRange(start, start + length, source?.Count);

    #endregion ICollection<T>

    #region IList<T>

    /// <summary>
    /// Determines whether the specified index is within the valid range of the <see cref="IList{T}"/>.
    /// </summary>
    /// <typeparam name="T">The type of the elements.</typeparam>
    /// <param name="source">The list.</param>
    /// <param name="index">The index to check.</param>
    /// <returns>True if the index is valid; otherwise, false.</returns>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static bool InRange<T>(this IList<T> source, int index)
        => InRange(index, source?.Count);

    /// <summary>
    /// Determines whether the specified range [start, end) is within the valid range of the <see cref="IList{T}"/>.
    /// </summary>
    /// <typeparam name="T">The type of the elements.</typeparam>
    /// <param name="source">The list.</param>
    /// <param name="start">The start index (inclusive).</param>
    /// <param name="end">The end index (exclusive).</param>
    /// <returns>True if the range is valid; otherwise, false.</returns>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static bool InRange<T>(this IList<T> source, int start, int end)
        => InRange(start, end, source?.Count);

    /// <summary>
    /// Determines whether the specified range [start, start+length) is within the valid range of the <see cref="IList{T}"/>.
    /// </summary>
    /// <typeparam name="T">The type of the elements.</typeparam>
    /// <param name="source">The list.</param>
    /// <param name="start">The start index (inclusive).</param>
    /// <param name="length">The length of the range.</param>
    /// <returns>True if the range is valid; otherwise, false.</returns>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static bool InRangeLength<T>(this IList<T> source, int start, int length)
        => InRange(start, start + length, source?.Count);

    #endregion IList<T>

    #region IReadOnlyList<T>

#if !NET35 && !NET40

    /// <summary>
    /// Determines whether the specified index is within the valid range of the <see cref="IReadOnlyList{T}"/>.
    /// </summary>
    /// <typeparam name="T">The type of the elements.</typeparam>
    /// <param name="source">The read-only list.</param>
    /// <param name="index">The index to check.</param>
    /// <returns>True if the index is valid; otherwise, false.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool InRange<T>(this IReadOnlyList<T> source, int index)
        => InRange(index, source?.Count);

    /// <summary>
    /// Determines whether the specified range [start, end) is within the valid range of the <see cref="IReadOnlyList{T}"/>.
    /// </summary>
    /// <typeparam name="T">The type of the elements.</typeparam>
    /// <param name="source">The read-only list.</param>
    /// <param name="start">The start index (inclusive).</param>
    /// <param name="end">The end index (exclusive).</param>
    /// <returns>True if the range is valid; otherwise, false.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool InRange<T>(this IReadOnlyList<T> source, int start, int end)
        => InRange(start, end, source?.Count);

    /// <summary>
    /// Determines whether the specified range [start, start+length) is within the valid range of the <see cref="IReadOnlyList{T}"/>.
    /// </summary>
    /// <typeparam name="T">The type of the elements.</typeparam>
    /// <param name="source">The read-only list.</param>
    /// <param name="start">The start index (inclusive).</param>
    /// <param name="length">The length of the range.</param>
    /// <returns>True if the range is valid; otherwise, false.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool InRangeLength<T>(this IReadOnlyList<T> source, int start, int length)
        => InRange(start, start + length, source?.Count);

#endif

    #endregion IReadOnlyList<T>

    #region IReadOnlyCollection<T>

#if !NET35 && !NET40

    /// <summary>
    /// Determines whether the specified index is within the valid range of the <see cref="IReadOnlyCollection{T}"/>.
    /// </summary>
    /// <typeparam name="T">The type of the elements.</typeparam>
    /// <param name="source">The read-only collection.</param>
    /// <param name="index">The index to check.</param>
    /// <returns>True if the index is valid; otherwise, false.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool InRange<T>(this IReadOnlyCollection<T> source, int index)
        => InRange(index, source?.Count);

    /// <summary>
    /// Determines whether the specified range [start, end) is within the valid range of the <see cref="IReadOnlyCollection{T}"/>.
    /// </summary>
    /// <typeparam name="T">The type of the elements.</typeparam>
    /// <param name="source">The read-only collection.</param>
    /// <param name="start">The start index (inclusive).</param>
    /// <param name="end">The end index (exclusive).</param>
    /// <returns>True if the range is valid; otherwise, false.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool InRange<T>(this IReadOnlyCollection<T> source, int start, int end)
        => InRange(start, end, source?.Count);

    /// <summary>
    /// Determines whether the specified range [start, start+length) is within the valid range of the <see cref="IReadOnlyCollection{T}"/>.
    /// </summary>
    /// <typeparam name="T">The type of the elements.</typeparam>
    /// <param name="source">The read-only collection.</param>
    /// <param name="start">The start index (inclusive).</param>
    /// <param name="length">The length of the range.</param>
    /// <returns>True if the range is valid; otherwise, false.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool InRangeLength<T>(this IReadOnlyCollection<T> source, int start, int length)
        => InRange(start, start + length, source?.Count);

#endif

    #endregion IReadOnlyCollection<T>

    #region List<T>

    /// <summary>
    /// Determines whether the specified index is within the valid range of the <see cref="List{T}"/>.
    /// </summary>
    /// <typeparam name="T">The type of the elements.</typeparam>
    /// <param name="source">The list.</param>
    /// <param name="index">The index to check.</param>
    /// <returns>True if the index is valid; otherwise, false.</returns>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static bool InRange<T>(this List<T> source, int index)
        => InRange(index, source?.Count);

    /// <summary>
    /// Determines whether the specified range [start, end) is within the valid range of the <see cref="List{T}"/>.
    /// </summary>
    /// <typeparam name="T">The type of the elements.</typeparam>
    /// <param name="source">The list.</param>
    /// <param name="start">The start index (inclusive).</param>
    /// <param name="end">The end index (exclusive).</param>
    /// <returns>True if the range is valid; otherwise, false.</returns>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static bool InRange<T>(this List<T> source, int start, int end)
        => InRange(start, end, source?.Count);

    /// <summary>
    /// Determines whether the specified range [start, start+length) is within the valid range of the <see cref="List{T}"/>.
    /// </summary>
    /// <typeparam name="T">The type of the elements.</typeparam>
    /// <param name="source">The list.</param>
    /// <param name="start">The start index (inclusive).</param>
    /// <param name="length">The length of the range.</param>
    /// <returns>True if the range is valid; otherwise, false.</returns>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static bool InRangeLength<T>(this List<T> source, int start, int length)
        => InRange(start, start + length, source?.Count);

    #endregion List<T>

    #region ArraySegment<T>

    /// <summary>
    /// Determines whether the specified index is within the valid range of the <see cref="ArraySegment{T}"/>.
    /// </summary>
    /// <typeparam name="T">The type of the elements.</typeparam>
    /// <param name="source">The array segment.</param>
    /// <param name="index">The index to check.</param>
    /// <returns>True if the index is valid; otherwise, false.</returns>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static bool InRange<T>(this ArraySegment<T> source, int index)
        => InRange(index, source.Count);

    /// <summary>
    /// Determines whether the specified range [start, end) is within the valid range of the <see cref="ArraySegment{T}"/>.
    /// </summary>
    /// <typeparam name="T">The type of the elements.</typeparam>
    /// <param name="source">The array segment.</param>
    /// <param name="start">The start index (inclusive).</param>
    /// <param name="end">The end index (exclusive).</param>
    /// <returns>True if the range is valid; otherwise, false.</returns>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static bool InRange<T>(this ArraySegment<T> source, int start, int end)
        => InRange(start, end, source.Count);

    /// <summary>
    /// Determines whether the specified range [start, start+length) is within the valid range of the <see cref="ArraySegment{T}"/>.
    /// </summary>
    /// <typeparam name="T">The type of the elements.</typeparam>
    /// <param name="source">The array segment.</param>
    /// <param name="start">The start index (inclusive).</param>
    /// <param name="length">The length of the range.</param>
    /// <returns>True if the range is valid; otherwise, false.</returns>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static bool InRangeLength<T>(this ArraySegment<T> source, int start, int length)
        => InRange(start, start + length, source.Count);

    #endregion ArraySegment<T>

    #region Array

    /// <summary>
    /// Determines whether the specified index is within the valid range of the array.
    /// </summary>
    /// <typeparam name="T">The type of the elements.</typeparam>
    /// <param name="source">The array.</param>
    /// <param name="index">The index to check.</param>
    /// <returns>True if the index is valid; otherwise, false.</returns>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static bool InRange<T>(this T[] source, int index)
        => InRange(index, source?.Length);

    /// <summary>
    /// Determines whether the specified range [start, end) is within the valid range of the array.
    /// </summary>
    /// <typeparam name="T">The type of the elements.</typeparam>
    /// <param name="source">The array.</param>
    /// <param name="start">The start index (inclusive).</param>
    /// <param name="end">The end index (exclusive).</param>
    /// <returns>True if the range is valid; otherwise, false.</returns>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static bool InRange<T>(this T[] source, int start, int end)
        => InRange(start, end, source?.Length);

    /// <summary>
    /// Determines whether the specified range [start, start+length) is within the valid range of the array.
    /// </summary>
    /// <typeparam name="T">The type of the elements.</typeparam>
    /// <param name="source">The array.</param>
    /// <param name="start">The start index (inclusive).</param>
    /// <param name="length">The length of the range.</param>
    /// <returns>True if the range is valid; otherwise, false.</returns>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static bool InRangeLength<T>(this T[] source, int start, int length)
        => InRange(start, start + length, source?.Length);

    #endregion Array

    #region Multi-dimensional Array

    /// <summary>
    /// Determines whether the specified indices are within the valid range of the 2D array.
    /// </summary>
    /// <typeparam name="T">The type of the elements.</typeparam>
    /// <param name="source">The 2D array.</param>
    /// <param name="i">The first dimension index.</param>
    /// <param name="j">The second dimension index.</param>
    /// <returns>True if the indices are valid; otherwise, false.</returns>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static bool InRange<T>(this T[,] source, int i, int j)
        => source != null && i >= 0 && i < source.GetLength(0) && j >= 0 && j < source.GetLength(1);

    /// <summary>
    /// Determines whether the specified index ranges [iStart, iEnd), [jStart, jEnd) are within the valid range of the 2D array.
    /// </summary>
    /// <typeparam name="T">The type of the elements.</typeparam>
    /// <param name="source">The 2D array.</param>
    /// <param name="iStart">The start index for the first dimension (inclusive).</param>
    /// <param name="iEnd">The end index for the first dimension (exclusive).</param>
    /// <param name="jStart">The start index for the second dimension (inclusive).</param>
    /// <param name="jEnd">The end index for the second dimension (exclusive).</param>
    /// <returns>True if the ranges are valid; otherwise, false.</returns>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static bool InRange<T>(this T[,] source, int iStart, int iEnd, int jStart, int jEnd)
        => source != null && iStart >= 0 && iEnd >= iStart && iEnd <= source.GetLength(0)
           && jStart >= 0 && jEnd >= jStart && jEnd <= source.GetLength(1);

    /// <summary>
    /// Determines whether the specified indices are within the valid range of the 3D array.
    /// </summary>
    /// <typeparam name="T">The type of the elements.</typeparam>
    /// <param name="source">The 3D array.</param>
    /// <param name="i">The first dimension index.</param>
    /// <param name="j">The second dimension index.</param>
    /// <param name="k">The third dimension index.</param>
    /// <returns>True if the indices are valid; otherwise, false.</returns>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static bool InRange<T>(this T[,,] source, int i, int j, int k)
        => source != null && i >= 0 && i < source.GetLength(0)
           && j >= 0 && j < source.GetLength(1)
           && k >= 0 && k < source.GetLength(2);

    /// <summary>
    /// Determines whether the specified index ranges [iStart, iEnd), [jStart, jEnd), [kStart, kEnd) are within the valid range of the 3D array.
    /// </summary>
    /// <typeparam name="T">The type of the elements.</typeparam>
    /// <param name="source">The 3D array.</param>
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
    public static bool InRange<T>(this T[,,] source, int iStart, int iEnd, int jStart, int jEnd, int kStart, int kEnd)
        => source != null && iStart >= 0 && iEnd >= iStart && iEnd <= source.GetLength(0)
           && jStart >= 0 && jEnd >= jStart && jEnd <= source.GetLength(1)
           && kStart >= 0 && kEnd >= kStart && kEnd <= source.GetLength(2);

    /// <summary>
    /// Determines whether the specified indices are within the valid range of an N-dimensional array.
    /// </summary>
    /// <typeparam name="T">The type of the elements.</typeparam>
    /// <param name="source">The N-dimensional array.</param>
    /// <param name="indices">The indices for each dimension.</param>
    /// <returns>True if all indices are valid; otherwise, false.</returns>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static bool InRange<T>(this System.Array source, params int[] indices)
    {
        if (source == null || indices == null || indices.Length != source.Rank)
            return false;
        for (int d = 0; d < indices.Length; d++)
        {
            int len = source.GetLength(d);
            if (indices[d] < 0 || indices[d] >= len)
                return false;
        }
        return true;
    }

    #endregion Multi-dimensional Array

    #region Static

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

    #endregion Static
}
