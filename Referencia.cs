using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;


public class Referencias
{
    
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AppReferencia
{
    public class Referencia
    {
        public Referencia()
        {
        }

        public string Nome { get; set; }
        string Empresa { get; set; }
        string Telefone { get; set; }
        string Observacao { get; set; }
        string  Email { get; set; }
        string CIdade { get; set; }

        public string JsonSerializar(Referencias referencias)
        {
            return JsonConvert.SerializeObject(referencias);
        }
        public static Referencias JsonDesserializar(string Json)
        {
            return JsonConvert.DeserializeObject<Referencias>(Json);
        }
        public static void Main(string[] args)
        {

            Referencias referencia = new Referencias();

            referencia.Nome = "Joao";
            referencia.Telefone = "991098256";
            referencia.Observacao = "Não passa";
            referencia.Cidade = "Porto calvo";
            referencia.Email = "Guabi@outlook.com";
          

            string output = JsonConvert.SerializeObject(referencias);


            Referencias deserializedReferencias = JsonConvert.DeserializeObject<Referencias>(output);
        }
                Console.Log(output);
    }
}
