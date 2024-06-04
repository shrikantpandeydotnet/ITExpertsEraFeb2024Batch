using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITExpertsEraFeb2024Batch
{
    public class GenericListExample
    {

        public void ListExample()
        {
            // Define
            List<string> list = new List<string>();

            //Add values 

            list.Add("Abc");
            list.Add("Paras");
            list.Add("Shweta");
            list.Add("Tanushree");

            // Read the value. 

            string value = list[0];
            string value1 = list[1];
            string value2 = list[2];
            string value3 = list[3];

            // insert

            list.Insert(0, "Anil");

            // update 

            list[1] = "Anamika";

            // loop
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            // Count

            int count = list.Count;

            // Contains 

            bool isValueExist = list.Contains("Paras");


            // remove 

            list.RemoveAt(0);
            list.Clear();

        }
    }
}
