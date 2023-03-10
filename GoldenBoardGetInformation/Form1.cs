using Connect.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoldenBoardGetInformation
{
    public partial class frmGoldenBoardGetInformation : Form
    {
        DataTable dt = new DataTable();
        DialogResult result = new DialogResult();
        IOException ex = new IOException();

        public frmGoldenBoardGetInformation()
        {
            InitializeComponent();
        }

        private void frmGoldenBoardGetInformation_Load(object sender, EventArgs e)
        {
            //------------Set default radio------------------
            rdoSN.Checked = true;
            rdoExcel.Checked = false;

            //------------Set default picLoad-----------
            pcbLoad.Visible = false;

            //------------Set default txt and button upload-----------
            txtSN.Enabled = true;
            btnUpload.Enabled = false;

            lbResult.Text = "";
        }

        private void rdoSN_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSN.Checked)
            {
                rdoExcel.Checked = false;
            }                        

            txtSN.Enabled = true;
            btnUpload.Enabled = false;
            lbResult.Text = "";
        }

        private void rdoExcel_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoExcel.Checked)
            {
                rdoSN.Checked = false;
            }                       

            txtSN.Enabled = false;
            btnUpload.Enabled = true;
            lbResult.Text = "";
        }

        private void txtSN_KeyDown(object sender, KeyEventArgs e)
        {
            //-------------SN Scan----------------------
            if (e.KeyCode == Keys.Enter)
            {
                lbResult.Text = "";
                txtSN.Enabled = false;
                rdoSN.Enabled = false;
                rdoExcel.Enabled = false;

                if (!bgwSNScan.IsBusy)
                {
                    pcbLoad.Visible = true;
                    bgwSNScan.RunWorkerAsync();
                }
            }
        }

        private void bgwSNScan_DoWork(object sender, DoWorkEventArgs e)
        {
            dt = new DataTable();
            dt = GetDataGoldenFromQTMCToQMBBySN(txtSN.Text.Trim());
        }

        private void bgwSNScan_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pcbLoad.Visible = false;
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["Result"].ToString().Trim() == "0")
                {
                    lbResult.Text = "SN: " + txtSN.Text.Trim() + " add information for goldenBoard finished.";
                }
                else
                {
                    lbResult.Text = "SN: " + txtSN.Text.Trim() + " " + dt.Rows[0]["Msg"].ToString().Trim();
                }

                txtSN.Text = "";
                txtSN.Enabled = true;
                rdoSN.Enabled = true;
                rdoExcel.Enabled = true;
            }
        }

        public DataTable GetDataGoldenFromQTMCToQMBBySN(string strSN)
        {
            DataTable dtTmp = new DataTable();
            ConnectDBQMBSMT oCon = new ConnectDBQMBSMT();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cmd.CommandText = "exec GetDataGoldenFromQTMCToQMBBySN " + "'" + strSN + "'";
                //cmd.CommandTimeout = 180;
                dtTmp = oCon.Query(cmd);
            }
            catch (Exception ex)
            {
                string strEx = ex.ToString().Trim();
                MessageBox.Show(strEx, "Error catch !!!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            return dtTmp;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            lbResult.Text = "";
            btnUpload.Enabled = false;
            rdoSN.Enabled = false;
            rdoExcel.Enabled = false;

            if (!bgwExcelUpload.IsBusy)
            {                
                //int size = -1;
                result = ofdExcel.ShowDialog(); // Show the dialog.
                pcbLoad.Visible = true;
                bgwExcelUpload.RunWorkerAsync();
            }

        }

        private void bgwExcelUpload_DoWork(object sender, DoWorkEventArgs e)
        {
            DataTable dtTmp = new DataTable();            
            if (result == DialogResult.OK) // Test result.
            {
                string file = ofdExcel.FileName;
                try
                {
                    try
                    {
                        dtTmp = ReadExcelFile(file, "GoldenBoard", "*", "dtTmp", true);
                    }
                    catch (Exception ex)
                    {
                        dtTmp = new DataTable();
                    }

                    if (dtTmp.Rows.Count > 0)
                    {
                        foreach (DataRow row in dtTmp.Rows)
                        {
                            dt = new DataTable();
                            dt = GetDataGoldenFromQTMCToQMBBySN(row["SN"].ToString().Trim());

                            if (dt.Rows.Count > 0)
                            {
                                if (dt.Rows[0]["Result"].ToString().Trim() == "0")
                                {
                                    lbResult.Invoke((MethodInvoker)delegate {
                                        lbResult.Text = "SN: " + row["SN"].ToString().Trim() + " add information for goldenBoard finished.";
                                    });
                                }
                                else
                                {
                                    lbResult.Invoke((MethodInvoker)delegate {
                                        lbResult.Text = "SN: " + row["SN"].ToString().Trim() + " " + dt.Rows[0]["Msg"].ToString().Trim();
                                    });                                    
                                }
                            }
                        }
                    }
                    else
                    {
                        lbResult.Invoke((MethodInvoker)delegate {
                            lbResult.Text = "Error uploading excel file. Please check the file as a rule and try again.";
                        });
                    }                  
                }
                catch (IOException ex1)
                {
                    ex = ex1;
                    lbResult.Text = ex.ToString().Trim();
                    return;
                }
            }
        }

        private void bgwExcelUpload_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pcbLoad.Visible = false;
            btnUpload.Enabled = true;
            rdoSN.Enabled = true;
            rdoExcel.Enabled = true;
        }

        public static DataTable ReadExcelFile(String filePath,
                                          String sheetName,
                                          String selectFields,
                                          String tableName,
                                          Boolean fileIncludesHeaders)
        {
            DataSet dataSet = null;
            DataTable dtReturn = null;
            string connectionString = string.Empty;
            string commandText = string.Empty;

            // Indicates the Excel file with header or not.
            string headerYesNo = string.Empty;
            string fileExtension = string.Empty;
            try
            {
                if (fileIncludesHeaders == true)
                {
                    // Set YES if excel WithHeader is TRUE.
                    headerYesNo = "YES";
                }
                else
                {
                    // Set NO if excel WithHeader is FALSE.
                    headerYesNo = "NO";
                }

                // Gets file extension for checking.
                fileExtension = Path.GetExtension(filePath);

                switch (fileExtension.ToUpper())
                {
                    case ".XLS":

                        //Take Connection For Microsoft Excel File.
                        connectionString =
                          string.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=""Excel 8.0;IMEX=2.0;HDR={1}""",
                                        filePath,
                                        headerYesNo);

                        break;

                    case ".XLSX":

                        //Take Connection For Microsoft Excel File.
                        connectionString =
                          string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=""Excel 12.0;IMEX=2.0;HDR={1}""",
                                        filePath,
                                        headerYesNo);

                        break;

                    default:

                        throw new Exception("File is invalid.");
                }

                commandText = string.Format("SELECT {0} FROM [{1}$]",
                                            selectFields,
                                            sheetName);

                dataSet = new DataSet();
                using (OleDbConnection dbConnection = new OleDbConnection(connectionString))
                {
                    OleDbCommand dbCommand = new OleDbCommand(commandText, dbConnection);
                    dbCommand.CommandType = CommandType.Text;
                    OleDbDataAdapter dbDataAdapter = new OleDbDataAdapter(dbCommand);
                    dbDataAdapter.Fill(dataSet);
                }

                if (dataSet != null &&
                    dataSet.Tables.Count > 0)
                {
                    dataSet.Tables[0].TableName = tableName;

                    // Sets reference of data table.
                    dtReturn = dataSet.Tables[tableName];
                }
            }
            catch (Exception ex)
            {
                //throw ex;
                dtReturn = new DataTable();
            }            
            return dtReturn;
        }
    }
}
