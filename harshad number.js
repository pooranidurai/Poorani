let n=12,rem,sum=0;
let temp=n;
while(n>0)
{
    rem=n%10;
    sum=sum+rem;
    n=Math.floor(n/10);
}
if(temp%sum==0)
{
    console.log("harshad number");
}
else
{
    console.log("not harsahd number");
}
