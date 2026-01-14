using System.Collections;
using System.Collections.Generic;
using System.Linq;

#if !NET35

using System.Collections.ObjectModel;

#endif

#if !NET35 && !NET40

using System.Runtime.CompilerServices;

#endif

namespace System.InRange;

/// <summary>
/// Provides extension methods for checking and validating index/range for various collection types. Throws ArgumentOutOfRangeException if out of range.
/// </summary>
public static partial class InRangeExtension
{
    #region IQueryable<T>

    /// <summary>
    /// Throws ArgumentOutOfRangeException if the index is out of range for the IQueryable.
    /// </summary>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static void CheckInRange<T>(this IQueryable<T> source, int index)
    {
        if (!source.InRange(index))
            throw new ArgumentOutOfRangeException(nameof(index));
    }

    /// <summary>
    /// Throws ArgumentOutOfRangeException if the range [start, end) is out of range for the IQueryable.
    /// </summary>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static void CheckInRange<T>(this IQueryable<T> source, int start, int end)
    {
        if (!source.InRange(start, end))
            throw new ArgumentOutOfRangeException();
    }

    /// <summary>
    /// Throws ArgumentOutOfRangeException if the range [start, start+length) is out of range for the IQueryable.
    /// </summary>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static void CheckInRangeLength<T>(this IQueryable<T> source, int start, int length)
    {
        if (!source.InRangeLength(start, length))
            throw new ArgumentOutOfRangeException();
    }

    #endregion IQueryable<T>

    #region IEnumerable<T>

    /// <summary>
    /// Throws ArgumentOutOfRangeException if the index is out of range for the IEnumerable.
    /// </summary>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static void CheckInRange<T>(this IEnumerable<T> source, int index)
    {
        if (!source.InRange(index))
            throw new ArgumentOutOfRangeException(nameof(index));
    }

    /// <summary>
    /// Throws ArgumentOutOfRangeException if the range [start, end) is out of range for the IEnumerable.
    /// </summary>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static void CheckInRange<T>(this IEnumerable<T> source, int start, int end)
    {
        if (!source.InRange(start, end))
            throw new ArgumentOutOfRangeException();
    }

    /// <summary>
    /// Throws ArgumentOutOfRangeException if the range [start, start+length) is out of range for the IEnumerable.
    /// </summary>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static void CheckInRangeLength<T>(this IEnumerable<T> source, int start, int length)
    {
        if (!source.InRangeLength(start, length))
            throw new ArgumentOutOfRangeException();
    }

    #endregion IEnumerable<T>

    #region ICollection<T>

    /// <summary>
    /// Throws ArgumentOutOfRangeException if the index is out of range for the ICollection.
    /// </summary>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static void CheckInRange<T>(this ICollection<T> source, int index)
    {
        if (!source.InRange(index))
            throw new ArgumentOutOfRangeException(nameof(index));
    }

    /// <summary>
    /// Throws ArgumentOutOfRangeException if the range [start, end) is out of range for the ICollection.
    /// </summary>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static void CheckInRange<T>(this ICollection<T> source, int start, int end)
    {
        if (!source.InRange(start, end))
            throw new ArgumentOutOfRangeException();
    }

    /// <summary>
    /// Throws ArgumentOutOfRangeException if the range [start, start+length) is out of range for the ICollection.
    /// </summary>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static void CheckInRangeLength<T>(this ICollection<T> source, int start, int length)
    {
        if (!source.InRangeLength(start, length))
            throw new ArgumentOutOfRangeException();
    }

    #endregion ICollection<T>

    #region IList<T>

    /// <summary>
    /// Throws ArgumentOutOfRangeException if the index is out of range for the IList.
    /// </summary>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static void CheckInRange<T>(this IList<T> source, int index)
    {
        if (!source.InRange(index))
            throw new ArgumentOutOfRangeException(nameof(index));
    }

    /// <summary>
    /// Throws ArgumentOutOfRangeException if the range [start, end) is out of range for the IList.
    /// </summary>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static void CheckInRange<T>(this IList<T> source, int start, int end)
    {
        if (!source.InRange(start, end))
            throw new ArgumentOutOfRangeException();
    }

    /// <summary>
    /// Throws ArgumentOutOfRangeException if the range [start, start+length) is out of range for the IList.
    /// </summary>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static void CheckInRangeLength<T>(this IList<T> source, int start, int length)
    {
        if (!source.InRangeLength(start, length))
            throw new ArgumentOutOfRangeException();
    }

    #endregion IList<T>

    #region ICollection (non-generic)

