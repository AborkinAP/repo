// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Console.Clear();

//Задача 2: получение максимального числа из 2
// Console.Write("Введите первое целое число ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе целое число ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// int max = number1;
// if(max < number2)
// {
// max = number2;
// }
    
// Console.WriteLine("Наибольшее число " + max);


// Задача 4: получение максимального числа из 3
// Console.Write("Введите первое целое число ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе целое число ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите третье целое число ");
// int number3 = Convert.ToInt32(Console.ReadLine());

// int max = number1;
// if(max < number2)
// {
//     max = number2;
//     if(max < number3)
//     {
//         max = number3;
//     }
// }
// if(max < number3){
//     max = number3;
// }   
// Console.WriteLine("Наибольшее число " + max);

// // Задача 6: определение четности числа
// Console.Write("Введите целое число ");
// int number = Convert.ToInt32(Console.ReadLine());
// int x = number % 2;
// if(x == 0)
// {
//     Console.WriteLine(number + " - четное число");
// }
// else 
// Console.WriteLine(number + " - нечетное число");

// Задача 8: показать все четные числа от 1 до N
Console.Write("Введите целое число ");
int number = Convert.ToInt32(Console.ReadLine());
int x = number - 1;
int count = 0;

while(count < number){

if (x % 2 == 0){
    Console.Write(x + ", ");
    x--;
    count++;
}
else 
x--;
count++;
}



