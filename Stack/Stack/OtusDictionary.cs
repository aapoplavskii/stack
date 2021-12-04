using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack
{
    class OtusDictionary
    {
        Node[] arraynode;

        public OtusDictionary(int size)
        {
            arraynode = new Node[size];

        }

        public void Add(int key, string value)
        {
            Node node = new Node(key, value);

            var index = key % arraynode.Length;

            if (arraynode[index] != null)
            {
                Resize(node);
                Console.WriteLine($"Массив увеличен в два раза. Новый размер составляет - {arraynode.Length}");
                index = key % arraynode.Length;
                arraynode[index] = node;
            }

            if (value != null)
                arraynode[index] = node;
            else
                throw new Exception("Вставляемое значение не может быть пустым!");

        }


        public string Get(int index)
        {
            if (index > arraynode.Length - 1)

                throw new Exception($"Запрашиваемый индекс выходит за пределы массива! Максимальный индекс - {arraynode.Length - 1}");

            if (arraynode[index]==null)     
            
                throw new Exception($"Элемента с индексом {index} не существует!");

            return arraynode[index].value;

        }
        private void Resize(Node node)
        {
            Node[] arraynodeNew = new Node[arraynode.Length*2];

            foreach (var itemarray in arraynode)
            {
                if (itemarray != null)
                {

                    var index = itemarray.key % arraynodeNew.Length;

                    arraynodeNew[index] = itemarray;

                }
            }

            arraynode = arraynodeNew;

        }


    }
}
