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

public static partial class InRangeExtension
{
    #region IQueryable<T>

    /// <summary>
    /// Returns the source and outputs whether the specified index is within the valid range of the <see cref="IQueryable{T}"/>.
    /// </summary>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static IQueryable<T> WithInRange<T>(this IQueryable<T> source, int index, out bool result)
    {
        result = InRange(index, source?.Count());
        return source!;
    }

    /// <summary>
    /// Returns the source and outputs whether the specified range [start, end) is within the valid range of the <see cref="IQueryable{T}"/>.
    /// </summary>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static IQueryable<T> WithInRange<T>(this IQueryable<T> source, int start, int end, out bool result)
    {
        result = InRange(start, end, source?.Count());
        return source!;
    }

    /// <summary>
    /// Returns the source and outputs whether the specified range [start, start+length) is within the valid range of the <see cref="IQueryable{T}"/>.
    /// </summary>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static IQueryable<T> WithInRangeLength<T>(this IQueryable<T> source, int start, int length, out bool result)
    {
        result = InRange(start, start + length, source?.Count());
        return source!;
    }

    #endregion IQueryable<T>

    #region IEnumerable<T>

    /// <summary>
    /// Returns the source and outputs whether the specified index is within the valid range of the <see cref="IEnumerable{T}"/>.
    /// </summary>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static IEnumerable<T> WithInRange<T>(this IEnumerable<T> source, int index, out bool result)
    {
        result = InRange(index, source?.Count());
        return source!;
    }

    /// <summary>
    /// Returns the source and outputs whether the specified range [start, end) is within the valid range of the <see cref="IEnumerable{T}"/>.
    /// </summary>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static IEnumerable<T> WithInRange<T>(this IEnumerable<T> source, int start, int end, out bool result)
    {
        result = InRange(start, end, source?.Count());
        return source!;
    }

    /// <summary>
    /// Returns the source and outputs whether the specified range [start, start+length) is within the valid range of the <see cref="IEnumerable{T}"/>.
    /// </summary>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static IEnumerable<T> WithInRangeLength<T>(this IEnumerable<T> source, int start, int length, out bool result)
    {
        result = InRange(start, start + length, source?.Count());
        return source!;
    }

    #endregion IEnumerable<T>

    #region ICollection<T>

    /// <summary>
    /// Returns the source and outputs whether the specified index is within the valid range of the <see cref="ICollection{T}"/>.
    /// </summary>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static ICollection<T> WithInRange<T>(this ICollection<T> source, int index, out bool result)
    {
        result = InRange(index, source?.Count);
        return source!;
    }

    /// <summary>
    /// Returns the source and outputs whether the specified range [start, end) is within the valid range of the <see cref="ICollection{T}"/>.
    /// </summary>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static ICollection<T> WithInRange<T>(this ICollection<T> source, int start, int end, out bool result)
    {
        result = InRange(start, end, source?.Count);
        return source!;
    }

    /// <summary>
    /// Returns the source and outputs whether the specified range [start, start+length) is within the valid range of the <see cref="ICollection{T}"/>.
    /// </summary>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static ICollection<T> WithInRangeLength<T>(this ICollection<T> source, int start, int length, out bool result)
    {
        result = InRange(start, start + length, source?.Count);
        return source!;
    }

    #endregion ICollection<T>

    #region IList<T>

    /// <summary>
    /// Returns the source and outputs whether the specified index is within the valid range of the <see cref="IList{T}"/>.
    /// </summary>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static IList<T> WithInRange<T>(this IList<T> source, int index, out bool result)
    {
        result = InRange(index, source?.Count);
        return source!;
    }

    /// <summary>
    /// Returns the source and outputs whether the specified range [start, end) is within the valid range of the <see cref="IList{T}"/>.
    /// </summary>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static IList<T> WithInRange<T>(this IList<T> source, int start, int end, out bool result)
    {
        result = InRange(start, end, source?.Count);
        return source!;
    }

    /// <summary>
    /// Returns the source and outputs whether the specified range [start, start+length) is within the valid range of the <see cref="IList{T}"/>.
    /// </summary>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static IList<T> WithInRangeLength<T>(this IList<T> source, int start, int length, out bool result)
    {
        result = InRange(start, start + length, source?.Count);
        return source!;
    }

    #endregion IList<T>

