using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Collecction
{
    public class Node
    {
        public Object item;
        public Node Link;

        public Node()
        {
            item = null;
            Link = null;
        }

        public Node(Object theitem)
        {
            item = theitem;
            Link = null;
        }
    }
}
