//Matk >=90; Biology >=90; Chemistry >= 90;

int math, biology, chemistry;

Console.WriteLine("Enter you math result");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter you biology result");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your chemistry result");
chemistry = Int32.Parse(Console.ReadLine());

if (math>=90 && biology>=90 && chemistry>=90)
{
    Console.WriteLine("Welcome to university!");
}
else
{
    Console.WriteLine("Try next year!");

}

Console.WriteLine("Have a nice day");