    /// <summary>
    /// Throws ArgumentOutOfRangeException if the index is out of range for the non-generic ICollection.
    /// </summary>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static void CheckInRange(this ICollection source, int index)
    {
        if (!source.InRange(index))
            throw new ArgumentOutOfRangeException(nameof(index));
    }

    /// <summary>
    /// Throws ArgumentOutOfRangeException if the range [start, end) is out of range for the non-generic ICollection.
    /// </summary>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static void CheckInRange(this ICollection source, int start, int end)
    {
        if (!source.InRange(start, end))
            throw new ArgumentOutOfRangeException();
    }

    /// <summary>
    /// Throws ArgumentOutOfRangeException if the range [start, start+length) is out of range for the non-generic ICollection.
    /// </summary>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static void CheckInRangeLength(this ICollection source, int start, int length)
    {
        if (!source.InRangeLength(start, length))
            throw new ArgumentOutOfRangeException();
    }

    #endregion ICollection (non-generic)

    #region IList (non-generic)

    /// <summary>
    /// Throws ArgumentOutOfRangeException if the index is out of range for the non-generic IList.
    /// </summary>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static void CheckInRange(this IList source, int index)
    {
        if (!source.InRange(index))
            throw new ArgumentOutOfRangeException(nameof(index));
    }

    /// <summary>
    /// Throws ArgumentOutOfRangeException if the range [start, end) is out of range for the non-generic IList.
    /// </summary>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static void CheckInRange(this IList source, int start, int end)
    {
        if (!source.InRange(start, end))
            throw new ArgumentOutOfRangeException();
    }

    /// <summary>
    /// Throws ArgumentOutOfRangeException if the range [start, start+length) is out of range for the non-generic IList.
    /// </summary>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static void CheckInRangeLength(this IList source, int start, int length)
    {
        if (!source.InRangeLength(start, length))
            throw new ArgumentOutOfRangeException();
    }

    #endregion IList (non-generic)

    #region ObservableCollection<T>

#if !NET35

    /// <summary>
    /// Throws ArgumentOutOfRangeException if the index is out of range for the ObservableCollection.
    /// </summary>
    public static void CheckInRange<T>(this ObservableCollection<T> source, int index)
    {
        if (!source.InRange(index))
            throw new ArgumentOutOfRangeException(nameof(index));
    }

    /// <summary>
    /// Throws ArgumentOutOfRangeException if the range [start, end) is out of range for the ObservableCollection.
    /// </summary>
    public static void CheckInRange<T>(this ObservableCollection<T> source, int start, int end)
    {
        if (!source.InRange(start, end))
            throw new ArgumentOutOfRangeException();
    }

    /// <summary>
    /// Throws ArgumentOutOfRangeException if the range [start, start+length) is out of range for the ObservableCollection.
    /// </summary>
    public static void CheckInRangeLength<T>(this ObservableCollection<T> source, int start, int length)
    {
        if (!source.InRangeLength(start, length))
            throw new ArgumentOutOfRangeException();
    }

#endif

    #endregion ObservableCollection<T>

    #region IReadOnlyList<T>

#if !NET35 && !NET40

    /// <summary>
    /// Throws ArgumentOutOfRangeException if the index is out of range for the IReadOnlyList.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void CheckInRange<T>(this IReadOnlyList<T> source, int index)
    {
        if (!source.InRange(index))
            throw new ArgumentOutOfRangeException(nameof(index));
    }

    /// <summary>
    /// Throws ArgumentOutOfRangeException if the range [start, end) is out of range for the IReadOnlyList.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void CheckInRange<T>(this IReadOnlyList<T> source, int start, int end)
    {
        if (!source.InRange(start, end))
            throw new ArgumentOutOfRangeException();
    }

    /// <summary>
    /// Throws ArgumentOutOfRangeException if the range [start, start+length) is out of range for the IReadOnlyList.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void CheckInRangeLength<T>(this IReadOnlyList<T> source, int start, int length)
    {
        if (!source.InRangeLength(start, length))
            throw new ArgumentOutOfRangeException();
    }

#endif

    #endregion IReadOnlyList<T>

    #region IReadOnlyCollection<T>

#if !NET35 && !NET40

    /// <summary>
    /// Throws ArgumentOutOfRangeException if the index is out of range for the IReadOnlyCollection.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void CheckInRange<T>(this IReadOnlyCollection<T> source, int index)
    {
        if (!source.InRange(index))
            throw new ArgumentOutOfRangeException(nameof(index));
    }

    /// <summary>
    /// Throws ArgumentOutOfRangeException if the range [start, end) is out of range for the IReadOnlyCollection.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void CheckInRange<T>(this IReadOnlyCollection<T> source, int start, int end)
    {
        if (!source.InRange(start, end))
            throw new ArgumentOutOfRangeException();
    }

