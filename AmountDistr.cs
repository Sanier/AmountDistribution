using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmountDistribution
{
    public class AmountDistr
    {
        public void AmountDistrub(string name, float summ, string[] sums)
        {
            //Переменная для подсчета коэффициента
            float koef = summ / sums.Select(float.Parse).Sum();

            float num = 0;
          
            if (name == "ПРОП" || name == "проп")
            {
                float summa = 0;
                for (int i = 0; i < sums.Length; i++)
                {
                    num = MathF.Round(float.Parse(sums[i]) * koef, 2);
                    summa += num;
                    sums[i] = Convert.ToString(num);                    
                }

                if (summa < summ)
                {
                    num += MathF.Round(summ - summa, 2);
                    sums[sums.Length - 1] = Convert.ToString(num);
                }

                //Вывод массива
                foreach (string s in sums)
                {
                    Console.Write("{0};", s);
                }
            }

            if (name == "ПЕРВ" || name == "певр")
            {
                num = summ;
                for (int i = 0; i < sums.Length; i++)
                {
                    if (num >= float.Parse(sums[i]))
                    {
                        num -= float.Parse(sums[i]);
                    }
                    else if (num > 0)
                    {
                        sums[i] = Convert.ToString(num);
                        num = 0;
                    }
                    else
                    {
                        sums[i] = "0";
                    }
                }

                //Вывод массива
                foreach (string s in sums)
                {
                    Console.Write("{0};", s);
                }
            }

            if (name == "ПОСЛ" || name == "посл")
            {
                num = summ;
                //перевод в массив Array через LINQ
                var result = sums.Select(c => new string(c.ToArray())).ToArray();
                //Разворот массива для работы с последними элементами
                Array.Reverse(result);

                for (int i = 0; i < sums.Length; i++)
                {
                    if (num >= float.Parse(result[i]))
                    {
                        num -= float.Parse(result[i]);
                    }
                    else if (num > 0)
                    {
                        result[i] = Convert.ToString(num);
                        num = 0;
                    }
                    else
                    {
                        result[i] = "0";
                    }
                }
                //Разворот обратно
                Array.Reverse(result);

                //Вывод массива
                foreach (string s in result)
                {
                    Console.Write("{0};", s);
                }
            }
        }
    }
}
