using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Statistics
    {
        DataTable dataTable = new DataTable();

        public Statistics()
        {
            setDataTable();

        }
        public void setDataTable()
        {

            string startupPath = System.AppDomain.CurrentDomain.BaseDirectory;
            var pathItems = startupPath.Split(Path.DirectorySeparatorChar);
            string projectPath = String.Join(Path.DirectorySeparatorChar.ToString(), pathItems.Take(pathItems.Length - 3));
            string statFile = projectPath + "\\Statistics.txt";

            // statGrid.Dock = DockStyle.Fill;

            //Read the data from text file
            string[] textData = System.IO.File.ReadAllLines(statFile);
            string[] headers = textData[0].Split(':');

            //Create and populate DataTable
            
            foreach (string header in headers)
                dataTable.Columns.Add(header, typeof(string), null);
            for (int i = 1; i < textData.Length; i++)
                dataTable.Rows.Add(textData[i].Split(','));

           





        }
        public DataTable getDataTable()
        {
            return dataTable;
        }

        public void updateStatistics(String player,int wins,int losses)
        {
            
            string startupPath = System.AppDomain.CurrentDomain.BaseDirectory;
            var pathItems = startupPath.Split(Path.DirectorySeparatorChar);
            string projectPath = String.Join(Path.DirectorySeparatorChar.ToString(), pathItems.Take(pathItems.Length - 3));
            string statFile = projectPath + "\\Statistics.txt";
            bool playerExists = false;
          
            int currCount = dataTable.Rows.Count;
 
                var originalStats = File.ReadAllLines(statFile);
                var updatedLines = new List<string>();

                foreach(var line in originalStats)
                {
                    string[] lineInfo = line.Split(',');
                if (lineInfo[0] == player)
                {
                    //update
                    playerExists = true;
                    lineInfo[1] = (int.Parse(lineInfo[1]) + wins).ToString();
                    lineInfo[2] = (int.Parse(lineInfo[2]) + losses).ToString();
                    
                }
                
                updatedLines.Add(string.Join(",", lineInfo));
                }
                File.WriteAllLines(statFile, updatedLines);
                
            if(playerExists==false)
            {
                StreamWriter sw = new StreamWriter(statFile, true);
                sw.WriteLine(player + "," + wins + "," + losses);
                  sw.Close();
            }
          

        }

    }
}
