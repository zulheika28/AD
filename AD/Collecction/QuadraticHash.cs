using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Collecction
{
    public class QuadraticHash
    {

        public int size = 1007;
        public int intValue;
        public int[] nums;
        public int[] hash1;
        int hashed;
        int finalHashValue;

        public QuadraticHash()
        {
            //create the hash array
            hash1 = new int[size];
            
            //create the ints that will be hashed
            nums = new int[] {26, 35, 28, 11, 69, 75, 42, 28, 88, 49 };
            //finalhashvalue is the key of the hash

            insertHashArray();
            ShowDistrib();
        }

        public int quadraticHashing(int s)
        {            
            int total = s % size;
            return total;
        }
        
        public void insertHashArray()
        {
            //Selecting the value from the num array
            for (int i = 0; i < 10; i++)
            {
                //hashed is the value of the hash which is extracted form the int arrray above
                hashed = nums[i];
                finalHashValue = quadraticHashing(hashed);
                //insert the value into the quadratic position
                hash1[finalHashValue] = hashed;
            }
        }

        public void ShowDistrib()
        {
            Console.WriteLine();
            Console.WriteLine("**************************************!");
            Console.WriteLine("Below is the Quadratic Hash insertion~!");

            //showing the valuesin the hashed array that are not empty
            for (int i = 0; i <= size; i++)
                if (hash1[i] != 0)
                {
                    Console.WriteLine("Key: "+ i + " Value: " + hash1[i]);
                }     
        }
    }
}
