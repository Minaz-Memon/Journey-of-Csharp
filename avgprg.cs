// See https://aka.ms/new-console-template for more information
//Author:Minaz Memon Date:11/01/2021
var numbers= new double[3];
numbers[0]=1.0;
numbers[1]=2;
numbers[2]=3;
var avg = (numbers[0]+numbers[1]+numbers[2])/3;
Console.WriteLine(avg);
if ( args.Length>0)
{ 
    Console.WriteLine($"Hello, {args[0]} !");
}
else
{
    Console.WriteLine($"Hello !");
}