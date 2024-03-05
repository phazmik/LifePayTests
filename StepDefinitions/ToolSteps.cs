using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace LifePayTests.StepDefinitions
{
    [Binding]
    public class ToolSteps
    {
        private readonly ScenarioContext _scenarioContext;
        public ToolSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

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
