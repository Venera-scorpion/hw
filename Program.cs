Console.Write("Введите число А:");
string text1 = Console.ReadLine();
int number1 = Convert.ToInt32(text1);
Console.Write("Введите число В:");
string text2 = Console.ReadLine();
int number2 = Convert.ToInt32(text2);
if(number1 > number2)
{
    Console.WriteLine("Число А большее");
    Console.WriteLine("Число В меньшее");
}
    else 
    {
     Console.WriteLine("Число А меньшее");
    Console.WriteLine("Число В большее");
    }
