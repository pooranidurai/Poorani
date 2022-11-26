using System;
public class main{
    public static void Main(string[] args)
    {
        string userInput;
        int n,i,flag=0;
        userInput=Console.ReadLine();
        n=Convert.ToInt32(userInput);
        for(i=2;i<=n/2;i++)
        {
           if(n%i==0)
           {
              flag=1;
              break;
           }
        }
        if(flag==0)
        {
            Console.WriteLine("prime number");
        }
        else
        {
            Console.WriteLine("Not prime number");
        }
    }
 }
