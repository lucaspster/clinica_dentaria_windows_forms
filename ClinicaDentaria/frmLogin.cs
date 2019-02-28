using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace DentalManagementSystem
{
    public partial class frmLogin : Form
    {
        ConnectionString cs = new ConnectionString();
        frmMainMenu frm = new frmMainMenu();
        CommonClasses cc = new CommonClasses();
        clsFunc cf = new clsFunc();
        string st1;
        string st2;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            if (UserID.Text == "")
            {
                MessageBox.Show("Informe o ID do usuário", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UserID.Focus();
                return;
            }
            if (Password.Text == "")
            {
                MessageBox.Show("Informe a senha", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Password.Focus();
                return;
            }
            try
            {
                cc.con = new SqlConnection(cs.DBConn);
                cc.con.Open();
                cc.cmd = cc.con.CreateCommand();
                cc.cmd.CommandText = "SELECT RTRIM(UserID),RTRIM(Password) FROM Registration where UserID = @d1 and Password=@d2";
                cc.cmd.Parameters.AddWithValue("@d1", UserID.Text);
                cc.cmd.Parameters.AddWithValue("@d2",Password.Text);
                cc.rdr = cc.cmd.ExecuteReader();
                if (cc.rdr.Read())
                {
                    cc.con = new SqlConnection(cs.DBConn);
                    cc.con.Open();
                    cc.cmd = cc.con.CreateCommand();
                    cc.cmd.CommandText = "SELECT usertype FROM Registration where UserID=@d3 and Password=@d4";
                    cc.cmd.Parameters.AddWithValue("@d3", UserID.Text);
                    cc.cmd.Parameters.AddWithValue("@d4",Password.Text);
                    cc.rdr = cc.cmd.ExecuteReader();
                    if (cc.rdr.Read())
                    {
                        UserType.Text = cc.rdr.GetValue(0).ToString().Trim();
                    }
                    if ((cc.rdr != null))
                    {
                        cc.rdr.Close();
                    }
                    if (cc.con.State == ConnectionState.Open)
                    {
                        cc.con.Close();
                    }
                    if ((UserType.Text == "Admin"))
                    {
                   frm.usersToolStripMenuItem.Enabled=true;
                   frm.databaseToolStripMenuItem.Enabled=true;
                   frm. staffToolStripMenuItem.Enabled=true;
                   frm.patientToolStripMenuItem.Enabled=true;
                   frm.procedureToolStripMenuItem.Enabled=true;
                   frm.invoiceToolStripMenuItem.Enabled = true;
                       frm.lblUser.Text = UserID.Text;
                       frm.lblUserType.Text = UserType.Text;
                       ProgressBar1.Visible = true;
                        ProgressBar1.Maximum = 5000;
                        ProgressBar1.Minimum = 0;
                        ProgressBar1.Value = 4;
                        ProgressBar1.Step = 1;
                        for (int i = 0; i <= 5000; i++)
                        {
                            ProgressBar1.PerformStep();
                        }
                        st1 = UserID.Text;
                        st2 = "Logado com sucesso";
                        cf.LogFunc(st1, System.DateTime.Now, st2);
                        this.Hide();
                        frm.Show();

                    }
                    if ((UserType.Text == "Gerente"))
                    {
                        frm.usersToolStripMenuItem.Enabled = false;
                        frm.databaseToolStripMenuItem.Enabled = false;
                        frm.staffToolStripMenuItem.Enabled = true;
                        frm.patientToolStripMenuItem.Enabled = true;
                        frm.procedureToolStripMenuItem.Enabled = false;
                        frm.invoiceToolStripMenuItem.Enabled = true;
                        frm.lblUser.Text = UserID.Text;
                        frm.lblUserType.Text = UserType.Text;
                        ProgressBar1.Visible = true;
                        ProgressBar1.Maximum = 5000;
                        ProgressBar1.Minimum = 0;
                        ProgressBar1.Value = 4;
                        ProgressBar1.Step = 1;
                        for (int i = 0; i <= 5000; i++)
                        {
                            ProgressBar1.PerformStep();
                        }
                        st1 = UserID.Text;
                        st2 = "Logado com sucesso";
                        cf.LogFunc(st1, System.DateTime.Now, st2);
                        this.Hide();
                        frm.Show();

                    }
                    if ((UserType.Text == "Dentista"))
                    {
                        frm.usersToolStripMenuItem.Enabled = false;
                        frm.databaseToolStripMenuItem.Enabled = false;
                        frm.staffToolStripMenuItem.Enabled = false;
                        frm.patientToolStripMenuItem.Enabled = false;
                        frm.procedureToolStripMenuItem.Enabled = true;
                        frm.invoiceToolStripMenuItem.Enabled = false;
                        frm.lblUser.Text = UserID.Text;
                        frm.lblUserType.Text = UserType.Text;
                        ProgressBar1.Visible = true;
                        ProgressBar1.Maximum = 5000;
                        ProgressBar1.Minimum = 0;
                        ProgressBar1.Value = 4;
                        ProgressBar1.Step = 1;
                        for (int i = 0; i <= 5000; i++)
                        {
                            ProgressBar1.PerformStep();
                        }
                        st1 = UserID.Text;
                        st2 = "Logado com sucesso";
                        cf.LogFunc(st1, System.DateTime.Now, st2);
                        this.Hide();
                        frm.Show();

                    }
                    if ((UserType.Text == "Funcionário"))
                    {
                        frm.usersToolStripMenuItem.Enabled = false;
                        frm.databaseToolStripMenuItem.Enabled = false;
                        frm.staffToolStripMenuItem.Enabled = false;
                        frm.patientToolStripMenuItem.Enabled = true;
                        frm.procedureToolStripMenuItem.Enabled = false;
                        frm.invoiceToolStripMenuItem.Enabled = false;
                        frm.lblUser.Text = UserID.Text;
                        frm.lblUserType.Text = UserType.Text;
                        ProgressBar1.Visible = true;
                        ProgressBar1.Maximum = 5000;
                        ProgressBar1.Minimum = 0;
                        ProgressBar1.Value = 4;
                        ProgressBar1.Step = 1;
                        for (int i = 0; i <= 5000; i++)
                        {
                            ProgressBar1.PerformStep();
                        }
                        st1 = UserID.Text;
                        st2 = "Logado com sucesso";
                        cf.LogFunc(st1, System.DateTime.Now, st2);
                        this.Hide();
                        frm.Show();

                    }
                }
                else
                {
                    MessageBox.Show("Login falhou... tente novamente !","Login Falhou",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    UserID.Text = "";
                    Password.Text = "";
                    UserID.Focus();
                }
                cc.cmd.Dispose();
                cc.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmChangePassword frm = new frmChangePassword();
            frm.Show();
            frm.txtUserID.Text = "";
            frm.txtNewPassword.Text = "";
            frm.txtOldPassword.Text = "";
            frm.txtConfirmPassword.Text = "";
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

   
    }
}
