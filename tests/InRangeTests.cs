using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.InRange;
using System.Linq;
using Xunit;

[SuppressMessage("Design", "CA1050:Declare types in namespaces")]
public sealed partial class InRangeTests
{
    [Fact]
    public void Array_InRange_Works()
    {
        int[] arr = [10, 20, 30];
        Assert.True(arr.InRange(0));
        Assert.True(arr.InRange(2));
        Assert.False(arr.InRange(-1));
        Assert.False(arr.InRange(3));
    }

    [Fact]
    public void IList_InRange_Works()
    {
        IList<string> list = ["a", "b"];
        Assert.True(list.InRange(0));
        Assert.True(list.InRange(1));
        Assert.False(list.InRange(2));
        Assert.False(list.InRange(-1));
    }

    [Fact]
    public void List_InRange_Works()
    {
        List<string> list = ["a", "b"];
        Assert.True(list.InRange(0));
        Assert.True(list.InRange(1));
        Assert.False(list.InRange(2));
        Assert.False(list.InRange(-1));
    }

    [Fact]
    public void Collection_InRange_Works()
    {
        ICollection<double> col = [1.1, 2.2];
        Assert.True(col.InRange(0));
        Assert.True(col.InRange(1));
        Assert.False(col.InRange(2));
        Assert.False(col.InRange(-1));
    }

    [Fact]
    public void Enumerable_InRange_Works()
    {
        IEnumerable<int> enumerable = [1, 2, 3];
        Assert.True(enumerable.InRange(0));
        Assert.True(enumerable.InRange(2));
        Assert.False(enumerable.InRange(3));
        Assert.False(enumerable.InRange(-1));
    }

    [Fact]
    public void Queryable_InRange_Works()
    {
        IQueryable<int> queryable = new List<int> { 1, 2, 3 }.AsQueryable();
        Assert.True(queryable.InRange(0));
        Assert.True(queryable.InRange(2));
        Assert.False(queryable.InRange(3));
        Assert.False(queryable.InRange(-1));
    }

    [Fact]
    public void Null_Collections_Return_False()
    {
        int[] arr = null;
        IList<int> list = null;
        ICollection<int> col = null;
        IEnumerable<int> enumerable = null;
        IQueryable<int> queryable = null;
        Assert.False(arr.InRange(0));
        Assert.False(list.InRange(0));
        Assert.False(col.InRange(0));
        Assert.False(enumerable.InRange(0));
        Assert.False(queryable.InRange(0));
    }

    [Fact]
    public void Static_InRange_Works()
    {
        Assert.True(InRangeExtension.InRange(0, 1));
        Assert.True(InRangeExtension.InRange(1, 2));
        Assert.False(InRangeExtension.InRange(-1, 2));
        Assert.False(InRangeExtension.InRange(2, 2));
        Assert.False(InRangeExtension.InRange(0, null));
    }

    [Fact]
    public void Array_InRange_Range_Works()
    {
        int[] arr = [10, 20, 30];
        Assert.True(arr.InRange(0, 2));
        Assert.True(arr.InRangeLength(1, 2));
        Assert.False(arr.InRange(2, 4));
        Assert.False(arr.InRangeLength(2, 2));
        Assert.False(arr.InRange(-1, 1));
    }

    [Fact]
    public void List_InRange_Range_Works()
    {
        List<int> list = [1, 2, 3];
        Assert.True(list.InRange(0, 2));
        Assert.True(list.InRangeLength(1, 2));
        Assert.False(list.InRange(2, 4));
        Assert.False(list.InRangeLength(2, 2));
        Assert.False(list.InRange(-1, 1));
    }

    [Fact]
    public void ICollection_InRange_Range_Works()
    {
        ICollection<int> col = [1, 2, 3];
        Assert.True(col.InRange(0, 2));
        Assert.True(col.InRangeLength(1, 2));
        Assert.False(col.InRange(2, 4));
        Assert.False(col.InRangeLength(2, 2));
        Assert.False(col.InRange(-1, 1));
    }

    [Fact]
    public void IEnumerable_InRange_Range_Works()
    {
        IEnumerable<int> enumerable = [1, 2, 3];
        Assert.True(enumerable.InRange(0, 2));
        Assert.True(enumerable.InRangeLength(1, 2));
        Assert.False(enumerable.InRange(2, 4));
        Assert.False(enumerable.InRangeLength(2, 2));
        Assert.False(enumerable.InRange(-1, 1));
    }

