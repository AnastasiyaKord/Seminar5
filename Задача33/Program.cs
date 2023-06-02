// Задача 33: Задайте массив. Напишите программу,
// которая определяет, присутствует ли заданное 
// число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да


int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
int[] GetRandomArray(int length, int leftRange, int rightRange)
{

    int[] array = new int[length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftRange, rightRange + 1);
    }

    return array;
}

bool Detector(int[] array, int number)
{
    bool temp = false;
    for (int i = 0; i < array.Length; i++)
    {
        if(number == array[i])
        {
            temp = true;
            break;
        }  
    }
    if (temp)
    {
        Console.Write("Да");
    }   
    else
    {
        Console.Write("Нет");
    } 
    return temp;

}

int length = ReadNumber("Введите длину массива: ");
int leftRange = ReadNumber("Введите левую границу вашего массива: ");
int rightRange = ReadNumber("Введите правую границу вашего массива: ");
int[] array = GetRandomArray(length, leftRange, rightRange);

int find = ReadNumber("Введите число, а я скажу, есть оно в массиве или нет");
Console.Write(Detector(array, find));


// Решение от преподавателя:
// int[] GetRandomArray(int length, int leftRange, int rightRange)
// {
//     int[] array = new int[length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = Random.Shared.Next(leftRange, rightRange + 1);
//     }

//     return array;
// }

// //true - findNumber найден в array
// //false - findNumber НЕ найден в array
// bool IsElementInArray(int[] array, int findNumber)
// {
//     bool result = false;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] == findNumber) 
//         {
//             result = true;
//             break;
//         }
//     }
//     return result;
// }

// int lengthOfArray = 12;
// int leftBorder = -9;
// int rightBorder = 9;
// int finding = 5;

// int[] myArray = GetRandomArray(lengthOfArray, leftBorder, rightBorder);

// Console.WriteLine($"[{string.Join(", ", myArray)}]");
// bool res = IsElementInArray(myArray, finding);
// Console.WriteLine(res);