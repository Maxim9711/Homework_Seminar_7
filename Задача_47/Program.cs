// See https://aka.ms/new-console-template for more information
void showArray (float [,] array){
    for(int i=0; i < array.GetLength(0); i++){
      for(int j=0; j < array.GetLength(1); j++)
        Console.Write($"{array[i, j]}       ");
      Console.Write("\n");
    }
}


Console.WriteLine("Введите размерность массива");

Console.Write("m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("n: ");
int n = Convert.ToInt32(Console.ReadLine());

float [,] array = new float [m, n];

for (int i=0; i < array.GetLength(0); i++)
  for (int j=0; j < array.GetLength(1); j++)
    array[i, j] = Convert.ToSingle(new Random().NextDouble());

showArray(array);
