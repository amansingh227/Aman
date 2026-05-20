using System;

class Add2Numbers{
    static void Main(){
        int a,b;
        Console.WriteLine("Enter value for a ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Value for b ");
        b = Convert.ToInt32(Console.ReadLine());
        int sum =a+b;
        Console.WriteLine($"Final Output {sum}");
        
    }
}