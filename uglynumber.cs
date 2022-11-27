using System;
public class main{
    public static void Main()
    {
        int n=int.Parse(Console.ReadLine());
        if(n%2==0 || n%3==0 || n%5==0)
        {
            Console.Write("ugly number");
        }
        else
        {
            Console.Write("Not ugly number");
        }
    }
}