    #region ICollection (non-generic)

    /// <summary>
    /// Returns the source and outputs whether the specified index is within the valid range of the <see cref="System.Collections.ICollection"/>.
    /// </summary>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static ICollection WithInRange(this ICollection source, int index, out bool result)
    {
        result = source != null && index >= 0 && index < source.Count;
        return source!;
    }

    /// <summary>
    /// Returns the source and outputs whether the specified range [start, end) is within the valid range of the <see cref="System.Collections.ICollection"/>.
    /// </summary>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static ICollection WithInRange(this ICollection source, int start, int end, out bool result)
    {
        result = source != null && start >= 0 && end >= start && end <= source.Count;
        return source!;
    }

    /// <summary>
    /// Returns the source and outputs whether the specified range [start, start+length) is within the valid range of the <see cref="System.Collections.ICollection"/>.
    /// </summary>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static ICollection WithInRangeLength(this ICollection source, int start, int length, out bool result)
    {
        result = source != null && start >= 0 && length >= 0 && (start + length) <= source.Count;
        return source!;
    }

    #endregion ICollection (non-generic)

    #region IList (non-generic)

    /// <summary>
    /// Returns the source and outputs whether the specified index is within the valid range of the <see cref="System.Collections.IList"/>.
    /// </summary>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static IList WithInRange(this IList source, int index, out bool result)
    {
        result = source != null && index >= 0 && index < source.Count;
        return source!;
    }

    /// <summary>
    /// Returns the source and outputs whether the specified range [start, end) is within the valid range of the <see cref="System.Collections.IList"/>.
    /// </summary>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static IList WithInRange(this IList source, int start, int end, out bool result)
    {
        result = source != null && start >= 0 && end >= start && end <= source.Count;
        return source!;
    }

    /// <summary>
    /// Returns the source and outputs whether the specified range [start, start+length) is within the valid range of the <see cref="System.Collections.IList"/>.
    /// </summary>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static IList WithInRangeLength(this IList source, int start, int length, out bool result)
    {
        result = source != null && start >= 0 && length >= 0 && (start + length) <= source.Count;
        return source!;
    }

    #endregion IList (non-generic)

    #region IReadOnlyList<T>

#if !NET35 && !NET40

    /// <summary>
    /// Returns the source and outputs whether the specified index is within the valid range of the <see cref="IReadOnlyList{T}"/>.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IReadOnlyList<T> WithInRange<T>(this IReadOnlyList<T> source, int index, out bool result)
    {
        result = InRange(index, source?.Count);
        return source!;
    }

    /// <summary>
    /// Returns the source and outputs whether the specified range [start, end) is within the valid range of the <see cref="IReadOnlyList{T}"/>.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IReadOnlyList<T> WithInRange<T>(this IReadOnlyList<T> source, int start, int end, out bool result)
    {
        result = InRange(start, end, source?.Count);
        return source!;
    }

    /// <summary>
    /// Returns the source and outputs whether the specified range [start, start+length) is within the valid range of the <see cref="IReadOnlyList{T}"/>.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IReadOnlyList<T> WithInRangeLength<T>(this IReadOnlyList<T> source, int start, int length, out bool result)
    {
        result = InRange(start, start + length, source?.Count);
        return source!;
    }

#endif

    #endregion IReadOnlyList<T>

    #region IReadOnlyCollection<T>

#if !NET35 && !NET40

    /// <summary>
    /// Returns the source and outputs whether the specified index is within the valid range of the <see cref="IReadOnlyCollection{T}"/>.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IReadOnlyCollection<T> WithInRange<T>(this IReadOnlyCollection<T> source, int index, out bool result)
    {
        result = InRange(index, source?.Count);
        return source!;
    }

    /// <summary>
    /// Returns the source and outputs whether the specified range [start, end) is within the valid range of the <see cref="IReadOnlyCollection{T}"/>.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IReadOnlyCollection<T> WithInRange<T>(this IReadOnlyCollection<T> source, int start, int end, out bool result)
    {
        result = InRange(start, end, source?.Count);
        return source!;
    }

    /// <summary>
    /// Returns the source and outputs whether the specified range [start, start+length) is within the valid range of the <see cref="IReadOnlyCollection{T}"/>.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IReadOnlyCollection<T> WithInRangeLength<T>(this IReadOnlyCollection<T> source, int start, int length, out bool result)
    {
        result = InRange(start, start + length, source?.Count);
        return source!;
    }

#endif

