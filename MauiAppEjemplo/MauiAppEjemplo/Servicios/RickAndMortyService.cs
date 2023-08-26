using MauiAppEjemplo.Modelo;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace MauiAppEjemplo.Servicios
{
    public class RickAndMortyService : IRickAndMortyService
    {
        private string urlApi = "https://rickandmortyapi.com/api/character";
        public async Task<List<PersonajesResponse>> Obtener()
        {
            var client = new HttpClient();
            var response = await client.GetAsync(urlApi);
            var responseBody = await response.Content.ReadAsStringAsync();
            JsonNode nodos = JsonNode.Parse(responseBody);
            JsonNode results = nodos["results"];
            var personajeData = JsonSerializer.Deserialize<List<PersonajesResponse>>(results.ToString());
            return personajeData;
        }
    }
}
