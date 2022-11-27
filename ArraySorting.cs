using System;
using System.Linq;
public class main{
    public static void Main()
    {
        int n=int.Parse(Console.ReadLine());
        int[]arr=new int[n];
        int i;
        for(i=0;i<n;i++)
        {
            int data=int.Parse(Console.ReadLine());
            arr[i]=data;
            
        }
        Array.Sort(arr);
        foreach(int item in arr)
        {
            Console.Write(item+" ");
        }
    }
}
