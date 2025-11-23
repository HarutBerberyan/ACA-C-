using System;
using System.Collections.Generic;
using System.Text;

/*int Mean(float a,float b)
{
    return (a+b)/2;
}
Console.WriteLine(Mean(3,2));*/
/*-----------------------------------------*/
/*double x = 2.5;
double y = -6*x + 8;
Console.WriteLine(y);*/

/*-----------------------------------------*/

/*int x = 9;
var y = 2*x*x - x + 4;
Console.WriteLine(y);*/

/*-----------------------------------------*/

/*float Celsius(float f)
{
    return (f-32)*5/9;
};
Console.WriteLine(Celsius(212));*/

/*-----------------------------------------*/

/*int a = 60;
var b = a*Math.PI/180;
var y = Math.Sin(b);
Console.WriteLine(y);*/

/*-----------------------------------------*/

/*int Sum = 0;
for(int i=1;i<=100;i++)
{
    Sum+=i;
}
Console.WriteLine(Sum);*/

/*-----------------------------------------*/

/*int sum = 0;
for(int i = 1; i <= 100; i++)
{
    if(i%2 == 1)
    {
        sum += 1;
    }
}
Console.WriteLine(sum);*/

/*-----------------------------------------*/

/*double Func(double a, double x)
{
    double y = a * Math.Pow(x,3) + Math.Pow(x, 1/a);
    return y;
}
Console.WriteLine(Func(2,1));/*

/*-----------------------------------------*/

/*float P = 1;
float Factorial(float n)
{
    while(n>=1)
    {
        P = P * n;
        n = n - 1;
    }
    return P;
}
Console.WriteLine(Factorial(5));*/

/*-----------------------------------------*/

/*int n1 = 0;
int n2 = 1;
float Fibonaci(float n)
{
    if(n==1)
    {
        return n1;
    }
    else
    {
        while(n>2)
        {
            int n3 = n2;
            n2 = n1 + n2;
            n1 = n3;
            n = n -1;
        }
        return n2;
    }
}
Console.WriteLine(Fibonaci(9));*/

/*-----------------------------------------*/

/*int a = 0;
bool Prime(int n)
{
    for(int i = 2; i <= n/2; i++)
    {
        if(n%i == 0)
        {
            a++;
        }
    }
    if(a==0)
    {
        return true;
    }
    else
    {
        return false;
    }
}
Console.WriteLine(Prime(9711));*/

/*-----------------------------------------*/

/*int sum = 0;
int SumDigits(int n)
{
    string a = n.ToString();
    for (int i = 0; i < a.Length - 1; i++)
    {
        int b = Convert.ToInt32(a[i]);
        sum += b;

    }
    return sum;
}
Console.WriteLine(SumDigits(12));*/