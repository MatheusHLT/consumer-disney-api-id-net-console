using ConsumerDisneyApi.Models;
using static System.Console;

WriteLine("Digite o ID do personagem: ");
var _id = ReadLine();

var enderecoUrl = $"https://api.disneyapi.dev/character/{_id}";

var cliente = new HttpClient();

try
{
    HttpResponseMessage? response = await cliente.GetAsync(enderecoUrl);
    response.EnsureSuccessStatusCode();

    string respostaApi = await response.Content.ReadAsStringAsync();

    DisneyResponse? resultado = System.Text.Json.JsonSerializer.Deserialize<DisneyResponse>(respostaApi);

    WriteLine($"\ncount: {resultado.Info?.count}");
    WriteLine($"\nNome: {resultado.Data?.name}");
    WriteLine($"\nImagem:\n {resultado.Data?.imageUrl}");
}

catch (Exception ex)
{
    WriteLine($"Ocorreu um erro ao consultar a api: {ex.Message}");
}