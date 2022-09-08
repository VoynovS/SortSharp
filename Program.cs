// See https://aka.ms/new-console-template for more information
using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

internal class Program {
    private static void Main(string[] args) {
        Console.WriteLine("Введите текст: ");
        //string str = Console.ReadLine();
        //string[] subs = str.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        List<string> words = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .ToList();// Вносит в List построчно слова из строки
        //List<int> num = new List<int>() { 10, 0, 1, 5, 6, 1 , 5 , 8}; //
       //words.Sort(); //Сортирует по словам от а до я
        /*foreach (string word in words) { // Выводит массив строк List
            Console.WriteLine(word);
        }
        Console.WriteLine("\n\n");*/
        //num.Sort();
        var result = words.GroupBy(x => x)
                          .Select(x => new { Word = x.Key, count = x.Count() })
                          .OrderByDescending(x => x.count); // Вопрос: почему метод ставит в приоритет количество повторений
        /*foreach (string word in words.Distinct()) {
            Console.WriteLine(word + " - " + words.Where(x => x == word).Count() + " раз");
        }*/

        //.Distinct()
        //OrderByDescending

        foreach (var word in result)
            Console.WriteLine("Слово " + word.Word + " встречается: " + word.count + " раз.");
    }
}


//примадонна примадонна привет привет привет Оля Оля Ламборгини Ламборгини

