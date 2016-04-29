using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Collecction
{
    class TreeNode
    {
        //value of the int entered
        private int value;
        //right placement of the value
        public TreeNode rightLeaf;
        //left placement of the value
        public TreeNode leftLeaf;

        public TreeNode(int value)
        {
            //place the parameter entered into the tree leaf value 
            this.value = value;
            rightLeaf = null;
            leftLeaf = null;
        }

       
        public void insertData(ref TreeNode node, int data)
        {
            //if there is no tree data create a new tree and enter data
            if (node == null)
            {
                node = new TreeNode(data);

            }
            //if there is a tree and and the new int entered is bigger than the parent, place to the right.
            else if (node.value < data)
            {
                insertData(ref node.rightLeaf, data);
            }
            //if there is a tree and and the new int entered is smaller than the parent, place to the left.
            else if (node.value > data)
            {
                insertData(ref node.leftLeaf, data);
            }
        }

        public void display(TreeNode treeNode)
        {
            if (treeNode == null)
                return;
            
            //get the data from the leftleaf
            display(treeNode.leftLeaf);
            Console.Write(" LeftLeaf: ");
            //show the value of all left and right leaves.
            Console.Write(treeNode.value + " ");
            //get the value from the right leaf
            display(treeNode.rightLeaf);
            Console.Write(" RightLeaf: ");
        }

    }
}
