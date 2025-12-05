/*
    Задача 3: SortedList<TKey, TValue> и SortedDictionary<TKey, TValue>
    Создать SortedList<int, string> и SortedDictionary<int, string> для пар Id → Name.
    Добавить элементы в случайном порядке и вывести их.
    Измерить время добавления 10000 элементов в каждую коллекцию и сравнить скорость.
*/

using System.Diagnostics;

class Program
{
    public static void Main()
    {
        var random = new Random();
        var keys = new List<int>();

        for (int i = 0; i < 10000; i++)
        {
            keys.Add(i);
        }

        for (int i = 0; i < keys.Count; i++)
        {
            int j = random.Next(i, keys.Count);
            int temp = keys[i];
            keys[i] = keys[j];
            keys[j] = temp;
        }
        
        var sortedList = new SortedList<int, string>();
        var stopwatch = Stopwatch.StartNew();
        foreach (var key in keys)
        {
            sortedList.Add(key, $"ключ сортед лист: {key}");
        }
        stopwatch.Stop();
        Console.WriteLine($"Сортед лист занял: {stopwatch.ElapsedMilliseconds} ");
        
        var sortedDictionary = new SortedDictionary<int, string>();
        var stopwatch2 = Stopwatch.StartNew();
        foreach (var key in keys)
        {
            sortedDictionary.Add(key, $"ключ сортед диктионари: {key}");
        }
        stopwatch2.Stop();
        Console.WriteLine($"Сортед диктионари занял: {stopwatch2.ElapsedMilliseconds} ");
        
    }
}
