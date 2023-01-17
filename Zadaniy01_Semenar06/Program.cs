Console.WriteLine("Введите количество цифр");
int n = Convert.ToInt32(Console.ReadLine());

int[] number = new int [n];


void FillArray(int[] array)
{
    for(int i=0;i<array.Length;i++)
    {
        Console.WriteLine($"Введите число {i+1} ");
        array[i]=Convert.ToInt32(Console.ReadLine());
    }
}

void Number(int[] array)
{
    int coun = 0;
    for(int i=0;i<array.Length;i++)
    {
        if(array[i]>0) coun++;
    }
    Console.WriteLine($"Вы ввели {coun} положительных чисел");
}


FillArray(number);
Number(number);






