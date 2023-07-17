using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace jogo_da_memoria {
    public partial class JogoDaMemoria : Form {

        Label primeiroClique = null;
        Label segundoClique = null;
        Random random = new Random();
        List<string> cards = new List<string>() { "!", "!", "N", "N", ",", ",", "k", "k", "b", "b", "v", "v", "w", "w", "z", "z" };

        private void inserirIcones() {
            foreach (Control control in tableLayoutPanel_principal.Controls) {
                Label cardLabel = control as Label;
                if (cardLabel != null) {
                    int indexAleatorio = random.Next(cards.Count);
                    cardLabel.Text = cards[indexAleatorio];
                    cardLabel.ForeColor = cardLabel.BackColor;
                    cards.RemoveAt(indexAleatorio);
                }
            }
        }

        public JogoDaMemoria() {
            InitializeComponent();
            inserirIcones();
        }

        private void cardClick(object sender, EventArgs e) {
            Label label = sender as Label;

            if (label != null) {
                if (label.ForeColor == Color.Black) {
                    return;
                }

                if (primeiroClique == null) {
                    primeiroClique = label;
                    primeiroClique.ForeColor = Color.Black;

                    return;
                }

                segundoClique = label;
                segundoClique.ForeColor = Color.Black;

                verificarGanhador();

                if (primeiroClique.Text == segundoClique.Text) {
                    primeiroClique = null;
                    segundoClique = null;
                    return;
                }

                timer.Start();
            }
        }

        private void timer_Tick(object sender, EventArgs e) {
            timer.Stop();
            primeiroClique.ForeColor = primeiroClique.BackColor;
            segundoClique.ForeColor = segundoClique.BackColor;

            primeiroClique = null;
            segundoClique = null;
        }

        private void verificarGanhador() {
            foreach (Control control in tableLayoutPanel_principal.Controls) {
                Label label = control as Label;
                if (label != null) {
                    if (label.ForeColor == label.BackColor) {
                        return;
                    }
                }
            }

            MessageBox.Show("Você encontrou todos os pares de cards!!", "Parabéns");
            Close();
        }
    }
}
