using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject.Hooks
{
    [Binding]
    public class Runner
    {
        public static IConfigurationRoot configurationRoot;
        public static Configuration config;

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            //1.Configuration file or information
            //2. Container Initialization
            string path = "C:\\Users\\athar\\source\\CSharpbasics\\SpecflowSinghSir\\SpecFlowProject\\Configuration.json";

            ConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
            //configurationBuilder.AddJsonFile(path);
            //configurationRoot=configurationBuilder.AddEnvironmentVariables().Build();
            //configurationRoot.Bind(config);
            configurationRoot = configurationBuilder.AddJsonFile(path).AddEnvironmentVariables().Build();
        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureContext context)
        {
            //1.Information of the fetture files.
            Console.WriteLine("Before Feature");
            Console.WriteLine(context.FeatureInfo.Title);
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            Console.WriteLine("After feature");
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            //1.Release resources
            //2.We can use for reporting. Grouping the reports.
            Console.WriteLine("After test run");
        }
    }
}
