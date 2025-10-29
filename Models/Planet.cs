// Models/PlanetModel.cs
namespace ConsumerDbzPlanet.Models
{
    public class PlanetModel
    {
        // Propriedades comuns de um planeta em uma API
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Status { get; set; } // Baseado na imagem de retorno "Status: Destruído"
        public string Image { get; set; } // Para a URL da imagem
        // Se a API retornar um array, você pode precisar de uma lista dessas, mas para a busca por ID, um objeto individual é esperado.
    }
}