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
            this.rdbQuad = new System.Windows.Forms.RadioButton();
            this.rdbQueen = new System.Windows.Forms.RadioButton();
            this.rdbKing = new System.Windows.Forms.RadioButton();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TIPO DE HABITACION";
            // 
            // rdbIndividual
            // 
            this.rdbIndividual.AutoSize = true;
            this.rdbIndividual.Location = new System.Drawing.Point(72, 110);
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
            this.rdbDoble.Location = new System.Drawing.Point(72, 148);
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
            this.rdbTriple.Location = new System.Drawing.Point(172, 110);
            this.rdbTriple.Name = "rdbTriple";
            this.rdbTriple.Size = new System.Drawing.Size(63, 17);
            this.rdbTriple.TabIndex = 3;
            this.rdbTriple.TabStop = true;
            this.rdbTriple.Text = "TRIPLE";
            this.rdbTriple.UseVisualStyleBackColor = true;
            // 
            // rdbQuad
            // 
            this.rdbQuad.AutoSize = true;
            this.rdbQuad.Location = new System.Drawing.Point(172, 148);
            this.rdbQuad.Name = "rdbQuad";
            this.rdbQuad.Size = new System.Drawing.Size(56, 17);
            this.rdbQuad.TabIndex = 4;
            this.rdbQuad.TabStop = true;
            this.rdbQuad.Text = "QUAD";
            this.rdbQuad.UseVisualStyleBackColor = true;
            // 
            // rdbQueen
            // 
            this.rdbQueen.AutoSize = true;
            this.rdbQueen.Location = new System.Drawing.Point(273, 110);
            this.rdbQueen.Name = "rdbQueen";
            this.rdbQueen.Size = new System.Drawing.Size(63, 17);
            this.rdbQueen.TabIndex = 5;
            this.rdbQueen.TabStop = true;
            this.rdbQueen.Text = "QUEEN";
            this.rdbQueen.UseVisualStyleBackColor = true;
            // 
            // rdbKing
            // 
            this.rdbKing.AutoSize = true;
            this.rdbKing.Location = new System.Drawing.Point(273, 148);
            this.rdbKing.Name = "rdbKing";
            this.rdbKing.Size = new System.Drawing.Size(51, 17);
            this.rdbKing.TabIndex = 6;
            this.rdbKing.TabStop = true;
            this.rdbKing.Text = "KING";
            this.rdbKing.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(61, 212);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(101, 46);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(223, 212);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 46);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "ACEPTAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmTipoHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 371);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.rdbKing);
            this.Controls.Add(this.rdbQueen);
            this.Controls.Add(this.rdbQuad);
            this.Controls.Add(this.rdbTriple);
            this.Controls.Add(this.rdbDoble);
            this.Controls.Add(this.rdbIndividual);
            this.Controls.Add(this.label1);
            this.Name = "frmTipoHabitacion";
            this.Text = "frmTipoHabitacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbIndividual;
        private System.Windows.Forms.RadioButton rdbDoble;
        private System.Windows.Forms.RadioButton rdbTriple;
        private System.Windows.Forms.RadioButton rdbQuad;
        private System.Windows.Forms.RadioButton rdbQueen;
        private System.Windows.Forms.RadioButton rdbKing;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}