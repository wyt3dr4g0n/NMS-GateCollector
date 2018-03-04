using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace NMS_GateCollector
{
    static class NMS_GateCollector
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
        }

        static DirectoryInfo GetSaveDir()
        {
            string dir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\HelloGames\\NMS\\";
            DirectoryInfo di = new DirectoryInfo(dir).GetDirectories().OrderByDescending(d => d.LastWriteTime).First();
            return di;
        }

        public static List<Planet> LoadPlanets()
        {
            Regex fileSearch = new Regex(@"save\d?.hg");
            FileInfo[] files = GetSaveDir()
                .GetFiles("save*.hg")
                .Where(path => fileSearch.IsMatch(path.Name))
                .ToArray();
            List<Record> planetRecords = new List<Record>();
            List<Planet> planets = new List<Planet>();

            foreach (FileInfo file in files)
            {
                StreamReader r = new StreamReader(file.FullName);
                string json = r.ReadToEnd();
                SaveData data = SaveData.FromJson(json);
                planetRecords.AddRange(data.DiscoveryManagerData.DiscoveryDataV1.Store.Record.Where(d => d.Dd.Dt == "Planet"));
                r.Dispose();
            }

            Console.WriteLine("Loaded all files");

            planets = planetRecords
                .Select(p => new Planet(p)).ToList()
                             .Distinct(new PlanetEqualityComparator())
                             .OrderByDescending(p => p.HasCustom)
                             .ThenBy(p => p.Discoverer)
                             .ThenBy(p => p.Galaxy)
                             .ThenBy(p => p.Name)
                             .ToList();
            return planets;
        }

    }

}
