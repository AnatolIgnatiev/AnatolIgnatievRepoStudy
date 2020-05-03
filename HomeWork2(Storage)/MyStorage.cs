using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2_Storage_
{
    public class MyStorage<T> : IEnumerable<T>
    {
        Cell<T> first;
        Cell<T> last;
        private int count;
        public int Count { get { return count; } }
        public void Add(T data)
        {
            Cell<T> Cell = new Cell<T>(data);
            if (first == null)
            {
                first = Cell;
            }
            else
            {
                last.Next = Cell;
            }
            last = Cell;
            count++;
        }
        public bool Delete(T data)
        {
            Cell<T> currentCell = first;
            Cell<T> previousCell = null;
            while (currentCell != null)
            {
                if (currentCell.Data.Equals(data))
                {
                    if (previousCell == null)
                    {
                        first = first.Next;
                        if (first == null)
                        {
                            last = null;
                        }
                    }
                    else
                    {
                        previousCell.Next = currentCell.Next;
                        if (currentCell.Next == null)
                        {
                            last = previousCell;
                        }
                    }
                    count--;
                    return true;
                }
                previousCell = currentCell;
                currentCell = currentCell.Next;
            }
            return false;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Cell<T> currentCell = first;
            while (currentCell != null)
            {
                yield return currentCell.Data;
                currentCell = currentCell.Next;
            }
        }
    }
}
