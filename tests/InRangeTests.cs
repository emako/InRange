using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.InRange;
using System.Linq;
using Xunit;

[SuppressMessage("Design", "CA1050:Declare types in namespaces")]
public sealed class InRangeTests
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
}
