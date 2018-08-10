using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// 最长回文子串
    /// 1、遍历字符串每一个字符，以该字符为中心向左右逐步扩展，判断两侧是否相等，如是则构成更长回文串，继续扩展，否则处理下一个字符；根据回文字符串长度的奇偶性分别判断；
    /// 2、动态规划方法，利用已知的回文子串来计算更大的回文子串；
    /// </summary>
    class LongestPalindromicSubString
    {
        public static string LongestPalindrome(string s)
        {
            int len = s.Length;
            if (len == 1) return s;
            int maxLen = 0;
            string result = "";
            for (int i = 0; i < len; i++)
            {
                // 不可能再有更长的子串了
                if (len - i + 1 < maxLen / 2)
                    break;

                int start = i;
                int end = i;
                while (start >= 0 && end < len)
                {
                    if (s[start] == s[end])
                    {
                        if (end - start + 1 > maxLen)
                        {
                            maxLen = end - start + 1;
                            result = s.Substring(start, maxLen);
                        }
                        start--;
                        end++;
                    }
                    else
                    {
                        break;
                    }
                }

                start = i;
                end = i + 1;
                while (start >= 0 && end < len)
                {
                    if (s[start] == s[end])
                    {
                        if (end - start + 1 > maxLen)
                        {
                            maxLen = end - start + 1;
                            result = s.Substring(start, maxLen);
                        }
                        start--;
                        end++;
                    }
                    else
                    {
                        break;
                    }

                }
            }

           

            Console.WriteLine(result);
            return result;
        }

        public static string LongestPalidromeDP(string s)
        {
            return "";
        }
    }
}
