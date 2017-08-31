using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace DiagnoseAssistant1
{
    public class EpisodeRegexUtils
    {
        public static Episode getEpisodeFromUrl(string url)
        {
            Regex rxPEID = new Regex(@"PatientID=(\d+)&EpisodeID=(\d+)&mradm=", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            Match m = rxPEID.Match(url);

            Episode epi = new Episode();
            //此属性判断是否匹配成功
            while (m.Success)
            {                
                //这里为什么要从下标1开始，因为下面获取组时：
                //下标0为一个整组，是根据匹配规则“(\w+)\s+(car)”获取的整组
                //下标1为第一个小括号里面的数据
                //下标2为第二个括号里面的数据....依次论推
                
                Group g1 = m.Groups[1];
                epi.PatientID = g1.ToString();

                Group g2 = m.Groups[2];
                epi.EpisodeID = g2.ToString();
                    
                //匹配下一个
                m = m.NextMatch();
            }
            return epi;
        }
    }
}
