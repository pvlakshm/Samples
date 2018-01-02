namespace OutOfProcDataCollector
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    using Microsoft.VisualStudio.TestPlatform.ObjectModel.DataCollection;


    [DataCollectorFriendlyName("SampleDataCollector")]
    [DataCollectorTypeUri("my://sample/datacollector")]
    public class SampleDataCollector : DataCollector, ITestExecutionEnvironmentSpecifier
    {
        private DataCollectionSink dataCollectionSink;
        private DataCollectionEnvironmentContext context;
        private DataCollectionLogger logger;
        private string tempDirectoryPath = Path.GetTempPath();

        public override void Initialize(
            System.Xml.XmlElement configurationElement,
            DataCollectionEvents events,
            DataCollectionSink dataSink,
            DataCollectionLogger logger,
            DataCollectionEnvironmentContext environmentContext)
        {
            events.SessionStart += this.SessionStarted_Handler;
            events.SessionEnd += this.SessionEnded_Handler;
            events.TestCaseStart += this.Events_TestCaseStart;
            events.TestCaseEnd += this.Events_TestCaseEnd;
            this.dataCollectionSink = dataSink;
            this.context = environmentContext;
            this.logger = logger;
        }

        private void Events_TestCaseEnd(object sender, TestCaseEndEventArgs e)
        {
            this.logger.LogWarning(this.context.SessionDataCollectionContext, e.TestCaseName + " end " + DateTime.UtcNow.Ticks.ToString());
        }

        private void Events_TestCaseStart(object sender, TestCaseStartEventArgs e)
        {
            this.logger.LogWarning(this.context.SessionDataCollectionContext, e.TestCaseName + " start " + DateTime.UtcNow.Ticks.ToString());
        }

        private void SessionStarted_Handler(object sender, SessionStartEventArgs args)
        {
           
        }

        private void SessionEnded_Handler(object sender, SessionEndEventArgs args)
        {
            
        }

        public IEnumerable<KeyValuePair<string, string>> GetTestExecutionEnvironmentVariables()
        {
            return new List<KeyValuePair<string, string>> { new KeyValuePair<string, string>("key", "value") };
        }
    }
}