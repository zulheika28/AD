using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AD.Sort;

using AD;
using System.Collections;
using System.Collections.ObjectModel;
using AD.Collecction;

namespace ADTest
{
    class Program
    {
        private static ArrayList list = new ArrayList();
        //size of the arraylist and collection
        private static int size= 1000000;

        private static Collection<int> collection = new Collection<int>();

        //Random int arrays for entering into arraylist and collection
        private static int[] randomIntArray;
        private static int[] randomIntArray1;

        static void Main(string[] args)
        {
            //Sort Section

            insertionSort();
            Console.WriteLine();
            Console.WriteLine();
            reverseSort();
            Console.WriteLine();
            Console.WriteLine();
            bubbleSort();
            Console.WriteLine();
            Console.WriteLine();
            smartBubbleSort();
            Console.WriteLine();
            Console.WriteLine();
            convertNumbersToLetters();
            Console.WriteLine();
            Console.WriteLine();



            //insertion into Arraylist and time comparison
            Console.WriteLine();
            var timeUnit2 = Timing.TimeUnit.Miliseconds;
            //calculate time to carry out request
            Timing.Result<Timing.NoReturn> result2 = null;

            result2 = Timing.GetTime(() => addToArray(), timeUnit2);

            Console.WriteLine();
            Console.WriteLine("Time to add " + getSize() + " numbers: " + result2.Time.ToString() + " miliseconds");

            //Adding into a Collection and time comparison
            Console.WriteLine();
            //calculate time to carry out request
            var timeUnit3 = Timing.TimeUnit.Miliseconds;
            Timing.Result<Timing.NoReturn> result3 = null;

            result3 = Timing.GetTime(() => addToCollection(), timeUnit3);

            Console.WriteLine();
            Console.WriteLine("Time to add " + collection.Count()+ " numbers: " + result3.Time.ToString() + " miliseconds");

            Console.WriteLine();

            getStack();
           

            // Binary Tree
            BinaryTree b = new BinaryTree();

            //insert the values
            b.insert(48);
            b.insert(10);
            b.insert(16);
            b.insert(23);
            b.insert(51);
            b.insert(3);

            //display the values
            b.display();

            //carry out the quadratic hash
            getQHash();


            //bucket hash
            Console.WriteLine("Bucket Hash");
            BucketHash.bucket();
            Console.WriteLine("");
            Console.ReadKey();

            //queue
            Console.WriteLine("Queue");
            queue.queues();
            Console.WriteLine("");

            //iterator
            Console.WriteLine("iterator");
            iteratormethod();

            //circular list
            Console.WriteLine("");
            Console.WriteLine("Circular list");
            circularlist();

            //Circular linked list
            Console.WriteLine("");
            circularlinklit();

            Console.ReadLine();
            Console.ReadKey();
        }

        public static void addToArray()
        {
            Console.WriteLine();
            Console.WriteLine("**************************************!");
            Console.WriteLine("Below is the Arraylist insertion~!");

            //create random ints
            Random rnd2 = new Random();

            //check if there are too many ints to be shown on console
            if (size > 20)
            {
                Console.WriteLine("Ints added to arraylist are not shown because there are too many.");
            }
            //if there are not too many, they can be shown
            else
            {
                Console.WriteLine("Ints added to arraylist printed below: ");
                //iterate through array
                for (int i = 0; i < size; i++)
                {
                    list.Add(rnd2.Next(size * 2));
                    Console.Write(list[i] + " ");
                }
            }
           

        }

        public static void addToCollection()
        {
            Console.WriteLine();
            Console.WriteLine("**************************************!");
            Console.WriteLine("Below is the Collection insertion~!");

            //create random ints for the collection
            Random rnd3 = new Random();
            if (size > 20)
            {
                //if the size is too large do not show
                Console.WriteLine("Ints added to arraylist are not shown because there are too many.");
            }
            //if its a small amount show them
            else
            {
                Console.WriteLine("Ints added to arraylist printed below: ");
                //iterate through collection
                for (int i = 0; i < size; i++)
                {
                    collection.Add(rnd3.Next(size * 2));
                    //Console.Write(collection[i] + " ");
                }
            }

            
        }

        public static int getSize()
        {
            //show the size of the array
            return size;
        }

