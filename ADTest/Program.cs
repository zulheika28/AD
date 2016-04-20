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
        private static int size= 1000000;

        private static Collection<int> collection = new Collection<int>();

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
            Timing.Result<Timing.NoReturn> result2 = null;

            result2 = Timing.GetTime(() => addToArray(), timeUnit2);

            Console.WriteLine();
            Console.WriteLine("Time to add " + getSize() + " numbers: " + result2.Time.ToString() + " miliseconds");

            //Adding into a Collection and time comparison
            Console.WriteLine();
            var timeUnit3 = Timing.TimeUnit.Miliseconds;
            Timing.Result<Timing.NoReturn> result3 = null;

            result3 = Timing.GetTime(() => addToCollection(), timeUnit3);

            Console.WriteLine();
            Console.WriteLine("Time to add " + collection.Count()+ " numbers: " + result3.Time.ToString() + " miliseconds");

            Console.WriteLine();
            getStack();
            getQHash();

            Console.ReadLine();
            Console.ReadKey();
        }

        public static void addToArray()
        {
            Console.WriteLine();
            Console.WriteLine("**************************************!");
            Console.WriteLine("Below is the Arraylist insertion~!");

            Random rnd2 = new Random();
            if (size > 20)
            {
                Console.WriteLine("Ints added to arraylist are not shown because there are too many.");
            }
            else
            {
                Console.WriteLine("Ints added to arraylist printed below: ");
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

            Random rnd3 = new Random();
            if (size > 20)
            {
                Console.WriteLine("Ints added to arraylist are not shown because there are too many.");
            }
            else
            {
                Console.WriteLine("Ints added to arraylist printed below: ");
                for (int i = 0; i < size; i++)
                {
                    collection.Add(rnd3.Next(size * 2));
                    //Console.Write(collection[i] + " ");
                }
            }

            
        }

        public static int getSize()
        {
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
            for (int i = 0; i < randomIntArray1.Length; i++)
            {
                char let = (char)('a' + randomIntArray1[i]);
                Console.Write(let + " ");
            }

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

            for (int i = 0; i < size1; i++)
            {
                randomIntArray[i] = rnd.Next(size1 * 2);
                Console.Write(randomIntArray[i] + " ");
            }

            var timeUnit = Timing.TimeUnit.Miliseconds;
            Timing.Result<Timing.NoReturn> insertionResult = null;

            Console.WriteLine();
            Console.WriteLine();
           
            insertionResult = Timing.GetTime(() => InsertionSort.InsertionSortArrayList<int>(randomIntArray), timeUnit);

            Console.WriteLine("Time to sort: " + insertionResult.Time.ToString() +" miliseconds");

            Console.WriteLine();
            Console.WriteLine("Sorted Array: ");
            for (int i = 0; i < randomIntArray.Length; i++)
            {

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
    }
}
