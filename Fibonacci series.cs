using System;
public class HelloWorld
{
public static void Main(string[] args)
{
int a=0,b=1,c,n=5;
for(int i=0;i<n;i++){
c=a+b;
Console.WriteLine("{0}\n",c);
a=b;
b=c;
}
}
}
