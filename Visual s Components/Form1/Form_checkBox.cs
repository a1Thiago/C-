using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Form1 {
    public partial class Form_checkBox : Form {

        public string txt;

        readonly private List<CheckBox> transportes = new List<CheckBox>();

        public Form_checkBox() {
            InitializeComponent();
            transportes.Add(CheckBox_Carro);
            transportes.Add(CheckBox_Aviao);
            transportes.Add(CheckBox_Navio);
            transportes.Add(CheckBox_Onibus);
            transportes.Add(CheckBox_Patinete);
        }

        private void button_transportesMarcados_Click(object sender, EventArgs e) {

            CheckBox_Patinete.Checked = !CheckBox_Patinete.Checked;

            txt = "";

            Label_Marcados.Text = "Marcados:";

            foreach (CheckBox transporte in transportes) {
                if (transporte.Checked)
                    txt += transporte.Text + ", ";
            }

            Label_Marcados.Text += " " + txt;

            MessageBox.Show(txt, "Veiculos Marcados");

        }
    }
}
