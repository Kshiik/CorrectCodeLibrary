using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectCodeLibrary
{
    public class CorrectCodeClass
    {
        /// <summary>
        /// Метод принимает в качестве параметра строку
        /// </summary>
        /// <param name="candidate">код</param>
        /// <returns>Метод возвращает true, если входная строка соответствует следующим условиям:
        ///         строка имеет правильную длину;
        ///         десятый символ строки(контрольное значение) содержит правильную цифру.
        ///При нарушении данных условий, метод возвращает false.
        ///</returns>
        public static bool IsCorrectCode(string candidate)
        {
            if (string.IsNullOrEmpty(candidate))
                return false;
            if (candidate.Length != 10)
                return false;
            if (!long.TryParse(candidate, out long x))
                return false;

            char[] arr = candidate.ToCharArray();
            int last = (int)Char.GetNumericValue(arr[9]);
            int summ = 0;

            for (int i = 0; i < 9; i++)
            {
                summ += (int)Char.GetNumericValue(arr[i]);
            }

            if (summ % 10 == 0)
            {
                if (last != 0)
                    return false;
            }
            else
            {
                if (summ % 3 == 0)
                {
                    if (last != 1)
                        return false;
                }
                else
                {
                    if (last != 9)
                        return false;
                }
            }
            return true;
        }
    }
}
