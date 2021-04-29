using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace winFormRe
{
    public class UrlP
    {
        public string url { get; set; }
        public Boolean isRequested { get; set; }

        public string successOrNot { get; set; }

        public UrlP(string url, bool isRequested,Boolean flag)
        {
            this.url = url;
            this.isRequested = isRequested;
            this.successOrNot = flag ? "success" : "fail";
        }

        public UrlP()
        {

        }

        public override bool Equals(object obj)
        {
            return obj is UrlP p &&
                   url == p.url;
        }
    }
    public class SimpleCrawler
    {
        public List<UrlP> urList;
        private int count = 0;

        public SimpleCrawler()
        {
            urList = new List<UrlP>();
        }

        public void Crawl()
        {
            while (true)
            {
                string current = null;
                foreach (UrlP urlTemp in urList)
                {
                    if (urlTemp.isRequested) continue;
                    if (urlTemp.successOrNot=="success"?false:true) continue;
                    current = urlTemp.url;
                }

                if (current == null || count > 10) break;
                string html = DownLoad(current); // 下载

                foreach (UrlP urlTemp in urList)
                {
                    if (urlTemp.url == current)
                    {
                        urlTemp.isRequested = true;
                        break;
                    }
                }
                count++;
                Parse(current, html);//解析,并加入新的链接
            }
        }

        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }

        private void Parse(string current, string html)
        {
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                Boolean successOrNot = true;
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                          .Trim('"', '\"', '#', '>');
                Uri uriTemp = new Uri(urList[0].url);
                string pattern = uriTemp.Host;
                //获取指定网站网页
                /*if (!Regex.IsMatch(strRef, @pattern))
                {
                    continue;
                }*/

                //判断结尾
                /*if (!Regex.IsMatch(strRef, @"(html|aspx|jsp)$"))
                    continue;*/

                //将相对路径转变为绝对路径
                if (!Regex.IsMatch(strRef,@"^(http:|https:)"))
                {
                    if (Regex.IsMatch(strRef, @"(.html)$"))
                    {
                        strRef = current + strRef;
                        successOrNot = true;
                    }
                    else
                        successOrNot = false;
                }
                if (strRef.Length == 0) continue;
                UrlP urlIn = new UrlP(strRef, false, successOrNot);
                Boolean flag = true;
                foreach(UrlP urlTemp in urList)
                {
                    if (urlTemp.Equals(urlIn)){
                        flag = false;
                    }
                }
                if (flag)
                {
                    urList.Add(urlIn);
                }

            }
        }
    }
}

