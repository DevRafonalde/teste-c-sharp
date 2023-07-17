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
    public partial class TelaPrincipal : Form {
        Controller controller;
        List<Oficio> oficios = new List<Oficio>();
        public TelaPrincipal() {
            InitializeComponent();
            comboBox_baseBusca.SelectedIndex = 0;
            comboBox_tipoProcesso.SelectedIndex = 0;
            this.controller = new Controller();
        }

        private void button_buscar_Click(object sender, EventArgs e) {
            oficios = controller.RealizarBusca(comboBox_baseBusca.SelectedItem.ToString(), textBox_numero.Text, oficios);
            
            dataGridView_resultados.DataSource = oficios;
            dataGridView_resultados.Columns["id"].Visible = false;
            dataGridView_resultados.Columns["usuarioFinalizacao"].Visible = false;
            dataGridView_resultados.Columns["dataFinalizacao"].Visible = false;
            dataGridView_resultados.Columns["oficioVinculadoId"].Visible = false;
            dataGridView_resultados.Columns["numeroOficioCadastrado"].Visible = false;

            for (int i = 0; i < dataGridView_resultados.RowCount; i++) {
                if (oficios[i].recebido) {
                    dataGridView_resultados.Rows[i].DefaultCellStyle.ForeColor = Color.FromArgb(0, 43, 128);
                } else {
                    dataGridView_resultados.Rows[i].DefaultCellStyle.ForeColor = Color.FromArgb(0, 102, 0);
                }
            }
        }
    }
}
