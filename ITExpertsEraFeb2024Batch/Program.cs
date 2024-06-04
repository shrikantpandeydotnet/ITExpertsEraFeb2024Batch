// See https://aka.ms/new-console-template for more information

//to write the code in console.
//Console.WriteLine("Hello, World!");
//Console.WriteLine("Welcome to the ITExpertsEra ");
//Console.WriteLine("First Class");
//Console.WriteLine("Introduction");
//Console.Write("This paragraph is going to be in a same line");
//Console.Write("This is second paragraph");
//Console.WriteLine();

//////////////////// First Program /////////////////////////////////////////////

//int firstNumber = 200;

//int secondNumber = 400;

//int result = firstNumber + secondNumber;

//Console.WriteLine(result);


///////////////// Get number from user and show them the result. 


//Console.WriteLine("Please enter your first number");

//int first  = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Please enter your second number");

//int second = Convert.ToInt32(Console.ReadLine());

//int results = first + second;

//Console.WriteLine("The result of first two numbers is " + results);

///////////////// if condition //////////////////

//Console.WriteLine("Please enter your first number");
//Console.WriteLine("Please enter your first number");

//int num1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Please enter your second number");

//int num2 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Please enter your third number");
//Console.WriteLine("Please enter your third number");

//int num3 = Convert.ToInt32(Console.ReadLine());

//if (num1 > num2  && num1 > num3) // || = logical or, && = logical end
//{
//    Console.WriteLine(num1 + " is the largest number");
//}
//else if (num2 > num1 && num2 > num3)
//{
//    Console.WriteLine(num2 + " is a the largest number");
//}
//else
//{
//    Console.WriteLine(num3 + " is a the largest number");
//}

/////////////////////////////// 21 February 2024 Data Types. ///////////////////////////////////////


//int varInt = 10;
//string varString = "This is second class of dotnet full stack course";
//bool varBool = true;
//DateTime varDateTime = DateTime.Now;
//float varFloat = 1.2f;

//Console.WriteLine(varInt);
//Console.WriteLine(varString);
//Console.WriteLine(varBool);
//Console.WriteLine(varDateTime);
//Console.WriteLine(varFloat);

//byte varByte = 255;
//char varChar = 's';
//object varObject = "sdssd";

//int varInt2 = default(int); 

//Console.WriteLine(varInt2);


///////////////////////////////////////////////// 27th February 2024 ///////////////////////////////////////////

// Syntax Array

using ITExpertsEraFeb2024Batch;
///
///
int[] intarrays = new int[5]; // 32bit * 5

// Array initialization

intarrays[0] = 10;
intarrays[1] = 20;
//intarrays[2] = 30;
//intarrays[3] = 40;
//intarrays[4] = 50;


//

// Print the aray
//Console.WriteLine(intarrays[0]);
//Console.WriteLine(intarrays[1]);
//Console.WriteLine(intarrays[2]);
//Console.WriteLine(intarrays[3]);
//Console.WriteLine(intarrays[4]);




// loop | for loop

//for (int i = 0; i <= 3 ; i++)
//{
//    Console.WriteLine(intarrays[i]); // intarrays[5] print
//}



//// Array declaration and initialization together.
//string[] stringArrays = new string[5] { "Apple", "Mangoes", "Banana", "Grapes", "Pineapple" };

//foreach (string str in stringArrays)
//{
//    Console.WriteLine (str);
//}

/// For loop questions... 


// write 1 to 100 counting

//for (int i = 1; i <=100; i++)
//{
//    Console.WriteLine(i);
//}

// print table

//int count = 1; 
//for (int i = 19; i <= 190; i = i+19)
//{
//    Console.WriteLine("19 * " + count + " = " +  i);
//    count++;
//}

// print reverse counting

//for (int i = 100; i >= 1; i--)
//{
//    Console.WriteLine(i);
//}


//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine("Outer Loop");

//    for (int j = 0; j < 10; j++)
//    {
//        Console.WriteLine(i * j); // 10 * 10 = 100
//    }
//}

// break; continue;

//for (int i = 0; i < 10; i++)
//{

