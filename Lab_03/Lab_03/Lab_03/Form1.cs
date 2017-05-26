using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PR_Lab3_Sample
{
     public partial class Form1 : Form
     {
          public Form1()
          {
               InitializeComponent();
          }


          private void searchBtn_Click(object sender, EventArgs e)
          {
               try
               {
                    searchBtn.Enabled = false;
                    searchRichTextBox.Text = "";

                    var req = WebRequest.Create(textBox1.Text);
                    var resp = req.GetResponse();
                    var dataStream = resp.GetResponseStream();
                    var reader = new StreamReader(dataStream);
                    var respFromServer = reader.ReadToEnd();
                    textBox1.Text = ((HttpWebResponse)resp).StatusCode.ToString();
                    var pattern = @"(((http|https|ftp)+\:\/\/)[&#95;.a-z0-9-]+\.[a-z0-9\/&#95;:@=.+?,##%&~-]*[^.|\'|""|\# |!|\(|?,| |>|<|;|\)])";
                    var matches = Regex.Matches(respFromServer, pattern, RegexOptions.Singleline);

                    foreach (var link in from Match match in matches select match.Groups[1].Value)
                    {
                         try
                         {
                              var reqt = WebRequest.Create(link);
                              var respt = reqt.GetResponse();
                              searchRichTextBox.AppendText("\n" + link + " " + ((HttpWebResponse)respt).StatusCode);
                              respt.Close();
                         }
                         catch (Exception ex1)
                         {
                              searchRichTextBox.AppendText("\n" + link + ex1.Message);
                         }
                    }

                    searchBtn.Enabled = true;
               }
               catch (Exception ex)
               {
                    MessageBox.Show(ex.Message);
                    searchBtn.Enabled = true;
               }
          }

          private async void PostRequest(string url)
          {
               IEnumerable<KeyValuePair<string, string>> queries = new List<KeyValuePair<string, string>>()
               {
                    new KeyValuePair<string, string>("FirstPost", "hello"),
                    new KeyValuePair<string, string>("SecondPost", "world")
               };
               HttpContent posContent = new FormUrlEncodedContent(queries);
               using (var client = new HttpClient())
               {
                    using (var response = await client.PostAsync(url, posContent))
                    {
                         using (var content = response.Content)
                         {
                              var myContent = await content.ReadAsStringAsync();
                              methodsRichTextBox.AppendText(myContent.ToString());
                              Console.WriteLine(myContent);
                         }
                    }
               }
          }

          private void post_btn_Click(object sender, EventArgs e)
          {
               methodsRichTextBox.Clear();
               PostRequest(textBox2.Text);
          }
          private async void getHead(string url)
          {
               HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Head, url);


               using (var client = new HttpClient())
               {

                    using (var response = await client.SendAsync(request))
                    {
                         using (var content = response.Content)
                         {

                              methodsRichTextBox.AppendText(response.Headers.ToString());
                              methodsRichTextBox.AppendText(response.RequestMessage.ToString());

                         }


                    }


               }
          }

          private async void GetRequest(string url)
          {
               using (var client = new HttpClient())
               {
                    using (var response = await client.GetAsync(url))
                    {
                         using (var content = response.Content)
                         {

                              var mycontent = await content.ReadAsStringAsync();
                              methodsRichTextBox.AppendText(mycontent.ToString());

                              methodsRichTextBox.AppendText(response.Headers.ToString());
                              methodsRichTextBox.AppendText("Content-Type:" + response.Content.Headers.ContentType.ToString() + "\n");

                              methodsRichTextBox.AppendText("Content length:" + response.Content.Headers.ContentLength.ToString() + "\n");
                              methodsRichTextBox.AppendText(response.Headers.Upgrade.ToString());

                            





                         }
                    }
               }
          }

          private void get_btn_Click(object sender, EventArgs e)
          {
               methodsRichTextBox.Clear();
               GetRequest(textBox2.Text);
          }

          private void Form1_Load(object sender, EventArgs e)
          {

          }
          private void textBox1_TextChanged(object sender, EventArgs e)
          {
              
          }
          private void Head_Click(object sender, EventArgs e)
          {
               methodsRichTextBox.Clear();
               getHead(textBox2.Text);
          }

     }
}