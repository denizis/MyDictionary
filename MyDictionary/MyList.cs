using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    internal class MyList<T1,T2>
    {
    
        T1[] keys;
        T2[] values;


        public MyList() {
            
            keys = new T1[0];
             values = new T2[0];


        }


        public void Add(T1 key, T2 value)
        {
            T1[] tempKeys = keys;
            T2[] tempValues = values;

            keys = new T1[keys.Length + 1];
            values = new T2[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];


            }



            for (int i = 0; i < tempValues.Length; i++)
            {
                values[i] = tempValues[i];


            }
       
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;





        }




        public T1[] GetKeys()
        {
            return keys;
        }

        // values dizisini dönen bir metot
        public T2[] GetValues()
        {
            return values;
        }

        public int Count
        {
            get { return keys.Length; }
        }
    }
}
