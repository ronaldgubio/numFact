namespace numFact
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonProvisional = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewFE = new System.Windows.Forms.DataGridView();
            this.dataGridViewVentas = new System.Windows.Forms.DataGridView();
            this.buttonProcesarFacturasElectronicas = new System.Windows.Forms.Button();
            this.buttonProcesarVentas = new System.Windows.Forms.Button();
            this.buttonIniciarDia = new System.Windows.Forms.Button();
            this.buttonProcesarTransaccionFE = new System.Windows.Forms.Button();
            this.textBoxTransaccionCodigo = new System.Windows.Forms.TextBox();
            this.panelOculto = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PLATAFORMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR_DIFERENCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOTIVO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMERO_PEDIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMERO_TRANS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RESPONSABLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PERSONA_AUTORIZADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMENTARIOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.btnProcesarPlataformas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVentas)).BeginInit();
            this.panelOculto.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonProvisional
            // 
            this.buttonProvisional.Location = new System.Drawing.Point(3, 98);
            this.buttonProvisional.Margin = new System.Windows.Forms.Padding(4);
            this.buttonProvisional.Name = "buttonProvisional";
            this.buttonProvisional.Size = new System.Drawing.Size(148, 71);
            this.buttonProvisional.TabIndex = 15;
            this.buttonProvisional.Text = "procesar facturas no pasadas";
            this.buttonProvisional.UseVisualStyleBackColor = true;
            this.buttonProvisional.Click += new System.EventHandler(this.buttonProvisional_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(701, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Documentos xml pendientes:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(305, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ventas pendientes:";
            // 
            // dataGridViewFE
            // 
            this.dataGridViewFE.AllowUserToAddRows = false;
            this.dataGridViewFE.AllowUserToDeleteRows = false;
            this.dataGridViewFE.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFE.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewFE.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewFE.Location = new System.Drawing.Point(695, 148);
            this.dataGridViewFE.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewFE.MultiSelect = false;
            this.dataGridViewFE.Name = "dataGridViewFE";
            this.dataGridViewFE.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFE.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewFE.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewFE.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewFE.ShowEditingIcon = false;
            this.dataGridViewFE.Size = new System.Drawing.Size(345, 185);
            this.dataGridViewFE.TabIndex = 12;
            // 
            // dataGridViewVentas
            // 
            this.dataGridViewVentas.AllowUserToAddRows = false;
            this.dataGridViewVentas.AllowUserToDeleteRows = false;
            this.dataGridViewVentas.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewVentas.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewVentas.Location = new System.Drawing.Point(303, 148);
            this.dataGridViewVentas.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewVentas.MultiSelect = false;
            this.dataGridViewVentas.Name = "dataGridViewVentas";
            this.dataGridViewVentas.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewVentas.RowHeadersWidth = 51;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewVentas.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewVentas.ShowEditingIcon = false;
            this.dataGridViewVentas.Size = new System.Drawing.Size(371, 185);
            this.dataGridViewVentas.TabIndex = 11;
            this.dataGridViewVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVentas_CellContentClick);
            // 
            // buttonProcesarFacturasElectronicas
            // 
            this.buttonProcesarFacturasElectronicas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(128)))));
            this.buttonProcesarFacturasElectronicas.FlatAppearance.BorderSize = 0;
            this.buttonProcesarFacturasElectronicas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProcesarFacturasElectronicas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProcesarFacturasElectronicas.ForeColor = System.Drawing.Color.Black;
            this.buttonProcesarFacturasElectronicas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProcesarFacturasElectronicas.Location = new System.Drawing.Point(695, 354);
            this.buttonProcesarFacturasElectronicas.Margin = new System.Windows.Forms.Padding(4);
            this.buttonProcesarFacturasElectronicas.Name = "buttonProcesarFacturasElectronicas";
            this.buttonProcesarFacturasElectronicas.Size = new System.Drawing.Size(345, 59);
            this.buttonProcesarFacturasElectronicas.TabIndex = 10;
            this.buttonProcesarFacturasElectronicas.Text = "4.- Procesar FE";
            this.buttonProcesarFacturasElectronicas.UseVisualStyleBackColor = false;
            this.buttonProcesarFacturasElectronicas.Click += new System.EventHandler(this.buttonProcesarFacturasElectronicas_Click);
            // 
            // buttonProcesarVentas
            // 
            this.buttonProcesarVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(128)))));
            this.buttonProcesarVentas.FlatAppearance.BorderSize = 0;
            this.buttonProcesarVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProcesarVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProcesarVentas.ForeColor = System.Drawing.Color.Black;
            this.buttonProcesarVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProcesarVentas.Location = new System.Drawing.Point(303, 354);
            this.buttonProcesarVentas.Margin = new System.Windows.Forms.Padding(4);
            this.buttonProcesarVentas.Name = "buttonProcesarVentas";
            this.buttonProcesarVentas.Size = new System.Drawing.Size(371, 59);
            this.buttonProcesarVentas.TabIndex = 9;
            this.buttonProcesarVentas.Text = "3.- Procesar ventas";
            this.buttonProcesarVentas.UseVisualStyleBackColor = false;
            this.buttonProcesarVentas.Click += new System.EventHandler(this.buttonProcesarVentas_Click);
            // 
            // buttonIniciarDia
            // 
            this.buttonIniciarDia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(128)))));
            this.buttonIniciarDia.FlatAppearance.BorderSize = 0;
            this.buttonIniciarDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIniciarDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIniciarDia.ForeColor = System.Drawing.Color.Black;
            this.buttonIniciarDia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonIniciarDia.Location = new System.Drawing.Point(45, 354);
            this.buttonIniciarDia.Margin = new System.Windows.Forms.Padding(4);
            this.buttonIniciarDia.Name = "buttonIniciarDia";
            this.buttonIniciarDia.Size = new System.Drawing.Size(241, 59);
            this.buttonIniciarDia.TabIndex = 8;
            this.buttonIniciarDia.Text = "1.- Iniciar día";
            this.buttonIniciarDia.UseVisualStyleBackColor = false;
            this.buttonIniciarDia.Click += new System.EventHandler(this.buttonIniciarDia_Click);
            // 
            // buttonProcesarTransaccionFE
            // 
            this.buttonProcesarTransaccionFE.Location = new System.Drawing.Point(3, 63);
            this.buttonProcesarTransaccionFE.Margin = new System.Windows.Forms.Padding(4);
            this.buttonProcesarTransaccionFE.Name = "buttonProcesarTransaccionFE";
            this.buttonProcesarTransaccionFE.Size = new System.Drawing.Size(239, 28);
            this.buttonProcesarTransaccionFE.TabIndex = 16;
            this.buttonProcesarTransaccionFE.Text = "Procesar transacción FE";
            this.buttonProcesarTransaccionFE.UseVisualStyleBackColor = true;
            this.buttonProcesarTransaccionFE.Click += new System.EventHandler(this.buttonProcesarTransaccionFE_Click);
            // 
            // textBoxTransaccionCodigo
            // 
            this.textBoxTransaccionCodigo.Location = new System.Drawing.Point(3, 31);
            this.textBoxTransaccionCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTransaccionCodigo.Name = "textBoxTransaccionCodigo";
            this.textBoxTransaccionCodigo.Size = new System.Drawing.Size(237, 22);
            this.textBoxTransaccionCodigo.TabIndex = 17;
            // 
            // panelOculto
            // 
            this.panelOculto.Controls.Add(this.button1);
            this.panelOculto.Controls.Add(this.textBoxTransaccionCodigo);
            this.panelOculto.Controls.Add(this.buttonProcesarTransaccionFE);
            this.panelOculto.Controls.Add(this.buttonProvisional);
            this.panelOculto.Location = new System.Drawing.Point(29, 117);
            this.panelOculto.Margin = new System.Windows.Forms.Padding(4);
            this.panelOculto.Name = "panelOculto";
            this.panelOculto.Size = new System.Drawing.Size(255, 214);
            this.panelOculto.TabIndex = 18;
            this.panelOculto.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 100);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 28);
            this.button1.TabIndex = 18;
            this.button1.Text = "tablas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(268, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(546, 29);
            this.label3.TabIndex = 19;
            this.label3.Text = "Procesamiento de información LTG V 2024.06";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.buttonCerrar);
            this.panel2.Controls.Add(this.label3);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1267, 86);
            this.panel2.TabIndex = 20;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.FlatAppearance.BorderSize = 0;
            this.buttonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCerrar.ForeColor = System.Drawing.Color.Black;
            this.buttonCerrar.Location = new System.Drawing.Point(941, 6);
            this.buttonCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(100, 59);
            this.buttonCerrar.TabIndex = 20;
            this.buttonCerrar.Text = "X";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PLATAFORMA,
            this.VALOR_DIFERENCIA,
            this.MOTIVO,
            this.NUMERO_PEDIDO,
            this.NUMERO_TRANS,
            this.RESPONSABLE,
            this.PERSONA_AUTORIZADO,
            this.COMENTARIOS,
            this.btnDelete});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.Location = new System.Drawing.Point(13, 463);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView1.Size = new System.Drawing.Size(1033, 246);
            this.dataGridView1.TabIndex = 21;
            // 
            // PLATAFORMA
            // 
            this.PLATAFORMA.HeaderText = "PLATAFORMA";
            this.PLATAFORMA.MinimumWidth = 6;
            this.PLATAFORMA.Name = "PLATAFORMA";
            // 
            // VALOR_DIFERENCIA
            // 
            this.VALOR_DIFERENCIA.HeaderText = "VALOR DE DIFERENCIA";
            this.VALOR_DIFERENCIA.MinimumWidth = 6;
            this.VALOR_DIFERENCIA.Name = "VALOR_DIFERENCIA";
            // 
            // MOTIVO
            // 
            this.MOTIVO.HeaderText = "MOTIVO";
            this.MOTIVO.MinimumWidth = 6;
            this.MOTIVO.Name = "MOTIVO";
            // 
            // NUMERO_PEDIDO
            // 
            this.NUMERO_PEDIDO.HeaderText = " NÚMERO DE PEDIDO";
            this.NUMERO_PEDIDO.MinimumWidth = 6;
            this.NUMERO_PEDIDO.Name = "NUMERO_PEDIDO";
            // 
            // NUMERO_TRANS
            // 
            this.NUMERO_TRANS.HeaderText = " NÚMERO DE  TRANSACCIÓN ";
            this.NUMERO_TRANS.MinimumWidth = 6;
            this.NUMERO_TRANS.Name = "NUMERO_TRANS";
            // 
            // RESPONSABLE
            // 
            this.RESPONSABLE.HeaderText = "RESPONSABLE";
            this.RESPONSABLE.MinimumWidth = 6;
            this.RESPONSABLE.Name = "RESPONSABLE";
            // 
            // PERSONA_AUTORIZADO
            // 
            this.PERSONA_AUTORIZADO.HeaderText = "PERSONA AUTORIZADO";
            this.PERSONA_AUTORIZADO.MinimumWidth = 6;
            this.PERSONA_AUTORIZADO.Name = "PERSONA_AUTORIZADO";
            // 
            // COMENTARIOS
            // 
            this.COMENTARIOS.HeaderText = "COMENTARIOS";
            this.COMENTARIOS.MinimumWidth = 6;
            this.COMENTARIOS.Name = "COMENTARIOS";
            // 
            // btnDelete
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.btnDelete.DefaultCellStyle = dataGridViewCellStyle10;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.HeaderText = "";
            this.btnDelete.MinimumWidth = 6;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Text = "-";
            this.btnDelete.UseColumnTextForButtonValue = true;
            this.btnDelete.Visible = false;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(6, 425);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(31, 32);
            this.BtnAgregar.TabIndex = 22;
            this.BtnAgregar.Text = "+";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Location = new System.Drawing.Point(45, 425);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(28, 32);
            this.BtnEliminar.TabIndex = 23;
            this.BtnEliminar.Text = "-";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(886, 820);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(131, 32);
            this.BtnGuardar.TabIndex = 24;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // btnProcesarPlataformas
            // 
            this.btnProcesarPlataformas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(128)))));
            this.btnProcesarPlataformas.FlatAppearance.BorderSize = 0;
            this.btnProcesarPlataformas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcesarPlataformas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesarPlataformas.ForeColor = System.Drawing.Color.Black;
            this.btnProcesarPlataformas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcesarPlataformas.Location = new System.Drawing.Point(339, 717);
            this.btnProcesarPlataformas.Margin = new System.Windows.Forms.Padding(4);
            this.btnProcesarPlataformas.Name = "btnProcesarPlataformas";
            this.btnProcesarPlataformas.Size = new System.Drawing.Size(371, 59);
            this.btnProcesarPlataformas.TabIndex = 25;
            this.btnProcesarPlataformas.Text = "2.- Procesar plataformas";
            this.btnProcesarPlataformas.UseVisualStyleBackColor = false;
            this.btnProcesarPlataformas.Click += new System.EventHandler(this.btnProcesarPlataformas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1054, 798);
            this.Controls.Add(this.btnProcesarPlataformas);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelOculto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewFE);
            this.Controls.Add(this.dataGridViewVentas);
            this.Controls.Add(this.buttonProcesarFacturasElectronicas);
            this.Controls.Add(this.buttonProcesarVentas);
            this.Controls.Add(this.buttonIniciarDia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Procesamiento de información LTG V 2.2";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVentas)).EndInit();
            this.panelOculto.ResumeLayout(false);
            this.panelOculto.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonProvisional;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewFE;
        private System.Windows.Forms.DataGridView dataGridViewVentas;
        private System.Windows.Forms.Button buttonProcesarFacturasElectronicas;
        private System.Windows.Forms.Button buttonProcesarVentas;
        private System.Windows.Forms.Button buttonIniciarDia;
        private System.Windows.Forms.Button buttonProcesarTransaccionFE;
        private System.Windows.Forms.TextBox textBoxTransaccionCodigo;
        private System.Windows.Forms.Panel panelOculto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn PLATAFORMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR_DIFERENCIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOTIVO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMERO_PEDIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMERO_TRANS;
        private System.Windows.Forms.DataGridViewTextBoxColumn RESPONSABLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PERSONA_AUTORIZADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMENTARIOS;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
        private System.Windows.Forms.Button btnProcesarPlataformas;
    }
}

