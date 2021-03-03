using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdpterPatternQueueApp.Model
{
    class QueueAdapter<T> : IQueue<T>, IEnumerator<T>
    {
        private LinkedList<T> _queue;

        public QueueAdapter()
        {
            _queue = new LinkedList<T>();
        }

        public void Enqueue(T item)
        {
            _queue.AddLast(item);
        }
        public void Dequeue()
        {
            _queue.RemoveFirst();
        }

        public int Count()
        {
            return _queue.Count;
        }
      
        public IEnumerator<T> GetEnumerator()
        {
            return _queue.GetEnumerator();
        }

        public void Reset()
        {

        }

        public bool MoveNext()
        {
            return false;
        }

        public void Dispose()
        {

        }

        public T Current => throw new NotImplementedException();

        object IEnumerator.Current => throw new NotImplementedException();
    }
}
