namespace Interfaz_Registrador
{
    partial class frmTipoHabitacion
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
            this.rdbIndividual = new System.Windows.Forms.RadioButton();
            this.rdbDoble = new System.Windows.Forms.RadioButton();
            this.rdbTriple = new System.Windows.Forms.RadioButton();
            this.rdbQueen = new System.Windows.Forms.RadioButton();
            this.rdbKing = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TIPO DE HABITACION";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rdbIndividual
            // 
            this.rdbIndividual.AutoSize = true;
            this.rdbIndividual.Location = new System.Drawing.Point(49, 87);
            this.rdbIndividual.Name = "rdbIndividual";
            this.rdbIndividual.Size = new System.Drawing.Size(86, 17);
            this.rdbIndividual.TabIndex = 1;
            this.rdbIndividual.TabStop = true;
            this.rdbIndividual.Text = "INDIVIDUAL";
            this.rdbIndividual.UseVisualStyleBackColor = true;
            // 
            // rdbDoble
            // 
            this.rdbDoble.AutoSize = true;
            this.rdbDoble.Location = new System.Drawing.Point(49, 110);
            this.rdbDoble.Name = "rdbDoble";
            this.rdbDoble.Size = new System.Drawing.Size(61, 17);
            this.rdbDoble.TabIndex = 2;
            this.rdbDoble.TabStop = true;
            this.rdbDoble.Text = "DOBLE";
            this.rdbDoble.UseVisualStyleBackColor = true;
            // 
            // rdbTriple
            // 
            this.rdbTriple.AutoSize = true;
            this.rdbTriple.Location = new System.Drawing.Point(159, 87);
            this.rdbTriple.Name = "rdbTriple";
            this.rdbTriple.Size = new System.Drawing.Size(63, 17);
            this.rdbTriple.TabIndex = 3;
            this.rdbTriple.TabStop = true;
            this.rdbTriple.Text = "TRIPLE";
            this.rdbTriple.UseVisualStyleBackColor = true;
            // 
            // rdbQueen
            // 
            this.rdbQueen.AutoSize = true;
            this.rdbQueen.Location = new System.Drawing.Point(159, 110);
            this.rdbQueen.Name = "rdbQueen";
            this.rdbQueen.Size = new System.Drawing.Size(63, 17);
            this.rdbQueen.TabIndex = 4;
            this.rdbQueen.TabStop = true;
            this.rdbQueen.Text = "QUEEN";
            this.rdbQueen.UseVisualStyleBackColor = true;
            // 
            // rdbKing
            // 
            this.rdbKing.AutoSize = true;
            this.rdbKing.Location = new System.Drawing.Point(247, 87);
            this.rdbKing.Name = "rdbKing";
            this.rdbKing.Size = new System.Drawing.Size(51, 17);
            this.rdbKing.TabIndex = 5;
            this.rdbKing.TabStop = true;
            this.rdbKing.Text = "KING";
            this.rdbKing.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 45);
            this.button1.TabIndex = 6;
            this.button1.Text = "ACEPTAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(179, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 45);
            this.button2.TabIndex = 7;
            this.button2.Text = "CANCELAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmTipoHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 343);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rdbKing);
            this.Controls.Add(this.rdbQueen);
            this.Controls.Add(this.rdbTriple);
            this.Controls.Add(this.rdbDoble);
            this.Controls.Add(this.rdbIndividual);
            this.Controls.Add(this.label1);
            this.Name = "frmTipoHabitacion";
            this.Text = "frmTipoHabitacion";
            this.Load += new System.EventHandler(this.frmTipoHabitacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbIndividual;
        private System.Windows.Forms.RadioButton rdbDoble;
        private System.Windows.Forms.RadioButton rdbTriple;
        private System.Windows.Forms.RadioButton rdbQueen;
        private System.Windows.Forms.RadioButton rdbKing;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}