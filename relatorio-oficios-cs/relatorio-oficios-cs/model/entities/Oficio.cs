using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace relatorio_oficios_cs {
    public class Oficio {
        public int id {
            get; set;
        }

        public int protocoloTitulo {
            get; set;
        }

        public int protocoloCertidao {
            get; set;
        }

        public int numero {
            get; set;
        }

        public string ano {
            get; set;
        }

        public string numeroProcesso {
            get; set;
        }

        public string tipoProcesso {
            get; set;
        }

        public string observacao {
            get; set;
        }

        public string numeroOficioCadastrado {
            get; set;
        }

        public bool recebido {
            get; set;
        }

        public bool emitido {
            get; set;
        }

        public string dataFinalizacao {
            get; set;
        }

        public string usuarioFinalizacao {
            get; set;
        }

        public int? oficioVinculadoId {
            get; set;
        }

        public int? oficioVinculadoNumero {
            get; set;
        }

        public string oficioVinculadoAno {
            get; set;
        }

        public bool respostaRecebida {
            get; set;
        }

        public Oficio JsonDesserializar(string json) {
            return JsonSerializer.Deserialize<Oficio>(json);
        }

        public List<Oficio> JsonDesserializarLista(string json) {
            return null;
        }
    }
}
