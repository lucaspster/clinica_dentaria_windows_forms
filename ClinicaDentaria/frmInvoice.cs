using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace DentalManagementSystem
{
    public partial class frmInvoice : Form
    {
        ConnectionString cs = new ConnectionString();
        CommonClasses cc = new CommonClasses();
        clsFunc cf = new clsFunc();
        string st1;
        string st2;
        public frmInvoice()
        {
            InitializeComponent();
        }
   
      public void Reset()
        {
          txtInvoiceNo.Text = "";
          txtCharges.Text = "";
          txtID.Text = "";
          txtPatientID.Text = "";
          txtPatientName.Text = "";
          txtP_ID.Text = "";
          dtpInvoiceDate.Text = System.DateTime.Now.ToString();
          dtpDateFrom.Text = System.DateTime.Today.ToString();
          dtpDateTo.Text = System.DateTime.Now.ToString();
          dtpInvoiceDate.Enabled = true;
          txtGrandTotal.Text = "";
          txtTotalPaid.Text = "";
          txtCopayAmount.Text = "";
          txtTotalPaid.Text = "";
          txtPaymentDue.Text = "";
          button2.Enabled = true;
          DataGridView1.Rows.Clear();
        btnSave.Enabled = true;
        dtpInvoiceDate.Enabled = true;
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
                string ct = "delete from Invoice where INV_ID=@d1";
                cc.cmd = new SqlCommand(ct);
                cc.cmd.Connection = cc.con;
                cc.cmd.Parameters.AddWithValue("@d1", txtID.Text);
                RowsAffected = cc.cmd.ExecuteNonQuery();
                if (RowsAffected > 0)
                {
                    st1 = lblUser.Text;
                    st2 = "Deletada a fatura no. '" + txtInvoiceNo.Text + "'";
                    cf.LogFunc(st1, System.DateTime.Now, st2);
                    MessageBox.Show("Deletado com sucesso", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
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
                string sql = "SELECT MAX(INV_ID+1) FROM Invoice";
                cc.cmd = new SqlCommand(sql);
                cc.cmd.Connection = cc.con;
                if (Convert.IsDBNull(cc.cmd.ExecuteScalar()))
                {
                    Num = 1;
                    txtID.Text = Convert.ToString(Num);
                    txtInvoiceNo.Text = "INV-" + Convert.ToString(Num);
                }
                else
                {
                    Num = (int)(cc.cmd.ExecuteScalar());
                    txtID.Text = Convert.ToString(Num);
                    txtInvoiceNo.Text = "INV-" + Convert.ToString(Num);
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
                    MessageBox.Show("Digite a informação do paciente ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    button1.Focus();
                    return;
                }
                if (DataGridView1.Rows.Count==0)
                {
                    MessageBox.Show("Nenhum procedimento adicionado ao quadro", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show("O Total pago não pode ser maior que o Total Geral", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTotalPaid.Text = "";
                    txtTotalPaid.Focus();
                    return;

                }
            cc.con = new SqlConnection(cs.DBConn);
            cc.con.Open();
            string cb = "insert into Invoice(INV_Id, InvoiceNo,Date,TotalCopayAmount,TotalCharges,GrandTotal_inv,TotalPaid_Inv,PaymentDue_Inv,PatientID,DateFrom,DateTo) Values (" + txtID.Text + ",'" + txtInvoiceNo.Text + "',@d3," + txtCopayAmount.Text + "," + txtCharges.Text + "," + txtGrandTotal.Text + "," + txtTotalPaid.Text + "," + txtPaymentDue.Text + "," + txtP_ID.Text + ",@d1,@d2)";
            cc.cmd = new SqlCommand(cb);
            cc.cmd.Parameters.AddWithValue("@d1", dtpDateFrom.Text);
            cc.cmd.Parameters.AddWithValue("@d2", dtpDateTo.Text);
            cc.cmd.Parameters.AddWithValue("@d3", dtpInvoiceDate.Value);
            cc.cmd.Connection = cc.con;
            cc.cmd.ExecuteReader();
            cc.con.Close();
            cc.con = new SqlConnection(cs.DBConn);
            cc.con.Open();
            string cb1 = "insert into Invoice_ProcedureInfo(InvoiceID,PaymentID) VALUES (" + txtID.Text + ",@d1)";
            cc.cmd = new SqlCommand(cb1);
            cc.cmd.Connection = cc.con;
            // Prepare command for repeated execution
            cc.cmd.Prepare();
            // Data to be inserted
            foreach (DataGridViewRow row in DataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    cc.cmd.Parameters.AddWithValue("@d1", row.Cells[0].Value);
                    cc.cmd.ExecuteNonQuery();
                    cc.cmd.Parameters.Clear();
                }
            }
                st1 = lblUser.Text;
                st2 = "incluida uma nova fatura de numero  '" + txtInvoiceNo.Text + "'";
                cf.LogFunc(st1, System.DateTime.Now, st2);
                btnSave.Enabled = false;
                MessageBox.Show("Concluído com sucesso", "Faturamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (DataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhum procedimento incluído no quadro", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                string cb = "Update Invoice set InvoiceNo='" + txtInvoiceNo.Text + "',TotalCopayAmount=" + txtCopayAmount.Text + ",TotalCharges=" + txtCharges.Text + ",GrandTotal_Inv=" + txtGrandTotal.Text + ",TotalPaid_Inv=" + txtTotalPaid.Text + ",PaymentDue_Inv=" + txtPaymentDue.Text + ",PatientID=" + txtP_ID.Text + " where Inv_ID=" + txtID.Text + "";
                cc.cmd = new SqlCommand(cb);
                cc.cmd.Connection = cc.con;
                cc.cmd.ExecuteReader();
                cc.con.Close();
                st1 = lblUser.Text;
                st2 = "atualizada a fatura de no. '" + txtInvoiceNo.Text + "'";
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
            frmInvoiceRecord frm = new frmInvoiceRecord();
            frm.Reset();
            frm.lblOperation.Text = "Fatura";
            frm.lblUser.Text = lblUser.Text;
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPatientRecord frm = new frmPatientRecord();
            frm.Reset();
            frm.lblOperation.Text = "Fatura";
            frm.lblUser.Text = lblUser.Text;
            frm.Show();
        }

        public void GetData()
        {

            try
            {

                if (txtPatientID.Text == "")
                {
                    MessageBox.Show("Digite a informação do paciente", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    button1.Focus();
                    return;
                }
                cc.con = new SqlConnection(cs.DBConn);
                cc.con.Open();
                cc.cmd = new SqlCommand("Select RTRIM(Pay_Id),Date,RTRIM(Staff.name) as [Staff name],RTRIM(Type) as [Designation],RTRIM(ProcedureType) as [Procedure Type],RTRIM(Description) as [Description],RTRIM(ToothInvolved) as [Tooth Involved],RTRIM(CopayAmount) as [Copay Amount],RTRIM(Charges) as [Charges],RTRIM(GrandTotal) as [Grand Total],RTRIM(TotalPaid) as [Total Paid],RTRIM(PaymentDue) as [Payment Due] from Patient,[Procedure],Staff where Patient.P_ID=[Procedure].PatientID and Staff.S_ID=[Procedure].StaffID and Date between @d1 and @d2 and Patient.PatientID='" + txtPatientID.Text + "' order by Date", cc.con);
                cc.cmd.Parameters.Add("@d1", SqlDbType.DateTime, 30, "Date").Value = dtpDateFrom.Value.Date;
                cc.cmd.Parameters.Add("@d2", SqlDbType.DateTime, 30, "Date").Value = dtpDateTo.Value;
                cc.rdr = cc.cmd.ExecuteReader(CommandBehavior.CloseConnection);
                DataGridView1.Rows.Clear();
                while (cc.rdr.Read() == true)
                {
                    DataGridView1.Rows.Add(cc.rdr[0], cc.rdr[1], cc.rdr[2], cc.rdr[3], cc.rdr[4], cc.rdr[5], cc.rdr[6], cc.rdr[7], cc.rdr[8], cc.rdr[9], cc.rdr[10], cc.rdr[11]);
                }
                double sum = 0;
                double sum1 = 0;
                double sum2 = 0;
                double sum3 = 0;
                double sum4 = 0;

                foreach (DataGridViewRow r in this.DataGridView1.Rows)
                {
                    double i = Convert.ToDouble(r.Cells[7].Value);
                    double j = Convert.ToDouble(r.Cells[8].Value);
                    double k = Convert.ToDouble(r.Cells[9].Value);
                    double l = Convert.ToDouble(r.Cells[10].Value);
                    double m = Convert.ToDouble(r.Cells[11].Value);
                    sum = sum + i;
                    sum1 = sum1 + j;
                    sum2 = sum2 + k;
                    sum3 = sum3 + l;
                    sum4 = sum4 + m;

                }
                sum = Math.Round(sum, 2);
                sum1 = Math.Round(sum1, 2);
                sum2 = Math.Round(sum2, 2);
                sum3 = Math.Round(sum3, 2);
                sum4 = Math.Round(sum4, 2);
                txtCopayAmount.Text = sum.ToString();
                txtCharges.Text = sum1.ToString();
                txtGrandTotal.Text = sum2.ToString();
                txtTotalPaid.Text = sum3.ToString();
                txtPaymentDue.Text = sum4.ToString();

                cc.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetData();
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

        private void txtTotalPaid_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

     
      
    }
}