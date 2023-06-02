// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07


int n = 4; 
int[,] arr = new int[n, n]; 

int val = 1; 
int rowStart = 0; 
int rowEnd = n - 1; 
int colStart = 0; 
int colEnd = n - 1; 

while (rowStart <= rowEnd && colStart <= colEnd) // пока не дошли до центра матрицы
{
    // заполняем верхнюю строку слева направо
    for (int i = colStart; i <= colEnd; i++)
    {
        arr[rowStart, i] = val;
        val++;
    }
    rowStart++; // увеличиваем начальную строку

    // заполняем правый столбец сверху вниз
    for (int i = rowStart; i <= rowEnd; i++)
    {
        arr[i, colEnd] = val;
        val++;
    }
    colEnd--; // уменьшаем конечный столбец

    // заполняем нижнюю строку справа налево
    for (int i = colEnd; i >= colStart; i--)
    {
        arr[rowEnd, i] = val;
        val++;
    }
    rowEnd--; // уменьшаем конечную строку

    // заполняем левый столбец снизу вверх
    for (int i = rowEnd; i >= rowStart; i--)
    {
        arr[i, colStart] = val;
        val++;
    }
    colStart++; // увеличиваем начальный столбец
}

// выводим матрицу на экран
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (arr[i, j ]< 10)
        {
            Console.Write($"0{arr[i, j]} ");
        }
        else { Console.Write($"{arr[i, j]} "); }
    }
    Console.WriteLine();
}
