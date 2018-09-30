using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwabhavQAdapter
{
    public class GenericAdapter<T> : IEnumerable<T>
    {
        private LinkedList<T> _simpleQueue;

        public GenericAdapter()
        {
            _simpleQueue = new LinkedList<T>();
        }

        public void eQueue(T name)
        {
            _simpleQueue.AddLast(name);
        }

        public void dQueue()
        {
            _simpleQueue.RemoveFirst();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _simpleQueue.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _simpleQueue.GetEnumerator();
        }
    }
}
