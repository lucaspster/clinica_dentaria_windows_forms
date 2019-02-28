using System;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace DentalManagementSystem
{
    public partial class frmMainMenu : Form
    {
        ConnectionString cs = new ConnectionString();
        CommonClasses cc = new CommonClasses();
        clsFunc cf = new clsFunc();
        string st1;
        string st2;
        public frmMainMenu()
        {
            InitializeComponent();
        }

  
        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistration frm = new frmRegistration();
            frm.lblUser.Text = lblUser.Text;
            frm.Reset();
            frm.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog();
        }

    
        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("Calc.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("Notepad.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void wordpadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("Wordpad.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void mSWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("WinWord.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void taskManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("TaskMgr.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

      
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = System.DateTime.Now.ToString();
        }

 

        private void logsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogs frm = new frmLogs();
            frm.Reset();
            frm.lblUser.Text = lblUser.Text;
            frm.ShowDialog();
        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            timer2.Enabled = false;
        }

   
        private void backupToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                timer2.Enabled = true;
                if ((!System.IO.Directory.Exists("C:\\DBBackup")))
                {
                    System.IO.Directory.CreateDirectory("C:\\DBBackup");
                }
                string destdir = "C:\\DBBackup\\DMS_DB " + DateTime.Now.ToString("dd-MM-yyyy_HH-mm-ss") + ".bak";
                cc.con = new SqlConnection(cs.DBConn);
                cc.con.Open();
                string cb = "backup database [" + System.Windows.Forms.Application.StartupPath + "\\DMS_DB.mdf] to disk='" + destdir + "'with init,stats=10";
                cc.cmd = new SqlCommand(cb);
                cc.cmd.Connection = cc.con;
                cc.cmd.ExecuteReader();
                cc.con.Close();
                st1 = lblUser.Text;
                st2 = "Backup realizado com sucesso";
                cf.LogFunc(st1, System.DateTime.Now, st2);
                MessageBox.Show("Operação concluída com sucesso", "Backup - Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void restoreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                var _with1 = openFileDialog1;
                _with1.Filter = ("DB Backup File|*.bak;");
                _with1.FilterIndex = 4;
                //Clear the file name
                openFileDialog1.FileName = "";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Cursor = Cursors.WaitCursor;
                    timer2.Enabled = true;
                    SqlConnection.ClearAllPools();
                    cc.con = new SqlConnection(cs.DBConn);
                    cc.con.Open();
                    string cb = "USE Master ALTER DATABASE [" + System.Windows.Forms.Application.StartupPath + "\\DMS_DB.mdf] SET Single_User WITH Rollback Immediate Restore database [" + System.Windows.Forms.Application.StartupPath + "\\DMS_DB.mdf] FROM disk='" + openFileDialog1.FileName + "' WITH REPLACE ALTER DATABASE [" + System.Windows.Forms.Application.StartupPath + "\\DMS_DB.mdf] SET Multi_User ";
                    cc.cmd = new SqlCommand(cb);
                    cc.cmd.Connection = cc.con;
                    cc.cmd.ExecuteReader();
                    cc.con.Close();
                    st1 = lblUser.Text;
                    st2 = "Restauração realizada com sucesso";
                    cf.LogFunc(st1, System.DateTime.Now, st2);
                    MessageBox.Show("Operação concluída com sucesso", "Restuaração do banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
     
        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            st1 = lblUser.Text;
            st2 = "Logout realizado com sucesso";
            cf.LogFunc(st1, System.DateTime.Now, st2);
            this.Hide();
            frmLogin frm = new frmLogin();
            frm.Show();
            frm.UserID.Text = "";
            frm.Password.Text = "";
            frm.ProgressBar1.Visible = false;
            frm.UserID.Focus();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void patientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPatient frm = new frmPatient();
            frm.lblUser.Text = lblUser.Text;
            frm.Reset();
            frm.Show();
        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStaff frm = new frmStaff();
            frm.lblUser.Text = lblUser.Text;
            frm.Reset();
            frm.Show();
        }

        private void procedureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProcedure frm = new frmProcedure();
            frm.lblUser.Text = lblUser.Text;
            frm.Reset();
            frm.Show();
        }

        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInvoice frm = new frmInvoice();
            frm.lblUser.Text = lblUser.Text;
            frm.Reset();
            frm.Show();
        }

     
     
    }
}
