namespace Ejercicio_1._Registro_automotor
{
    partial class FormDatos
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
            lsbImprimir = new ListBox();
            btnCerrar = new Button();
            SuspendLayout();
            // 
            // lsbImprimir
            // 
            lsbImprimir.FormattingEnabled = true;
            lsbImprimir.ItemHeight = 15;
            lsbImprimir.Location = new Point(165, 68);
            lsbImprimir.Name = "lsbImprimir";
            lsbImprimir.RightToLeft = RightToLeft.No;
            lsbImprimir.Size = new Size(382, 199);
            lsbImprimir.TabIndex = 0;
            // 
            // btnCerrar
            // 
            btnCerrar.DialogResult = DialogResult.Cancel;
            btnCerrar.Location = new Point(324, 286);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 1;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // FormDatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCerrar);
            Controls.Add(lsbImprimir);
            Name = "FormDatos";
            Text = "FormDatos";
            Load += FormDatos_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button btnCerrar;
        public ListBox lsbImprimir;
    }
}