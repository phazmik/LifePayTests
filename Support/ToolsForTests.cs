using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using System.Diagnostics;

namespace LifePayTests.Support
{
    public class ToolsForTests
    {
        private readonly IWebDriver _driver;
        public ToolsForTests(IWebDriver driver)
        {
            _driver = driver;
        }
        public static void setTime(string timeInYourSystemFormat)
        {
            var proc = new System.Diagnostics.ProcessStartInfo();
            proc.UseShellExecute = true;
            proc.WorkingDirectory = @"C:\Windows\System32";
            proc.CreateNoWindow = true;
            proc.FileName = @"C:\Windows\System32\cmd.exe";
            proc.Verb = "runas";
            proc.Arguments = "/C time " + timeInYourSystemFormat;
            try
            {
                System.Diagnostics.Process.Start(proc);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }
        }
        static readonly HttpClient client = new HttpClient();

        public static async Task<string> GetAPITimeMoscow()
        {
            try
            {
                HttpResponseMessage responseMessage = await client.GetAsync("http://worldtimeapi.org/api/timezone/Europe/Moscow");
                responseMessage.EnsureSuccessStatusCode();
                string responseBody = await responseMessage.Content.ReadAsStringAsync();
                var response = JObject.Parse(responseBody);
                var datetime = response["datetime"];
                DateTime d = Convert.ToDateTime(datetime);
                return d.ToString("hh:mm:ss") + " " + d.ToString("tt");
            }
            catch (HttpRequestException e)
            {
                Debug.WriteLine("\nException Caught!");
                Debug.WriteLine("Message :{0} ", e.Message);
            }
            return "";
        }
    }

}
