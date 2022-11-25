let number=5;
if(number < 0){
console.log('Factorial for negative number does not exist');
}
else{
let fact=1;
for(let i=1;i<=number;i++){
fact*=i;
}
console.log('The factorial of ${number} is ${fact}');
}
