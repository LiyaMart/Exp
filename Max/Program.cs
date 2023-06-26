int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2>result) result=arg2;
    if (arg3>result) result=arg3;
    return result;
}

int a1=54;
int a2=65;
int a3=3;
int a4=86;
int a5=23;
int a6=53;
int a7=7;
int a8=85;
int a9=73;

int max1 = Max(a1, a2, a3);
int max2 = Max(a4, a5, a6);
int max3 = Max(a7, a8, a9);
int max = Max(max1, max2, max3);

Console.WriteLine(max);