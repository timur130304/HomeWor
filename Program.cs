// Задача 47

// double [,] CreateandShowArray(){
//     Console.WriteLine("Enter the numbers of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Enter the numbers of columns: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Enter the minimum numbers: ");
//     double min = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Enter the maximum numbers: ");
//     double max = Convert.ToInt32(Console.ReadLine());
//     double [,] arr = new double[rows, columns];
//     for (int i = 0;i < rows;i++)
//         for (int j = 0;j < columns; j++){
//             arr[i,j] = new Random().NextDouble() * (max - min) + min;
//         }
//     return arr;
// }

// void ShowArray(double[,] arr){
//     for (int i = 0;i < arr.GetLength(0);i++){
//         for (int j = 0;j < arr.GetLength(1); j++){
//             Console.Write(arr[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// ShowArray(CreateandShowArray());

// Задача 50

// int [,] CreateandShowArray(){
//     Console.WriteLine("Enter the numbers of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Enter the numbers of columns: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Enter the minimum numbers: ");
//     int min = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Enter the maximum numbers: ");
//     int max = Convert.ToInt32(Console.ReadLine());
//     int [,] arr = new int[rows, columns];
//     for (int i = 0;i < rows;i++)
//         for (int j = 0;j < columns; j++){
//             arr[i,j] = new Random().Next(min, max + 1);
//         }
//     return arr;
// }

// void ShowElementArray(int [,] arr){
//     Console.WriteLine("Write the row number of the element: ");
//     int row = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Write the column number of the element: ");
//     int column = Convert.ToInt32(Console.ReadLine());
//     if (row > 0 && row < arr.GetLength(0) && column > 0 && column < arr.GetLength(1)){
//         Console.WriteLine($"Element: {arr[row,column]}");
//     }
//     else{
//         Console.WriteLine("There is no such element");
//     }
// }
// ShowElementArray(CreateandShowArray());

// Задача 52

int [,] CreateandShowArray(){
    Console.WriteLine("Enter the numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the numbers of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the minimum numbers: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the maximum numbers: ");
    int max = Convert.ToInt32(Console.ReadLine());
    int [,] arr = new int[rows, columns];
    for (int i = 0;i < rows;i++)
        for (int j = 0;j < columns; j++){
            arr[i,j] = new Random().Next(min, max + 1);
        }
    return arr;
}
void ArithmeanandShowArr(int [,] arr){
    for (int i = 0;i < arr.GetLength(0);i++){
        for (int j = 0;j < arr.GetLength(1); j++){
            Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    for (int j = 0;j < arr.GetLength(1); j++){
        double mean = 0;
        for (int i = 0;i < arr.GetLength(0);i++){
            mean += arr[i, j];
        }
        Console.WriteLine($"Среднее значение {j + 1} столбца: {mean / arr.GetLength(0)}");
    }
}
ArithmeanandShowArr(CreateandShowArray());