Link1:
Console.WriteLine("Введите Номер задачи 64, 66 или 68: ");
int TaskN=Convert.ToInt32(Console.ReadLine());
switch (TaskN){
/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
case 64:
Console.WriteLine("Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии. \n N = 5 -> 5, 4, 3, 2, 1 \n N = 8 -> 8, 7, 6, 5, 4, 3, 2, 1");
void Order(int N){
    if (N==1){
        Console.Write($"{N}");
    }else{
        Console.Write($"{N}, ");
        Order(N-1);
    }
}
Console.WriteLine("Введите N: ");
int N64=Convert.ToInt32(Console.ReadLine());
Order(N64);

break;

case 66:
Console.WriteLine("Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. \n M = 1; N = 15 -> 120 \n M = 4; N = 8. -> 30");
int MNSum(int M, int N){
    if (M==N){
        return N;
    }else if(M>N){
        return (M + MNSum(M-1, N));
    }else{
        return (M + MNSum(M+1, N));
    }


}

Console.WriteLine("Введите M: ");
int M66=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N: ");
int N66=Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N = {MNSum(M66, N66)}");

break;

case 68:
Console.WriteLine("Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. \n m = 2, n = 3 -> A(m,n) = 9 \n m = 3, n = 2 -> A(m,n) = 29");
int A(int M, int N){ 
    if (M==0){
        return N+1;
    }else if (N==0){
        return A(M-1, 1);
    }else{
        return A(M-1, A(M, N-1));
    }
}
linkA:
Console.WriteLine("Введите M: ");
int M68=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N: ");
int N68=Convert.ToInt32(Console.ReadLine());
if (M68<0 || N68<0){
    Console.WriteLine("M Или N Введены некоректно! Повторите попытку.");
    goto linkA;   
}
Console.WriteLine($"A(m,n) = {A(M68, N68)}");
break;

default:
    Console.WriteLine("Некоректный номер задачи! Повторите попытку.");
    goto Link1;
}
