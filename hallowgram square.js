let n=5,i,j;
let string="";
for(i=0;i<=n;i++)
{
    for(j=0;j<=n;j++)
    {
        if(i==0||i==n||j==0||j==n)
    {
       string+="*";
    }
    else
    {
        string+=" ";
    }
   }
     string+="\n";
}
console.log(string);
