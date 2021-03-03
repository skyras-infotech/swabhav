using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdpterPatternQueueApp.Model
{
    interface IQueue<T> : IEnumerator<T>
    {
        void Enqueue(T item);
        void Dequeue();
        int Count();
    }
}
