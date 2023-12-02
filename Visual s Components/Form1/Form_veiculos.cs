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
    public partial class Form_veiculos : Form {

        readonly Form_principal fp;
        public Form_veiculos(string v, Form_principal fp) {

            InitializeComponent();

            textArea_veiculos.Text = v;

            fp.num += 1;

            this.fp = fp;
        }

        private void Form_veiculos_FormClosed(object sender, FormClosedEventArgs e) {
            fp.textArea_veiculos.Text = textArea_veiculos.Text;
        }
    }
}
