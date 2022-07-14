//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//1 7 -> такого числа в массиве нет


int[,] CreateRandom2dArray(int rows,int colums,int minValue,int maxValue)
{
    int[,] newArray= new int[rows,colums];

    for(int i=0;i<rows;i++)
        for(int j=0;j<colums;j++)
            newArray[i,j]= new Random().Next(minValue,maxValue+1);
    return newArray;
}

void Show2dArray(int[,]array)
{
     for(int i=0;i<array.GetLength(0);i++)
        {
        for(int j=0;j<array.GetLength(1);j++)
            Console.Write(array[i,j]+"   ");
        Console.WriteLine();
        }
}


int FindElement(int[,] array,int m,int n)
{
    int rezult=-1000;

    for(int i=0;i<array.GetLength(0);i++)
        for(int j=0;j<array.GetLength(1);j++)
            if(i==m-1 && j==n-1)
           rezult=array[i,j];
    return rezult;
}

int[,]myArray=CreateRandom2dArray(10,10,-20,20);
Show2dArray(myArray);

Console.WriteLine("Input position horizontal ->");
int m=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input pozition vertiсal ->");
int n=Convert.ToInt32(Console.ReadLine());

if(m<=10 && m>0 && n<=10 && n>0)
Console.WriteLine("Element "+m+","+n+" ->"+FindElement(myArray,m,n));
else
Console.WriteLine("Element "+m+","+n+ " ->not found");