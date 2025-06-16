namespace CurpLibrery
{
    partial class Curp
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNombres = new TextBox();
            txtApellidoPa = new TextBox();
            txtApellidoMa = new TextBox();
            dtpfecha = new DateTimePicker();
            cbSexo = new ComboBox();
            cboEstado = new ComboBox();
            label7 = new Label();
            lblCurp = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(88, 151);
            label1.Name = "label1";
            label1.Size = new Size(185, 28);
            label1.TabIndex = 0;
            label1.Text = "Apellido Paterno:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(88, 410);
            label2.Name = "label2";
            label2.Size = new Size(65, 28);
            label2.TabIndex = 1;
            label2.Text = "Sexo:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(88, 329);
            label3.Name = "label3";
            label3.Size = new Size(222, 28);
            label3.TabIndex = 2;
            label3.Text = "Fecha de Nacimiento:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(88, 243);
            label5.Name = "label5";
            label5.Size = new Size(192, 28);
            label5.TabIndex = 4;
            label5.Text = "Apellido Materno:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(88, 496);
            label6.Name = "label6";
            label6.Size = new Size(202, 28);
            label6.TabIndex = 5;
            label6.Text = "Entidad Federativa:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(219, 69);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(406, 31);
            txtNombres.TabIndex = 6;
            txtNombres.TextChanged += txtNombres_TextChanged_1;
            // 
            // txtApellidoPa
            // 
            txtApellidoPa.Location = new Point(288, 151);
            txtApellidoPa.Name = "txtApellidoPa";
            txtApellidoPa.Size = new Size(337, 31);
            txtApellidoPa.TabIndex = 7;
            txtApellidoPa.TextChanged += txtApellidoPa_TextChanged_1;
            // 
            // txtApellidoMa
            // 
            txtApellidoMa.Location = new Point(288, 243);
            txtApellidoMa.Name = "txtApellidoMa";
            txtApellidoMa.Size = new Size(337, 31);
            txtApellidoMa.TabIndex = 8;
            txtApellidoMa.TextChanged += txtApellidoMa_TextChanged_1;
            // 
            // dtpfecha
            // 
            dtpfecha.Format = DateTimePickerFormat.Short;
            dtpfecha.Location = new Point(325, 329);
            dtpfecha.Name = "dtpfecha";
            dtpfecha.Size = new Size(300, 31);
            dtpfecha.TabIndex = 9;
            dtpfecha.ValueChanged += dtpfecha_ValueChanged;
            // 
            // cbSexo
            // 
            cbSexo.FormattingEnabled = true;
            cbSexo.Items.AddRange(new object[] { "Hombre", "Mujer" });
            cbSexo.Location = new Point(159, 410);
            cbSexo.Name = "cbSexo";
            cbSexo.Size = new Size(182, 33);
            cbSexo.TabIndex = 10;
            cbSexo.SelectedIndexChanged += cbSexo_SelectedIndexChanged_1;
            // 
            // cboEstado
            // 
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new Point(296, 496);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(182, 33);
            cboEstado.TabIndex = 11;
            cboEstado.SelectedIndexChanged += cboEstado_SelectedIndexChanged_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(88, 611);
            label7.Name = "label7";
            label7.Size = new Size(242, 28);
            label7.TabIndex = 12;
            label7.Text = "Tu curp es la siguiente:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCurp
            // 
            lblCurp.AutoSize = true;
            lblCurp.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            lblCurp.ForeColor = SystemColors.HotTrack;
            lblCurp.Location = new Point(383, 611);
            lblCurp.Name = "lblCurp";
            lblCurp.Size = new Size(242, 28);
            lblCurp.TabIndex = 13;
            lblCurp.Text = "Tu curp es la siguiente:";
            lblCurp.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(88, 69);
            label4.Name = "label4";
            label4.Size = new Size(125, 28);
            label4.TabIndex = 14;
            label4.Text = "Nombre(s):";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Curp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(label4);
            Controls.Add(lblCurp);
            Controls.Add(label7);
            Controls.Add(cboEstado);
            Controls.Add(cbSexo);
            Controls.Add(dtpfecha);
            Controls.Add(txtApellidoMa);
            Controls.Add(txtApellidoPa);
            Controls.Add(txtNombres);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ButtonFace;
            Name = "Curp";
            Size = new Size(688, 711);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox txtNombres;
        private TextBox txtApellidoPa;
        private TextBox txtApellidoMa;
        private DateTimePicker dtpfecha;
        private ComboBox cbSexo;
        private ComboBox cboEstado;
        private Label label7;
        private Label lblCurp;
        private Label label4;
    }
}
