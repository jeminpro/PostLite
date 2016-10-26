using PostLite.Model;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using System.Net;
using System;
using System.Text;

namespace PostLite
{
    internal static class Util
    {
        internal static List<HeaderKeyValue> ParseHeaderAndRemoveInvalid(DataGridView dataGridView)
        {
            var header = new List<HeaderKeyValue>();

            for(int i=0; i < dataGridView.RowCount; i++)
            {                
                var row = dataGridView.Rows[i];

                if (row.IsNewRow)
                    continue;

                var key = string.Format("{0}", row.Cells["Key"].Value);
                var value = string.Format("{0}", row.Cells["Value"].Value);

                if (string.IsNullOrWhiteSpace(key) || string.IsNullOrWhiteSpace(value))
                {
                    dataGridView.Rows.RemoveAt(row.Index);
                    i--;
                }
                else
                {
                    header.Add(new HeaderKeyValue { HeaderKey = key, HeaderValue = value });
                }
            }

            return header;
        }

        internal static string Serialize<T>(this T toSerialize)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            StringWriter textWriter = new StringWriter();
            xmlSerializer.Serialize(textWriter, toSerialize);
            return textWriter.ToString();
        }

        internal static T Deserialize<T>(this string toDeserialize)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            StringReader textReader = new StringReader(toDeserialize);
            return (T)xmlSerializer.Deserialize(textReader);
        }

        internal static PostResponse WebClientPost(PostRequest postRequest)
        {
            var postResponse = new PostResponse();            

            using (WebClient wc = new WebClient())
            {
                var sw = new System.Diagnostics.Stopwatch();

                foreach (var header in postRequest.Header)
                {
                    wc.Headers.Add(header.HeaderKey, header.HeaderValue);                    
                }
                
                try
                {
                    sw.Start();
                    postResponse.ResponseBody = wc.UploadString(postRequest.URL, "POST", postRequest.Body);
                    sw.Stop();

                    postResponse.StatusCode = "OK";
                }
                catch (Exception ex)
                {
                    postResponse.StatusCode = "Error";
                    postResponse.ResponseBody = ex.Message;
                }
                
                

                if (sw.Elapsed.TotalSeconds > 1)
                    postResponse.Time = string.Format("{0:0.00} s", sw.Elapsed.TotalSeconds);
                else
                    postResponse.Time = string.Format("{0:000} ms", sw.Elapsed.TotalMilliseconds);

            }

            return postResponse;
        }

        internal static PostResponse HttpWebRequestPost(PostRequest postRequest)
        {
            var postResponse = new PostResponse();

            var sw = new System.Diagnostics.Stopwatch();
            sw.Start();

            WebRequest request = WebRequest.Create(postRequest.URL);
            request.Method = "POST";
            foreach (var header in postRequest.Header)
            {
                request.Headers.Add(header.HeaderKey, header.HeaderValue);
            }

            byte[] byteArray = Encoding.UTF8.GetBytes(postRequest.Body);
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();
            WebResponse response = request.GetResponse();
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            postResponse.ResponseBody = reader.ReadToEnd();

            HttpWebResponse httpWebResponse = (HttpWebResponse)response;
            postResponse.StatusCode = string.Format("{0} {1}", (int)httpWebResponse.StatusCode, httpWebResponse.StatusDescription);
            reader.Close();
            dataStream.Close();
            response.Close();

            sw.Stop();
            if (sw.Elapsed.TotalSeconds > 1)
                postResponse.Time = string.Format("{0:0.00} s", sw.Elapsed.TotalSeconds);
            else
                postResponse.Time = string.Format("{0:000} ms", sw.Elapsed.TotalMilliseconds);

            return postResponse;
        }
    }
}
