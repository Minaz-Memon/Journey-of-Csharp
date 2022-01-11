// See https://aka.ms/new-console-template for more information
var x,y,Add;
x=1;
y=2;
Add=x+y;
Console.WriteLine(Add);
if ( args.Length>0)
{ 
    Console.WriteLine($"Hello, {args[0]} !");
}
else
{
    Console.WriteLine($"Hello !");
}