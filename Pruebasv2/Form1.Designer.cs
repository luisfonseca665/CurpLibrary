namespace Pruebasv2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            curp1 = new CurpLibrery.Curp();
            SuspendLayout();
            // 
            // curp1
            // 
            curp1.BackColor = Color.Transparent;
            curp1.CurpGenerada = "";
            curp1.Estado = "AGUASCALIENTES";
            curp1.FechaNacimiento = new DateTime(2025, 6, 14, 19, 41, 53, 39);
            curp1.ForeColor = SystemColors.ButtonFace;
            curp1.Genero = "HOMBRE";
            curp1.Location = new Point(66, 38);
            curp1.Name = "curp1";
            curp1.Nombre = "";
            curp1.PrimerApellido = "";
            curp1.SegundoApellido = "";
            curp1.Size = new Size(742, 753);
            curp1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1359, 817);
            Controls.Add(curp1);
            Name = "Form1";
            Text = "Generador de Curp.";
            ResumeLayout(false);
        }

        #endregion

        private CurpLibrery.Curp curp1;
    }
}
