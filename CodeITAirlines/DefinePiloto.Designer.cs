namespace CodeITAirlines
{
    partial class DefinePiloto
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
            this.radioPessoa1 = new System.Windows.Forms.RadioButton();
            this.radioPessoa2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // radioPessoa1
            // 
            this.radioPessoa1.AutoSize = true;
            this.radioPessoa1.Location = new System.Drawing.Point(65, 66);
            this.radioPessoa1.Name = "radioPessoa1";
            this.radioPessoa1.Size = new System.Drawing.Size(84, 21);
            this.radioPessoa1.TabIndex = 0;
            this.radioPessoa1.TabStop = true;
            this.radioPessoa1.Text = "Pessoa1";
            this.radioPessoa1.UseVisualStyleBackColor = true;
            // 
            // radioPessoa2
            // 
            this.radioPessoa2.AutoSize = true;
            this.radioPessoa2.Location = new System.Drawing.Point(65, 109);
            this.radioPessoa2.Name = "radioPessoa2";
            this.radioPessoa2.Size = new System.Drawing.Size(84, 21);
            this.radioPessoa2.TabIndex = 1;
            this.radioPessoa2.TabStop = true;
            this.radioPessoa2.Text = "Pessoa2";
            this.radioPessoa2.UseVisualStyleBackColor = true;
            // 
            // DefinePiloto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 235);
            this.Controls.Add(this.radioPessoa2);
            this.Controls.Add(this.radioPessoa1);
            this.Name = "DefinePiloto";
            this.Text = "DefinePiloto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioPessoa1;
        private System.Windows.Forms.RadioButton radioPessoa2;
    }
}