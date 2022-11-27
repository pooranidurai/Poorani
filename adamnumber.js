function rev(sqr)
{
    let rem,rev=0;
    while(sqr>0)
    {
        rem=sqr%10;
        rev=rev*10+rem;
        sqr=sqr/10;
    }
    return rev;
}
let num=12;
let sqr=num*num;
let m=rev(sqr);
let n=rev(num);
let k=n*n;
if(m==k)
{
    document.write("Adam number");
}
else
{
    document.write("Not adam number");
}
