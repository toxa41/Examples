﻿int[,] pic = new int[,];
void PrintImage(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i ++)
    {
        for (int j = 0; j < image.GetLength(1); j ++)
        {
            // image, j] = new Random().Next(1, 10);//[1;10]
            if(image[i,j] == 0) Console.Write($" ");
            else Console.Write($"+");
        }
    Console.WriteLine(); 
    }
}

PrintImage(pic);