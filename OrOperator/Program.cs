//math or chemistry >=90 
//math && chemistry || math && biology || chemistry && biology
int math, biology, chemistry;

Console.WriteLine("Enter you math result");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter you biology result");
biology = Int32.Parse(Console.ReadLine());


Console.WriteLine("Enter your chemistry result");
chemistry = Int32.Parse(Console.ReadLine());

if ((math>=90 && chemistry>=90) || (math>=90 && biology>=90) || (chemistry>=90 && biology>=90))
{
    Console.WriteLine("Welcome to university!");
}
else
{
    Console.WriteLine("Try next year!");

}

Console.WriteLine("Have a nice day");