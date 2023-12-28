using System;
using BasicArithmetic;
class Program {
static void main(){
double num1=10,num2=20;
System.Console.WriteLine($"Addition : {ArithmeticOperations.Add(num1,num2)}");
System.Console.WriteLine($"Subtraction : {ArithmeticOperations.Subtract(num1,num2)}");
System.Console.WriteLine($"Multiplication : {ArithmeticOperations.Multiply(num1,num2)}");
try{
                Console.WriteLine($"Division: {ArithmeticOperations.Divide(num1, num2)}");

}
catch(DivideByZeroException ex ){
    System.Console.WriteLine($"Error: {ex.Message}");

}
}
}