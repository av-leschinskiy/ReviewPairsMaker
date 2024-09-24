namespace ReviewPairsMaker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var originalArray = GetStudents();
            var middleIndex = originalArray.Length / 2;
            var secondHalfArray = GetSecondHalfArray(originalArray, middleIndex);
            Console.Clear();

            for (var lesson = 1; lesson <= 20; lesson++)
            {
                Console.WriteLine($"Урок: {lesson}");

            }
        }

        static string[] GetSecondHalfArray(string[] originalArray, int middleIndex)
        {
            var secondHalfArray = new string[originalArray.Length - middleIndex];
            for (int i = middleIndex; i < originalArray.Length; i++)
                secondHalfArray[i - middleIndex] = originalArray[i];
            return secondHalfArray;
        }

        static string[] GetStudents()
        {
            return new string[] {
                "Герасимова Юлия Алексеевна",
                "Дацков Андрей Игоревич    ",
                "Куликов Сергей Сергеевич  ",
                "Лисовенко Вадим Николаевич",
                "Роганов Александр Игоревич",
                "Сахарюк Илья Викторович   ",
                "Степанов Дмитрий Андреевич",
                "Ткаченко Павел Игоревич   ",
                "Шелест Давид Александрович",
                "Юровник Максим Васильевич "
            };
        }
    }
}