    /// <summary>
    /// Throws ArgumentOutOfRangeException if the range [start, start+length) is out of range for the IReadOnlyCollection.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void CheckInRangeLength<T>(this IReadOnlyCollection<T> source, int start, int length)
    {
        if (!source.InRangeLength(start, length))
            throw new ArgumentOutOfRangeException();
    }

#endif

    #endregion IReadOnlyCollection<T>

    #region List<T>

    /// <summary>
    /// Throws ArgumentOutOfRangeException if the index is out of range for the List.
    /// </summary>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static void CheckInRange<T>(this List<T> source, int index)
    {
        if (!source.InRange(index))
            throw new ArgumentOutOfRangeException(nameof(index));
    }

    /// <summary>
    /// Throws ArgumentOutOfRangeException if the range [start, end) is out of range for the List.
    /// </summary>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static void CheckInRange<T>(this List<T> source, int start, int end)
    {
        if (!source.InRange(start, end))
            throw new ArgumentOutOfRangeException();
    }

    /// <summary>
    /// Throws ArgumentOutOfRangeException if the range [start, start+length) is out of range for the List.
    /// </summary>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static void CheckInRangeLength<T>(this List<T> source, int start, int length)
    {
        if (!source.InRangeLength(start, length))
            throw new ArgumentOutOfRangeException();
    }

    #endregion List<T>

    #region Array

    /// <summary>
    /// Throws ArgumentOutOfRangeException if the index is out of range for the array.
    /// </summary>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static void CheckInRange<T>(this T[] source, int index)
    {
        if (!source.InRange(index))
            throw new ArgumentOutOfRangeException(nameof(index));
    }

    /// <summary>
    /// Throws ArgumentOutOfRangeException if the range [start, end) is out of range for the array.
    /// </summary>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static void CheckInRange<T>(this T[] source, int start, int end)
    {
        if (!source.InRange(start, end))
            throw new ArgumentOutOfRangeException();
    }

    /// <summary>
    /// Throws ArgumentOutOfRangeException if the range [start, start+length) is out of range for the array.
    /// </summary>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static void CheckInRangeLength<T>(this T[] source, int start, int length)
    {
        if (!source.InRangeLength(start, length))
            throw new ArgumentOutOfRangeException();
    }

    #endregion Array

    #region Multi-dimensional Array

    /// <summary>
    /// Throws <see cref="ArgumentOutOfRangeException"/> if the specified indices are out of range for the 2D array.
    /// </summary>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static void CheckInRange<T>(this T[,] source, int i, int j)
    {
        if (!source.InRange(i, j))
            throw new ArgumentOutOfRangeException();
    }

    /// <summary>
    /// Throws <see cref="ArgumentOutOfRangeException"/> if the specified ranges are out of range for the 2D array.
    /// </summary>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static void CheckInRange<T>(this T[,] source, int iStart, int iEnd, int jStart, int jEnd)
    {
        if (!source.InRange(iStart, iEnd, jStart, jEnd))
            throw new ArgumentOutOfRangeException();
    }

    /// <summary>
    /// Throws <see cref="ArgumentOutOfRangeException"/> if the specified indices are out of range for the 3D array.
    /// </summary>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static void CheckInRange<T>(this T[,,] source, int i, int j, int k)
    {
        if (!source.InRange(i, j, k))
            throw new ArgumentOutOfRangeException();
    }

    /// <summary>
    /// Throws <see cref="ArgumentOutOfRangeException"/> if the specified ranges are out of range for the 3D array.
    /// </summary>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static void CheckInRange<T>(this T[,,] source, int iStart, int iEnd, int jStart, int jEnd, int kStart, int kEnd)
    {
        if (!source.InRange(iStart, iEnd, jStart, jEnd, kStart, kEnd))
            throw new ArgumentOutOfRangeException();
    }

    /// <summary>
    /// Throws ArgumentOutOfRangeException if the index is out of range for the N-dimensional array.
    /// </summary>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static void CheckInRange(this Array source, int index)
    {
        if (!source.InRange(index))
            throw new ArgumentOutOfRangeException();
    }

    #endregion Multi-dimensional Array

    #region ArraySegment<T>

    /// <summary>
    /// Throws ArgumentOutOfRangeException if the index is out of range for the ArraySegment.
    /// </summary>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static void CheckInRange<T>(this ArraySegment<T> source, int index)
    {
        if (!source.InRange(index))
            throw new ArgumentOutOfRangeException(nameof(index));
    }

