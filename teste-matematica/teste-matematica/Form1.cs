using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace relatorio_oficios_cs
{
    public partial class Form1 : Form {

        Random random = new Random();

        int numero1Soma;
        int numero2Soma;
        int numero1Subtracao;
        int numero2Subtracao;
        int numero1Multiplicacao;
        int numero2Multiplicacao;
        int numero1Divisao;
        int numero2Divisao;
        int tempoRestante;

        public void inicarQuiz() {
            // O 51 dentro do método Next(51) serve para selecionar um número aleatório menor que 51, se fosse 100, seria menor que 100 e assim por diante
            numero1Soma = random.Next(51);
            numero2Soma = random.Next(51);

            label_numero1Soma.Text = numero1Soma.ToString();
            label_numero2Soma.Text = numero2Soma.ToString();

            numericUpDown_resultadoSoma.Value = 0;

            // Aqui fiz uma lógica para que o resultado não dê negativo
            numero1Subtracao = random.Next(1, 101);
            numero2Subtracao = random.Next(1, numero1Subtracao);

            label_numero1Subtracao.Text = numero1Subtracao.ToString();
            label_numero2Subtracao.Text = numero2Subtracao.ToString();

            numericUpDown_resultadoSubtracao.Value = 0;

            numero1Multiplicacao = random.Next(2, 11);
            numero2Multiplicacao = random.Next(2, 11);

            label_numero1Multiplicacao.Text = numero1Multiplicacao.ToString();
            label_numero2Multiplicacao.Text = numero2Multiplicacao.ToString();

            numericUpDown_resultadoMultiplicacao.Value = 0;

            // Vou fazer uma lógica aqui para evitar que a divisão dê uma fração
            // Agora o Next(2, 11) pega um número aleatório entre 2 e 11
            numero2Divisao = random.Next(2, 11);
            int quocienteTemporario = random.Next(2, 11);
            numero1Divisao = numero2Divisao * quocienteTemporario;

            label_numero1Divisao.Text = numero1Divisao.ToString();
            label_numero2Divisao.Text = numero2Divisao.ToString();

            numericUpDown_resultadoDivisao.Value = 0;

            tempoRestante = 30;
            label_contador.Text = tempoRestante.ToString();
            timerTeste.Start();
        }

        private bool verificarResposta() {
            if ((numero1Soma + numero2Soma == numericUpDown_resultadoSoma.Value)
                && (numero1Subtracao - numero2Subtracao == numericUpDown_resultadoSubtracao.Value)
                && (numero1Multiplicacao * numero2Multiplicacao == numericUpDown_resultadoMultiplicacao.Value)
                && (numero1Divisao / numero2Divisao == numericUpDown_resultadoDivisao.Value)) {
                return true;
            } else {
                return false;
            }
        }

        public Form1() {
            InitializeComponent();
        }

        private void button_inicio_Click(object sender, EventArgs e) {
            inicarQuiz();
            button_inicio.Enabled = false;
        }

        private void timerTeste_Tick(object sender, EventArgs e)
        {
            if(verificarResposta()) {
                timerTeste.Stop();
                MessageBox.Show("Você acertou todas as questões!", "Parabéns!");
                button_inicio.Enabled = true;
            } else if (tempoRestante > 0) {
                tempoRestante--;
                label_contador.Text = tempoRestante + " segundos";
            } else {
                timerTeste.Stop();
                label_contador.Text = "Acabou o tempo!!";
                MessageBox.Show("Você nãõ conseguiu finalizar o teste a tempo.");
                numericUpDown_resultadoSoma.Value = numero1Soma + numero2Soma;
                numericUpDown_resultadoSubtracao.Value = numero1Subtracao - numero2Subtracao;
                numericUpDown_resultadoMultiplicacao.Value = numero1Multiplicacao * numero2Multiplicacao;
                numericUpDown_resultadoDivisao.Value = numero1Divisao / numero2Divisao;
                button_inicio.Enabled = true;
            }
        }

        private void focoResposta(object sender, EventArgs e) {
            NumericUpDown caixaResposta = sender as NumericUpDown;

            if (caixaResposta != null) {
                int comprimentoResposta = caixaResposta.Value.ToString().Length;
                caixaResposta.Select(0, comprimentoResposta);
            }
        }
    }
}
