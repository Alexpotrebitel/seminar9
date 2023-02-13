// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
/*void Shownums(int num)
{
    if (num>1) Shownums(num-1);
    Console.Write(num+" ");
}
Shownums(5);
*/
//Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
/*int Sumchisel(int num)
{
    if (num!=0)return Sumchisel(num/10)+num%10;
else return 0;
}
Console.WriteLine(Sumchisel(1234));
*/
// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до
/*void  Shownums(int m, int n)
{
    Console.Write(" "+n);
    if (m<n) Shownums(m,n-1);
    else    if (m>n) Shownums(m-1,n);
        }
  Console.WriteLine();  
 Shownums(1,5);
 */
// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B.
/*double AtoBgree(double A,double B)
{
    if (  B>0) return AtoBgree(A,B-1)*A;
    else if ( B<0) return AtoBgree(A,B+1)*(1/A);
    else return 1;
}
Console.WriteLine(AtoBgree(2,-3));
*/