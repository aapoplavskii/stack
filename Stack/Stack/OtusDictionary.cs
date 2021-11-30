using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class OtusDictionary
    {
        Dictionary<int, string> arrayvalue;

        public OtusDictionary(int size)
        {
            arrayvalue = new Dictionary<int, string>(size);
            
        }

       public void Add(int key, string value)
        {
            try
            {
                arrayvalue.Add(key, value);
            }
            catch(ArgumentException)
            {
                throw new ArgumentException($"Ошибка добавления! Элемент с ключом - {key} уже существует");
            }
                      
        }

        public string Get(int key)
        {
            try
            {
                return arrayvalue[key];
            }
            catch(NullReferenceException)
            {
                throw new NullReferenceException($"Элемента с индексом {key} не существует!");
            }
        }

        public void Resize(int sizenew)
        {
            Dictionary<int, string> arrayvalueNew = new Dictionary<int, string>(sizenew);

            for (int i = 0; i < arrayvalue.Count; i++)
            {

                arrayvalueNew[i] = arrayvalue[i];

            }

        }


    }
}
