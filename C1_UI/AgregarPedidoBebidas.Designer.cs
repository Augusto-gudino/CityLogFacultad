namespace C1_UI
{
    partial class AgregarPedidoBebidas
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
            this.groupBoxAgregarPedidos = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAgregarDocente = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblEnvio = new System.Windows.Forms.Label();
            this.radioButtonDomicilio = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBoxAgregarPedidos.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAgregarPedidos
            // 
            this.groupBoxAgregarPedidos.Controls.Add(this.radioButton2);
            this.groupBoxAgregarPedidos.Controls.Add(this.radioButtonDomicilio);
            this.groupBoxAgregarPedidos.Controls.Add(this.lblEnvio);
            this.groupBoxAgregarPedidos.Controls.Add(this.textBox2);
            this.groupBoxAgregarPedidos.Controls.Add(this.label4);
            this.groupBoxAgregarPedidos.Controls.Add(this.label3);
            this.groupBoxAgregarPedidos.Controls.Add(this.textBox1);
            this.groupBoxAgregarPedidos.Controls.Add(this.button1);
            this.groupBoxAgregarPedidos.Controls.Add(this.btnAgregarDocente);
            this.groupBoxAgregarPedidos.Controls.Add(this.comboBox2);
            this.groupBoxAgregarPedidos.Controls.Add(this.label2);
            this.groupBoxAgregarPedidos.Controls.Add(this.label1);
            this.groupBoxAgregarPedidos.Controls.Add(this.comboBox1);
            this.groupBoxAgregarPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAgregarPedidos.Location = new System.Drawing.Point(121, 12);
            this.groupBoxAgregarPedidos.Name = "groupBoxAgregarPedidos";
            this.groupBoxAgregarPedidos.Size = new System.Drawing.Size(796, 245);
            this.groupBoxAgregarPedidos.TabIndex = 1;
            this.groupBoxAgregarPedidos.TabStop = false;
            this.groupBoxAgregarPedidos.Text = "Ingrese los productos que desea adquirir";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dirección";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(517, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 22);
            this.textBox1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(690, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnAgregarDocente
            // 
            this.btnAgregarDocente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDocente.Location = new System.Drawing.Point(575, 209);
            this.btnAgregarDocente.Name = "btnAgregarDocente";
            this.btnAgregarDocente.Size = new System.Drawing.Size(100, 30);
            this.btnAgregarDocente.TabIndex = 3;
            this.btnAgregarDocente.Text = "Agregar";
            this.btnAgregarDocente.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(517, 42);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(345, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccione la cantidad\r\ndeseada\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione un producto";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Coca Cola",
            "Pepsi",
            "7Up",
            "Aquarius"});
            this.comboBox1.Location = new System.Drawing.Point(182, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telefono";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(182, 117);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 22);
            this.textBox2.TabIndex = 2;
            // 
            // lblEnvio
            // 
            this.lblEnvio.AutoSize = true;
            this.lblEnvio.Location = new System.Drawing.Point(126, 176);
            this.lblEnvio.Name = "lblEnvio";
            this.lblEnvio.Size = new System.Drawing.Size(46, 16);
            this.lblEnvio.TabIndex = 8;
            this.lblEnvio.Text = "Envio";
            // 
            // radioButtonDomicilio
            // 
            this.radioButtonDomicilio.AutoSize = true;
            this.radioButtonDomicilio.Location = new System.Drawing.Point(191, 174);
            this.radioButtonDomicilio.Name = "radioButtonDomicilio";
            this.radioButtonDomicilio.Size = new System.Drawing.Size(90, 20);
            this.radioButtonDomicilio.TabIndex = 9;
            this.radioButtonDomicilio.TabStop = true;
            this.radioButtonDomicilio.Text = "Domicilio";
            this.radioButtonDomicilio.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(191, 200);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(159, 20);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Retira Por Sucursal";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // AgregarPedidoBebidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1064, 545);
            this.Controls.Add(this.groupBoxAgregarPedidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarPedidoBebidas";
            this.Text = "AgregarPedidoBebidas";
            this.groupBoxAgregarPedidos.ResumeLayout(false);
            this.groupBoxAgregarPedidos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAgregarPedidos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAgregarDocente;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEnvio;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButtonDomicilio;
    }
}