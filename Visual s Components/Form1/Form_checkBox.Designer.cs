namespace Form1 {
    partial class Form_checkBox {
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
            this.CheckBox_Carro = new System.Windows.Forms.CheckBox();
            this.CheckBox_Aviao = new System.Windows.Forms.CheckBox();
            this.CheckBox_Navio = new System.Windows.Forms.CheckBox();
            this.CheckBox_Onibus = new System.Windows.Forms.CheckBox();
            this.button_transportesMarcados = new System.Windows.Forms.Button();
            this.Label_Marcados = new System.Windows.Forms.Label();
            this.CheckBox_Patinete = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // CheckBox_Carro
            // 
            this.CheckBox_Carro.AutoSize = true;
            this.CheckBox_Carro.Location = new System.Drawing.Point(11, 10);
            this.CheckBox_Carro.Name = "CheckBox_Carro";
            this.CheckBox_Carro.Size = new System.Drawing.Size(51, 17);
            this.CheckBox_Carro.TabIndex = 0;
            this.CheckBox_Carro.Text = "Carro";
            this.CheckBox_Carro.UseVisualStyleBackColor = true;
            // 
            // CheckBox_Aviao
            // 
            this.CheckBox_Aviao.AutoSize = true;
            this.CheckBox_Aviao.Location = new System.Drawing.Point(11, 33);
            this.CheckBox_Aviao.Name = "CheckBox_Aviao";
            this.CheckBox_Aviao.Size = new System.Drawing.Size(53, 17);
            this.CheckBox_Aviao.TabIndex = 1;
            this.CheckBox_Aviao.Text = "Avião";
            this.CheckBox_Aviao.UseVisualStyleBackColor = true;
            // 
            // CheckBox_Navio
            // 
            this.CheckBox_Navio.AutoSize = true;
            this.CheckBox_Navio.Location = new System.Drawing.Point(11, 56);
            this.CheckBox_Navio.Name = "CheckBox_Navio";
            this.CheckBox_Navio.Size = new System.Drawing.Size(54, 17);
            this.CheckBox_Navio.TabIndex = 2;
            this.CheckBox_Navio.Text = "Navio";
            this.CheckBox_Navio.UseVisualStyleBackColor = true;
            // 
            // CheckBox_Onibus
            // 
            this.CheckBox_Onibus.AutoSize = true;
            this.CheckBox_Onibus.Location = new System.Drawing.Point(11, 79);
            this.CheckBox_Onibus.Name = "CheckBox_Onibus";
            this.CheckBox_Onibus.Size = new System.Drawing.Size(59, 17);
            this.CheckBox_Onibus.TabIndex = 3;
            this.CheckBox_Onibus.Text = "Ônibus";
            this.CheckBox_Onibus.UseVisualStyleBackColor = true;
            // 
            // button_transportesMarcados
            // 
            this.button_transportesMarcados.Location = new System.Drawing.Point(95, 12);
            this.button_transportesMarcados.Name = "button_transportesMarcados";
            this.button_transportesMarcados.Size = new System.Drawing.Size(197, 23);
            this.button_transportesMarcados.TabIndex = 4;
            this.button_transportesMarcados.Text = "Transportes Marcados";
            this.button_transportesMarcados.UseVisualStyleBackColor = true;
            this.button_transportesMarcados.Click += new System.EventHandler(this.button_transportesMarcados_Click);
            // 
            // Label_Marcados
            // 
            this.Label_Marcados.AutoSize = true;
            this.Label_Marcados.Location = new System.Drawing.Point(8, 428);
            this.Label_Marcados.Name = "Label_Marcados";
            this.Label_Marcados.Size = new System.Drawing.Size(57, 13);
            this.Label_Marcados.TabIndex = 5;
            this.Label_Marcados.Text = "Marcados:";
            // 
            // CheckBox_Patinete
            // 
            this.CheckBox_Patinete.AutoSize = true;
            this.CheckBox_Patinete.Location = new System.Drawing.Point(11, 157);
            this.CheckBox_Patinete.Name = "CheckBox_Patinete";
            this.CheckBox_Patinete.Size = new System.Drawing.Size(65, 17);
            this.CheckBox_Patinete.TabIndex = 6;
            this.CheckBox_Patinete.Text = "Patinete";
            this.CheckBox_Patinete.UseVisualStyleBackColor = true;
            // 
            // Form_checkBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 450);
            this.Controls.Add(this.CheckBox_Patinete);
            this.Controls.Add(this.Label_Marcados);
            this.Controls.Add(this.button_transportesMarcados);
            this.Controls.Add(this.CheckBox_Onibus);
            this.Controls.Add(this.CheckBox_Navio);
            this.Controls.Add(this.CheckBox_Aviao);
            this.Controls.Add(this.CheckBox_Carro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form_checkBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CheckBox_Carro;
        private System.Windows.Forms.CheckBox CheckBox_Aviao;
        private System.Windows.Forms.CheckBox CheckBox_Onibus;
        private System.Windows.Forms.Button button_transportesMarcados;
        private System.Windows.Forms.CheckBox CheckBox_Navio;
        private System.Windows.Forms.Label Label_Marcados;
        private System.Windows.Forms.CheckBox CheckBox_Patinete;
    }
}