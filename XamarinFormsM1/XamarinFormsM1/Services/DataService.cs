using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using XamarinFormsM1.Models;

namespace XamarinFormsM1.Services
{
    public class DataService
    {
        // Classe de exemplo de serviço de requisição à WEB API 
        public HttpClient client { get; set; }

        public DataService()
        {
            client = new HttpClient();
        }

        public async Task<List<Jogo>> GetJogosAsync()
        {
            try
            {
                string url = "http://localhost:5000/api/Jogos/";

                // Solicita todos os jogos, recebe a resposta em string, onde é possível a conversão para um objeto
                var response = await client.GetStringAsync(url);
                var jogos = JsonConvert.DeserializeObject<List<Jogo>>(response);

                return jogos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task AddJogoAsync(Jogo jogo)
        {
            try
            {
                string url = "http://localhost:5000/api/Jogos/";
                Uri uri = new Uri(string.Format(url));

                //Transforma o objeto JOGO em json
                var data = JsonConvert.SerializeObject(jogo);
                var content = new StringContent(data, Encoding.UTF8, "application/json");

                //instancia o formato da resposta do HttpClient
                HttpResponseMessage response = null;

                response = await client.PostAsync(uri, content);
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception("Erro ao adicionar o jogo");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task PutJogoAsync(Jogo jogo)
        {
            try
            {
                string url = "http://localhost:5000/api/Jogos/{0}";
                Uri uri = new Uri(string.Format(url, jogo.Id));

                //Transforma o objeto JOGO em json
                var data = JsonConvert.SerializeObject(jogo);
                var content = new StringContent(data, Encoding.UTF8, "application/json");

                //instancia o formato da resposta do HttpClient
                HttpResponseMessage response = null;

                response = await client.PutAsync(uri, content);
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception("Erro ao alterar o jogo");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task DeleteJogoAsync(Jogo jogo)
        {
            try
            {
                string url = "http://localhost:5000/api/Jogos/{0}";
                Uri uri = new Uri(string.Format(url, jogo.Id));

                var response = await client.DeleteAsync(uri);

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception("Erro ao deletar o jogo");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
