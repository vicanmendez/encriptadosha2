namespace encriptado
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelTexto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Texto a encriptar: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(367, 131);
            this.textBox.Name = "textBox";
            this.textBox.PasswordChar = '*';
            this.textBox.Size = new System.Drawing.Size(185, 20);
            this.textBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(622, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "ENCRIPTAR sha256";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelTexto
            // 
            this.labelTexto.AutoSize = true;
            this.labelTexto.Location = new System.Drawing.Point(171, 185);
            this.labelTexto.Name = "labelTexto";
            this.labelTexto.Size = new System.Drawing.Size(93, 13);
            this.labelTexto.TabIndex = 3;
            this.labelTexto.Text = "Texto encriptado: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTexto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelTexto;
    }
}

