﻿int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int[] array = {1,2,63,4,15,62,7,8,9};

int max1 = Max(a1, b1, c1);
Console.WriteLine(max1);
int max2 = Max(a2, b2, c2);
Console.WriteLine(max2);
int max3 = Max(a3, b3, c3);
Console.WriteLine(max3);
int maximum = Max(max1, max2, max3);
Console.WriteLine(maximum);

