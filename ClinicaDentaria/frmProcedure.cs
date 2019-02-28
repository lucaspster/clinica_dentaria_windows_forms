using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace DentalManagementSystem
{
    public partial class frmProcedure : Form
    {
        ConnectionString cs = new ConnectionString();
        CommonClasses cc = new CommonClasses();
        clsFunc cf = new clsFunc();
        string st1;
        string st2;
        public frmProcedure()
        {
            InitializeComponent();
        }

        public void Reset()
        {
            txtPaymentID.Text = "";
            txtToothInvolved.Text = "";
            cmbStaffName.SelectedIndex = -1;
            txtID.Text = "";
            txtDescription.Text = "";
            txtPatientID.Text = "";
            txtPatientName.Text = "";
            txtCopayAmount.Text = "";
            txtProcedureType.Text = "";
            txtDesignation.Text = "";
            txtCharges.Text = "";
            txtTotalPaid.Text = "";
            txtGrandTotal.Text = "";
            txtStaffID.Text = "";
            txtPaymentDue.Text = "";
            dtpDate.Text = System.DateTime.Now.ToString();
            dtpDate.Enabled = true;
            txtGrandTotal.Text = "";
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
                string ct = "delete from [Procedure] where Pay_ID=@d1";
                cc.cmd = new SqlCommand(ct);
                cc.cmd.Connection = cc.con;
                cc.cmd.Parameters.AddWithValue("@d1", txtID.Text);
                RowsAffected = cc.cmd.ExecuteNonQuery();
                if (RowsAffected > 0)
                {
                    st1 = lblUser.Text;
                    st2 = "deletado o procedimento com pagamento id '" + txtPaymentID.Text + "'";
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
                string sql = "SELECT MAX(Pay_ID+1) FROM [Procedure]";
                cc.cmd = new SqlCommand(sql);
                cc.cmd.Connection = cc.con;
                if (Convert.IsDBNull(cc.cmd.ExecuteScalar()))
                {
                    Num = 1;
                    txtID.Text = Convert.ToString(Num);
                    txtPaymentID.Text = "B-" + Convert.ToString(Num);
                }
                else
                {
                    Num = (int)(cc.cmd.ExecuteScalar());
                    txtID.Text = Convert.ToString(Num);
                    txtPaymentID.Text = "B-" + Convert.ToString(Num);
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
                if (txtPatientID.Text == "")
                {
                    MessageBox.Show("Digite a informação do paciente", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    button1.Focus();
                    return;
                }
                if (cmbStaffName.Text == "")
                {
                    MessageBox.Show("Selecione o funcionário", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbStaffName.Focus();
                    return;
                }
                if (txtProcedureType.Text == "")
                {
                    MessageBox.Show("Informe o tipo de procedimento", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtProcedureType.Focus();
                    return;
                }
                if (txtToothInvolved.Text == "")
                {
                    MessageBox.Show("Informe o dente envolvido", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtToothInvolved.Focus();
                    return;
                }
                if (txtCopayAmount.Text == "")
                {
                    MessageBox.Show("Informe o valor do convênio", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCopayAmount.Focus();
                    return;
                }
                if (txtCharges.Text == "")
                {
                    MessageBox.Show("Informe os encargos", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCharges.Focus();
                    return;
                }
                if (txtTotalPaid.Text == "")
                {
                    MessageBox.Show("Informe o total Pago", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTotalPaid.Focus();
                    return;
                }
                  double val1 = 0;
            double val2 = 0;
            double.TryParse(txtGrandTotal.Text, out val1);
            double.TryParse(txtTotalPaid.Text, out val2);
            if (val2 > val1)
            {
                MessageBox.Show("O total pago não pode ser maior que Total Geral", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTotalPaid.Text = "";
                txtTotalPaid.Focus();
                return;

            }
                cc.con = new SqlConnection(cs.DBConn);
                cc.con.Open();
                string cb = "insert into [Procedure](Pay_Id,PaymentID,Date,PatientID,StaffID,ProcedureType,Description,ToothInvolved,CopayAmount,Charges,GrandTotal,TotalPaid,PaymentDue) Values (" + txtID.Text + ",'" + txtPaymentID.Text + "',@d4," + txtP_ID.Text + "," + txtStaffID.Text + ",@d1,@d2,@d3," + txtCopayAmount.Text + "," + txtCharges.Text + "," + txtGrandTotal.Text + "," + txtTotalPaid.Text + "," + txtPaymentDue.Text + ")";
                cc.cmd = new SqlCommand(cb);
                cc.cmd.Parameters.AddWithValue("@d1", txtProcedureType.Text);
                cc.cmd.Parameters.AddWithValue("@d2", txtDescription.Text);
                cc.cmd.Parameters.AddWithValue("@d3", txtProcedureType.Text);
                cc.cmd.Parameters.AddWithValue("@d4", dtpDate.Value);
                cc.cmd.Connection = cc.con;
                cc.cmd.ExecuteReader();
                cc.con.Close();
                st1 = lblUser.Text;
                st2 = "incluido um novo procedimento com pagamento id '" + txtPaymentID.Text + "'";
                cf.LogFunc(st1, System.DateTime.Now, st2);
                btnSave.Enabled = false;
                MessageBox.Show("Salvo com sucesso", "Procedure", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (txtPatientID.Text == "")
                {
                    MessageBox.Show("Digite a informação do paciente", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    button1.Focus();
                    return;
                }
                if (cmbStaffName.Text == "")
                {
                    MessageBox.Show("Selecione o funcionário", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbStaffName.Focus();
                    return;
                }
                if (txtProcedureType.Text == "")
                {
                    MessageBox.Show("Informe o tipo de procedimento", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtProcedureType.Focus();
                    return;
                }
                if (txtToothInvolved.Text == "")
                {
                    MessageBox.Show("Informe o dente envolvido", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtToothInvolved.Focus();
                    return;
                }
                if (txtCopayAmount.Text == "")
                {
                    MessageBox.Show("Informe o valor do convênio", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCopayAmount.Focus();
                    return;
                }
                if (txtCharges.Text == "")
                {
                    MessageBox.Show("Informe os encargos", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCharges.Focus();
                    return;
                }
                if (txtTotalPaid.Text == "")
                {
                    MessageBox.Show("Informe o total Pago", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTotalPaid.Focus();
                    return;
                }
                  double val1 = 0;
            double val2 = 0;
            double.TryParse(txtGrandTotal.Text, out val1);
            double.TryParse(txtTotalPaid.Text, out val2);
            if (val2 > val1)
            {
                MessageBox.Show("O total pago não pode ser maior que Total Geral", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTotalPaid.Text = "";
                txtTotalPaid.Focus();
                return;

            }
                cc.con = new SqlConnection(cs.DBConn);
                cc.con.Open();
                string cb = "Update [Procedure] set PaymentID='" + txtPaymentID.Text + "',PatientID=" + txtP_ID.Text + ",StaffID=" + txtStaffID.Text + ",ProcedureType=@d1,Description=@d2,ToothInvolved=@d3,CopayAmount=" + txtCopayAmount.Text + ",Charges=" + txtCharges.Text + ",GrandTotal=" + txtGrandTotal.Text + ",TotalPaid=" + txtTotalPaid.Text + ",PaymentDue=" + txtPaymentDue.Text + " where pay_ID=" + txtID.Text + "";
                cc.cmd = new SqlCommand(cb);
                cc.cmd.Parameters.AddWithValue("@d1", txtProcedureType.Text);
                cc.cmd.Parameters.AddWithValue("@d2", txtDescription.Text);
                cc.cmd.Parameters.AddWithValue("@d3", txtProcedureType.Text);
                cc.cmd.Connection = cc.con;
                cc.cmd.ExecuteReader();
                cc.con.Close();
                st1 = lblUser.Text;
                st2 = "Atualizado o procedimento com pagamento id '" + txtPaymentID.Text + "'";
                cf.LogFunc(st1, System.DateTime.Now, st2);
                btnUpdate.Enabled = false;
                MessageBox.Show("Atualizada com sucesso", "Procedure", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            frmProcedureRecord frm = new frmProcedureRecord();
            frm.Reset();
            frm.lblOperation.Text = "Procedure";
            frm.lblUser.Text = lblUser.Text;
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPatientRecord frm = new frmPatientRecord();
            frm.Reset();
            frm.lblOperation.Text = "Procedimento";
            frm.lblUser.Text = lblUser.Text;
            frm.Show();
        }

        public void Calculate()
        {
            try
            {
                double val1 = 0;
                double val2 = 0;
                double val3 = 0;
                double val4 = 0;
                double val5 = 0;
                double.TryParse(txtCopayAmount.Text, out val1);
                double.TryParse(txtCharges.Text, out val2);
                double.TryParse(txtTotalPaid.Text, out val4);
                val3 = Convert.ToDouble(val1 + val2);
                val3 = Math.Round(val3, 2);
                txtGrandTotal.Text = val3.ToString();
                val5 = Convert.ToDouble(val3 - val4);
                val5 = Math.Round(val5, 2);
                txtPaymentDue.Text = val5.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        public void FillStaffName()
        {
            try
            {
                cc.con = new SqlConnection(cs.DBConn);
                cc.con.Open();
                string ct = "select RTRIM(Name) from Staff order by Name";
                cc.cmd = new SqlCommand(ct);
                cc.cmd.Connection = cc.con;
                cc.rdr = cc.cmd.ExecuteReader();
                while (cc.rdr.Read())
                {
                    cmbStaffName.Items.Add(cc.rdr[0]);
                }
                cc.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCopayAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtCharges_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtTotalPaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
        }

        private void cmbStaffName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cc.con = new SqlConnection(cs.DBConn);
                cc.con.Open();
                cc.cmd = cc.con.CreateCommand();
                cc.cmd.CommandText = "SELECT Type,S_ID FROM Staff WHERE Name=@d1";
                cc.cmd.Parameters.AddWithValue("@d1", cmbStaffName.Text);
                cc.rdr = cc.cmd.ExecuteReader();
                if (cc.rdr.Read())
                {
                    txtDesignation.Text = cc.rdr.GetValue(0).ToString();
                    txtStaffID.Text = cc.rdr.GetValue(1).ToString();
                }
                if ((cc.rdr != null))
                {
                    cc.rdr.Close();
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

        private void frmProcedure_Load(object sender, EventArgs e)
        {
            FillStaffName();
        }

        private void txtCopayAmount_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txtCharges_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txtTotalPaid_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txtTotalPaid_Validating(object sender, CancelEventArgs e)
        {
            double val1 = 0;
            double val2 = 0;
            double.TryParse(txtGrandTotal.Text, out val1);
            double.TryParse(txtTotalPaid.Text, out val2);
            if (val2 > val1)
            {
                MessageBox.Show("O total pago não pode ser maior que Total Geral", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTotalPaid.Text = "";
                txtTotalPaid.Focus();
                return;

            }
        }

        private void txtToothInvolved_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }

    }
}