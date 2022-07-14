//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


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

double[] FindElements(int[,] array,int colums)
{
    double[]arefm=new double [colums];
        
        
        for (int i=0;i<array.GetLength(1);i++)
        {
            double sum=0 ;
            for (int j=0;j<array.GetLength(0);j++)
            {
                sum+=array [j,i];
            }
            
            arefm[i]=Math.Round(sum/array.GetLongLength(0),3);   
        }
        
       
    return arefm;
}

void Showreszult(double[]array)
{
     for(int i=0;i<array.GetLength(0);i++)
        {
            Console.Write("arithmetic mean colums "+(i+1)+"->  "+array[i]);
            Console.WriteLine();
        }
}

Console.WriteLine("Enter an integer number rows:");
int m=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter an integer number of colums:");
int n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if(m>0 && m<=100 && n>0 && n<=100)
{
int[,]myarray=CreateRandom2dArray(m,n,-20,20);
Show2dArray(myarray);
Console.WriteLine();
double[]rezults=FindElements(myarray,n);
Showreszult(rezults);
}
else
Console.WriteLine("Erorr.The program has gone beyond the calculation range from (1,1) to (100,100)");