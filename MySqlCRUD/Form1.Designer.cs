namespace MySqlCRUD
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEdi = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.raea = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvAutor = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.btnBuscarAutor = new System.Windows.Forms.Button();
            this.btnAgregarAutor = new System.Windows.Forms.Button();
            this.txtapellidoa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnombrea = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAutorBuscar = new System.Windows.Forms.TextBox();
            this.txtcoda = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvPrestamo = new System.Windows.Forms.DataGridView();
            this.btnEliminarP = new System.Windows.Forms.Button();
            this.btnBuscarPrestamo = new System.Windows.Forms.Button();
            this.btnAgregarp = new System.Windows.Forms.Button();
            this.txtcodlp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtcodap = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtbuscarp = new System.Windows.Forms.TextBox();
            this.txtcodp = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtnacionalidada = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "CODIGO:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCod
            // 
            this.txtCod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.Location = new System.Drawing.Point(162, 105);
            this.txtCod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(217, 29);
            this.txtCod.TabIndex = 1;
            this.txtCod.TextChanged += new System.EventHandler(this.txtBookName_TextChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(149, 286);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(112, 37);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Agregar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvBook
            // 
            this.dgvBook.AllowUserToAddRows = false;
            this.dgvBook.AllowUserToDeleteRows = false;
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Location = new System.Drawing.Point(421, 105);
            this.dgvBook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.ReadOnly = true;
            this.dgvBook.RowHeadersWidth = 51;
            this.dgvBook.Size = new System.Drawing.Size(367, 176);
            this.dgvBook.TabIndex = 3;
            this.dgvBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBook_CellContentClick);
            this.dgvBook.DoubleClick += new System.EventHandler(this.dgvBook_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 147);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "TITULO:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtTit
            // 
            this.txtTit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTit.Location = new System.Drawing.Point(162, 144);
            this.txtTit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTit.Name = "txtTit";
            this.txtTit.Size = new System.Drawing.Size(217, 29);
            this.txtTit.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 183);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "EDITORIAL:";
            // 
            // txtEdi
            // 
            this.txtEdi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdi.Location = new System.Drawing.Point(162, 183);
            this.txtEdi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEdi.Multiline = true;
            this.txtEdi.Name = "txtEdi";
            this.txtEdi.Size = new System.Drawing.Size(217, 38);
            this.txtEdi.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(269, 286);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 37);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(162, 231);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(219, 29);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(19, 226);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 37);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "BUSCAR";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // raea
            // 
            this.raea.AutoSize = true;
            this.raea.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raea.Location = new System.Drawing.Point(991, 56);
            this.raea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.raea.Name = "raea";
            this.raea.Size = new System.Drawing.Size(60, 21);
            this.raea.TabIndex = 4;
            this.raea.Text = "AUTOR";
            this.raea.Click += new System.EventHandler(this.raea_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(208, 56);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "LIBRO";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dgvAutor
            // 
            this.dgvAutor.AllowUserToAddRows = false;
            this.dgvAutor.AllowUserToDeleteRows = false;
            this.dgvAutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutor.Location = new System.Drawing.Point(1226, 108);
            this.dgvAutor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvAutor.Name = "dgvAutor";
            this.dgvAutor.ReadOnly = true;
            this.dgvAutor.RowHeadersWidth = 51;
            this.dgvAutor.Size = new System.Drawing.Size(442, 176);
            this.dgvAutor.TabIndex = 16;
            this.dgvAutor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAutor_CellContentClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1096, 329);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 37);
            this.button2.TabIndex = 13;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBuscarAutor
            // 
            this.btnBuscarAutor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscarAutor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarAutor.ForeColor = System.Drawing.Color.White;
            this.btnBuscarAutor.Location = new System.Drawing.Point(812, 282);
            this.btnBuscarAutor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscarAutor.Name = "btnBuscarAutor";
            this.btnBuscarAutor.Size = new System.Drawing.Size(112, 37);
            this.btnBuscarAutor.TabIndex = 14;
            this.btnBuscarAutor.Text = "BUSCAR";
            this.btnBuscarAutor.UseVisualStyleBackColor = false;
            this.btnBuscarAutor.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAgregarAutor
            // 
            this.btnAgregarAutor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregarAutor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAutor.ForeColor = System.Drawing.Color.White;
            this.btnAgregarAutor.Location = new System.Drawing.Point(943, 329);
            this.btnAgregarAutor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregarAutor.Name = "btnAgregarAutor";
            this.btnAgregarAutor.Size = new System.Drawing.Size(123, 37);
            this.btnAgregarAutor.TabIndex = 15;
            this.btnAgregarAutor.Text = "Agregar";
            this.btnAgregarAutor.UseVisualStyleBackColor = false;
            this.btnAgregarAutor.Click += new System.EventHandler(this.btnAgregarAutor_Click);
            // 
            // txtapellidoa
            // 
            this.txtapellidoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapellidoa.Location = new System.Drawing.Point(941, 186);
            this.txtapellidoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtapellidoa.Multiline = true;
            this.txtapellidoa.Name = "txtapellidoa";
            this.txtapellidoa.Size = new System.Drawing.Size(275, 38);
            this.txtapellidoa.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(808, 200);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "APELLIDO:";
            // 
            // txtnombrea
            // 
            this.txtnombrea.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombrea.Location = new System.Drawing.Point(941, 147);
            this.txtnombrea.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnombrea.Name = "txtnombrea";
            this.txtnombrea.Size = new System.Drawing.Size(275, 29);
            this.txtnombrea.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(808, 155);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "NOMBRE:";
            // 
            // txtAutorBuscar
            // 
            this.txtAutorBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutorBuscar.Location = new System.Drawing.Point(941, 286);
            this.txtAutorBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAutorBuscar.Name = "txtAutorBuscar";
            this.txtAutorBuscar.Size = new System.Drawing.Size(275, 29);
            this.txtAutorBuscar.TabIndex = 10;
            // 
            // txtcoda
            // 
            this.txtcoda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcoda.Location = new System.Drawing.Point(941, 108);
            this.txtcoda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcoda.Name = "txtcoda";
            this.txtcoda.Size = new System.Drawing.Size(275, 29);
            this.txtcoda.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(813, 111);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "CODIGO:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(623, 365);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 21);
            this.label8.TabIndex = 30;
            this.label8.Text = "PRESTAMO";
            // 
            // dgvPrestamo
            // 
            this.dgvPrestamo.AllowUserToAddRows = false;
            this.dgvPrestamo.AllowUserToDeleteRows = false;
            this.dgvPrestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamo.Location = new System.Drawing.Point(819, 417);
            this.dgvPrestamo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvPrestamo.Name = "dgvPrestamo";
            this.dgvPrestamo.ReadOnly = true;
            this.dgvPrestamo.RowHeadersWidth = 51;
            this.dgvPrestamo.Size = new System.Drawing.Size(357, 176);
            this.dgvPrestamo.TabIndex = 29;
            // 
            // btnEliminarP
            // 
            this.btnEliminarP.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminarP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarP.ForeColor = System.Drawing.Color.White;
            this.btnEliminarP.Location = new System.Drawing.Point(676, 606);
            this.btnEliminarP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarP.Name = "btnEliminarP";
            this.btnEliminarP.Size = new System.Drawing.Size(112, 37);
            this.btnEliminarP.TabIndex = 26;
            this.btnEliminarP.Text = "Eliminar";
            this.btnEliminarP.UseVisualStyleBackColor = false;
            this.btnEliminarP.Click += new System.EventHandler(this.btnEliminarP_Click);
            // 
            // btnBuscarPrestamo
            // 
            this.btnBuscarPrestamo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscarPrestamo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPrestamo.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPrestamo.Location = new System.Drawing.Point(431, 543);
            this.btnBuscarPrestamo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscarPrestamo.Name = "btnBuscarPrestamo";
            this.btnBuscarPrestamo.Size = new System.Drawing.Size(112, 37);
            this.btnBuscarPrestamo.TabIndex = 27;
            this.btnBuscarPrestamo.Text = "BUSCAR";
            this.btnBuscarPrestamo.UseVisualStyleBackColor = false;
            this.btnBuscarPrestamo.Click += new System.EventHandler(this.btnBuscarPrestamo_Click);
            // 
            // btnAgregarp
            // 
            this.btnAgregarp.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregarp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarp.ForeColor = System.Drawing.Color.White;
            this.btnAgregarp.Location = new System.Drawing.Point(556, 606);
            this.btnAgregarp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregarp.Name = "btnAgregarp";
            this.btnAgregarp.Size = new System.Drawing.Size(112, 37);
            this.btnAgregarp.TabIndex = 28;
            this.btnAgregarp.Text = "Agregar";
            this.btnAgregarp.UseVisualStyleBackColor = false;
            this.btnAgregarp.Click += new System.EventHandler(this.btnAgregarp_Click);
            // 
            // txtcodlp
            // 
            this.txtcodlp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodlp.Location = new System.Drawing.Point(560, 495);
            this.txtcodlp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcodlp.Multiline = true;
            this.txtcodlp.Name = "txtcodlp";
            this.txtcodlp.Size = new System.Drawing.Size(217, 38);
            this.txtcodlp.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(454, 498);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 21);
            this.label9.TabIndex = 18;
            this.label9.Text = "CodLibro:";
            // 
            // txtcodap
            // 
            this.txtcodap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodap.Location = new System.Drawing.Point(560, 456);
            this.txtcodap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcodap.Name = "txtcodap";
            this.txtcodap.Size = new System.Drawing.Size(217, 29);
            this.txtcodap.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(454, 459);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 21);
            this.label10.TabIndex = 19;
            this.label10.Text = "CodAutor:";
            // 
            // txtbuscarp
            // 
            this.txtbuscarp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscarp.Location = new System.Drawing.Point(560, 543);
            this.txtbuscarp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbuscarp.Name = "txtbuscarp";
            this.txtbuscarp.Size = new System.Drawing.Size(217, 29);
            this.txtbuscarp.TabIndex = 23;
            // 
            // txtcodp
            // 
            this.txtcodp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodp.Location = new System.Drawing.Point(560, 417);
            this.txtcodp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcodp.Name = "txtcodp";
            this.txtcodp.Size = new System.Drawing.Size(217, 29);
            this.txtcodp.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(454, 420);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 21);
            this.label11.TabIndex = 20;
            this.label11.Text = "Fecha:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(808, 242);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 21);
            this.label12.TabIndex = 31;
            this.label12.Text = "NACIONALIDAD:";
            // 
            // txtnacionalidada
            // 
            this.txtnacionalidada.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnacionalidada.Location = new System.Drawing.Point(943, 234);
            this.txtnacionalidada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnacionalidada.Name = "txtnacionalidada";
            this.txtnacionalidada.Size = new System.Drawing.Size(275, 29);
            this.txtnacionalidada.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1681, 657);
            this.Controls.Add(this.txtnacionalidada);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvPrestamo);
            this.Controls.Add(this.btnEliminarP);
            this.Controls.Add(this.btnBuscarPrestamo);
            this.Controls.Add(this.btnAgregarp);
            this.Controls.Add(this.txtcodlp);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtcodap);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtbuscarp);
            this.Controls.Add(this.txtcodp);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvAutor);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnBuscarAutor);
            this.Controls.Add(this.btnAgregarAutor);
            this.Controls.Add(this.txtapellidoa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtnombrea);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAutorBuscar);
            this.Controls.Add(this.txtcoda);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.raea);
            this.Controls.Add(this.dgvBook);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtEdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "MySql CRUD APP";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEdi;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label raea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvAutor;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnBuscarAutor;
        private System.Windows.Forms.Button btnAgregarAutor;
        private System.Windows.Forms.TextBox txtapellidoa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnombrea;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAutorBuscar;
        private System.Windows.Forms.TextBox txtcoda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvPrestamo;
        private System.Windows.Forms.Button btnEliminarP;
        private System.Windows.Forms.Button btnBuscarPrestamo;
        private System.Windows.Forms.Button btnAgregarp;
        private System.Windows.Forms.TextBox txtcodlp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtcodap;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtbuscarp;
        private System.Windows.Forms.TextBox txtcodp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtnacionalidada;
    }
}

