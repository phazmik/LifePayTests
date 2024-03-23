using System.Diagnostics;
using TechTalk.SpecFlow;

namespace StepDefinitions
{
    [Binding]
    public class ToolSteps
    {
        [AfterTestRun]
        public static void AfterTestRun()
        {
            var processes = Process.GetProcesses();
            foreach (var process in processes)
            {
                try
                {
                    Debug.WriteLine(process.ProcessName);
                    var shouldKill = false;
                    foreach (var processName in new List<string> { "chrome", "webdriver" })
                    {
                        if (process.ProcessName.ToLower().Contains(processName))
                        {
                            shouldKill = true;
                            break;
                        }
                    }
                    if (shouldKill)
                    {
                        process.Kill();
                    }
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e);
                }
            }
        }
    }
}
