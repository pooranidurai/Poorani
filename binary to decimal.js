let bno=101;
let dno=0,rem,i=0;
while(bno>0)
{
    rem=bno%10;
    dno=bno+rem*Math.pow(2,i);
    i++;
    bno=Math.floor(dno/10);
}
console.log(dno);
