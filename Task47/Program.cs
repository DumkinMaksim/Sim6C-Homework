//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//m = 3, n = 4.

//0,5 7 -2 -0,2

//1 -3,3 8 -9,9

//8 7,8 -7,1 9

double[,] CreateRandom2dArray(int rows,int colums,int minValue,int maxValue)
{
    double[,] newArray= new double[rows,colums];

    for(int i=0;i<rows;i++)
        for(int j=0;j<colums;j++)
            newArray[i,j]= Math.Round(new Random().Next(minValue,maxValue+1)+new Random().NextDouble(),2);
    return newArray;
}

void Show2dArray(double[,]array)
{
     for(int i=0;i<array.GetLength(0);i++)
        {
        for(int j=0;j<array.GetLength(1);j++)
            Console.Write(array[i,j]+" ");
        Console.WriteLine();
        }
}
Console.WriteLine("Input m: ->");
int m=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input n: ->");
int n=Convert.ToInt32(Console.ReadLine());

double[,]myArray=CreateRandom2dArray(m,n,-9,9);
Show2dArray(myArray);
