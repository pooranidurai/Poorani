let n=5,i,j;
let string="";
for(i=0;i<n;i++)
{
    for(s=0;s<n-i-1;s++)
    {
        string+=" ";
    }
    for(j=0;j<i+1;j++)
    {
        string+="* ";
    }
    string+="\n";
}
console.log(string);
