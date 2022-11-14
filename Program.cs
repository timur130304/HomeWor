//Задача 25

// int Degree(int one, int two){
//     int degree = one;
//     if (two <= 0){
//         degree = 0;
//     }
//     else{
//         for (int i = 1;i < two; i++){
//             degree *= one;
//         }
//     }
//     return degree;
// }

// Console.WriteLine("Enter a number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the degree of the number: ");
// int b = Convert.ToInt32(Console.ReadLine());
// int deg  = Degree(a, b);
// if (deg == 0){
//     Console.WriteLine($"The degree b must be natural");
// }
// else{
//     Console.WriteLine($"The number {a} to the power of {b}  = {deg}");
// }

// Задача 27

// int TheAmount(int a)
// {
//     int i = a, sum = 0;
//     int count = 0;
//     while (i > 0){
//         i /= 10;
//         count++;
//     }
//     for (int z  = 0;z < count;z++){
//         sum  += a % 10;
//         a /= 10;
//     }
//     return sum;
// }

// Console.WriteLine("Enter a number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int amount = TheAmount(num);
// Console.WriteLine($"The sum of the digits of the power of {num} is equal to {amount}"); 

// Задача 29

// void TheArray()
// {
//     Random rnd = new Random();
//     Console.WriteLine("Enter the size of the array: ");
//     int size = Convert.ToInt32(Console.ReadLine());
//     int [] arr  = new int [size];
//     for (int i = 0;i < size;i++){
//         arr[i] = rnd.Next(0,99);
//         Console.Write(' ');
//         Console.Write(arr[i]);
//     }

// }
// TheArray();

