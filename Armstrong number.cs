using System;
public class main{
    public static void Main()
    {
        int n=int.Parse(Console.ReadLine());
        int temp,rem,sum=0;
        temp=n;
        while(n>0)
        {

            rem=n%10;
            sum=sum+(rem*rem*rem);
            n=n/10;
        }
        if(temp==sum)
        {
            Console.WriteLine("Armstrong");
        }
        else
        {
            Console.WriteLine("Not armstrong");
        }
    }
}
