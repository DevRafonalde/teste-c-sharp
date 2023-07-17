using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace relatorio_oficios_cs.model.repositories {
    public class OficioRepository {
        public static List<Oficio> RequisitarOficios(string metodo, string parametro) {
            try {
                // Conexão HTTP
                HttpClient httpClient = new HttpClient();
                string url = "http://192.168.0.109:8602/api/v1/intranet/consulta/" + metodo + parametro;
                HttpResponseMessage response = httpClient.GetAsync(url).Result;

                if (response.IsSuccessStatusCode) {
                    string conteudo = response.Content.ReadAsStringAsync().Result;

                    if (conteudo.Length > 2) {
                        string[] arr = conteudo.Substring(1, conteudo.Length - 2).Replace(";", "").Replace("},", "};").Replace("emitido\":null", "emitido\":false").Split(';');
                        List<Oficio> lista = arr.Select(json => JsonSerializer.Deserialize<Oficio>(json)).Where(oficio => oficio != null)
                            .OrderBy(oficio => oficio.numero)
                            .ToList();

                        Dictionary<int, Oficio> hashmap = new Dictionary<int, Oficio>();
                        foreach (Oficio oficio in lista) {
                            if (!hashmap.ContainsKey(oficio.id)) {
                                hashmap.Add(oficio.id, oficio);
                            }
                        }

                        return hashmap.Values.ToList();
                    }

                    return new List<Oficio>();
                }

                return new List<Oficio>();
            } catch (Exception ex) {
                Console.WriteLine("Error: " + ex.Message);
                return new List<Oficio>();
            }
        }
    }
}