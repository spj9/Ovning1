// Övning 1 i C#

using Ovning1;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Registrera ny anställd");
        Console.WriteLine("Ange namn:");

        string inputName = Console.ReadLine();

        Console.WriteLine("Ange lön:");

        string inputSalary = Console.ReadLine();

        Employee person = new Employee(inputName, inputSalary);

        person.DisplayRegisteredEmployee();
    }
}