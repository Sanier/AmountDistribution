
namespace AmountDistribution
{
    public class AmountDistr
    {
        public void AmountDistrub(string name, float sum, string[] sums)
        {
            float koef = sum / sums.Select(float.Parse).Sum();

            float num = 0;
            name.ToLower();

            switch(name)
            {
                case "проп":
                    float summa = 0;
                    for (int i = 0; i < sums.Length; i++)
                    {
                        num = MathF.Round(float.Parse(sums[i]) * koef, 2);
                        sum += num;
                        sums[i] = Convert.ToString(num);
                    }

                    if (summa < sum)
                    {
                        num += MathF.Round(sum - summa, 2);
                        sums[sums.Length - 1] = Convert.ToString(num);
                    }

                    ArrayOutput(sums);
                    break;

                case "певр":
                    num = sum;
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

                    ArrayOutput(sums);
                    break;

                case "посл":

                    num = sum;

                    var result = sums.Select(c => new string(c.ToArray())).ToArray();

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

                    Array.Reverse(result);
                    ArrayOutput(result);
                    break;

                default:
                    throw new Exception("");
            }
        }

        private void ArrayOutput(string[] result)
        {
            foreach (string s in result)
                Console.Write("{0};", s);
        }
    }
}
