using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionTester
{
    public class LinkedListCollection <T> : BaseCollection<T>
    {
        private LinkedList<T> linklist;

        public LinkedListCollection()
        {
            this.linklist = new LinkedList<T>();
        }

        protected override void FillCollectionInternal(string[] input, Func<string, T> func)
        {
            foreach (var line in input)
            {
                linklist.AddFirst(func(line));
            }
        }

        protected override void SortCollectionInternal(Func<T, T> comparer)
        {
            linklist = new LinkedList<T>(linklist.OrderBy(comparer));
        }

        protected override void PrintCollectionInternal(TextWriter writer)
        {
            foreach (var item in linklist)
            {
                writer.WriteLine(item);
            }
        }
        public override T FirstObject()
        {
            return linklist.First();
        }

        public override T LastObject()
        {
            return linklist.Last();
        }

        public override int Count()
        {
            return linklist.Count();
        }
    }
}
