
using MauiAppEjemplo.Modelo;

namespace MauiAppEjemplo.Servicios
{
    public interface IRickAndMortyService
    {
        public Task<List<PersonajesResponse>> Obtener();

    }
}
