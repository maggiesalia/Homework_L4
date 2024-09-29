

using System.Diagnostics.CodeAnalysis;
using System.Transactions;


/// ____________________________________________________________#1 - Multiples of 5
//Console.WriteLine("Enter number to check if it is multiplied on 5:");
//var num = Convert.ToInt32(Console.ReadLine());

//if (num % 5 == 0)
//{
//    Console.WriteLine($"{num}, YES");
//}
//else
//{
//    Console.WriteLine($"{num}, NO");
//}


/// ____________________________________________________________#2 - Arithmetic Operations - ???
Console.WriteLine("Enter 1st number:");
var first_num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter 2nd number:");
var sec_num = Convert.ToInt32(Console.ReadLine());

if (first_num == 0 || sec_num == 0)
{
    Console.WriteLine(sec_num - first_num);
    Console.WriteLine(sec_num + first_num);
    Console.WriteLine(sec_num * first_num);
    Console.WriteLine("Not Allowed To Devide By Zero");
}
else if (first_num < sec_num)
{
    Console.WriteLine(sec_num - first_num);
    Console.WriteLine(sec_num + first_num);
    Console.WriteLine(sec_num * first_num);
    Console.WriteLine(sec_num % first_num);
}
else
{
    Console.WriteLine(first_num - sec_num);
    Console.WriteLine(first_num + sec_num);
    Console.WriteLine(first_num * sec_num);
    Console.WriteLine(first_num % sec_num);
}

///____________________________________________________________#3
//Console.WriteLine("Enter 1st number:");
//var first_num = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter 2nd number:");
//var sec_num = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"x={first_num}; y={sec_num}");
//Console.WriteLine("Type 'SWAP'");
//Console.ReadLine();

//first_num = first_num + sec_num;
//sec_num = first_num - sec_num;
//first_num = first_num - sec_num;

//Console.WriteLine($"x={first_num}; y={sec_num}");


/// ____________________________________________________________#4 - Multiplication Table
//Console.WriteLine("Enter number:");
//var number = Convert.ToInt32(Console.ReadLine());

//for (int i = 1; i <= 10; i++)
//{
//    var num_sum = number * i;
//    Console.WriteLine($"{number} * {i} = {num_sum}");
//}

/// ____________________________________________________________#5 - Even number & its squares
//Console.WriteLine("Enter number:");
//var even = Convert.ToInt32(Console.ReadLine());

//if (even % 2 == 0 )
//{
//    for (int i = 2; i < even; i += 2)
//    {
//        Console.WriteLine(i * i);
//    }
//}





