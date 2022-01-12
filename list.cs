// See https://aka.ms/new-console-template for more information
// Author: Minaz Memon Date: 12/01/2022
var numbers= new []{12.3,12.4,1.0,1.1};
var grades= new List<double>() {12.3,12.4,1.0,1.1};
grades.Add(5.9);

var Result=0.0;
foreach (var number in grades)
{
 Result+=number;  
}
Console.WriteLine(Result);
if ( args.Length>0)
{ 
    Console.WriteLine($"Hello, {args[0]} !");
}
else
{
    Console.WriteLine($"Hello !");
}