        public static void convertNumbersToLetters()
        {
            int intsize = 25;

            Console.WriteLine();
            Console.WriteLine("**************************************!");
            Console.WriteLine("Below is the Letter sort~!");
            Console.WriteLine("Unsorted Letters");
            randomIntArray1 = new int[intsize];

            Random rnd10 = new Random();

            for (int i = 0; i < intsize; i++)
            {
                randomIntArray1[i] = rnd10.Next(intsize);
                //Console.Write(randomIntArray1[i] + " ");
            }
            Console.WriteLine();
            //iterate through the array
            for (int i = 0; i < randomIntArray1.Length; i++)
            {
                //convert the number values into letters
                char let = (char)('a' + randomIntArray1[i]);
                Console.Write(let + " ");
            }

            //calculate time to carry out request
            var timeUnit = Timing.TimeUnit.Miliseconds;
            Timing.Result<Timing.NoReturn> result10 = null;

            Console.WriteLine();
            Console.WriteLine();
            result10 = Timing.GetTime(() => BubbleSort.BubbleSortArrayList<int>(randomIntArray1), timeUnit);

            Console.WriteLine("Time to sort letters: " + result10.Time.ToString() + " miliseconds");

            Console.WriteLine();
            Console.WriteLine("Sorted Letters: ");
            for (int i = 0; i < randomIntArray1.Length; i++)
            {
                //Console.Write(randomIntArray1[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < randomIntArray1.Length; i++)
            {
                char let = (char)('a' + randomIntArray1[i]);
                Console.Write(let + " ");
            }

        }

        public static void insertionSort()
        {
            int size1 = 10;

            Console.WriteLine();
            Console.WriteLine("**************************************!");
            Console.WriteLine("Below is the Insertion Sort~!");
            Console.WriteLine("Unsorted Array");
            randomIntArray = new int[size1];

            Random rnd = new Random();
            //iterate through array
            for (int i = 0; i < size1; i++)
            {
                //multiply the random number by 2 to get more variety
                randomIntArray[i] = rnd.Next(size1 * 2);
                Console.Write(randomIntArray[i] + " ");
            }

            //calculate time to carry out request
            var timeUnit = Timing.TimeUnit.Miliseconds;
            Timing.Result<Timing.NoReturn> insertionResult = null;

            //create space
            Console.WriteLine();
            Console.WriteLine();
           
            insertionResult = Timing.GetTime(() => InsertionSort.InsertionSortArrayList<int>(randomIntArray), timeUnit);

            Console.WriteLine("Time to sort: " + insertionResult.Time.ToString() +" miliseconds");

            Console.WriteLine();
            Console.WriteLine("Sorted Array: ");
            //iterate through sorted array
            for (int i = 0; i < randomIntArray.Length; i++)
            {
                //show the sorted array
                Console.Write(randomIntArray[i] + " ");
            }
        }

        public static void reverseSort()
        {
            int size1 = 10;

            Console.WriteLine();
            Console.WriteLine("**************************************!");
            Console.WriteLine("Below is the Reverse sort~!");
            Console.WriteLine("Unsorted Array");
            randomIntArray = new int[size1];

            Random rnd = new Random();

            for (int i = 0; i < size1; i++)
            {
                randomIntArray[i] = rnd.Next(size1 * 2);
                Console.Write(randomIntArray[i] + " ");
            }

            var timeUnit = Timing.TimeUnit.Miliseconds;
            Timing.Result<Timing.NoReturn> reverseResult = null;

            Console.WriteLine();
            Console.WriteLine();
            reverseResult = Timing.GetTime(() => ReverseSort.ReverseSortArrayList<int>(randomIntArray), timeUnit);
            
            Console.WriteLine("Time to sort: " + reverseResult.Time.ToString() + " miliseconds");

            Console.WriteLine();
            Console.WriteLine("Sorted Array: ");
            for (int i = 0; i < randomIntArray.Length; i++)
            {

                Console.Write(randomIntArray[i] + " ");
            }
        }

        public static void bubbleSort()
        {
            int size1 = 10;

            Console.WriteLine();
            Console.WriteLine("**************************************!");
            Console.WriteLine("Below is the Bubble sort~!");
            Console.WriteLine("Unsorted Array");
            randomIntArray = new int[size1];

            Random rnd = new Random();

            for (int i = 0; i < size1; i++)
            {
                randomIntArray[i] = rnd.Next(size1 * 2);
                Console.Write(randomIntArray[i] + " ");
            }

            var timeUnit = Timing.TimeUnit.Miliseconds;
            Timing.Result<Timing.NoReturn> result = null;

            Console.WriteLine();
            Console.WriteLine();
            result = Timing.GetTime(() => BubbleSort.BubbleSortArrayList<int>(randomIntArray), timeUnit);

            Console.WriteLine("Time to sort: " + result.Time.ToString() +" miliseconds");

            Console.WriteLine();
            Console.WriteLine("Sorted Array: ");
            for (int i = 0; i < randomIntArray.Length; i++)
            {

                Console.Write(randomIntArray[i] + " ");
            }
        }

        public static void smartBubbleSort()
        {
            int size1 = 10;

            Console.WriteLine();
            Console.WriteLine("**************************************!");
            Console.WriteLine("Below is the Smart bubble sort~!");
            Console.WriteLine("Unsorted Array");
            randomIntArray = new int[size1];

            Random rnd = new Random();

            for (int i = 0; i < size1; i++)
            {
                randomIntArray[i] = rnd.Next(size1 * 2);
                Console.Write(randomIntArray[i] + " ");
            }

            var timeUnit = Timing.TimeUnit.Miliseconds;
            Timing.Result<Timing.NoReturn> smartResult = null;

            Console.WriteLine();
            Console.WriteLine();
            smartResult = Timing.GetTime(() => SmartBubbleSort.SmartBubbleSortArrayList<int>(randomIntArray), timeUnit);

            Console.WriteLine("Time to sort: " + smartResult.Time.ToString() +" miliseconds");

            Console.WriteLine();
            Console.WriteLine("Sorted Array: ");
            for (int i = 0; i < randomIntArray.Length; i++)
            {

                Console.Write(randomIntArray[i] + " ");
            }
        }

        public static void getStack()
        {
            StackCollection<int> stack = new StackCollection<int>(10);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("*******Stack Collection*******");
            stack.push(25);
            stack.push(29);
            stack.push(51);
            stack.push(67);
            int[] Values = stack.GetAllStackValues();
            Console.WriteLine("Below is the complete collection after push: ");
            foreach (int value in Values)
            {
                Console.WriteLine();
                Console.WriteLine(value);
            }
            stack.pop();
            stack.pop();
            int[] Values1 = stack.GetAllStackValues();
            Console.WriteLine();
            Console.WriteLine("Below is the complete collection after pop: ");
            foreach (int value1 in Values1)
            {
                Console.WriteLine();
                Console.WriteLine(value1);
            }
            stack.push(88);
            int[] Values2 = stack.GetAllStackValues();
            Console.WriteLine();
            Console.WriteLine("Below is the complete collection after more push: ");
            foreach (int value2 in Values2)
            {
                Console.WriteLine();
                Console.WriteLine(value2);
            }
            stack.peep(0);
            stack.peep(1);
            stack.peep(2);
            int[] Values3 = stack.GetAllStackValues();
            Console.WriteLine();
            Console.WriteLine("Below is the final collection: ");
            foreach (int value3 in Values3)
            {
                Console.WriteLine();
                Console.WriteLine(value3);
            }
        }

        public static void getQHash()
        {
            QuadraticHash qHash = new QuadraticHash();
            
        }

        public static void iteratormethod()
        {
            iterator<int> iterators = new iterator<int>();

            // Adding numbers to the iterator stack
            for (int num = 0; num <= 9; num++)
            {
                iterators.Push(num);
            }

            //TopToBottom returns IEnumerable(Of Integer).
            foreach (int num in iterators.TopBottom)
            {
                Console.Write("{0} ", num);
            }
            Console.WriteLine();
            Console.WriteLine();
            // Output: 9 8 7 6 5 4 3 2 1 0

            foreach (int num in iterators.Bottomtothetop)
            {
                Console.Write("{0} ", num);
            }
            Console.WriteLine();
            Console.WriteLine();
            // Output: 0 1 2 3 4 5 6 7 8 9

            Console.ReadKey();
        }

        public static void circularlist()
        {
            circularlist<int> cl = new circularlist<int>(10);

            //loops the numbers 8 times to display the 8 numbers
            for (int i = 0; i < 10; i++)
            {
                cl.Value = i;
                //goes onto the next number
                cl.Next();

            }
            //loops the numbers out to print them out
            foreach (int n in cl)
            {
                Console.WriteLine(n);
            }

            Console.ReadKey();
        }

        public static void circularlinklit()
        {
            //Connection to the the linked list class 
            LinkLit LinkList = new LinkLit();
            //connection to the iterator class, whilst inserting the List from linked list
            liStiterator Lititerator = new liStiterator(LinkList);

            //string value for the inserting fruit before and after
            string item;

            //inserting in fruit/veg after
            Lititerator.InsertAfter("Apple");
            Lititerator.InsertAfter("Strawberry");
            Lititerator.InsertAfter("Asparagus");

            //insertings before Asparagus
            Lititerator.InsertBefore("Broccoli");

            //inserts after Asparagus
            Lititerator.InsertAfter("Endive");

            //Inserts before Endive
            Lititerator.InsertBefore("Fig");
            Lititerator.InsertBefore("Lemon");

            Console.WriteLine("CircularLinkedList");
            //Show complete list
            Console.WriteLine();
            Console.WriteLine("Complete list:");
            LinkList.ShowListofItem();
            Console.ReadKey();

            //Insert after
            Console.WriteLine();
            Console.WriteLine("Insert pear after:");
            item = "Pear //Add After";
            Lititerator.InsertAfter(item);
            //shows list with item added after
            LinkList.ShowListofItem();
            Console.ReadKey();

            //Insert before
            Console.WriteLine();
            Console.WriteLine("Insert pumpkin before:");
            item = "Pumpkin //Add Before";
            Lititerator.InsertBefore(item);
            //shows list with item added before
            LinkList.ShowListofItem();
            Console.ReadKey();

        }
    }
}
