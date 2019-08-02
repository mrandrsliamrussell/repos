using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using Xceed.Words.NET;

namespace lab55_csv_word_excel
{
    class Program
    {
        static void Main(string[] args)
        {
            File.Delete("output.csv");
            
            File.AppendAllText("output.csv", "seconds, rabbitPopulation");
            for (int i = 0; i < 10; i++)
            {
                File.AppendAllText("output.csv", $" \n{i}, { i * 2 }");
            }

           // Process.Start("output.csv");
            //using word
            //1) nuget Docx
            //2) nuget Microsoft office

            var rabbitpopulation = 1;
            var limit = 5000000;
            var seconds = 0;
            var document = DocX.Create("rabbitpopulationExplosion.docx");
            var spreadsheet = 
            document.InsertParagraph("This is a document about the explosion of the rabbit population in sparta london");

            while(rabbitpopulation < limit)
            {
                seconds++;
                rabbitpopulation += 2;
               // document.InsertParagraph($"the rabbits grow stronger, there are {rabbitpopulation} of them.");
            }
            //document.Save();
            //Process.Start("WinWord.exe", "rabbitpopulationExplosion.docx");


            Microsoft.Office.Interop.Excel.Application oXL;
            Microsoft.Office.Interop.Excel._Workbook oWB;
            Microsoft.Office.Interop.Excel._Worksheet oSheet;
            Microsoft.Office.Interop.Excel.Range oRng;

            object misvalue = System.Reflection.Missing.Value;
            try
            {
                //Start Excel and get Application object.
                oXL = new Microsoft.Office.Interop.Excel.Application();
                oXL.Visible = true;

                //Get a new workbook.
                oWB = (Microsoft.Office.Interop.Excel._Workbook)(oXL.Workbooks.Add(""));
                oSheet = (Microsoft.Office.Interop.Excel._Worksheet)oWB.ActiveSheet;

                //Add table headers going cell by cell.
                
                oSheet.Cells[2, 10] = "hello";

               

                


                rabbitpopulation = 1;
                seconds = 0;
                while(rabbitpopulation < limit)
                {
                    seconds++;
                    rabbitpopulation*=2;
                    oSheet.Cells[seconds + 5, 4] = rabbitpopulation;
                    oSheet.Cells[seconds + 5, 3] = "Rabbit";
                }



               // oXL.Visible = false;
               // oXL.UserControl = false;
                // saves in My Documents
                /*oWB.SaveAs("test506.xls", Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing,
                    false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);*/

       
               
               //  oWB.Close();
              

            }
            catch (Exception e)
            {

            }
            System.Threading.Thread.Sleep(1000);
           

        }
    }
}
