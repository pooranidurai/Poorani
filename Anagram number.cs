using System;
public class main{
    public static void Main()
    {
        string str;
        str=Console.ReadLine();
        string str1;
        str1=Console.ReadLine();
        char[]ch=str.ToLower().ToCharArray();
        char[]ch1=str1.ToLower().ToCharArray();
        Array.Sort(ch);
        Array.Sort(ch1);
        string s1=new string(ch);
        string s2=new string(ch1);
        if(s1==s2)
        {
            Console.WriteLine("Anagram");
        }
        else
        {
            Console.WritLine("Not Anagram");
        }
     }
 }
