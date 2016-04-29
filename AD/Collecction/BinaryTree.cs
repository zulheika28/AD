using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Collecction
{
    public class BinaryTree
    {
        private TreeNode tree;

        public BinaryTree()
        {
            tree = null;
        }
        public bool treeExistance()
        {
            return tree == null;
        }

        public void insert(int d)
        {
            //if the tree is empty
            if (treeExistance())
            {
                //creATE A TREE
                tree = new TreeNode(d);
            }
            else
            {
                //IF TREE EXISTS add the data
                tree.insertData(ref tree, d);
            }

        }

        public void display()
        {
            Console.WriteLine();
            Console.WriteLine("**************************************!");
            Console.WriteLine("Below is the Binary Tree~!");
            Console.WriteLine("");
            if (!treeExistance())
            {
                tree.display(tree);
            }
               
            Console.WriteLine();
        }
        
    }
}
