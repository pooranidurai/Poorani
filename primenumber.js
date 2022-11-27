let n=7;
let i,flag=0;
for(i=2;i<n/2;i++)
{
    if(n%i==0)
    {
        flag=1;
        break;
    }
}
if(flag==0)
{
    console.log("prime number");
}
else
{
    console.log("not prime number");
}
