using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public class WordsCollection : IteratorAggregate
    {
        List<string> collection = new List<string>();

        bool direction = false;

        public void ReverseDirection()
        {
            direction = !direction;
        }

        public List<string> getItems()
        {
            return collection;
        }

        public void AddItem(string item)
        {
            this.collection.Add(item);
        }

        public override IEnumerator GetEnumerator()
        {
            return new AlphabeticalOrderIterator(this, direction);
        }
    }
}
