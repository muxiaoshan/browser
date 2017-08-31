using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiagnoseAssistant1
{
    public class RegexTest
    {
        public static void Main()
        {
            test2();
        }
        static void test1()
        {
            // Define a regular expression for repeated words.
            Regex rx = new Regex(@"\b(?<word>\w+)\s+(\k<word>)\b", RegexOptions.Compiled | RegexOptions.IgnoreCase);

            // Define a test string.        
            string text = "The the quick brown fox  fox jumped over the lazy dog dog.";

            // Find matches.
            MatchCollection matches = rx.Matches(text);

            // Report the number of matches found.
            Console.WriteLine("{0} matches found.", matches.Count);

            // Report on each match.
            foreach (Match match in matches)
            {
                string word = match.Groups["word"].Value;
                int index = match.Index;
                Console.WriteLine("{0} repeated at position {1}", word, index);
            }
        }
        static void test2()
        {
            string url = "http://172.26.100.32/dthealth/web/csp/websys.csp?a=a&TMENU=50214&TPAGID=3242735760&TWKFLJ=websys.csp^1363680009&PatientID=783889&EpisodeID=2405124&mradm=2405124&WardID=69";
            Regex rxPEID = new Regex(@"PatientID=(\d+)&EpisodeID=(\d+)&mradm=", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            Match m = rxPEID.Match(url);
            //int matchCount = 0;

            //此属性判断是否匹配成功
            while (m.Success)
            {
                //匹配的个数
                //Console.WriteLine("Match" + (++matchCount));

                //这里为什么要从下标1开始，因为下面获取组时：
                //下标0为一个整组，是根据匹配规则“(\w+)\s+(car)”获取的整组
                //下标1为第一个小括号里面的数据
                //下标2为第二个括号里面的数据....依次论推
                for (int i = 1; i <= 2; i++)
                {
                    //获取由正则表达式匹配的组的集合,这行代码相当于下面两句
                    //GroupCollection gc = mt.Groups;
                    //Group g = gc[i];
                    Group g = m.Groups[i];
                    //输出
                    Console.WriteLine("Group" + i + "='" + g + "'");

                    //获取由捕获组匹配的所有捕获的集合
                    CaptureCollection cc = g.Captures;
                    for (int j = 0; j < cc.Count; j++)
                    {
                        Capture c = cc[j];

                        System.Console.WriteLine("Capture" + j + "='" + c + "', Position=" + c.Index);
                    }
                }
                //匹配下一个
                m = m.NextMatch();
            }
        }

    }
}
