using CsvHelper;
using MetroFramework;
using MetroFramework.Controls;
using Microsoft.Office.Interop.Excel;
using ReadingFromExcel.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadingFromExcelFile
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        MetroTabPage GrdtabPage;
       MetroFramework.Controls.MetroGrid  tabGridview;
        OpenFileDialog fileDialogue;
        ExcelReader Reader;
        public Form1()
        {
            InitializeComponent();
            filenameTxt.Text = "";
        }

        private void CmdExist_Click(object sender, EventArgs e)
        {
            string PeriodDate = periodDate.Text;
            fileDialogue = new OpenFileDialog();
            fileDialogue.ShowDialog();
            string filename = fileDialogue.FileName;
            Reader = new ExcelReader(filename);
            filenameTxt.Text = filename;
            System.Data.DataTable SheetNames = Reader.GetSheetsNames();
            treeView1.Nodes.Clear();
            foreach (DataRow row in SheetNames.Rows)
            {
                treeView1.Nodes.Add(row["TABLE_NAME"].ToString().Split('$')[0].StartsWith("'") ? row["TABLE_NAME"].ToString().Split('$')[0].Remove(0,1) : row["TABLE_NAME"].ToString().Split('$')[0]);
            }
            treeView2.Nodes.Add("Redwood").Nodes.Add(PeriodDate).Nodes.Add("PRA110");

            metroTabControl1.Visible = true;
        }

        private async void RibbonButton4_Click(object sender, EventArgs e)
        {
            if(filenameTxt.Text != "")
            {
                string NodeFileName = NodeName.Text;
                Loader loading = new Loader();
                loading.Show();
                Task<bool> task = Reader.SaveFileToDB(NodeFileName);
                bool check = await task;

                if (check)
                {
                    loading.Hide();
                    MetroMessageBox.Show(this, "Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MetroMessageBox.Show(this, "Saving failed...", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                    
            }
            else
            {
                MetroMessageBox.Show(this, "", "No file selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void CmdNew_Click(object sender, EventArgs e)
        {
            if (filenameTxt.Text != "")
            {
                filenameTxt.Text = "";
                NodeName.Text = "";
                tabGridview = new MetroGrid();
                tabGridview.Name = "tabGridView";
                tabGridview.Dock = DockStyle.Fill;
                
                treeView1.Nodes.Clear();
                treeView2.Nodes.Clear();
                GrdtabPage.Text = "";
                GrdtabPage.Controls.Clear();
                metroTabControl2.Controls.Clear();
                tabGridview.DataSource = null;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TreeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
            Padding pading = new Padding();
            pading.Top = 30;
            // MetroFramework.Controls.MetroTabControl a
            string filename = filenameTxt.Text;
            NodeName.Text = e.Node.Text;

            tabGridview = new MetroFramework.Controls.MetroGrid();
            tabGridview.Name = "tabGridView";
            tabGridview.Dock = DockStyle.Fill;
            tabGridview.GridColor = Color.BurlyWood;

            GrdtabPage = new MetroTabPage();
            GrdtabPage.Text = e.Node.Text;
            GrdtabPage.Padding = pading;
            GrdtabPage.Controls.Add(tabGridview);



            metroTabControl2.Style = MetroColorStyle.Blue;
            metroTabControl2.SelectedTab = GrdtabPage;
            metroTabControl2.Controls.Add(GrdtabPage);

            System.Data.DataTable GrdData = Reader.GetGridData(e.Node.Text);
            tabGridview.DataSource = GrdData;
            tabGridview.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
    }
}
