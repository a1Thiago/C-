using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1 {
    public partial class Form_principal : Form {

        public int num;
        public Form_principal() {
            InitializeComponent();
            num = 0;
        }

        private void button_adicionar_Click(object sender, EventArgs e) {

            if (input_veiculo.Text == "") {
                MessageBox.Show("Digite um veículo");
                input_veiculo.Focus();
            }

            textArea_veiculos.Text += input_veiculo.Text + ", ";

            input_veiculo.Clear();
            input_veiculo.Focus();

        }

        private void button_limpar_Click(object sender, EventArgs e) {
            textArea_veiculos.Clear();
            input_veiculo.Clear();
            input_veiculo.Focus();
        }

        private void button_mostrarVeiculos_Click(object sender, EventArgs e) {

            Form_veiculos form_Veiculos = new Form_veiculos(textArea_veiculos.Text, this);

            form_Veiculos.Show();
        }

        private void button_valNum_Click(object sender, EventArgs e) {
            MessageBox.Show(num.ToString());
        }

        private void checkBoxToolStripMenuItem_Click(object sender, EventArgs e) {

            Form_checkBox form_CheckBox = new Form_checkBox();

            form_CheckBox.Show();

        }

        private void checkedListBoxToolStripMenuItem_Click(object sender, EventArgs e) {
            Form_CheckedListBox form_CheckedListBox = new Form_CheckedListBox();

            form_CheckedListBox.Show();
        }
    }
}
