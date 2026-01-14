using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.InRange;
using Xunit;

public sealed partial class InRangeTests
{
    [Fact]
    public void Array_WithInRange_Works()
    {
        int[] arr = [10, 20, 30];
        Assert.True(arr.WithInRange(1, out var result) == arr && result);
        Assert.False(arr.WithInRange(3, out result) == arr && result);
        Assert.True(arr.WithInRange(0, 2, out result) == arr && result);
        Assert.False(arr.WithInRange(2, 4, out result) == arr && result);
        Assert.True(arr.WithInRangeLength(1, 2, out result) == arr && result);
        Assert.False(arr.WithInRangeLength(2, 2, out result) == arr && result);
    }

    [Fact]
    public void List_WithInRange_Works()
    {
        List<int> list = [1, 2, 3];
        Assert.True(list.WithInRange(1, out var result) == list && result);
        Assert.False(list.WithInRange(3, out result) == list && result);
        Assert.True(list.WithInRange(0, 2, out result) == list && result);
        Assert.False(list.WithInRange(2, 4, out result) == list && result);
        Assert.True(list.WithInRangeLength(1, 2, out result) == list && result);
        Assert.False(list.WithInRangeLength(2, 2, out result) == list && result);
    }

    [Fact]
    public void ObservableCollection_WithInRange_Works()
    {
        ObservableCollection<int> oc = [1, 2, 3];
        Assert.True(oc.WithInRange(1, out var result) == oc && result);
        Assert.False(oc.WithInRange(3, out result) == oc && result);
        Assert.True(oc.WithInRange(0, 2, out result) == oc && result);
        Assert.False(oc.WithInRange(2, 4, out result) == oc && result);
        Assert.True(oc.WithInRangeLength(1, 2, out result) == oc && result);
        Assert.False(oc.WithInRangeLength(2, 2, out result) == oc && result);
    }

    [Fact]
    public void ArraySegment_WithInRange_Works()
    {
        ArraySegment<int> seg = new([1, 2, 3]);
        Assert.True(seg.WithInRange(1, out var result) == seg && result);
        Assert.False(seg.WithInRange(3, out result) == seg && result);
        Assert.True(seg.WithInRange(0, 2, out result) == seg && result);
        Assert.False(seg.WithInRange(2, 4, out result) == seg && result);
        Assert.True(seg.WithInRangeLength(1, 2, out result) == seg && result);
        Assert.False(seg.WithInRangeLength(2, 2, out result) == seg && result);
    }

    [Fact]
    public void NonGenericCollection_WithInRange_Works()
    {
        int[] arr = [1, 2, 3];
        ICollection col = arr;
        IList list = arr;
        Assert.True(col.WithInRange(1, out var result) == col && result);
        Assert.False(col.WithInRange(3, out result) == col && result);
        Assert.True(col.WithInRange(0, 2, out result) == col && result);
        Assert.False(col.WithInRange(2, 4, out result) == col && result);
        Assert.True(col.WithInRangeLength(1, 2, out result) == col && result);
        Assert.False(col.WithInRangeLength(2, 2, out result) == col && result);
        Assert.True(list.WithInRange(1, out result) == list && result);
        Assert.False(list.WithInRange(3, out result) == list && result);
        Assert.True(list.WithInRange(0, 2, out result) == list && result);
        Assert.False(list.WithInRange(2, 4, out result) == list && result);
        Assert.True(list.WithInRangeLength(1, 2, out result) == list && result);
        Assert.False(list.WithInRangeLength(2, 2, out result) == list && result);
    }

    [Fact]
    public void MultiDimensionalArray_WithInRange_Works()
    {
        int[,] arr2d = new int[3, 2];
        Assert.True(arr2d.WithInRange(2, 1, out var result) == arr2d && result);
        Assert.False(arr2d.WithInRange(3, 0, out result) == arr2d && result);
    }

    [Fact]
    public void IReadOnlyList_WithInRange_Works()
    {
        IReadOnlyList<int> list = [1, 2, 3];
        Assert.True(list.WithInRange(1, out var result) == list && result);
        Assert.False(list.WithInRange(3, out result) == list && result);
        Assert.True(list.WithInRange(0, 2, out result) == list && result);
        Assert.False(list.WithInRange(2, 4, out result) == list && result);
        Assert.True(list.WithInRangeLength(1, 2, out result) == list && result);
        Assert.False(list.WithInRangeLength(2, 2, out result) == list && result);
    }

    [Fact]
    public void IReadOnlyCollection_WithInRange_Works()
    {
        IReadOnlyCollection<int> col = [1, 2, 3];
        Assert.True(col.WithInRange(1, out var result) == col && result);
        Assert.False(col.WithInRange(3, out result) == col && result);
        Assert.True(col.WithInRange(0, 2, out result) == col && result);
        Assert.False(col.WithInRange(2, 4, out result) == col && result);
        Assert.True(col.WithInRangeLength(1, 2, out result) == col && result);
        Assert.False(col.WithInRangeLength(2, 2, out result) == col && result);
    }
}
