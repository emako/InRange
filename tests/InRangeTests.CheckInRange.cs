using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.InRange;
using Xunit;

public sealed partial class InRangeTests
{
    [Fact]
    public void Array_CheckInRange_Works()
    {
        int[] arr = [10, 20, 30];
        arr.CheckInRange(0); // should not throw
        Assert.Throws<ArgumentOutOfRangeException>(() => arr.CheckInRange(3));
        arr.CheckInRange(0, 2);
        Assert.Throws<ArgumentOutOfRangeException>(() => arr.CheckInRange(2, 4));
        arr.CheckInRangeLength(1, 2);
        Assert.Throws<ArgumentOutOfRangeException>(() => arr.CheckInRangeLength(2, 2));
    }

    [Fact]
    public void List_CheckInRange_Works()
    {
        List<int> list = [1, 2, 3];
        list.CheckInRange(0);
        Assert.Throws<ArgumentOutOfRangeException>(() => list.CheckInRange(3));
        list.CheckInRange(0, 2);
        Assert.Throws<ArgumentOutOfRangeException>(() => list.CheckInRange(2, 4));
        list.CheckInRangeLength(1, 2);
        Assert.Throws<ArgumentOutOfRangeException>(() => list.CheckInRangeLength(2, 2));
    }

    [Fact]
    public void ObservableCollection_CheckInRange_Works()
    {
        ObservableCollection<int> oc = [1, 2, 3];
        oc.CheckInRange(0);
        Assert.Throws<ArgumentOutOfRangeException>(() => oc.CheckInRange(3));
        oc.CheckInRange(0, 2);
        Assert.Throws<ArgumentOutOfRangeException>(() => oc.CheckInRange(2, 4));
        oc.CheckInRangeLength(1, 2);
        Assert.Throws<ArgumentOutOfRangeException>(() => oc.CheckInRangeLength(2, 2));
    }

    [Fact]
    public void ArraySegment_CheckInRange_Works()
    {
        ArraySegment<int> seg = new([1, 2, 3]);
        seg.CheckInRange(0);
        Assert.Throws<ArgumentOutOfRangeException>(() => seg.CheckInRange(3));
        seg.CheckInRange(0, 2);
        Assert.Throws<ArgumentOutOfRangeException>(() => seg.CheckInRange(2, 4));
        seg.CheckInRangeLength(1, 2);
        Assert.Throws<ArgumentOutOfRangeException>(() => seg.CheckInRangeLength(2, 2));
    }

    [Fact]
    public void NonGenericCollection_CheckInRange_Works()
    {
        int[] arr = [1, 2, 3];
        System.Collections.ICollection col = arr;
        System.Collections.IList list = arr;
        col.CheckInRange(0);
        Assert.Throws<ArgumentOutOfRangeException>(() => col.CheckInRange(3));
        col.CheckInRange(0, 2);
        Assert.Throws<ArgumentOutOfRangeException>(() => col.CheckInRange(2, 4));
        col.CheckInRangeLength(1, 2);
        Assert.Throws<ArgumentOutOfRangeException>(() => col.CheckInRangeLength(2, 2));
        list.CheckInRange(0);
        Assert.Throws<ArgumentOutOfRangeException>(() => list.CheckInRange(3));
        list.CheckInRange(0, 2);
        Assert.Throws<ArgumentOutOfRangeException>(() => list.CheckInRange(2, 4));
        list.CheckInRangeLength(1, 2);
        Assert.Throws<ArgumentOutOfRangeException>(() => list.CheckInRangeLength(2, 2));
    }

    [Fact]
    public void MultiDimensionalArray_CheckInRange_Works()
    {
        int[,] arr2d = new int[3, 2];
        arr2d.CheckInRange(2, 1);
        Assert.Throws<ArgumentOutOfRangeException>(() => arr2d.CheckInRange(3, 0));
    }

    [Fact]
    public void IReadOnlyList_CheckInRange_Works()
    {
        IReadOnlyList<int> list = [1, 2, 3];
        list.CheckInRange(0);
        Assert.Throws<ArgumentOutOfRangeException>(() => list.CheckInRange(3));
        list.CheckInRange(0, 2);
        Assert.Throws<ArgumentOutOfRangeException>(() => list.CheckInRange(2, 4));
        list.CheckInRangeLength(1, 2);
        Assert.Throws<ArgumentOutOfRangeException>(() => list.CheckInRangeLength(2, 2));
    }

    [Fact]
    public void IReadOnlyCollection_CheckInRange_Works()
    {
        IReadOnlyCollection<int> col = [1, 2, 3];
        col.CheckInRange(0);
        Assert.Throws<ArgumentOutOfRangeException>(() => col.CheckInRange(3));
        col.CheckInRange(0, 2);
        Assert.Throws<ArgumentOutOfRangeException>(() => col.CheckInRange(2, 4));
        col.CheckInRangeLength(1, 2);
        Assert.Throws<ArgumentOutOfRangeException>(() => col.CheckInRangeLength(2, 2));
    }
}
