// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


string productOfNumbers()
{
    int[] arr = {1, 2, 3, 4, 5};
    int[] product = new int[arr.Length / 2 + arr.Length % 2];

    for (int i = 0; i < (arr.Length / 2 + arr.Length % 2); i++)

    if (i < arr.Length / 2)
   
    {
        product[i] = arr[i] * arr[arr.Length - 1 - i];
    }

        else

            {
                product[i] = arr[i] * 1;
            }


    
    string output = $"Product of numbers {String.Join(", ", arr)}: {String.Join(", ", product)}";

    return output;

}

Console.WriteLine(productOfNumbers());