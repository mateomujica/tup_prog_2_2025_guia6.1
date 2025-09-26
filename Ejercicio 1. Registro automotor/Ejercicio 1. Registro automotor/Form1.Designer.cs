namespace Ejercicio_1._Registro_automotor
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbxDNI = new TextBox();
            tbxNombre = new TextBox();
            tbxPatente = new TextBox();
            btnRegistrar = new Button();
            btnVerRegistros = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 38);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 0;
            label1.Text = "DNI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 75);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 111);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 2;
            label3.Text = "Patente";
            // 
            // tbxDNI
            // 
            tbxDNI.Location = new Point(74, 38);
            tbxDNI.Name = "tbxDNI";
            tbxDNI.Size = new Size(98, 23);
            tbxDNI.TabIndex = 3;
            // 
            // tbxNombre
            // 
            tbxNombre.Location = new Point(74, 75);
            tbxNombre.Name = "tbxNombre";
            tbxNombre.Size = new Size(98, 23);
            tbxNombre.TabIndex = 4;
            // 
            // tbxPatente
            // 
            tbxPatente.Location = new Point(74, 111);
            tbxPatente.Name = "tbxPatente";
            tbxPatente.Size = new Size(98, 23);
            tbxPatente.TabIndex = 5;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(203, 75);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(73, 23);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnVerRegistros
            // 
            btnVerRegistros.Location = new Point(101, 188);
            btnVerRegistros.Name = "btnVerRegistros";
            btnVerRegistros.Size = new Size(133, 23);
            btnVerRegistros.TabIndex = 7;
            btnVerRegistros.Text = "Ver Registros";
            btnVerRegistros.UseVisualStyleBackColor = true;
            btnVerRegistros.Click += btnVerRegistros_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbxNombre);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnRegistrar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbxPatente);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbxDNI);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(308, 170);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alta Registro";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 258);
            Controls.Add(groupBox1);
            Controls.Add(btnVerRegistros);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbxDNI;
        private TextBox tbxNombre;
        private TextBox tbxPatente;
        private Button btnRegistrar;
        private Button btnVerRegistros;
        private GroupBox groupBox1;
    }
}