    #endregion IReadOnlyCollection<T>

    #region List<T>

    /// <summary>
    /// Returns the source and outputs whether the specified index is within the valid range of the <see cref="List{T}"/>.
    /// </summary>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static List<T> WithInRange<T>(this List<T> source, int index, out bool result)
    {
        result = InRange(index, source?.Count);
        return source!;
    }

    /// <summary>
    /// Returns the source and outputs whether the specified range [start, end) is within the valid range of the <see cref="List{T}"/>.
    /// </summary>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static List<T> WithInRange<T>(this List<T> source, int start, int end, out bool result)
    {
        result = InRange(start, end, source?.Count);
        return source!;
    }

    /// <summary>
    /// Returns the source and outputs whether the specified range [start, start+length) is within the valid range of the <see cref="List{T}"/>.
    /// </summary>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static List<T> WithInRangeLength<T>(this List<T> source, int start, int length, out bool result)
    {
        result = InRange(start, start + length, source?.Count);
        return source!;
    }

    #endregion List<T>

    #region Array

    /// <summary>
    /// Returns the source and outputs whether the specified index is within the valid range of the array.
    /// </summary>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static T[] WithInRange<T>(this T[] source, int index, out bool result)
    {
        result = InRange(index, source?.Length);
        return source!;
    }

    /// <summary>
    /// Returns the source and outputs whether the specified range [start, end) is within the valid range of the array.
    /// </summary>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static T[] WithInRange<T>(this T[] source, int start, int end, out bool result)
    {
        result = InRange(start, end, source?.Length);
        return source!;
    }

    /// <summary>
    /// Returns the source and outputs whether the specified range [start, start+length) is within the valid range of the array.
    /// </summary>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static T[] WithInRangeLength<T>(this T[] source, int start, int length, out bool result)
    {
        result = InRange(start, start + length, source?.Length);
        return source!;
    }

    #endregion Array

    #region ArraySegment<T>

    /// <summary>
    /// Returns the source and outputs whether the specified index is within the valid range of the <see cref="ArraySegment{T}"/>.
    /// </summary>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static ArraySegment<T> WithInRange<T>(this ArraySegment<T> source, int index, out bool result)
    {
        result = InRange(index, source.Count);
        return source;
    }

    /// <summary>
    /// Returns the source and outputs whether the specified range [start, end) is within the valid range of the <see cref="ArraySegment{T}"/>.
    /// </summary>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static ArraySegment<T> WithInRange<T>(this ArraySegment<T> source, int start, int end, out bool result)
    {
        result = InRange(start, end, source.Count);
        return source;
    }

    /// <summary>
    /// Returns the source and outputs whether the specified range [start, start+length) is within the valid range of the <see cref="ArraySegment{T}"/>.
    /// </summary>
#if !NET35 && !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static ArraySegment<T> WithInRangeLength<T>(this ArraySegment<T> source, int start, int length, out bool result)
    {
        result = InRange(start, start + length, source.Count);
        return source;
    }

    #endregion ArraySegment<T>

    #region ObservableCollection<T>

#if !NET35

    /// <summary>
    /// Returns the source and outputs whether the specified index is within the valid range of the <see cref="System.Collections.ObjectModel.ObservableCollection{T}"/>.
    /// </summary>
#if !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static ObservableCollection<T> WithInRange<T>(this ObservableCollection<T> source, int index, out bool result)
    {
        result = InRange(index, source?.Count);
        return source!;
    }

    /// <summary>
    /// Returns the source and outputs whether the specified range [start, end) is within the valid range of the <see cref="System.Collections.ObjectModel.ObservableCollection{T}"/>.
    /// </summary>
#if !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static ObservableCollection<T> WithInRange<T>(this ObservableCollection<T> source, int start, int end, out bool result)
    {
        result = InRange(start, end, source?.Count);
        return source!;
    }

    /// <summary>
    /// Returns the source and outputs whether the specified range [start, start+length) is within the valid range of the <see cref="System.Collections.ObjectModel.ObservableCollection{T}"/>.
    /// </summary>
#if !NET40

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static ObservableCollection<T> WithInRangeLength<T>(this ObservableCollection<T> source, int start, int length, out bool result)
    {
        result = InRange(start, start + length, source?.Count);
        return source!;
    }

#endif

