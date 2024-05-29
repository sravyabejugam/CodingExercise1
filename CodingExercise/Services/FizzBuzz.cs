using System.Collections;

namespace CodingExercise.Services
{
    public class FizzBuzz : IFizzBuzz
    {
        ArrayList arrlist1 = new ArrayList();
        ArrayList arrlist2 = new ArrayList();

        public ArrayList GetandPost(ArrayList arr)
        {
            //foreach (var item in arr)
            //    arrlist1.Add(item.ToString());

            int numeric;
            int val1 = 3;
            int val2 = 5;
            string str1, str2;
            foreach (var item in arr)
            {
                if (int.TryParse(item.ToString(), out numeric))
                {
                    if ((numeric % val1 == 0) && (numeric % val2 == 0))
                    {
                        arrlist2.Add("FizzBuzz");
                    }
                    else if (numeric % val1 == 0)
                    {
                        arrlist2.Add("Fizz");
                    }
                    else if (numeric % val2 == 0)
                    {
                        arrlist2.Add("Buzz");
                    }
                    else
                    {
                        str1 = string.Format($"Divided {numeric} by {val1}");
                        str2 = string.Format($"Divided {numeric} by {val2}");
                        arrlist2.Add(str1);
                        arrlist2.Add(str2);
                    }

                }

                else
                {
                    arrlist2.Add("Invalid Item");
                }
            }

            return arrlist2;

        }

        //    public ArrayList GetandPost(ArrayList arr)
        //    {
        //        foreach(var item in arr)
        //            arrlist1.Add(item.ToString());

        //        return arrlist1;
        //    }
    }
}
