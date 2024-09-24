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

                if (lesson > 1)
                    secondHalfArray = GetShiftedSecondArray(secondHalfArray);

                PrintReviewPairsForLesson(originalArray, secondHalfArray, middleIndex);

                Console.WriteLine("---------------------------------------------------");
            }
        }

        static string[] GetShiftedSecondArray(string[] array)
        {
            var shiftedArray = new string[array.Length];

            shiftedArray[0] = array[array.Length - 1];

            for (int i = 0; i < array.Length - 1; i++)
                shiftedArray[i + 1] = array[i];

            return shiftedArray;
        }

        static void PrintReviewPairsForLesson(string[] originalArray, string[] secondHalfArray, int middleIndex)
        {
            for (var i = 0; i < middleIndex; i++)
            {
                var student1 = originalArray[i];
                var student2 = secondHalfArray[i];

                var reviewPair = $"{student1} <-> {student2}";
                Console.WriteLine(reviewPair);
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
