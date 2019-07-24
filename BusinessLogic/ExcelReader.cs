using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ReadingFromExcel.BusinessLogic
{
     class ExcelReader
    {
        string _connectionString;
        public ExcelReader(string fileName)
        {
            _connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={fileName};Extended Properties='Excel 8.0;HDR=YES;IMEX=1;';";
        }

        #region Retrieving data actions from database
        public System.Data.DataTable GetSheetsNames()
        {
            try
            {
                DbProviderFactory objDbFactory = DbProviderFactories.GetFactory("System.Data.OleDb");

                DbDataAdapter objDbAdapter = null;

                objDbAdapter = objDbFactory.CreateDataAdapter();

                DbConnection objDbConnection = objDbFactory.CreateConnection();

                objDbConnection.ConnectionString = _connectionString;

                objDbConnection.Open();

                System.Data.DataTable objSheetNames = objDbConnection.GetSchema("Tables");

                return objSheetNames;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public System.Data.DataTable GetGridData(string NodeText)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(_connectionString);
                OleDbCommand oconn = new OleDbCommand(@"Select * From [" + NodeText + "$]", con);
                con.Open();
                OleDbDataAdapter sda = new OleDbDataAdapter(oconn);
                System.Data.DataTable data = new System.Data.DataTable();
                sda.Fill(data);
                con.Close();

                return data;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        #endregion

        #region Saving To DataBase and cell address making logic
        public async Task<bool> SaveFileToDB(string NodeName)
        {
            try
            {
               await Task.Run(() =>
                {
                    OleDbConnection con = new OleDbConnection(_connectionString);
                    OleDbCommand oconn2 = new OleDbCommand($@"Select F4,F7,F8,F9,F10,F11,F12,F13,F14,F15,F16,F17,F18,F19,F20
                                                            , F21, F22, F23, F24, F25, F26, F27, F28, F29, F30
                                                            , F31, F32, F33, F34, F35, F36, F37, F38, F39, F40
                                                            , F41, F42, F43, F44, F45, F46, F47, F48, F49, F50
                                                            , F51, F52, F53, F54, F55, F56, F57, F58, F59, F60
                                                            , F61, F62, F63, F64, F65, F66, F67, F68, F69, F70
                                                            , F71, F72, F73, F74, F75, F76, F77, F78, F79, F80
                                                            , F81, F82, F83, F84, F85, F86, F87, F88, F89, F90
                                                            , F91, F92, F93, F94, F95, F96, F97, F98, F99, F100
                                                            , F101, F102, F103, F104, F105, F106, F107, F108, F109, F110
                                                            , F111, F112, F113, F114, F115 From [{NodeName}$]", con);

                    OleDbDataAdapter sda2 = new OleDbDataAdapter(oconn2);
                    System.Data.DataTable data2 = new System.Data.DataTable();
                    sda2.Fill(data2);
                    int count = 0;
                    string columnValue = "";
                    string rowValue = "";
                    string ValueOfConcatenatedfield = "";
                    for (int i = 1; i < data2.Columns.Count; i++)
                    {
                        for (int j = 16; j < data2.Rows.Count; j++)
                        {
                            if (count == 0)
                            {
                                columnValue = data2.Rows[j][i].ToString();
                            }
                            count++;
                            if (!String.IsNullOrEmpty(data2.Rows[j][0].ToString()))
                            {
                                rowValue = data2.Rows[j][0].ToString();
                                ValueOfConcatenatedfield = data2.Rows[j][i].ToString();
                                string cellAddress = $"FSA_{columnValue}_R{rowValue}";
                                string cellValue = ValueOfConcatenatedfield;

                                string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell\source\repos\ReadingFromExcelFile\CurrencySheetsDB.mdf;Integrated Security=True";

                                using (SqlConnection connection = new SqlConnection(_connectionString))
                                {
                                    String query = "INSERT INTO dbo.CurrencySheetsData (CellAddress,CellValue) VALUES (@CellAddress,@CellValue)";

                                    using (SqlCommand command = new SqlCommand(query, connection))
                                    {
                                        command.Parameters.AddWithValue("@CellAddress", cellAddress);
                                        command.Parameters.AddWithValue("@CellValue", cellValue);
                                        connection.Open();
                                        int result = command.ExecuteNonQuery();

                                        // Check Error
                                        if (result < 0)
                                            Console.WriteLine("Error inserting data into Database!");
                                    }
                                }
                            }

                        }
                        count = 0;
                    }

                });
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
            
        }
        #endregion

        #region commented Work to use in furutre, if needed
        //private string CurrentDirectory;
        //public void readingAndPrintingValuesFromCells()
        //{
        //    string DirectoryPathToGetFiles = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "");
        //    string pathToGetFiles = Path.GetFullPath(Path.Combine(DirectoryPathToGetFiles, @"..\\..\\excelfiles\\bankData.xlsx"));
        //    Excel.Application xlApp = new Excel.Application();

        //    Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(pathToGetFiles);
        //    Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
        //    Excel.Range xlRange = xlWorksheet.UsedRange;

        //    int rowCount = xlRange.Rows.Count;
        //    int colCount = xlRange.Columns.Count;
        //    string CellValue = "";

        //    for (int i = 1; i <= rowCount; i++)
        //    {
        //        for (int j = 1; j <= colCount; j++)
        //        {
        //            //new line
        //            if (j == 1)
        //               // Console.Write("\r\n");

        //            if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
        //               CellValue =  xlRange.Cells[i, j].Value2.ToString();
        //        }
        //    }


        //    GC.Collect();
        //    GC.WaitForPendingFinalizers();

        //    Marshal.ReleaseComObject(xlRange);
        //    Marshal.ReleaseComObject(xlWorksheet);

        //    //close and release
        //    xlWorkbook.Close();
        //    Marshal.ReleaseComObject(xlWorkbook);

        //    //quit and release
        //    xlApp.Quit();
        //    Marshal.ReleaseComObject(xlApp);
        //}
        #endregion
    }
}
