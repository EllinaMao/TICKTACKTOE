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
            string text2 = "Hello world";
            DictionaryRussianMorze dict = new ();
            DictionaryEnglMorze dict2 = new ();
            string morze = MorzeCoderDecoder.ToMorze(text, dict.MorzeCode);
            Console.WriteLine($"Текст: {morze}");
            string fromMorze = MorzeCoderDecoder.FromMorze(morze, dict.MorzeCode);
            Console.WriteLine($"Текст: {fromMorze}");

            string morze2 = MorzeCoderDecoder.ToMorze(text2, dict2.MorzeCode);
            Console.WriteLine($"Текст: {morze2}");
            string fromMorze2 = MorzeCoderDecoder.FromMorze(morze2, dict2.MorzeCode);
            Console.WriteLine($"Текст: {fromMorze2}");


        }
    }
}
