using System;
using PersonLibrary;

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student();
        string phoneNumber = student.GetCellPhoneNumber();
        Console.WriteLine($"Student's phone number is: {phoneNumber}");
    }
}
