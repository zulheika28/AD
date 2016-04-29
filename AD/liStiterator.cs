using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Collecction
{
    public class liStiterator
    {
        //current node
        private Node curr;
        //previous node
        private Node prev;

        //Connection to the linked list to retrive the list of data 
        LinkLit theList;

        public liStiterator(LinkLit Mylist)
        {
            //MyList becomes the list
            theList = Mylist;

            //gets first item in list from the linked list class
            curr = theList.GetFirst();

            //setting previous to null since there are no previous data 
            //since this is a new list
            prev = null;
        }

        //To insert new item before 
        public void InsertBefore(Object theitem)
        {
            //new node is made adding the item to insert before
            Node newNodeitem = new Node(theitem);

            newNodeitem.Link = prev.Link;
            //the new node is going to be entered as the previous link
            prev.Link = newNodeitem;
            //the new node becomes the current item
            curr = newNodeitem;

        }

        public void InsertAfter(Object theitem)
        {
            //new node is made adding the item to insert after
            Node newnodeitem = new Node(theitem);

            newnodeitem.Link = curr.Link;
            //new node becomes the current item
            curr.Link = newnodeitem;
            //makes sure that the new item gets added to the next link
            NextLink();

        }
        public void NextLink()
        {
            //current link becomes the previous link
            prev = curr;
            curr = curr.Link;

        }
    }
}
