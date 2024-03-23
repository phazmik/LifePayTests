using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace Support
{
    public static class ToolsForTests
    {
        public static void setSystemTime(string timeInYourSystemFormat)
        {
            var proc = new ProcessStartInfo();
            proc.UseShellExecute = true;
            proc.WorkingDirectory = @"C:\Windows\System32";
            proc.CreateNoWindow = true;
            proc.FileName = @"C:\Windows\System32\cmd.exe";
            proc.Verb = "runas";
            proc.Arguments = "/C time " + timeInYourSystemFormat;
            try
            {
                Process.Start(proc);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }
        }
        
        public static async Task<string> GetAPITimeMoscow()
        {
            try
            {
                HttpClient client = new HttpClient();
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