//    if (i == 5)
//    {
//        break;
//    }

//    Console.WriteLine(i);
//}

//Console.WriteLine("Loop breaked successfully and came out");

//for (int i = 0; i < 10; i++)
//{

//    if (i == 5)
//    {
//        continue;
//    }

//    Console.WriteLine(i);
//}


// while loop 

//int i = 1;

//while (i < 10)
//{
//    Console.WriteLine(i);
//    i++;
//}

//do
//{
//    Console.WriteLine(i);
//    i++;
//}
//while (i < 10);

/////////////////////////////////////// 29th Feb 2024 //////////////////////////////////////////
///


// Create object

//Car objCar; // Car Class variable

//objCar = new Car(); // objCar is now object.


//Car objCar = new Car();


//objCar.Name = "Honda City";
//objCar.NoOfSeats = 4;
//objCar.Brand = "Honda";
//objCar.Color = "Black";


//objCar.Accelerator(10);
//objCar.Brake(100);


//Car objCar2 = new Car();

//objCar2.Name = "i10";
//objCar2.NoOfSeats = 6;
//objCar2.Brand = "Hyundai";
//objCar2.Color = "Red";


//objCar2.Accelerator(20);
//objCar2.Brake(200);

//Car objCar3 = new Car();

//objCar3 = objCar; // objCAr3 =011
//objCar = null;

//objCar3 = objCar;


//Console.WriteLine("============================================================");
//Console.WriteLine(objCar3.NoOfSeats); // 4
//Console.WriteLine(objCar.NoOfSeats);  // no value

MathsOperations objMO = new MathsOperations();

//int result = objMO.Sum(100, 20);

//Console.WriteLine(result);


//int[] array1 = new int[5] { 10, 20, 30, 40, 50 };

//int result2 = objMO.Sum(array1);
//int result3 = objMO.Sum(new int[] {34, 34, 34, 54, 45});


//int[] resultArray = objMO.ArrayfromNumber(10, 20, 30);


//int result = objMO.Sum(100, 23, 23, 23, 23, 34, 56, 66, 56, 56, 756);


//ConstructorExample objConst = new ConstructorExample(100, "sdfsss");


//Console.WriteLine(objConst.varInt + " = " + objConst.varString);

//// Copy Constructor

//ConstructorExample objConst2 = new ConstructorExample(objConst);




////////////////////////////////// 07 March 2024 ////////////////////////////////
///

//StaticExample objSE = new StaticExample();

//objSE.varInt = 10;

//StaticExample objSE2 = new StaticExample();

//objSE2.varInt = 20;

//StaticExample.StaticVArInt = 20;
//StaticExample.TestMethod();

//ConstructorExample.StaticVarInt = 120;

//ConstructorExample objCE = new ConstructorExample();
//ConstructorExample objCE2 = new ConstructorExample();

////////////////////////////////// 13 March 2024 /////////////////////////


//PropertiesExamples objPE = new PropertiesExamples();

//objPE.Size = 10; // set;

//objPE.TestProperty = 20; // set;

//objPE.WriteOnlyProperty = 10000;



//Console.WriteLine(objPE.Size); // get;
//Console.WriteLine(objPE.TestProperty); // get;

//Console.WriteLine(objPE.TestProperty);



//Parent objParent = new Parent();

//objParent.ParentMethod();


//Child objChild;
//objChild = new Child();

////objChild.ParentMethod();
////objChild.ChildMethod();


//objChild.ParentMethod2();

//objChild.ParentMethod();

////

//Parent parent = new Child();

//parent.ParentMethod();


////////////////////////// 26 March 2024 ///////////////////////

//CollectionExamples coll = new CollectionExamples();

//coll.ArrayListCollection();













//TwoSumExample objTSE = new TwoSumExample();

//objTSE.TwoSumProblem(new int[] { 6, 3, 12, 4, 5 }, 10);


///////////////////////// 04th April 2024 /////////////////////////////////


ExceptionHandling objEh = new ExceptionHandling();

objEh.TestMethod(5);




Console.ReadLine(); // to read from the screen.