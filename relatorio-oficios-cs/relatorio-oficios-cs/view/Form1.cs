using relatorio_oficios_cs.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace relatorio_oficios_cs {
    public partial class Form1 : Form {
        Controller controller;
        List<Oficio> oficios = new List<Oficio>();
        public Form1() {
            InitializeComponent();
            comboBox_baseBusca.SelectedIndex = 0;
            comboBox_tipoProcesso.SelectedIndex = 0;
            this.controller = new Controller();
        }

        private void button_buscar_Click(object sender, EventArgs e) {
            Console.WriteLine("Item selecionado na combo box de base de busca na tela: " + comboBox_baseBusca.SelectedItem.ToString());
            oficios = controller.RealizarBusca(comboBox_baseBusca.SelectedItem.ToString(), textBox_numero.Text, oficios);
            
            dataGridView_resultados.DataSource = oficios;
        }
    }
}
