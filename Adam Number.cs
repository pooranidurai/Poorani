using System;
public class main{
    static int rev(int sqr)
    {
       int rem,rev=0;
       while(sqr>0)
       {
           rem=sqr%10;
           rev=rev*10+rem;
           sqr=sqr/10;
       }
       return rev;
    }
   public static void Main(string []args)
   {
       string userInput;
       int num;
       int sqr,m,n,k;
       userInput=Console.ReadLine();
       num=Convert.ToInt32(userInput);
       sqr=num*num;
       m=rev(sqr);
       n=rev(num);
       k=n*n;
       if(m=k)
       {
          Console.WriteLine("Adam Number");
       }
       else
       {
          Console.WriteLine("Not adam number");
       }
    }
 }
