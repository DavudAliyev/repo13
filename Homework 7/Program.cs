using System;

namespace Homework_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = MathOperation(10, 15, '+');
            Console.WriteLine(result);


        }

        //Verilmiş iki ədəd üzərində verilmiş operator simvoluna əsasən riyazi əməliyyat aparıb nəticəsini console-da göstərən metod.

        static int MathOperation(int num1, int num2, char op)
        {
            bool check = true;
            int result = 0;

            do
            {
                switch (op)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        result = num1 / num2;
                        break;
                    default:
                        check = false;
                        break;
                }
            } while (false);
            return result;
        }

        //Verilmiş yazıdaki verilmiş simvolların sayını qaytaran metod

        static int FindSymbol(string text, char symbol)
        {
            int count = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == symbol)
                {
                    count++;
                }
            }
            return count;
        }

        //Verilmiş yazıdaki sözlərin sayını qaytaran metod (söz dedikdə boşluqlarla ayrılmış bütün yazılar nəzərdə tutulur)

        static int FindNumOfWords(string text)
        {
            int count = 1;

            for(int i = 0;i < text.Length; i++)
            {
                if (text[i] == ' ')
                    count++;
            }
            return count;

        }

        //Verilmiş edədin rəqəmləri cəmini qaytaran metod

        static int SumOfNums(string num)
        {
            int wantedindex = -1;

            for (int i = 0;i<num.Length;i++)
            {
                wantedindex = i;
            }

            int sum = 0;

            for(int i = 0; i <= wantedindex; i++)
            {
                sum += num[i];
            }
            return sum;
        }

        //Verilmiş ədədi verilmiş qüvvətə yüksəldib nəticəsini qaytaran metod

        static int SquareOfNum(int result, int num)
        {
            string numStr=Convert.ToString(num);

            for (int i = 0;i<numStr.Length;i++)
            {
                result *= num;
            }
            return result;
        }

        //Verilmiş ədədlər siyahısının bütün elementlərini  müsbət şəkildə qaytaran metod.
        //Misalçün  metoda {1,-4,9,-8} dəyərləri olan array göndərilsə metod bizə {1,4,9,8} dəyərləri olan array qaytarmalıdır.

        static int NewArrayOfNums(int[] numbers)
        {
            string newArray = "";

            for (int i = 0; i <= numbers.Length; i++)
            {
                if (numbers[i] > 0)
                {
                    newArray += numbers[i];
                    return i;
                }
            }
            return -1;
        }
    }
}
