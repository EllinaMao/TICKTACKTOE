namespace MorzeCoderAndDecoder
{
    /*
Задание 3
Создайте приложение для перевода обычного текста
в азбуку Морзе. Пользователь вводит текст. Приложение
отображает введенный текст азбукой Морзе. Используйте
механизмы пространств имён.

Задание 4
Добавьте к предыдущему заданию механизм перевода
текста из азбуки Морзе в обычный текст
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Привет мир. Я люблю пиццу";
            DictionaryRussianMorze dict = new DictionaryRussianMorze();
            string morze = MorzeCoderDecoder.ToMorze(text, dict.MorzeCode);
            Console.WriteLine($"Текст: {morze}");
            string fromMorze = MorzeCoderDecoder.FromMorze(morze, dict.MorzeCode);
            Console.WriteLine($"Текст: {fromMorze}");


        }
    }
}
