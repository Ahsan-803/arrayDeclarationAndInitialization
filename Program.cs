
//Declaraing an Array

int[] evenNum;
String[] cities;

evenNum = new int[5];          //Specify the size of array or Using "new" keyword to allocate new space in memory 
cities = new string[3];    //Specify the size of array or Using "new" keyword to allocate new space in memory

//initialization Array

evenNum = new int[] {2,4,6,8,10};
cities = new string[] {"LHR","ISB","FSB","ssl"};

Console.WriteLine("----- Don't get direct output of array -----");
Console.WriteLine(evenNum);     //Don't get direct output of any array 
Console.WriteLine(cities);      //Don't get direct output of any array

//get length of any array using "length" libaries

Console.WriteLine("----- length of array -----");
Console.WriteLine(evenNum.Length);
Console.WriteLine(cities.Length);

//Get output of any array using any LOOP

Console.WriteLine("----- Output Even Number -----");
for (int i = 0; i < evenNum.Length; i++)
    Console.WriteLine(evenNum[i]);

Console.WriteLine("----- Output of String -----");
for (int i = 0;i < cities.Length; i++)
    Console.WriteLine(cities[i]);

//direct Declared AND initailization 


int[] oddNum = new int[] {1,3,5,7,9};

Console.WriteLine("----- Output ODD Number -----");
foreach (int j in oddNum)           //foreach loop good approach to get Output of an array and show output without index
    Console.WriteLine(j);

//Array Declaration Using "Var" keyword 
Console.WriteLine("-----using Var keyword -----");

var studentName = new string[] {"ali","bilal","ahmad"};     //But Var is not good practies for array
var seriesNum = new int[] {1,2,3,4,5,6,7};

foreach (int i in seriesNum)
    Console.WriteLine(i);
foreach(var i in studentName)       //During declaration use "Var" then also use to avoid explicity
    Console.WriteLine(i);           //Var automatically use those datatype which type of data initialize


                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          
