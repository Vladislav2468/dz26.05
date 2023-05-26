//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


double[] array = { 3.14, 2.718, 1.618, 0.577, -1.414 };

double FindDifference(double[] arr)
{
    double minVal = arr[0];
    double maxVal = arr[0];
    for(int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > maxVal)
        {
            maxVal = arr[i];
        }
        if (arr[i] < minVal)
        {
            minVal = arr[i];  
        }    
    }
    double result = maxVal - minVal;
    return result;
}   
Console.WriteLine("разница между максимальным и минимальным элементов массива = " + FindDifference(array));