namespace Form1 {
    partial class Form_veiculos {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.textArea_veiculos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textArea_veiculos
            // 
            this.textArea_veiculos.Location = new System.Drawing.Point(7, 9);
            this.textArea_veiculos.Multiline = true;
            this.textArea_veiculos.Name = "textArea_veiculos";
            this.textArea_veiculos.Size = new System.Drawing.Size(337, 415);
            this.textArea_veiculos.TabIndex = 0;
            this.textArea_veiculos.Text = " ";
            // 
            // Form_veiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 450);
            this.Controls.Add(this.textArea_veiculos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.Name = "Form_veiculos";
            this.Text = "Lista de veiculos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_veiculos_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textArea_veiculos;
    }
}