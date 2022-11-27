let count=0,rem;
for(i=50;i<60;i++)
{
    let x=i;
    while(x>0)
    {
        rem=x%10;
        if(rem==5)
        {
            count++;
        }
        x=Math.floor(x/10);
    }
}
console.log(count);
