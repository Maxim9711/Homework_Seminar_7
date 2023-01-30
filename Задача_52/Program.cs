// See https://aka.ms/new-console-template for more information
void showArray (double [,] array){
    for(int i=0; i < array.GetLength(0); i++){
      for(int j=0; j < array.GetLength(1); j++)
        Console.Write($"{array[i, j]}  ");
      Console.Write("\n");
    }
}

double [] average(double [,] array){

  double [] avr = new double [array.GetLength(1)];

  for(int i=0; i < array.GetLength(1); i++){
    for(int j=0; j < array.GetLength(0); j++)
      avr[i] += array[j,i];
      avr[i] /= array.GetLength(0);
  }


  return avr;
}

double [,] array = new double [7, 9];

for (int i=0; i < array.GetLength(0); i++)
  for (int j=0; j < array.GetLength(1); j++)
    array[i, j] = new Random().Next(0, 51);

showArray(array);

Console.WriteLine();
double [] avr = average(array);
for(int i=0; i < avr.Length; i++)
  Console.Write($"{avr[i]} ");
Console.WriteLine();