    /// <summary>
    /// Throws ArgumentOutOfRangeException if the range [start, end) is out of range for the ArraySegment.
    /// </summary>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static void CheckInRange<T>(this ArraySegment<T> source, int start, int end)
    {
        if (!source.InRange(start, end))
            throw new ArgumentOutOfRangeException();
    }

    /// <summary>
    /// Throws ArgumentOutOfRangeException if the range [start, start+length) is out of range for the ArraySegment.
    /// </summary>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static void CheckInRangeLength<T>(this ArraySegment<T> source, int start, int length)
    {
        if (!source.InRangeLength(start, length))
            throw new ArgumentOutOfRangeException();
    }

    #endregion ArraySegment<T>

    #region Span

#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER

    /// <summary>
    /// Throws ArgumentOutOfRangeException if the index is out of range for the Span.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void CheckInRange<T>(this Span<T> source, int index)
    {
        if (!source.InRange(index))
            throw new ArgumentOutOfRangeException(nameof(index));
    }

    /// <summary>
    /// Throws ArgumentOutOfRangeException if the range [start, end) is out of range for the Span.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void CheckInRange<T>(this Span<T> source, int start, int end)
    {
        if (!source.InRange(start, end))
            throw new ArgumentOutOfRangeException();
    }

    /// <summary>
    /// Throws ArgumentOutOfRangeException if the range [start, start+length) is out of range for the Span.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void CheckInRangeLength<T>(this Span<T> source, int start, int length)
    {
        if (!source.InRangeLength(start, length))
            throw new ArgumentOutOfRangeException();
    }

#endif

    #endregion Span

    #region ReadOnlySpan

#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER

    /// <summary>
    /// Throws ArgumentOutOfRangeException if the index is out of range for the ReadOnlySpan.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void CheckInRange<T>(this ReadOnlySpan<T> source, int index)
    {
        if (!source.InRange(index))
            throw new ArgumentOutOfRangeException(nameof(index));
    }

    /// <summary>
    /// Throws ArgumentOutOfRangeException if the range [start, end) is out of range for the ReadOnlySpan.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void CheckInRange<T>(this ReadOnlySpan<T> source, int start, int end)
    {
        if (!source.InRange(start, end))
            throw new ArgumentOutOfRangeException();
    }
    /// <summary>
    /// Throws ArgumentOutOfRangeException if the range [start, start+length) is out of range for the ReadOnlySpan.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void CheckInRangeLength<T>(this ReadOnlySpan<T> source, int start, int length)
    {
        if (!source.InRangeLength(start, length))
            throw new ArgumentOutOfRangeException();
    }
#endif

    #endregion ReadOnlySpan

    #region Memory

#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
    /// <summary>
    /// Throws ArgumentOutOfRangeException if the index is out of range for the Memory.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void CheckInRange<T>(this Memory<T> source, int index)
    {
        if (!source.InRange(index))
            throw new ArgumentOutOfRangeException(nameof(index));
    }
    /// <summary>
    /// Throws ArgumentOutOfRangeException if the range [start, end) is out of range for the Memory.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void CheckInRange<T>(this Memory<T> source, int start, int end)
    {
        if (!source.InRange(start, end))
            throw new ArgumentOutOfRangeException();
    }
    /// <summary>
    /// Throws ArgumentOutOfRangeException if the range [start, start+length) is out of range for the Memory.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void CheckInRangeLength<T>(this Memory<T> source, int start, int length)
    {
        if (!source.InRangeLength(start, length))
            throw new ArgumentOutOfRangeException();
    }
#endif

    #endregion Memory

    #region ReadOnlyMemory

#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER

    /// <summary>
    /// Throws ArgumentOutOfRangeException if the index is out of range for the ReadOnlyMemory.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void CheckInRange<T>(this ReadOnlyMemory<T> source, int index)
    {
        if (!source.InRange(index))
            throw new ArgumentOutOfRangeException(nameof(index));
    }

    /// <summary>
    /// Throws ArgumentOutOfRangeException if the range [start, end) is out of range for the ReadOnlyMemory.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void CheckInRange<T>(this ReadOnlyMemory<T> source, int start, int end)
    {
        if (!source.InRange(start, end))
            throw new ArgumentOutOfRangeException();
    }

    /// <summary>
    /// Throws ArgumentOutOfRangeException if the range [start, start+length) is out of range for the ReadOnlyMemory.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void CheckInRangeLength<T>(this ReadOnlyMemory<T> source, int start, int length)
    {
        if (!source.InRangeLength(start, length))
            throw new ArgumentOutOfRangeException();
    }

#endif

    #endregion ReadOnlyMemory
}
