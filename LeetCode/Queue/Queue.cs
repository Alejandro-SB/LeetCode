using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Queue
{
    public class MyCircularQueue
    {
        private int items { get; set; }
        private int position { get; set; }
        private readonly int size;
        private readonly int?[] queue;

        /** Initialize your data structure here. Set the size of the queue to be k. */
        public MyCircularQueue(int k)
        {
            this.items = 0;
            this.position = 0;
            this.size = k;
            this.queue = Enumerable.Repeat<int?>(null, k).ToArray();
        }

        /** Insert an element into the circular queue. Return true if the operation is successful. */
        public bool EnQueue(int value)
        {
            if(this.IsFull())
            {
                return false;
            }

            int foundPlace = this.position;
            bool first = true;

            while(foundPlace != this.position || first)
            {
                if(this.queue[foundPlace] == null)
                {
                    break;
                }
                else
                {
                    foundPlace = this.getArrayPosition(++foundPlace);
                }

                first = false;
            }

            if(foundPlace == this.position && !first)
            {
                return false;
            }

            this.queue[foundPlace] = value;
            ++items;

            return true;
        }

        /** Delete an element from the circular queue. Return true if the operation is successful. */
        public bool DeQueue()
        {
            if(this.queue[this.position] == null)
            {
                return false;
            }
            else
            {
                this.queue[position] = null;
                --this.items;

                this.position = this.getArrayPosition(++this.position);

                return true;
            }
        }

        /** Get the front item from the queue. */
        public int Front()
        {
            if (this.IsEmpty())
            {
                return -1;
            }

            return this.queue[this.position] ?? 0;
        }

        /** Get the last item from the queue. */
        public int Rear()
        {
            if (this.IsEmpty())
            {
                return -1;
            }

            int foundPlace = this.getArrayPosition(this.position - 1);

            while (foundPlace != this.position)
            {
                if (this.queue[foundPlace] != null)
                {
                    break;
                }
                else
                {
                    foundPlace = this.getArrayPosition(--foundPlace);
                }
            }

            return this.queue[foundPlace] ?? 0;
        }

        /** Checks whether the circular queue is empty or not. */
        public bool IsEmpty()
        {
            return this.items == 0;
        }

        /** Checks whether the circular queue is full or not. */
        public bool IsFull()
        {
            return this.size == this.items;
        }

        private int getArrayPosition(int a)
        {
            return (a % this.size + this.size) % this.size;
        }
    }
}
