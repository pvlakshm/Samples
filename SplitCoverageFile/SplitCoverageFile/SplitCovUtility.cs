using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Coverage.Interop;

namespace SplitCoverageFile
{
    class SplitCovUtility
    {
        public static void SplitCovFile(string coverageFile, string outputCoverageFilePath, bool includeSkippedMods)
        {
            try
            {
                if (!(CoverageData.IsValidCoverageFile(coverageFile)))
                {
                    throw new InvalidCoverageFileException(coverageFile);
                }
            }
            catch (InvalidCoverageFileException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new InvalidCoverageFileException(ex.Message, ex);
            }

            try
            {
                CoverageData.SplitCoverageFile(coverageFile, outputCoverageFilePath, includeSkippedMods, true);
            }
            catch (AnalysisException ex)
            {
                throw new InvalidCoverageFileException(ex.Message);
            }
        }

        private static void SplitCovFile(string[] args)
        {
            string outDir = null;
            string covInput = null;
            string outDirPath = null;
            string fileExt = "*.coverage";
            bool includeSkippedMods = false;

            covInput = args[0];

            if (args.Length > 1)
            {
                outDir = args[1];
                Directory.CreateDirectory(outDir);
            }

            if (args.Length > 2)
            {
                includeSkippedMods = Convert.ToBoolean(args[2]);
            }

            IEnumerable<string> covFiles = null;

            if (covInput.EndsWith(".coverage"))
            {
                if (!File.Exists(covInput))
                {
                    Console.WriteLine("Input coverage file does not exist!");
                    return;
                }

                covFiles = new string[] { covInput };
            }
            else
            {
                if (!Directory.Exists(covInput))
                {
                    Console.WriteLine("Input directory does not exist!");
                    return;
                }

                covFiles = Directory.EnumerateFiles(covInput, fileExt, SearchOption.AllDirectories);
            }

            foreach (string covdataFile in covFiles)
            {
                outDirPath = (outDir == null ? Path.GetDirectoryName(covdataFile) : outDir) + "\\";

                Console.WriteLine("Splitting Coverage File: " + covdataFile);

                try
                {
                    SplitCovFile(covdataFile, outDirPath, includeSkippedMods);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message.ToString());
                }
            }
        }

        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Usage: SplitCoverageFile.exe [input_coverage_file or input_coverage_dir] [output_cov_dir(Optional)] [write_skipped_module(Optional)(default = true)]");
                return;
            }

            var watch = System.Diagnostics.Stopwatch.StartNew();

            SplitCovFile(args);

            watch.Stop();
            Console.WriteLine("Total time taken: " + watch.Elapsed.Minutes + "mins " + watch.Elapsed.Seconds + "secs");
        }
    }
}
