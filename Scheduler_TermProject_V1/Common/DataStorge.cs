using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using Common;

namespace Common
{
    class DataStorge
    {
        protected string fileLocation = System.Windows.Forms.Application.StartupPath;
        protected string fileName = "data.xlsx";


        public DataStorge()
        {
            this.fileLocation = System.Windows.Forms.Application.StartupPath;
            this.fileName = "data.xlsx";
        }

        public DataStorge(string fileLocation, string fileName)
        {
            this.fileLocation = fileLocation;
            this.fileName = fileName;
        }

        public List<Process> GetProcesses()
        {
            List<Process> result = new List<Process>();

            Microsoft.Office.Interop.Excel.Application application = null;
            Workbook workbook = null;
            Worksheet worksheet = null;

            try
            {
                application = new Microsoft.Office.Interop.Excel.Application();
                application.Visible = false;
                application.DisplayAlerts = false;

                workbook = application.Workbooks.Open($@"{this.fileLocation}\{this.fileName}");
                worksheet = workbook.Worksheets.get_Item(1);
                
                Range range = worksheet.UsedRange;
                for (int row = 2; row <= range.Rows.Count; row++)
                {
                    Process process = new Process();

                    process.PID = Convert.ToString((range.Cells[row, 1]).Value2);
                    process.arrivalTime = Convert.ToInt32((range.Cells[row, 2] as Range).Value2);
                    process.serviceTime = Convert.ToInt32((range.Cells[row, 3] as Range).Value2.ToString());
                    process.priority = Convert.ToDouble((range.Cells[row, 4] as Range).Value2.ToString());
                    process.timeQuantum = Convert.ToInt32((range.Cells[row, 5] as Range).Value2.ToString());

                    result.Add(process);
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex);
                result = new List<Process>();
            }
            finally
            {
                workbook.Close(true);
                application.Quit();

                Marshal.ReleaseComObject(workbook);
                Marshal.ReleaseComObject(application);
            }

            return result;
        }

        public bool SaveProcesses(List<Process> processes)
        {
            bool result = true;

            Microsoft.Office.Interop.Excel.Application application = null;
            Workbook workbook = null;
            Worksheet worksheet = null;

            try
            {
                application = new Microsoft.Office.Interop.Excel.Application();
                application.Visible = false;
                application.DisplayAlerts = false;

                workbook = application.Workbooks.Open($@"{this.fileLocation}\{this.fileName}");
                worksheet = workbook.Worksheets.get_Item(1);
                worksheet.Cells.ClearContents();

                worksheet.Cells[1, 1] = "processId";
                worksheet.Cells[1, 2] = "arriveTime";
                worksheet.Cells[1, 3] = "serviceTime";
                worksheet.Cells[1, 4] = "priority";
                worksheet.Cells[1, 5] = "timeQuantum";

                for (int i = 0; i < processes.Count; i++)
                {
                    worksheet.Cells[i + 2, 1] = processes[i].PID;
                    worksheet.Cells[i + 2, 2] = processes[i].arrivalTime;
                    worksheet.Cells[i + 2, 3] = processes[i].serviceTime;
                    worksheet.Cells[i + 2, 4] = processes[i].priority;
                    worksheet.Cells[i + 2, 5] = processes[i].timeQuantum;
                }
            }
            catch
            {
                result = false;
            }
            finally
            {
                workbook.Save();
                workbook.Close(true);
                application.Quit();

                Marshal.ReleaseComObject(workbook);
                Marshal.ReleaseComObject(application);
            }

            return result;
        }

        public System.Data.DataTable GetData()
        {
            System.Data.DataTable result = new System.Data.DataTable();

            Microsoft.Office.Interop.Excel.Application application = null;
            Workbook workbook = null;
            Worksheet worksheet = null;

            try
            {
                application = new Microsoft.Office.Interop.Excel.Application();
                application.Visible = false;
                application.DisplayAlerts = false;

                workbook = application.Workbooks.Open($@"{this.fileLocation}\{this.fileName}");
                worksheet = workbook.Worksheets.get_Item(1);
            }
            catch
            {
                result = new System.Data.DataTable();
            }
            finally
            {
                workbook.Save();
                workbook.Close(true);
                application.Quit();

                Marshal.ReleaseComObject(workbook);
                Marshal.ReleaseComObject(application);
            }

            return result;
        }
    }
}
