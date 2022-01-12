// See https://aka.ms/new-console-template for more information
//Author: Minaz Memon Date:12/01/2022

//Declaring List , here var is use for variable
var grades= new List<double>() {12.3,12.4,1.0,1.1};
//adding into list
grades.Add(5.9);

var Result=0.0;
//for loop in C#
foreach (var number in grades)
{
   Result += number;  
}
//to average the from total element of list so here count is used
Result /=grades.Count;  
Console.WriteLine($"The Average of Grade is {Result:N1} !");
if ( args.Length>0)
{ 
    Console.WriteLine($"Hello, {args[0]} !");
}
else
{
    Console.WriteLine($"Hello !");
}