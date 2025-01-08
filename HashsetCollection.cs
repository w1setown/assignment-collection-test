using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionTester;

public class HashSetCollection<T> : BaseCollection<T>
{
    private HashSet<T> hashSet;

    public HashSetCollection()
    {
        this.hashSet = new HashSet<T>();
    }

    protected override void FillCollectionInternal(string[] input, Func<string, T> func)
    {
        foreach (var line in input)
        {
            hashSet.Add(func(line));
        }
    }

    protected override void SortCollectionInternal(Func<T, T> comparer)
    {
        hashSet = new HashSet<T>(hashSet.OrderBy(comparer));
    }

    protected override void PrintCollectionInternal(TextWriter writer)
    {
        foreach (var item in hashSet)
        {
            writer.WriteLine(item);
        }
    }

    public override T FirstObject()
    {
        return hashSet.First();
    }

    public override T LastObject()
    {
        return hashSet.Last(); 
    }

    public override int Count()
    {
        return hashSet.Count(); 
    }
}