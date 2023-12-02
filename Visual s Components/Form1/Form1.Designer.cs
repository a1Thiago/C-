namespace Form1 {
    partial class Form_principal {
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
            this.label1 = new System.Windows.Forms.Label();
            this.input_veiculo = new System.Windows.Forms.TextBox();
            this.button_adicionar = new System.Windows.Forms.Button();
            this.textArea_veiculos = new System.Windows.Forms.TextBox();
            this.button_limpar = new System.Windows.Forms.Button();
            this.button_mostrarVeiculos = new System.Windows.Forms.Button();
            this.button_valNum = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.componentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkedListBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite um veículo";
            // 
            // input_veiculo
            // 
            this.input_veiculo.Location = new System.Drawing.Point(12, 45);
            this.input_veiculo.Name = "input_veiculo";
            this.input_veiculo.Size = new System.Drawing.Size(170, 20);
            this.input_veiculo.TabIndex = 1;
            // 
            // button_adicionar
            // 
            this.button_adicionar.Location = new System.Drawing.Point(188, 43);
            this.button_adicionar.Name = "button_adicionar";
            this.button_adicionar.Size = new System.Drawing.Size(148, 23);
            this.button_adicionar.TabIndex = 2;
            this.button_adicionar.Text = "Adicionar";
            this.button_adicionar.UseVisualStyleBackColor = true;
            this.button_adicionar.Click += new System.EventHandler(this.button_adicionar_Click);
            // 
            // textArea_veiculos
            // 
            this.textArea_veiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textArea_veiculos.Location = new System.Drawing.Point(12, 85);
            this.textArea_veiculos.Multiline = true;
            this.textArea_veiculos.Name = "textArea_veiculos";
            this.textArea_veiculos.Size = new System.Drawing.Size(324, 316);
            this.textArea_veiculos.TabIndex = 3;
            // 
            // button_limpar
            // 
            this.button_limpar.Location = new System.Drawing.Point(12, 407);
            this.button_limpar.Name = "button_limpar";
            this.button_limpar.Size = new System.Drawing.Size(324, 23);
            this.button_limpar.TabIndex = 4;
            this.button_limpar.Text = "Limpar";
            this.button_limpar.UseVisualStyleBackColor = true;
            this.button_limpar.Click += new System.EventHandler(this.button_limpar_Click);
            // 
            // button_mostrarVeiculos
            // 
            this.button_mostrarVeiculos.Location = new System.Drawing.Point(12, 436);
            this.button_mostrarVeiculos.Name = "button_mostrarVeiculos";
            this.button_mostrarVeiculos.Size = new System.Drawing.Size(324, 23);
            this.button_mostrarVeiculos.TabIndex = 5;
            this.button_mostrarVeiculos.Text = "Mostrar veículos";
            this.button_mostrarVeiculos.UseVisualStyleBackColor = true;
            this.button_mostrarVeiculos.Click += new System.EventHandler(this.button_mostrarVeiculos_Click);
            // 
            // button_valNum
            // 
            this.button_valNum.Location = new System.Drawing.Point(12, 465);
            this.button_valNum.Name = "button_valNum";
            this.button_valNum.Size = new System.Drawing.Size(324, 23);
            this.button_valNum.TabIndex = 6;
            this.button_valNum.Text = "Valor variavel num";
            this.button_valNum.UseVisualStyleBackColor = true;
            this.button_valNum.Click += new System.EventHandler(this.button_valNum_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.componentesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(342, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // componentesToolStripMenuItem
            // 
            this.componentesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkBoxToolStripMenuItem,
            this.checkedListBoxToolStripMenuItem});
            this.componentesToolStripMenuItem.Name = "componentesToolStripMenuItem";
            this.componentesToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.componentesToolStripMenuItem.Text = "Componentes";
            // 
            // checkBoxToolStripMenuItem
            // 
            this.checkBoxToolStripMenuItem.Name = "checkBoxToolStripMenuItem";
            this.checkBoxToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.checkBoxToolStripMenuItem.Text = "CheckBox";
            this.checkBoxToolStripMenuItem.Click += new System.EventHandler(this.checkBoxToolStripMenuItem_Click);
            // 
            // checkedListBoxToolStripMenuItem
            // 
            this.checkedListBoxToolStripMenuItem.Name = "checkedListBoxToolStripMenuItem";
            this.checkedListBoxToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.checkedListBoxToolStripMenuItem.Text = "CheckedListBox";
            this.checkedListBoxToolStripMenuItem.Click += new System.EventHandler(this.checkedListBoxToolStripMenuItem_Click);
            // 
            // Form_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 497);
            this.Controls.Add(this.button_valNum);
            this.Controls.Add(this.button_mostrarVeiculos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_veiculo);
            this.Controls.Add(this.button_adicionar);
            this.Controls.Add(this.textArea_veiculos);
            this.Controls.Add(this.button_limpar);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Components";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input_veiculo;
        private System.Windows.Forms.Button button_adicionar;
        private System.Windows.Forms.Button button_limpar;
        private System.Windows.Forms.Button button_mostrarVeiculos;
        private System.Windows.Forms.Button button_valNum;
        public System.Windows.Forms.TextBox textArea_veiculos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem componentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkedListBoxToolStripMenuItem;
    }
}

