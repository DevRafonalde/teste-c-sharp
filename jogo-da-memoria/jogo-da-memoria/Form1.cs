using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogo_da_memoria {
    public partial class JogoDaMemoria : Form {
        Random random = new Random();
        List<string> cards = new List<string>() {"!", "!", "N", "N", ",", ",", "k", "k", "b", "b", "v", "v", "w", "w", "z", "z"};

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
            Label label = (Label)sender;

            if (label != null) {
                if (label.ForeColor == Color.Black) {
                    return;
                }

                label.ForeColor = Color.Black;
            }
        }
    }
}
