namespace Tarea_2
{
    partial class Tarea2
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
            this.label5 = new System.Windows.Forms.Label();
            this.PromedioButton = new System.Windows.Forms.Button();
            this.Nota4TextBox = new System.Windows.Forms.TextBox();
            this.Nota3TextBox = new System.Windows.Forms.TextBox();
            this.Nota2TextBox = new System.Windows.Forms.TextBox();
            this.Nota1TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(98, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(259, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "Ingre las notas del Alumno";
            // 
            // PromedioButton
            // 
            this.PromedioButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PromedioButton.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PromedioButton.Location = new System.Drawing.Point(161, 248);
            this.PromedioButton.Name = "PromedioButton";
            this.PromedioButton.Size = new System.Drawing.Size(114, 38);
            this.PromedioButton.TabIndex = 18;
            this.PromedioButton.Text = "Promedio";
            this.PromedioButton.UseVisualStyleBackColor = false;
            this.PromedioButton.Click += new System.EventHandler(this.PromedioButton_Click);
            // 
            // Nota4TextBox
            // 
            this.Nota4TextBox.Location = new System.Drawing.Point(215, 191);
            this.Nota4TextBox.Name = "Nota4TextBox";
            this.Nota4TextBox.Size = new System.Drawing.Size(100, 20);
            this.Nota4TextBox.TabIndex = 17;
            // 
            // Nota3TextBox
            // 
            this.Nota3TextBox.Location = new System.Drawing.Point(215, 159);
            this.Nota3TextBox.Name = "Nota3TextBox";
            this.Nota3TextBox.Size = new System.Drawing.Size(100, 20);
            this.Nota3TextBox.TabIndex = 16;
            // 
            // Nota2TextBox
            // 
            this.Nota2TextBox.Location = new System.Drawing.Point(215, 119);
            this.Nota2TextBox.Name = "Nota2TextBox";
            this.Nota2TextBox.Size = new System.Drawing.Size(100, 20);
            this.Nota2TextBox.TabIndex = 15;
            // 
            // Nota1TextBox
            // 
            this.Nota1TextBox.Location = new System.Drawing.Point(215, 79);
            this.Nota1TextBox.Name = "Nota1TextBox";
            this.Nota1TextBox.Size = new System.Drawing.Size(100, 20);
            this.Nota1TextBox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(134, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nota 4:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(134, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nota 3:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nota 2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(134, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nota 1:";
            // 
            // Tarea2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 409);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PromedioButton);
            this.Controls.Add(this.Nota4TextBox);
            this.Controls.Add(this.Nota3TextBox);
            this.Controls.Add(this.Nota2TextBox);
            this.Controls.Add(this.Nota1TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Tarea2";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button PromedioButton;
        private System.Windows.Forms.TextBox Nota4TextBox;
        private System.Windows.Forms.TextBox Nota3TextBox;
        private System.Windows.Forms.TextBox Nota2TextBox;
        private System.Windows.Forms.TextBox Nota1TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

