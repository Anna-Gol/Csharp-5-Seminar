// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

string Difference()

{
    int[] array = {3, 7, 22, 2, 78};
    int min = array[0];
    int max = array[0];
    int numDif = 0;
 
    for (int i = 0; i < array.Length; i++)

        {
            if (array[i] < min)
            {
                 min = array[i];
            }

            else if (array[i] > max)
            {
                max = array[i];
            }

            numDif = max - min;
        }

    

    string output = $"Difference betweem {max} and {min} = {numDif}";

    return output;


}

Console.WriteLine(Difference());