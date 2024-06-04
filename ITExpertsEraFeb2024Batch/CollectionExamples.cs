using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITExpertsEraFeb2024Batch
{
    public class CollectionExamples
    {
        public void ArrayListCollection()
        {
            // Define
            ArrayList objArrayList = new ArrayList();

            // Add Values
            objArrayList.Add(10);
            objArrayList.Add("Test");
            objArrayList.Add(true);
            objArrayList.Add(DateTime.Now);

            // Read Values from the ArrayList

            int value1 = Convert.ToInt32(objArrayList[0]);
            string value2 = Convert.ToString(objArrayList[1]);
            bool value3 = Convert.ToBoolean(objArrayList[2]);
            DateTime value4 = Convert.ToDateTime(objArrayList[3]);

            // Update

            objArrayList[2] = 100; //  updated true to 100;

            // Insert at

            objArrayList.Insert(1, "Paras"); // 10, "Paras", "Test", true, DateTime.Now

            // Remove

            objArrayList.Remove("Test");

            // Remove at 

            objArrayList.RemoveAt(2);

            // Count

            int Count = objArrayList.Count; // 3

            if (objArrayList.Contains(10))
            {
                Console.WriteLine("Value Exist");
            }

            // Remove All

            objArrayList.Clear();

        }

        public void HashTableCollectin()
        {
            // hash table 

            Hashtable objHashTable = new Hashtable();

            // Add values

            objHashTable.Add(1, "Test");
            objHashTable.Add("key2", 10);
            objHashTable.Add(2, DateTime.Now);
            objHashTable.Add(3, true);

            // Read 

            string value1 = Convert.ToString(objHashTable[1]);
            int value2 = Convert.ToInt32(objHashTable["Key2"]);
            DateTime value3 = Convert.ToDateTime(objHashTable[2]);
            bool value4 = Convert.ToBoolean(objHashTable[3]);

            //Update

            objHashTable["Key2"] = 100;

            // count 

            int count = objHashTable.Count;

            // contains

            bool iskeyexist = objHashTable.Contains(10);
            bool iskeyexist2 = objHashTable.ContainsKey(10);
            bool iskeyexist3 = objHashTable.ContainsValue(100);

            // Delete 

            objHashTable.Remove("key2");

            objHashTable.Clear();

            foreach (object key in objHashTable.Keys) 
            {
                Console.WriteLine(key);
            }

            foreach (object value in objHashTable.Values)
            {
                Console.WriteLine(value);
            }



        }

        public void StackOperation() // LIFO - Last In First Out
        {
            Stack objStack = new Stack();


            // push to insert value
            objStack.Push(1);
            objStack.Push("test");
            objStack.Push(DateTime.Now);
            objStack.Push(true);

            // peek.

            bool valuePeek1 = Convert.ToBoolean(objStack.Peek()); // returns value but do not delete it. 

            bool valuePeek2 = Convert.ToBoolean(objStack.Peek());
            bool valuePeek3 = Convert.ToBoolean(objStack.Peek());
            bool valuePeek4 = Convert.ToBoolean(objStack.Peek());
            bool valuePeek5 = Convert.ToBoolean(objStack.Peek());

            int count1 = objStack.Count; // 0


            // to get value | Pop

            bool value1 = Convert.ToBoolean( objStack.Pop()); // returns value and delete it. 
            DateTime value2 = Convert.ToDateTime( objStack.Pop()); // returns value and delete it. 
            string value3 = Convert.ToString( objStack.Pop()); // returns value and delete it. 
            int value4 = Convert.ToInt32( objStack.Pop()); // returns value and delete it. 


            // count

            int count = objStack.Count; // 0

            objStack.Clear();

            objStack.Contains(10);
        }

        public void QueueOperation() // FIFO - First In First Out
        {
            Queue objQueue = new Queue();

            // Insert

            objQueue.Enqueue(1); 
            objQueue.Enqueue(10); 
            objQueue.Enqueue(20); 
            objQueue.Enqueue(30);

            // Peek 

            int valuePeek1 = Convert.ToInt32(objQueue.Peek()); 
            int valuePeek2 = Convert.ToInt32(objQueue.Peek()); 
            int valuePeek3 = Convert.ToInt32(objQueue.Peek()); 
            int valuePeek4 = Convert.ToInt32(objQueue.Peek());

            // Dequeue

            int value1 = Convert.ToInt32(objQueue.Dequeue());
            int value2 = Convert.ToInt32(objQueue.Dequeue());
            int value3 = Convert.ToInt32(objQueue.Dequeue());
            int value4 = Convert.ToInt32(objQueue.Dequeue());

            int count = objQueue.Count;

            objQueue.Clear();
            objQueue.Contains(10);
        }
    }
}
