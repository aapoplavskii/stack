using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Node
    {

        public int key { get; set; }
        public string value { get; set; }

        public Node(int key, string value)
        {

            this.key = key;
            this.value = value;
                   
        }

    }
}
