let dno=5;
let bno=0,rem,f=1;
while(dno>0)
{
    rem=dno%2;
    bno=bno+rem*f;
    f=f*10;
    dno=Math.floor(dno/2);
}
console.log(bno);
