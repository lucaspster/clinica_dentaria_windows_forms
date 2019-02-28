namespace DentalManagementSystem
{
    partial class frmProcedure
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label Label5;
            System.Windows.Forms.Label Label51;
            System.Windows.Forms.Label Label49;
            System.Windows.Forms.Label Label48;
            System.Windows.Forms.Label Label9;
            System.Windows.Forms.Label label6;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcedure));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.txtP_ID = new System.Windows.Forms.TextBox();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.txtToothInvolved = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPaymentDue = new System.Windows.Forms.TextBox();
            this.txtTotalPaid = new System.Windows.Forms.TextBox();
            this.txtCharges = new System.Windows.Forms.TextBox();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            this.txtCopayAmount = new System.Windows.Forms.TextBox();
            this.cmbStaffName = new System.Windows.Forms.ComboBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.txtProcedureType = new System.Windows.Forms.TextBox();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtPaymentID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.btnGetData = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            Label5 = new System.Windows.Forms.Label();
            Label51 = new System.Windows.Forms.Label();
            Label49 = new System.Windows.Forms.Label();
            Label48 = new System.Windows.Forms.Label();
            Label9 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.ForeColor = System.Drawing.Color.Black;
            Label5.Location = new System.Drawing.Point(26, 26);
            Label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            Label5.Name = "Label5";
            Label5.Size = new System.Drawing.Size(89, 15);
            Label5.TabIndex = 268;
            Label5.Text = "Pagamento ID:";
            // 
            // Label51
            // 
            Label51.AutoSize = true;
            Label51.ForeColor = System.Drawing.Color.Black;
            Label51.Location = new System.Drawing.Point(21, 258);
            Label51.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            Label51.Name = "Label51";
            Label51.Size = new System.Drawing.Size(65, 13);
            Label51.TabIndex = 319;
            Label51.Text = "Total Pago :";
            // 
            // Label49
            // 
            Label49.AutoSize = true;
            Label49.ForeColor = System.Drawing.Color.Black;
            Label49.Location = new System.Drawing.Point(22, 232);
            Label49.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            Label49.Name = "Label49";
            Label49.Size = new System.Drawing.Size(65, 13);
            Label49.TabIndex = 314;
            Label49.Text = "Total Geral :";
            // 
            // Label48
            // 
            Label48.AutoSize = true;
            Label48.ForeColor = System.Drawing.Color.Black;
            Label48.Location = new System.Drawing.Point(22, 207);
            Label48.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            Label48.Name = "Label48";
            Label48.Size = new System.Drawing.Size(58, 13);
            Label48.TabIndex = 313;
            Label48.Text = "Encargos :";
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.ForeColor = System.Drawing.Color.Black;
            Label9.Location = new System.Drawing.Point(22, 180);
            Label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            Label9.Name = "Label9";
            Label9.Size = new System.Drawing.Size(85, 13);
            Label9.TabIndex = 312;
            Label9.Text = "Valor Convênio :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = System.Drawing.Color.Black;
            label6.Location = new System.Drawing.Point(21, 284);
            label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(74, 13);
            label6.TabIndex = 320;
            label6.Text = "Valor Devido :";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.txtP_ID);
            this.Panel1.Controls.Add(this.txtStaffID);
            this.Panel1.Controls.Add(this.groupBox1);
            this.Panel1.Controls.Add(this.GroupBox2);
            this.Panel1.Controls.Add(this.GroupBox4);
            this.Panel1.Controls.Add(this.txtID);
            this.Panel1.Controls.Add(this.lblUser);
            this.Panel1.Controls.Add(this.Panel3);
            this.Panel1.Controls.Add(this.Panel2);
            this.Panel1.Location = new System.Drawing.Point(12, 12);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(717, 498);
            this.Panel1.TabIndex = 3;
            // 
            // txtP_ID
            // 
            this.txtP_ID.Location = new System.Drawing.Point(365, 165);
            this.txtP_ID.Name = "txtP_ID";
            this.txtP_ID.Size = new System.Drawing.Size(111, 21);
            this.txtP_ID.TabIndex = 11;
            this.txtP_ID.Visible = false;
            // 
            // txtStaffID
            // 
            this.txtStaffID.Location = new System.Drawing.Point(365, 219);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(111, 21);
            this.txtStaffID.TabIndex = 10;
            this.txtStaffID.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtPatientName);
            this.groupBox1.Controls.Add(this.Label3);
            this.groupBox1.Controls.Add(this.Label2);
            this.groupBox1.Controls.Add(this.txtPatientID);
            this.groupBox1.Location = new System.Drawing.Point(261, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 81);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paciente Info";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(220, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 21);
            this.button1.TabIndex = 6;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPatientName
            // 
            this.txtPatientName.BackColor = System.Drawing.Color.White;
            this.txtPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientName.Location = new System.Drawing.Point(130, 49);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(176, 21);
            this.txtPatientName.TabIndex = 1;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(21, 24);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(76, 15);
            this.Label3.TabIndex = 0;
            this.Label3.Text = "Paciente ID :";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(21, 49);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(98, 15);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "Nome Paciente :";
            // 
            // txtPatientID
            // 
            this.txtPatientID.BackColor = System.Drawing.SystemColors.Control;
            this.txtPatientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientID.Location = new System.Drawing.Point(130, 24);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.ReadOnly = true;
            this.txtPatientID.Size = new System.Drawing.Size(84, 21);
            this.txtPatientID.TabIndex = 0;
            // 
            // GroupBox2
            // 
            this.GroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox2.Controls.Add(this.txtToothInvolved);
            this.GroupBox2.Controls.Add(this.label7);
            this.GroupBox2.Controls.Add(this.txtPaymentDue);
            this.GroupBox2.Controls.Add(label6);
            this.GroupBox2.Controls.Add(this.txtTotalPaid);
            this.GroupBox2.Controls.Add(Label51);
            this.GroupBox2.Controls.Add(this.txtCharges);
            this.GroupBox2.Controls.Add(this.txtGrandTotal);
            this.GroupBox2.Controls.Add(Label49);
            this.GroupBox2.Controls.Add(this.txtCopayAmount);
            this.GroupBox2.Controls.Add(Label48);
            this.GroupBox2.Controls.Add(Label9);
            this.GroupBox2.Controls.Add(this.cmbStaffName);
            this.GroupBox2.Controls.Add(this.Label8);
            this.GroupBox2.Controls.Add(this.txtDescription);
            this.GroupBox2.Controls.Add(this.Label11);
            this.GroupBox2.Controls.Add(this.Label12);
            this.GroupBox2.Controls.Add(this.txtProcedureType);
            this.GroupBox2.Controls.Add(this.txtDesignation);
            this.GroupBox2.Controls.Add(this.Label10);
            this.GroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.Location = new System.Drawing.Point(9, 166);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(350, 319);
            this.GroupBox2.TabIndex = 2;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Detalhes do Produto";
            // 
            // txtToothInvolved
            // 
            this.txtToothInvolved.Location = new System.Drawing.Point(116, 155);
            this.txtToothInvolved.Name = "txtToothInvolved";
            this.txtToothInvolved.Size = new System.Drawing.Size(84, 20);
            this.txtToothInvolved.TabIndex = 4;
            this.txtToothInvolved.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtToothInvolved.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtToothInvolved_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 322;
            this.label7.Text = "Dente :";
            // 
            // txtPaymentDue
            // 
            this.txtPaymentDue.Location = new System.Drawing.Point(116, 284);
            this.txtPaymentDue.Name = "txtPaymentDue";
            this.txtPaymentDue.ReadOnly = true;
            this.txtPaymentDue.Size = new System.Drawing.Size(84, 20);
            this.txtPaymentDue.TabIndex = 9;
            this.txtPaymentDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalPaid
            // 
            this.txtTotalPaid.Location = new System.Drawing.Point(116, 258);
            this.txtTotalPaid.Name = "txtTotalPaid";
            this.txtTotalPaid.Size = new System.Drawing.Size(84, 20);
            this.txtTotalPaid.TabIndex = 8;
            this.txtTotalPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalPaid.TextChanged += new System.EventHandler(this.txtTotalPaid_TextChanged);
            this.txtTotalPaid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalPaid_KeyPress);
            this.txtTotalPaid.Validating += new System.ComponentModel.CancelEventHandler(this.txtTotalPaid_Validating);
            // 
            // txtCharges
            // 
            this.txtCharges.Location = new System.Drawing.Point(116, 207);
            this.txtCharges.Name = "txtCharges";
            this.txtCharges.Size = new System.Drawing.Size(84, 20);
            this.txtCharges.TabIndex = 6;
            this.txtCharges.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCharges.TextChanged += new System.EventHandler(this.txtCharges_TextChanged);
            this.txtCharges.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCharges_KeyPress);
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.Location = new System.Drawing.Point(116, 232);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.ReadOnly = true;
            this.txtGrandTotal.Size = new System.Drawing.Size(84, 20);
            this.txtGrandTotal.TabIndex = 7;
            this.txtGrandTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCopayAmount
            // 
            this.txtCopayAmount.Location = new System.Drawing.Point(116, 181);
            this.txtCopayAmount.Name = "txtCopayAmount";
            this.txtCopayAmount.Size = new System.Drawing.Size(84, 20);
            this.txtCopayAmount.TabIndex = 5;
            this.txtCopayAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCopayAmount.TextChanged += new System.EventHandler(this.txtCopayAmount_TextChanged);
            this.txtCopayAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCopayAmount_KeyPress);
            // 
            // cmbStaffName
            // 
            this.cmbStaffName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbStaffName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbStaffName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStaffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStaffName.FormattingEnabled = true;
            this.cmbStaffName.Location = new System.Drawing.Point(116, 26);
            this.cmbStaffName.Name = "cmbStaffName";
            this.cmbStaffName.Size = new System.Drawing.Size(218, 21);
            this.cmbStaffName.TabIndex = 0;
            this.cmbStaffName.SelectedIndexChanged += new System.EventHandler(this.cmbStaffName_SelectedIndexChanged);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(22, 26);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(68, 13);
            this.Label8.TabIndex = 95;
            this.Label8.Text = "Funcionário :";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(116, 102);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDescription.Size = new System.Drawing.Size(218, 46);
            this.txtDescription.TabIndex = 3;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(22, 77);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(68, 13);
            this.Label11.TabIndex = 89;
            this.Label11.Text = "Tipo Proced.";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(22, 52);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(41, 13);
            this.Label12.TabIndex = 87;
            this.Label12.Text = "Cargo :";
            // 
            // txtProcedureType
            // 
            this.txtProcedureType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcedureType.Location = new System.Drawing.Point(116, 77);
            this.txtProcedureType.Name = "txtProcedureType";
            this.txtProcedureType.Size = new System.Drawing.Size(165, 20);
            this.txtProcedureType.TabIndex = 2;
            // 
            // txtDesignation
            // 
            this.txtDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesignation.Location = new System.Drawing.Point(116, 52);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.ReadOnly = true;
            this.txtDesignation.Size = new System.Drawing.Size(165, 20);
            this.txtDesignation.TabIndex = 1;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(22, 102);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(61, 13);
            this.Label10.TabIndex = 76;
            this.Label10.Text = "Descrição :";
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.dtpDate);
            this.GroupBox4.Controls.Add(this.txtPaymentID);
            this.GroupBox4.Controls.Add(this.label4);
            this.GroupBox4.Controls.Add(Label5);
            this.GroupBox4.Location = new System.Drawing.Point(9, 75);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(246, 81);
            this.GroupBox4.TabIndex = 0;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "Info Pagamento";
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd/MMM/yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(119, 45);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(111, 21);
            this.dtpDate.TabIndex = 1;
            // 
            // txtPaymentID
            // 
            this.txtPaymentID.Location = new System.Drawing.Point(119, 19);
            this.txtPaymentID.Name = "txtPaymentID";
            this.txtPaymentID.ReadOnly = true;
            this.txtPaymentID.Size = new System.Drawing.Size(111, 21);
            this.txtPaymentID.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 335;
            this.label4.Text = "Data :";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(365, 192);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(111, 21);
            this.txtID.TabIndex = 4;
            this.txtID.Visible = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(365, 244);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(45, 15);
            this.lblUser.TabIndex = 5;
            this.lblUser.Text = "Label8";
            this.lblUser.Visible = false;
            // 
            // Panel3
            // 
            this.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel3.Controls.Add(this.btnGetData);
            this.Panel3.Controls.Add(this.btnDelete);
            this.Panel3.Controls.Add(this.btnClose);
            this.Panel3.Controls.Add(this.btnUpdate);
            this.Panel3.Controls.Add(this.btnSave);
            this.Panel3.Controls.Add(this.btnNew);
            this.Panel3.Location = new System.Drawing.Point(594, 85);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(111, 203);
            this.Panel3.TabIndex = 2;
            // 
            // btnGetData
            // 
            this.btnGetData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGetData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetData.Location = new System.Drawing.Point(13, 135);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(82, 28);
            this.btnGetData.TabIndex = 5;
            this.btnGetData.Text = "Ver Dados";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(13, 103);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 28);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Deletar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(13, 167);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(82, 28);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Fechar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(13, 72);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 28);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(13, 41);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 28);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(13, 10);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(82, 28);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "Novo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel2.Controls.Add(this.Label1);
            this.Panel2.Location = new System.Drawing.Point(9, 7);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(696, 62);
            this.Panel2.TabIndex = 0;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(272, 17);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(140, 24);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Procedimento";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmProcedure
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(739, 521);
            this.Controls.Add(this.Panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProcedure";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.frmProcedure_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.Panel3.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label lblUser;
        internal System.Windows.Forms.TextBox txtID;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtPatientID;
        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Button btnUpdate;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.Button btnNew;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtPatientName;
        internal System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        internal System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.TextBox txtTotalPaid;
        internal System.Windows.Forms.TextBox txtCharges;
        internal System.Windows.Forms.TextBox txtGrandTotal;
        internal System.Windows.Forms.TextBox txtCopayAmount;
        internal System.Windows.Forms.ComboBox cmbStaffName;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox txtDescription;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.TextBox txtProcedureType;
        internal System.Windows.Forms.TextBox txtDesignation;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.GroupBox GroupBox4;
        internal System.Windows.Forms.DateTimePicker dtpDate;
        internal System.Windows.Forms.TextBox txtPaymentID;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Button button1;
        internal System.Windows.Forms.TextBox txtStaffID;
        internal System.Windows.Forms.TextBox txtPaymentDue;
        internal System.Windows.Forms.TextBox txtP_ID;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox txtToothInvolved;

    }
}

