using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace DentalManagementSystem
{
    public partial class frmStaff : Form
    {
        ConnectionString cs = new ConnectionString();
        CommonClasses cc = new CommonClasses();
        clsFunc cf = new clsFunc();
        string st1;
        string st2;
        string gender;
        public frmStaff()
        {
            InitializeComponent();
        }

      public void Reset()
        {
        txtEmailID.Text = "";
        txtStaffName.Text = "";
        txtContactNo.Text = "";
        txtCity.Text = "";
        txtAddress.Text = "";
        txtStaffID.Text = "";
        rbMale.Checked = false;
        rbFemale.Checked = false;
        dtpDOB.Text = System.DateTime.Today.ToString();
        txtID.Text = "";
        cmbStaffType.SelectedIndex = -1;
        txtStaffName.Focus();
        btnSave.Enabled = true;
        btnUpdate.Enabled = false;
        btnDelete.Enabled = false;
        auto();
        }
     
  
        private void delete_records()
        {

            try
            {
                int RowsAffected = 0;
                cc.con = new SqlConnection(cs.DBConn);
                cc.con.Open();
                string ct = "delete from Staff where S_ID=@d1";
                cc.cmd = new SqlCommand(ct);
                cc.cmd.Connection = cc.con;
                cc.cmd.Parameters.AddWithValue("@d1", txtID.Text);
                RowsAffected = cc.cmd.ExecuteNonQuery();
                if (RowsAffected > 0)
                {
                    st1 = lblUser.Text;
                    st2 = "deleted the Staff '" + txtStaffName.Text + "' having Staff id '" + txtStaffID.Text + "'";
                    cf.LogFunc(st1, System.DateTime.Now, st2);
                    MessageBox.Show("Deletado com sucesso", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
                else
                {
                    MessageBox.Show("Registro não encontrado", "Não Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
                if (cc.con.State == ConnectionState.Open)
                {
                    cc.con.Close();
                }
             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
     
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void auto()
        {
            try
            {
                int Num = 0;
                cc.con = new SqlConnection(cs.DBConn);
                cc.con.Open();
                string sql = "SELECT MAX(S_ID+1) FROM Staff";
                cc.cmd = new SqlCommand(sql);
                cc.cmd.Connection = cc.con;
                if (Convert.IsDBNull(cc.cmd.ExecuteScalar()))
                {
                    Num = 1;
                    txtID.Text = Convert.ToString(Num);
                    txtStaffID.Text = "S-" + Convert.ToString(Num);
                }
                else
                {
                    Num = (int)(cc.cmd.ExecuteScalar());
                    txtID.Text = Convert.ToString(Num);
                    txtStaffID.Text = "S-" + Convert.ToString(Num);
                }
                cc.cmd.Dispose();
                cc.con.Close();
                cc.con.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
           
            try
            {
            if (txtStaffName.Text == "")
                {
            MessageBox.Show("Informe o nome do funcionário", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtStaffName.Focus();
            return;
            }
            if (cmbStaffType.Text == "")
            {
                MessageBox.Show("Informe o tipo do funcionário", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbStaffType.Focus();
                return;
            }
            if (rbMale.Checked==false && rbFemale.Checked==false)
            {
            MessageBox.Show("Informe o gênero", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
            }
            if (txtAddress.Text == "" )
            {
                MessageBox.Show("Informe o endereço", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtAddress.Focus();
            return;
            }
            if (txtCity.Text == "")
            {
            MessageBox.Show("Informe a cidade", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtCity.Focus();
            return;
            }
            if (txtContactNo.Text == "")
            {
            MessageBox.Show("Informe o no. de contato", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtContactNo.Focus();
            return;
            }
                if (rbMale.Checked==true )
                {
                    gender = rbMale.Text;
                }
                if (rbFemale.Checked==true )
                {
                    gender = rbFemale.Text;
                }
               

                cc.con = new SqlConnection(cs.DBConn);
                cc.con.Open();
                string cb = "insert into Staff(S_ID,StaffID,Name,Address,City,ContactNo,Email,Gender,DOB,Type) VALUES (@d1,@d2,@d3,@d4,@d5,@d6,@d7,'" + gender + "',@d8,'" + cmbStaffType.Text + "')";
                cc.cmd = new SqlCommand(cb);
                cc.cmd.Connection = cc.con;
                cc.cmd.Parameters.AddWithValue("@d1", txtID.Text);
                cc.cmd.Parameters.AddWithValue("@d2", txtStaffID.Text);
                cc.cmd.Parameters.AddWithValue("@d3",txtStaffName.Text);
                cc.cmd.Parameters.AddWithValue("@d4", txtAddress.Text);
                cc.cmd.Parameters.AddWithValue("@d5", txtCity.Text);
                cc.cmd.Parameters.AddWithValue("@d6", txtContactNo.Text);
                cc.cmd.Parameters.AddWithValue("@d7",txtEmailID.Text);
                cc.cmd.Parameters.AddWithValue("@d8",  DateTime.Parse(dtpDOB.Text));
                cc.cmd.ExecuteReader();
                cc.con.Close();
                st1 = lblUser.Text;
                st2 = "incluindo um novo funcionário  '" + txtStaffName.Text + "' com id '" + txtStaffID.Text + "'";
                cf.LogFunc(st1, System.DateTime.Now, st2);
                btnSave.Enabled = false;
                MessageBox.Show("Salvo com sucesso", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
        private void btnUpdate_Click(object sender, EventArgs e)
        {
              try
              {
                  if (txtStaffName.Text == "")
                  {
                      MessageBox.Show("Informe o nome do funcionário", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                      txtStaffName.Focus();
                      return;
                  }
                  if (cmbStaffType.Text == "")
                  {
                      MessageBox.Show("Informe o tipo do funcionário", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                      cmbStaffType.Focus();
                      return;
                  }
                  if (rbMale.Checked == false && rbFemale.Checked == false)
                  {
                      MessageBox.Show("Informe o gênero", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                      return;
                  }
                  if (txtAddress.Text == "")
                  {
                      MessageBox.Show("Informe o endereço", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                      txtAddress.Focus();
                      return;
                  }
                  if (txtCity.Text == "")
                  {
                      MessageBox.Show("Informe a cidade", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                      txtCity.Focus();
                      return;
                  }
                  if (txtContactNo.Text == "")
                  {
                      MessageBox.Show("Informe o no. de contato", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                      txtContactNo.Focus();
                      return;
                  }
                  if (rbMale.Checked == true)
                  {
                      gender = rbMale.Text;
                  }
                  if (rbFemale.Checked == true)
                  {
                      gender = rbFemale.Text;
                  }
                  cc.con = new SqlConnection(cs.DBConn);
                  cc.con.Open();
                  string cb = "Update Staff set StaffID=@d2,Name=@d3,Address=@d4,City=@d5,ContactNo=@d6,Email=@d7,Gender='" + gender + "',DOB=@d8,Type='" + cmbStaffType.Text + "' where S_ID=@d1";
                  cc.cmd = new SqlCommand(cb); 
                  cc.cmd.Connection = cc.con;
                  cc.cmd.Parameters.AddWithValue("@d1", txtID.Text);
                  cc.cmd.Parameters.AddWithValue("@d2", txtStaffID.Text);
                  cc.cmd.Parameters.AddWithValue("@d3", txtStaffName.Text);
                  cc.cmd.Parameters.AddWithValue("@d4", txtAddress.Text);
                  cc.cmd.Parameters.AddWithValue("@d5", txtCity.Text);
                  cc.cmd.Parameters.AddWithValue("@d6", txtContactNo.Text);
                  cc.cmd.Parameters.AddWithValue("@d7", txtEmailID.Text);
                  cc.cmd.Parameters.AddWithValue("@d8", dtpDOB.Text);
                  cc.cmd.ExecuteReader();
                  cc.con.Close();
                  st1 = lblUser.Text;
                  st2 = "atualizado o funcionário '" + txtStaffName.Text + "' com id '" + txtStaffID.Text + "'";
                  cf.LogFunc(st1, System.DateTime.Now, st2);
                btnUpdate.Enabled = false;
                MessageBox.Show("Atualizada com sucesso", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    
        private void btnNew_Click(object sender, EventArgs e)
        {
            Reset();
        }



        private void txtEmailID_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (txtEmailID.Text.Length > 0)
            {
                if (!rEMail.IsMatch(txtEmailID.Text))
                {
                    MessageBox.Show("Email inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmailID.SelectAll();
                    e.Cancel = true;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja deletar esse registro ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                delete_records();
            }
        }

    
        private void btnGetData_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStaffRecord frm = new frmStaffRecord();
            frm.Reset();
            frm.lblOperation.Text = "Funcionário Master";
            frm.lblUser.Text = lblUser.Text;
            frm.Show();
        }

    }
}