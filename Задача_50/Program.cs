// See https://aka.ms/new-console-template for more information
void showArray (int [,] array){
    for(int i=0; i < array.GetLength(0); i++){
      for(int j=0; j < array.GetLength(1); j++)
        Console.Write($"{array[i, j]}  ");
      Console.Write("\n");
    }
}


int [,] array = new int [7, 7];

for (int i=0; i < array.GetLength(0); i++)
  for (int j=0; j < array.GetLength(1); j++)
    array[i, j] = new Random().Next(-50, 50);

showArray(array);

Console.WriteLine("Введите позицию элемента в массиве");
Console.Write("Строка: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Столбец: ");
int n = Convert.ToInt32(Console.ReadLine());


if(m >= 0 & m <= array.GetLength(0) & n >= 0 & n <= array.GetLength(1))
  Console.Write($"Элемент массива: {array[m-1, n-1]}");
else
  Console.Write($"Нет элемента на данной позиции");
