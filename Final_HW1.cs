﻿﻿// Написать программу которая из имеющегося массива строк формирует массив из 
// строк, длина которых мень ше либо равна 3 символа. Первоначальный массив 
// можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При 
// решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
﻿
void MaxNum3(string[] array){

string [] ArrayString(int num){
    string [] array = new string [num];
    for (int i = 0; i < num; i++)
    {
        Console.WriteLine($"Введите {i+1} строку: ");
        array[i] = Console.ReadLine();
        while (array[i] == "")
        {
            Console.WriteLine("Введите корректное значение: ");
            Console.WriteLine($"Введите {i+1} строку: ");
            array[i] = Console.ReadLine();
        }

    }
    return array;
    
﻿void ShowArray(string [] array){
    
    for (int i = 0; i < array.Length; i++){
        Console.Write($" {array[i]}");
    }
    Console.WriteLine();
}
