using relatorio_oficios_cs.model.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace relatorio_oficios_cs.controller {
    class Controller {
        public Controller() {
        }

        public List<Oficio> RealizarBusca(string metodo, string parametro, List<Oficio> oficios) {

            switch (metodo) {
                case "Ano":
                    metodo = "findOficioByAno/";
                    break;
                case "Número": 
                    metodo = "findOficioByNumero/";
                    break;
                case "Ano/Número":
                    metodo = "findOficioByAnoAndNumero/";
                    break;
                case "Protocolo RI":
                    metodo = "findOficioByProtocoloTitulo/";
                    break;
                case "Protocolo Certidão":
                    metodo = "findOficioByProtocoloCertidao/";
                    break;
                case "Número do Processo":
                    metodo = "findOficioByNumeroProcesso/";
                    parametro = Regex.Replace(parametro, "[^0-9]", "");
                    Console.WriteLine("Parâmetro dentro do controller: " + parametro);
                    break;
            }
            if (parametro.Equals("")) {
                metodo = "findAllOficio";
            }

            return OficioRepository.RequisitarOficios(metodo, parametro);
        }
    }
}
