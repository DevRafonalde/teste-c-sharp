using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace relatorio_oficios_cs.helpers {
    public class RespostasHelper {
        public static List<Oficio> ConferirTodasRespostas(List<Oficio> respostas) {
            foreach (Oficio oficio in respostas) {
                if (ConferirArquivoDeRespostaOficiosAlmada(oficio) || ConferirArquivoDeRespostaOficiosFlavis(oficio)) {
                    oficio.respostaRecebida = true;
                } else if (oficio.observacao.ToLower().Replace(" ", "").Contains("respostarecebida-ok")) {
                    oficio.respostaRecebida = true;
                } else {
                    oficio.respostaRecebida = false;
                }
            }

            return respostas;
        }

        private static bool ConferirArquivoDeRespostaOficiosFlavis(Oficio oficio) {
            string ano;
            int numero;
            if (oficio.recebido) {
                if (oficio.oficioVinculadoNumero == null) {
                    return false;
                } else {
                    ano = oficio.oficioVinculadoAno;
                    numero = (int) oficio.oficioVinculadoNumero;
                }
            } else {
                ano = oficio.ano;
                numero = oficio.numero;
            }

            if (0 < numero && numero < 10) {
                return File.Exists("T:\\GESTAO\\CONTROLE DE OFICIOS\\OFICIOS ENVIADOS\\OFICIO_" + ano + "\\" + ano + "-0" + numero + "\\" + ano + "-0" + numero + "R.pdf");
            } else {
                return File.Exists("T:\\GESTAO\\CONTROLE DE OFICIOS\\OFICIOS ENVIADOS\\OFICIO_" + ano + "\\" + ano + "-" + numero + "\\" + ano + "-" + numero + "R.pdf");
            }
        }

        private static bool ConferirArquivoDeRespostaOficiosAlmada(Oficio oficio) {
            string ano;
            int numero;
            if (oficio.recebido) {
                if (oficio.oficioVinculadoNumero == null) {
                    return false;
                } else {
                    ano = oficio.oficioVinculadoAno;
                    numero = (int) oficio.oficioVinculadoNumero;
                }
            } else {
                ano = oficio.ano;
                numero = oficio.numero;
            }
            
            return File.Exists("T:\\GESTAO\\CONTROLE DE OFICIOS\\OFICIOS ENVIADOS\\OFICIO_" + ano + "\\" + ano + "-0" + numero + "\\" + ano + "-0" + numero + "R.pdf");
        }
    }
}
