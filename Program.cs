// Задачча 34

// int [] CreateRandArray(int size)
// {
//     Random rnd = new Random();
//     int [] arr  = new int [size];
//     for (int i = 0;i < size;i++){
//         arr[i] = rnd.Next(100,999);
//     }
//     return arr;
// }
// Console.WriteLine("Enter the size of the array: ");
// int size = Convert.ToInt32(Console.ReadLine());

// static void PrintArray(int [] arr){
//     for (int i = 0;i < arr.Length;i++){
//         Console.WriteLine(arr[i]);
//     }
// }

// void HonestNumber(int [] arr){
//     int count = 0;
//     for (int i = 0;i < arr.Length;i++){
//         if (arr[i] % 2 == 0){
//             count += 1;
//         }
//     }
//     Console.WriteLine($"The number of even numbers in the array is {count}");
    
// }
// PrintArray(CreateRandArray(size));
// HonestNumber(CreateRandArray(size));

// Задача 36

// int [] CreateRandArray(int size)
// {
//     Random rnd = new Random();
//     int [] arr  = new int [size];
//     for (int i = 0;i < size;i++){
//         arr[i] = rnd.Next(1,999);
//         Console.WriteLine(arr[i]);
//     }
//     return arr;
// }


// void Sum(int [] arr){
//     int sum = 0;
//     for(int i = 0; i < arr.Length; i++){
//         if (i % 2 != 0){
//             sum += arr[i];
//         }
//     }
//     Console.WriteLine($"The sum of the numbers in odd positions is equal to {sum}");
// }
// Console.WriteLine("Enter the size of the array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Sum(CreateRandArray(size));

// Задача 38

// double [] CreateRandArray(int size)
// {
//     Random rnd = new Random();
//     double [] arr  = new double [size];
//     for (int i = 0;i < size;i++){
//         arr[i] = rnd.NextDouble();
//         Console.WriteLine(arr[i]);
//     }
//     return arr;
// }

// void MaxElandMinEl(double [] arr ){
//     double max = arr[0];
//     double min = arr[0];
//     for(int i = 1;i < arr.Length;i++){
//         if (arr[i] > max){
//             max = arr[i];
//         }
//     }
//     for(int i = 1;i < arr.Length;i++){
//         if (arr[i] < min){
//             min = arr[i];
//         }
//     }
//     Console.WriteLine($"The difference between  the max and min is equal to {max - min}");
// }
// Console.WriteLine("Enter the size of the array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// MaxElandMinEl(CreateRandArray(size));