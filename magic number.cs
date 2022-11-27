using System;
public class main{
    public static void Main()
    {
        int n=int.Parse(Console.ReadLine());
        int temp,temp1,rem,rem1,sum=0,rev=0,r;
        temp=n;
        while(n>0)
        {
            rem=n%10;
            sum=sum+rem;
            n=n/10;
        }
        temp1=sum;
        while(sum>0)
        {
            rem1=sum%10;
            rev=rev*10+rem1;
            sum=sum/10;
        }
        r=temp1*rev;
        if(temp==r)
        {
            Console.WriteLine("Magic number");
        }
        else
        {
            Console.WriteLine("Not magic");
        }
    }
}
