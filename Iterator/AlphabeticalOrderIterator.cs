using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public class AlphabeticalOrderIterator : Iterator
    {
        private WordsCollection collection;

        private int position = -1;

        private bool reverse = false;

        public AlphabeticalOrderIterator(WordsCollection collection, bool reverse = false)
        {
            this.reverse = reverse;
            this.collection = collection;

            if(reverse)
            {
                this.position = collection.getItems().Count;
            }
        }

        public override object Current()
        {
            return this.collection.getItems()[position];
        }

        public override int Key()
        {
            return this.position;
        }

        public override bool MoveNext()
        {
            int updatedPosition = this.position + (this.reverse ? -1 : 1);

            if (updatedPosition >= 0 && updatedPosition < this.collection.getItems().Count)
            {
                this.position = updatedPosition;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void Reset()
        {
            this.position = this.reverse ? this.collection.getItems().Count - 1 : 0;
        }
    }
}