    [Fact]
    public void Queryable_InRange_Range_Works()
    {
        IQueryable<int> queryable = new List<int> { 1, 2, 3 }.AsQueryable();
        Assert.True(queryable.InRange(0, 2));
        Assert.True(queryable.InRangeLength(1, 2));
        Assert.False(queryable.InRange(2, 4));
        Assert.False(queryable.InRangeLength(2, 2));
        Assert.False(queryable.InRange(-1, 1));
    }

    [Fact]
    public void ArraySegment_InRange_Works()
    {
        var seg = new ArraySegment<int>([1, 2, 3]);
        Assert.True(seg.InRange(0));
        Assert.True(seg.InRange(2));
        Assert.False(seg.InRange(3));
        Assert.True(seg.InRange(0, 2));
        Assert.False(seg.InRange(2, 4));
        Assert.True(seg.InRangeLength(1, 2));
        Assert.False(seg.InRangeLength(2, 2));
    }

    [Fact]
    public void ObservableCollection_InRange_Works()
    {
        var oc = new System.Collections.ObjectModel.ObservableCollection<int> { 1, 2, 3 };
        Assert.True(oc.InRange(0));
        Assert.True(oc.InRange(2));
        Assert.False(oc.InRange(3));
        Assert.True(oc.InRange(0, 2));
        Assert.False(oc.InRange(2, 4));
        Assert.True(oc.InRangeLength(1, 2));
        Assert.False(oc.InRangeLength(2, 2));
    }

    [Fact]
    public void NonGenericCollection_InRange_Works()
    {
        var arr = new int[] { 1, 2, 3 };
        System.Collections.ICollection col = arr;
        System.Collections.IList list = arr;
        Assert.True(col.InRange(0));
        Assert.True(col.InRange(2));
        Assert.False(col.InRange(3));
        Assert.True(col.InRange(0, 2));
        Assert.False(col.InRange(2, 4));
        Assert.True(col.InRangeLength(1, 2));
        Assert.False(col.InRangeLength(2, 2));
        Assert.True(list.InRange(0));
        Assert.True(list.InRange(2));
        Assert.False(list.InRange(3));
        Assert.True(list.InRange(0, 2));
        Assert.False(list.InRange(2, 4));
        Assert.True(list.InRangeLength(1, 2));
        Assert.False(list.InRangeLength(2, 2));
    }

    [Fact]
    public void MultiDimensionalArray_InRange_Works()
    {
        int[,] arr2d = new int[3, 2];
        Assert.True(arr2d.InRange(0, 0));
        Assert.True(arr2d.InRange(2, 1));
        Assert.False(arr2d.InRange(3, 0));
        Assert.False(arr2d.InRange(0, 2));
        Assert.True(arr2d.InRange(0, 2, 0, 2));
        Assert.False(arr2d.InRange(2, 4, 0, 2));
        int[,,] arr3d = new int[2, 2, 2];
        Assert.True(arr3d.InRange(1, 1, 1));
        Assert.False(arr3d.InRange(2, 1, 1));
        Assert.True(arr3d.InRange(0, 2, 0, 2, 0, 2));
        Assert.False(arr3d.InRange(1, 3, 0, 2, 0, 2));
    }

    [Fact]
    public void IReadOnlyList_InRange_Works()
    {
        IReadOnlyList<int> list = [1, 2, 3];
        Assert.True(list.InRange(0));
        Assert.True(list.InRange(2));
        Assert.False(list.InRange(3));
        Assert.True(list.InRange(0, 2));
        Assert.False(list.InRange(2, 4));
        Assert.True(list.InRangeLength(1, 2));
        Assert.False(list.InRangeLength(2, 2));
    }

    [Fact]
    public void IReadOnlyCollection_InRange_Works()
    {
        IReadOnlyCollection<int> col = [1, 2, 3];
        Assert.True(col.InRange(0));
        Assert.True(col.InRange(2));
        Assert.False(col.InRange(3));
        Assert.True(col.InRange(0, 2));
        Assert.False(col.InRange(2, 4));
        Assert.True(col.InRangeLength(1, 2));
        Assert.False(col.InRangeLength(2, 2));
    }
}
