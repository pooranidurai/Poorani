let n=154,rem,sum=0;
let temp=n;
while(n>0)
{
    rem=n%10;
    sum=(sum)+(rem*rem*rem);
    n=Math.floor(n/10);
}

if(temp==sum)
{
    console.log("armstrong");
}
else
{
    console.log("not armstrong");
}
