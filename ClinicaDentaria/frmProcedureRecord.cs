using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace DentalManagementSystem
{
    public partial class frmProcedureRecord : Form
    {
        ConnectionString cs = new ConnectionString();
        CommonClasses cc = new CommonClasses();
        public frmProcedureRecord()
        {
            InitializeComponent();
        }
        public void GetData()
        {
            try
            {
                cc.con = new SqlConnection(cs.DBConn);
                cc.con.Open();
                cc.cmd = new SqlCommand("Select RTRIM(Pay_Id) as [ID],RTRIM(PaymentID) as [Pagamento ID],Date,RTRIM(P_ID) as [PID],RTRIM(Patient.PatientID) as [Paciente ID],RTRIM(Patient.name) as [Nome Paciente],RTRIM(S_ID) as [SID],RTRIM(Staff.name) as [Funcionário],RTRIM(Type) as [Cargo],RTRIM(ProcedureType) as [Tipo Proced.],RTRIM(Description) as [Descricão],RTRIM(ToothInvolved) as [Dente],RTRIM(CopayAmount) as [Valor Convên.],RTRIM(Charges) as [Encargos],RTRIM(GrandTotal) as [Total Geral],RTRIM(TotalPaid) as [Total Pago],RTRIM(PaymentDue) as [Valor Devido] from Patient,[Procedure],Staff where Patient.P_ID=[Procedure].PatientID and Staff.S_ID=[Procedure].StaffID order by date", cc.con);
                cc.da = new SqlDataAdapter(cc.cmd);
                cc.ds = new DataSet();
                cc.da.Fill(cc.ds, "Procedure");
                dgw.DataSource = cc.ds.Tables["Procedure"].DefaultView;
                cc.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtPatientName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cc.con = new SqlConnection(cs.DBConn);
                cc.con.Open();
                cc.cmd = new SqlCommand("Select RTRIM(Pay_Id) as [ID],RTRIM(PaymentID) as [Pagamento ID],Date,RTRIM(P_ID) as [PID],RTRIM(Patient.PatientID) as [Paciente ID],RTRIM(Patient.name) as [Nome Paciente],RTRIM(S_ID) as [SID],RTRIM(Staff.name) as [Funcionário],RTRIM(Type) as [Cargo],RTRIM(ProcedureType) as [Tipo Proced.],RTRIM(Description) as [Descricão],RTRIM(ToothInvolved) as [Dente],RTRIM(CopayAmount) as [Valor Convên.],RTRIM(Charges) as [Encargos],RTRIM(GrandTotal) as [Total Geral],RTRIM(TotalPaid) as [Total Pago],RTRIM(PaymentDue) as [Valor Devido] from Patient,[Procedure],Staff where Patient.P_ID=[Procedure].PatientID and Staff.S_ID=[Procedure].StaffID  and Patient.name like '" + txtPatientName.Text + "%' order by Patient.name", cc.con);
                cc.da = new SqlDataAdapter(cc.cmd);
                cc.ds = new DataSet();
                cc.da.Fill(cc.ds, "Customer");
                dgw.DataSource = cc.ds.Tables["Customer"].DefaultView;
                cc.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Reset()
        {
            txtPatientName.Text = "";
            dtpDateFrom.Text = System.DateTime.Today.ToString();
            dtpDateTo.Text = System.DateTime.Now.ToString();
            GetData();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgw_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            string strRowNumber = (e.RowIndex + 1).ToString();
            SizeF size = e.Graphics.MeasureString(strRowNumber, this.Font);
            if (dgw.RowHeadersWidth < Convert.ToInt32((size.Width + 20)))
            {
               dgw.RowHeadersWidth = Convert.ToInt32((size.Width + 20));
            }
            Brush b = SystemBrushes.ControlText;
            e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
     
        }

        private void dgw_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (lblOperation.Text == "Procedimento")
                {
                    DataGridViewRow dr = dgw.SelectedRows[0];
                    this.Hide();
                    frmProcedure frm = new frmProcedure();
                    frm.Show();
                    frm.txtID.Text = dr.Cells[0].Value.ToString();
                    frm.txtPaymentID.Text = dr.Cells[1].Value.ToString();
                    frm.dtpDate.Text = dr.Cells[2].Value.ToString();
                    frm.txtP_ID.Text = dr.Cells[3].Value.ToString();
                    frm.txtPatientID.Text = dr.Cells[4].Value.ToString();
                    frm.txtPatientName.Text = dr.Cells[5].Value.ToString();
                    frm.txtStaffID.Text = dr.Cells[6].Value.ToString();
                    frm.cmbStaffName.Text = dr.Cells[7].Value.ToString();
                    frm.txtDesignation.Text = dr.Cells[8].Value.ToString();
                    frm.txtProcedureType.Text = dr.Cells[9].Value.ToString();
                    frm.txtDescription.Text = dr.Cells[10].Value.ToString();
                    frm.txtToothInvolved.Text = dr.Cells[11].Value.ToString();
                    frm.txtCopayAmount.Text = dr.Cells[12].Value.ToString();
                    frm.txtCharges.Text = dr.Cells[13].Value.ToString();
                    frm.txtGrandTotal.Text = dr.Cells[14].Value.ToString();
                    frm.txtTotalPaid.Text = dr.Cells[15].Value.ToString();
                    frm.txtPaymentDue.Text = dr.Cells[16].Value.ToString();
                    frm.dtpDate.Enabled = false;
                    frm.btnUpdate.Enabled = true;
                    frm.btnDelete.Enabled = true;
                    frm.btnSave.Enabled = false;
                    frm.lblUser.Text = lblUser.Text;
                    lblOperation.Text = "";
                }
             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCustomerRecord_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            try
            {
                cc.con = new SqlConnection(cs.DBConn);
                cc.con.Open();
                cc.cmd = new SqlCommand("Select RTRIM(Pay_Id) as [ID],RTRIM(PaymentID) as [Pagamento ID],Date,RTRIM(P_ID) as [PID],RTRIM(Patient.PatientID) as [Paciente ID],RTRIM(Patient.name) as [Nome Paciente],RTRIM(S_ID) as [SID],RTRIM(Staff.name) as [Funcionário],RTRIM(Type) as [Cargo],RTRIM(ProcedureType) as [Tipo Proced.],RTRIM(Description) as [Descricão],RTRIM(ToothInvolved) as [Dente],RTRIM(CopayAmount) as [Valor Convên.],RTRIM(Charges) as [Encargos],RTRIM(GrandTotal) as [Total Geral],RTRIM(TotalPaid) as [Total Pago],RTRIM(PaymentDue) as [Valor Devido] from Patient,[Procedure],Staff where Patient.P_ID=[Procedure].PatientID and Staff.S_ID=[Procedure].StaffID and Date between @d1 and @d2 order by Date", cc.con);
                cc.cmd.Parameters.Add("@d1", SqlDbType.DateTime, 30, "Date").Value = dtpDateFrom.Value.Date;
                cc.cmd.Parameters.Add("@d2", SqlDbType.DateTime, 30, "Date").Value = dtpDateTo.Value;
                cc.da = new SqlDataAdapter(cc.cmd);
                cc.ds = new DataSet();
                cc.da.Fill(cc.ds, "Customer");
                dgw.DataSource = cc.ds.Tables["Customer"].DefaultView;
                cc.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
