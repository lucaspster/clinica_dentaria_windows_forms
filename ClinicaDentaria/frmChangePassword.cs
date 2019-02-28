using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace DentalManagementSystem
{
    public partial class frmChangePassword : Form
    {
        CommonClasses cc = new CommonClasses();
        clsFunc cf = new clsFunc();
        ConnectionString cs = new ConnectionString();
        string st1;
        string st2;
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int RowsAffected = 0;
                if ((txtUserID.Text.Trim().Length == 0))
                {
                    MessageBox.Show("Informe o Id do usuário ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUserID.Focus();
                    return;
                }
                if ((txtOldPassword.Text.Trim().Length == 0))
                {
                    MessageBox.Show("Informe a senha anterior", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtOldPassword.Focus();
                    return;
                }
                if ((txtNewPassword.Text.Trim().Length == 0))
                {
                    MessageBox.Show("Please enter new password", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNewPassword.Focus();
                    return;
                }
                if ((txtConfirmPassword.Text.Trim().Length == 0))
                {
                    MessageBox.Show("Confirme a nova senha", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtConfirmPassword.Focus();
                    return;
                }
                if ((txtNewPassword.TextLength < 5))
                {
                    MessageBox.Show("A nova senha deve ter no mínimo 5 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNewPassword.Text = "";
                    txtConfirmPassword.Text = "";
                    txtNewPassword.Focus();
                    return;
                }
                else if ((txtNewPassword.Text != txtConfirmPassword.Text))
                {
                    MessageBox.Show("A senha não confere.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNewPassword.Text = "";
                    txtOldPassword.Text = "";
                    txtConfirmPassword.Text = "";
                    txtOldPassword.Focus();
                    return;
                }
                else if ((txtOldPassword.Text == txtNewPassword.Text))
                {
                    MessageBox.Show("A senha é a mesma , informe uma nova senha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNewPassword.Text = "";
                    txtConfirmPassword.Text = "";
                    txtNewPassword.Focus();
                    return;
                }
              
                cc.con = new SqlConnection(cs.DBConn);
                cc.con.Open();
                string co = "Update Registration set Password = '" + txtNewPassword.Text + "'where UserID=@d1 and Password =@d2";
                cc.cmd = new SqlCommand(co);
                cc.cmd.Connection = cc.con;
                cc.cmd.Parameters.AddWithValue("@d1", txtUserID.Text);
                cc.cmd.Parameters.AddWithValue("@d2", txtOldPassword.Text);
                RowsAffected = cc.cmd.ExecuteNonQuery();
                if ((RowsAffected > 0))
                {
                    st1 = txtUserID.Text;
                    st2 = "Senha alterada com sucesso";
                    cf.LogFunc(st1, System.DateTime.Now, st2);
                    MessageBox.Show("Alterada com sucesso", "Senha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUserID.Text = "";
                    txtNewPassword.Text = "";
                    txtOldPassword.Text = "";
                    txtConfirmPassword.Text = "";
                    frmLogin LoginForm1 = new frmLogin();
                    this.Hide();
                    frmLogin frm = new frmLogin();
                    frm.UserID.Text = "";
                    frm.Password.Text = "";
                    frm.ProgressBar1.Visible = false;
                    frm.UserID.Focus();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Senha e/ou usuário inválido(s)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserID.Text = "";
                    txtNewPassword.Text = "";
                    txtOldPassword.Text = "";
                    txtConfirmPassword.Text = "";
                    txtUserID.Focus();
                }
                if ((cc.con.State == ConnectionState.Open))
                {
                    cc.con.Close();
                }
                cc.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangePassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmLogin frm = new frmLogin();
            frm.UserID.Text = "";
            frm.Password.Text = "";
            frm.ProgressBar1.Visible = false;
            frm.UserID.Focus();
            frm.Show();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {

        }

    }
}
