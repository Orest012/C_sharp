using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Task #1
//public class Solution
//{
//    public bool IsSubsequence(string s, string t)
//    {
//        int counter = 0;
//        int norm = 0;

//        if (s == "")
//        {
//            return true;
//        }
//        else if (t == "")
//        {
//            return false;
//        }

//        for (int i = 0; i < s.Length; i++)
//        {
//            counter = 0;
//            for (int j = 0; j < t.Length; j++)
//            {
//                if (s[i] == t[j])
//                {
//                    counter++;
//                }
//            }
//            if (counter != 0)
//            {
//                norm++;
//            }
//            else
//            {
//                norm = 0;
//                i = s.Length;
//            }
//        }
//        if (norm == 0)
//        {
//            return false;

//        }
//        else
//        {
//            return true;
//        }
//    }
//}
#endregion
#region Task #2
//public class Solution_1
//{
//    public string MergeAlternately(string word1, string word2)
//    {
//        char[] ch = new char[word1.Length + word2.Length];

//        int index = 0;
//        int i = 0;

//        while (i < word1.Length || i < word2.Length)
//        {
//            if (i < word1.Length)
//            {
//                ch[index++] = word1[i];
//            }

//            if (i < word2.Length)
//            {
//                ch[index++] = word2[i];
//            }

//            i++;
//        }

//        //foreach (char c in ch)
//        //{
//        //    Console.Write(c);
//        //}
//        string str = new string(ch);
//        //Console.WriteLine(str);
//        return str;
//    }
//}
#endregion
#region Task #3
//public class Solution_2
//{
//    public string ReverseWords(string s)
//    {
//        string[] words = s.Split(' ');
//        StringBuilder reversed = new StringBuilder();

//            for (int i = words.Length - 1; i >= 0; i--)
//            {
//                if (!string.IsNullOrWhiteSpace(words[i]))
//                {
//                    reversed.Append(words[i]);
//                    if (i != 0 && i != words.Length)
//                    {
//                        reversed.Append(" ");
//                    }
//                }
//            }

//            string result = reversed.ToString().TrimEnd();


//            return result;
//        }
//}

//class A {
//    private int a;
//    public A()
//    {
//        this.a = 0;
//    }
//    public A(int a) {
//        this.a = a;
//    }
//    public int Num {
//        get
//        {
//            return a;
//        }

//        set 
//        {
//            a = value;
//        }
//    }
//    public static A operator +(A obj_1, A obj_2) {
//        A obj = new A();
//        obj.a = obj_1.a + obj_2.a;

//        return obj;
//    }
//}
#endregion
#region Task #4
//public class Solution_3
//{
//    public bool IsValid(string s)
//    {
//        while (s.Contains("()") || s.Contains("[]") || s.Contains("{}"))
//        {
//            s = s.Replace("()", "").Replace("[]", "").Replace("{}", "");
//        }
//        return s.Length == 0;
//    }
//}
//public class Solution_4
//{
//    public double MyPow(double x, int n)
//    {
//        double res = 0.0, x_new = x, x_prev = x;
//        for (int i=0; i!=n/2; i++) {

//        }

//        return res;
//    }
//}
#endregion
#region Task #5
//public class Solution
//{
//    public IList<string> GetLettersFromDigits(string digits)
//    {
//        IList<string> numbers = new List<string>();
//        int res = 0;
//        int index = 0;

//        if (digits == "")
//        {
//            return numbers;
//        }
//        else
//        {
//            if (int.TryParse(digits, out int resul))
//            {
//                res = resul;

//                List<int> l1 = new List<int>();
//                while (res != 0)
//                {
//                    l1.Add(res % 10);
//                    res /= 10;
//                }



//                int[] arr = new int[l1.Count];
//                string[] ss = new string[]
//                {
//                "a", "b", "c",
//                "d", "e", "f",
//                "g", "h", "i",
//                "j", "k", "l",
//                "m", "n", "o",
//                "p", "q", "r",
//                "s", "t", "u",
//                "v", "w", "x", "y", "z"
//                };

//                index = l1.Count - 1;
//                foreach (int num in l1)
//                {
//                    arr[index] = num;
//                    index--;
//                }
//                int Range = l1.Count + 1;
//                string[] comb = new string[Range * Range];
//                int count = 0;
                

//                Console.WriteLine(l1.Count);

                
//                foreach (int num in arr)
//                {
//                    if (num >= 2 && num <= 9)
//                    {
//                        int startIndex = (num - 2) * 3;
//                        if (count != 0) {
//                            index = 0;
//                            for (int i = 0; i < Range; i++)
//                            {
//                                for (int j = 0; j < Range; j++)
//                                {
//                                    if (startIndex + i < ss.Length)
//                                    {
//                                        comb[index++] += ss[startIndex + j];
//                                    }
//                                }
//                            }
                           
//                        }

                        
//                        if (count == 0)
//                        {
//                            index = 0;
//                            for (int i = 0; i < Range; i++)
//                            {
//                                for (int j = 0; j < Range; j++)
//                                {
//                                    if (startIndex + i < ss.Length)
//                                    {
//                                        comb[index++] = ss[startIndex + i];
//                                    }
//                                }
//                            }
//                        }
                        
//                    }
//                    count ++; 
//                }

//                foreach (var num in comb)
//                {
//                    numbers.Add(num);
//                }

//                return numbers;
//            }
//        }

//        return numbers;
//    }

//}
#endregion

internal class Program
    {
    public static void Main()
    {
        #region Task #5
        //string str = Console.ReadLine();
        //Solution solution = new Solution();


        //char[] ch = new char[35];
        //int index = 0;
        //for (int i = 97; i <= 122; i++) {
        //    ch[index] = (char)i;
        //    index++;
        //}


        //IList<string> l1 = new List<string>();
        //l1 = solution.GetLettersFromDigits(str);
        //foreach (var num in l1) {
        //    Console.WriteLine(num);
        //}
        #endregion

        Console.ReadLine();

    }
}


