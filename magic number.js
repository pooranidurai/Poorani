let n=1728,rem,rem1,sum=0,rev=0;
let temp=n;
while(n>0)
{
    rem=n%10;
    sum=(sum)+rem;
    n=Math.floor(n/10);
}
let temp1=sum;
while(sum>0)
{
    rem1=sum%10;
    rev=rev*10+rem1;
    sum=Math.floor(sum/10);
}
let r= temp1*rev;
if(temp==r)
{
    console.log("magic number");
}
else
{
    console.log("not magic number");
}
