using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Collecction
{
    public class LinkLit
    {
        private Node header;

        public LinkLit()
        {
            header = new Node("header");
        }

        public Node GetFirst()
        {
            //returns the first item of the list
            return header;
        }

        //shows list of items
        public void ShowListofItem()
        {
            Node curr = header.Link;
            //while the current is not equal to null then it will display all items
            while (!(curr == null))
            {
                Console.WriteLine(curr.item);
                curr = curr.Link;
            }
        }
    }
}
