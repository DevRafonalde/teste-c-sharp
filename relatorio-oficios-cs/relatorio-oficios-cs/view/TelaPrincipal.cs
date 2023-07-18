using relatorio_oficios_cs.controller;
using relatorio_oficios_cs.helpers;
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
            oficios = RespostasHelper.ConferirTodasRespostas(oficios);

            List<Oficio> oficiosRE;
            List<Oficio> oficiosEmAberto;
            List<Oficio> oficiosRespondidos;
            List<Oficio> oficiosSemResposta;
            List<Oficio> oficiosPorObs;
            List<Oficio> oficiosPorTipoProcesso;

            // Filtro de recebidos ou emitidos
            if (radioButton_recebidos.Checked) {
                oficiosRE = oficios.Where(o => o.recebido).ToList();
            } else if (radioButton_enviados.Checked) {
                oficiosRE = oficios.Where(o => o.emitido).ToList();
            } else {
                radioButton_ambos.Checked = true;
                oficiosRE = oficios.Where(o => !(o.recebido && o.oficioVinculadoId != null)).ToList();
            }

            // Filtro de ofícios em aberto
            if (checkBox_emAberto.Checked) {
                oficiosEmAberto = oficiosRE.Where(o => o.dataFinalizacao == null).ToList();
            } else {
                oficiosEmAberto = oficiosRE;
            }

            // Filtro das respostas recebidas
            if (checkBox_respostaRecebida.Checked) {
                oficiosRespondidos = RespostasHelper.ConferirTodasRespostas(oficiosEmAberto).Where(o => o.respostaRecebida).ToList();
            } else {
                oficiosRespondidos = oficiosEmAberto;
            }

            // Filtro dos sem resposta
            if (checkBox_semResposta.Checked) {
                oficiosSemResposta = RespostasHelper.ConferirTodasRespostas(oficiosRespondidos).Where(o => !o.respostaRecebida).ToList();
            } else {
                oficiosSemResposta = oficiosRespondidos;
            }

            // Filtro das observações
            if (!textBox_obs.Text.Equals("")) {
                oficiosPorObs = oficiosSemResposta.Where(o => o.observacao.ToLower().Contains(textBox_obs.Text.ToLower())).ToList();
            } else {
                oficiosPorObs = oficiosSemResposta;
            }

            // Filtro dos tipos de processo
            // O index 0 é o "Selecione.."
            if (comboBox_tipoProcesso.SelectedIndex != 0) {
                oficiosPorTipoProcesso = oficiosPorObs.Where(o => o.tipoProcesso.ToLower().Contains(comboBox_tipoProcesso.SelectedItem.ToString().ToLower())).ToList();
            } else {
                oficiosPorTipoProcesso = oficiosPorObs;
            }


            dataGridView_resultados.DataSource = oficiosPorTipoProcesso;

            dataGridView_resultados.Columns["id"].Visible = false;
            dataGridView_resultados.Columns["usuarioFinalizacao"].Visible = false;
            dataGridView_resultados.Columns["dataFinalizacao"].Visible = false;
            dataGridView_resultados.Columns["oficioVinculadoId"].Visible = false;
            dataGridView_resultados.Columns["numeroOficioCadastrado"].Visible = false;
            dataGridView_resultados.Columns["protocoloTitulo"].Visible = false;
            dataGridView_resultados.Columns["protocoloCertidao"].Visible = false;
            dataGridView_resultados.Columns["numero"].Visible = false;
            dataGridView_resultados.Columns["ano"].Visible = false;
            dataGridView_resultados.Columns["oficioVinculadoNumero"].Visible = false;
            dataGridView_resultados.Columns["oficioVinculadoAno"].Visible = false;
            dataGridView_resultados.Columns["recebido"].Visible = false;
            dataGridView_resultados.Columns["emitido"].Visible = false;

            for (int i = 0; i < dataGridView_resultados.ColumnCount; i++) {
                if (dataGridView_resultados.Columns[i] != dataGridView_resultados.Columns["observacao"]) {
                    dataGridView_resultados.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }

            dataGridView_resultados.Columns["nOficioRecebido"].DisplayIndex = 0;
            dataGridView_resultados.Columns["nOficioRecebido"].HeaderText = "N° Ofício recebido";

            dataGridView_resultados.Columns["nOficioEnviado"].DisplayIndex = 1;
            dataGridView_resultados.Columns["nOficioEnviado"].HeaderText = "N° Ofício enviado";

            dataGridView_resultados.Columns["numeroProcesso"].DisplayIndex = 2;
            dataGridView_resultados.Columns["numeroProcesso"].HeaderText = "N° processo";

            dataGridView_resultados.Columns["tipoProcesso"].DisplayIndex = 3;
            dataGridView_resultados.Columns["tipoProcesso"].HeaderText = "Tipo processo";

            dataGridView_resultados.Columns["respostaRecebida"].DisplayIndex = 4;
            dataGridView_resultados.Columns["respostaRecebida"].HeaderText = "Resposta recebida";

            dataGridView_resultados.Columns["observacao"].DisplayIndex = 5;
            dataGridView_resultados.Columns["observacao"].HeaderText = "Observação";


            for (int i = 0; i < dataGridView_resultados.RowCount; i++) {
                if (oficiosPorTipoProcesso[i].recebido) {
                    dataGridView_resultados.Rows[i].DefaultCellStyle.ForeColor = Color.FromArgb(0, 43, 128);
                    oficiosPorTipoProcesso[i].nOficioRecebido = oficiosPorTipoProcesso[i].ano + "/" + oficiosPorTipoProcesso[i].numero;
                    oficiosPorTipoProcesso[i].nOficioEnviado = ((oficiosPorTipoProcesso[i].oficioVinculadoAno + "/").Replace("null/", "") + oficiosPorTipoProcesso[i].oficioVinculadoNumero).Replace("null", "");
                    if (oficiosPorTipoProcesso[i].nOficioEnviado.Equals("/")) {
                        oficiosPorTipoProcesso[i].nOficioEnviado = string.Empty;
                    }
                } else {
                    dataGridView_resultados.Rows[i].DefaultCellStyle.ForeColor = Color.FromArgb(0, 102, 0);
                    oficiosPorTipoProcesso[i].nOficioRecebido = ((oficiosPorTipoProcesso[i].oficioVinculadoAno + "/").Replace("null/", "") + oficiosPorTipoProcesso[i].oficioVinculadoNumero).Replace("null", "");
                    oficiosPorTipoProcesso[i].nOficioEnviado = oficiosPorTipoProcesso[i].ano + "/" + oficiosPorTipoProcesso[i].numero;
                    if (oficiosPorTipoProcesso[i].nOficioRecebido.Equals("/")) {
                        oficiosPorTipoProcesso[i].nOficioRecebido = string.Empty;
                    }
                }
            }

            label_qntdOficios.Text = "Ofícios encontrados (" + dataGridView_resultados.RowCount.ToString() + ")";
        }
    }
}
