using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPApp.Model
{
    class WorkReport
    {
        private readonly List<WorkReportEntry> entries;
        public WorkReport()
        {
            entries = new List<WorkReportEntry>();
        }
        public void AddEntry(WorkReportEntry entry) => entries.Add(entry);
        public void RemoveEntryAt(int index) => entries.RemoveAt(index);
        public override string ToString() =>
            string.Join(Environment.NewLine, entries.Select(x => $"Code: {x.ProjectCode}, " +
            $"Name: {x.ProjectName}, Hours: {x.SpentHours}"));

        // Here we are violating the princpal of SRP, beacuse it says the class should have one job to done,
        // so we can make new class for Save to File
        /*public void SaveToFile(string directoryPath, string fileName)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            File.WriteAllText(Path.Combine(directoryPath, fileName), ToString());
        }*/
    }
}
