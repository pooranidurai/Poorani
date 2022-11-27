let n=6,sum=0;
for(i=0;i<n;i++)
{
    if(n%i==0)
    {
        sum=sum+i;
    }
}
if(n==sum)
{
    console.log("perfect number");
}
else
{
    console.log("not perfect number");
}