    #endregion ObservableCollection<T>

    #region Span

#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER

    /// <summary>
    /// Returns the source and outputs whether the specified index is within the valid range of the <see cref="Span{T}"/>.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Span<T> WithInRange<T>(this Span<T> source, int index, out bool result)
    {
        result = InRange(index, source.Length);
        return source;
    }
    /// <summary>
    /// Returns the source and outputs whether the specified range [start, end) is within the valid range of the <see cref="Span{T}"/>.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Span<T> WithInRange<T>(this Span<T> source, int start, int end, out bool result)
    {
        result = InRange(start, end, source.Length);
        return source;
    }
    /// <summary>
    /// Returns the source and outputs whether the specified range [start, start+length) is within the valid range of the <see cref="Span{T}"/>.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Span<T> WithInRangeLength<T>(this Span<T> source, int start, int length, out bool result)
    {
        result = InRange(start, start + length, source.Length);
        return source;
    }

#endif

    #endregion Span

    #region ReadOnlySpan

#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER

    /// <summary>
    /// Returns the source and outputs whether the specified index is within the valid range of the <see cref="ReadOnlySpan{T}"/>.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ReadOnlySpan<T> WithInRange<T>(this ReadOnlySpan<T> source, int index, out bool result)
    {
        result = InRange(index, source.Length);
        return source;
    }

    /// <summary>
    /// Returns the source and outputs whether the specified range [start, end) is within the valid range of the <see cref="ReadOnlySpan{T}"/>.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ReadOnlySpan<T> WithInRange<T>(this ReadOnlySpan<T> source, int start, int end, out bool result)
    {
        result = InRange(start, end, source.Length);
        return source;
    }

    /// <summary>
    /// Returns the source and outputs whether the specified range [start, start+length) is within the valid range of the <see cref="ReadOnlySpan{T}"/>.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ReadOnlySpan<T> WithInRangeLength<T>(this ReadOnlySpan<T> source, int start, int length, out bool result)
    {
        result = InRange(start, start + length, source.Length);
        return source;
    }

#endif

    #endregion ReadOnlySpan

    #region ReadOnlySpan

#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER

    /// <summary>
    /// Returns the source and outputs whether the specified index is within the valid range of the <see cref="Memory{T}"/>.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Memory<T> WithInRange<T>(this Memory<T> source, int index, out bool result)
    {
        result = InRange(index, source.Length);
        return source;
    }

    /// <summary>
    /// Returns the source and outputs whether the specified range [start, end) is within the valid range of the <see cref="Memory{T}"/>.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Memory<T> WithInRange<T>(this Memory<T> source, int start, int end, out bool result)
    {
        result = InRange(start, end, source.Length);
        return source;
    }

    /// <summary>
    /// Returns the source and outputs whether the specified range [start, start+length) is within the valid range of the <see cref="Memory{T}"/>.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Memory<T> WithInRangeLength<T>(this Memory<T> source, int start, int length, out bool result)
    {
        result = InRange(start, start + length, source.Length);
        return source;
    }

#endif

    #endregion ReadOnlySpan

    #region ReadOnlySpan

#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER

    /// <summary>
    /// Returns the source and outputs whether the specified index is within the valid range of the <see cref="ReadOnlyMemory{T}"/>.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ReadOnlyMemory<T> WithInRange<T>(this ReadOnlyMemory<T> source, int index, out bool result)
    {
        result = InRange(index, source.Length);
        return source;
    }

    /// <summary>
    /// Returns the source and outputs whether the specified range [start, end) is within the valid range of the <see cref="ReadOnlyMemory{T}"/>.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ReadOnlyMemory<T> WithInRange<T>(this ReadOnlyMemory<T> source, int start, int end, out bool result)
    {
        result = InRange(start, end, source.Length);
        return source;
    }

    /// <summary>
    /// Returns the source and outputs whether the specified range [start, start+length) is within the valid range of the <see cref="ReadOnlyMemory{T}"/>.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ReadOnlyMemory<T> WithInRangeLength<T>(this ReadOnlyMemory<T> source, int start, int length, out bool result)
    {
        result = InRange(start, start + length, source.Length);
        return source;
    }

#endif

    #endregion ReadOnlySpan
}
