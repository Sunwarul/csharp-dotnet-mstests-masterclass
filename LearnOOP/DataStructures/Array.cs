using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpSyntax.DataStructures
{
    public class Array
    {
        private int size;
        private int[] array;
        int pointer = 0;
        public Array(int size)
        {
            this.size = size;
            this.array = new int[this.size];
        }
      
        public bool Insert(int value)
        {
            if (pointer >= this.size)
            {
                return false;
            }
            else
            {
                this.array[++pointer] = value;
                return true;
            }
            
        }

        public int Remove( int index)
        {
            return this.array[index] = 0;
        }
    }
}
