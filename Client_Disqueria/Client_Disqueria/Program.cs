using Client_Disqueria.DTO.Cancion;
using Client_Disqueria.DTO.Disco;
using Client_Disqueria.DTO.Login;
using RestSharp;
using RestSharp.Serializers.NewtonsoftJson;

var service = new Service();

var token = service.Loggin("string", "string");

//-------------------GetSongsByFilter-----------------
Console.WriteLine("-----------------------GetSongsByFilter-------------");
var filter = new CancionFilterRequestDTO
{
    NombreCancion = "Rock",
    Banda = null,
    DuracionCancion = null
};

var getSongs = service.GetSongsByFilter(token, filter);
getSongs.ForEach(x => service.PrintSongs(x));

//----------------GetTopFiveDisks----------------
Console.WriteLine("-----------------------GetTopFiveDisks-------------");

var getTopFiveDisks = service.GetTopFiveDisks(token);
getTopFiveDisks.ForEach(x => service.PrintDiscos(x));

//----------------GetDisksByFilter----------------
Console.WriteLine("-----------------------GetDisksByFilter-------------");
var diskFilter = new DiscoFilterRequestDTO
{
    Genero = "Rock",
    Banda = null,
    CantidadVendida = null,
    TituloDisco = null
};

var getDisksByFilter = service.GetDisksByFilter(token, diskFilter);
getDisksByFilter.ForEach(x => service.PrintDiscos(x));


//----------------Create----------------
Console.WriteLine("-----------------------Create-------------");
var seed = Environment.TickCount;
var random = new Random(seed);

var newDisk = new DiscoCreateRequestDTO
{
    Nombre = "Disco 1",
    Banda = "Banda 1",
    FechaLanzamiento = new DateTime(1994, 1, 1),
    Genero = "Genero 1",
    UnidadesVendidas = random.Next(1000, 999999),
    SKU = random.Next(1000000, 9999999).ToString()
};

var create = service.Create(token, newDisk);
if (create) Console.WriteLine("Creado Ok!");
else Console.WriteLine("No se creo el disco");

//----------------Update----------------
Console.WriteLine("-----------------------Update-------------");

var update = new DiscoUpdateRequestDTO
{
    Titulo = "nuevo disco",
    Genero = "nuevo genero",
    FechaLanzamiento = new DateTime(1994, 1, 1),
    Banda = "nueva banda",
    CantidadVendidas = 999999
};
var SKU = "Test";

var result = service.Update(token, SKU, update);
if (result) Console.WriteLine("Actualizado Ok!");
else Console.WriteLine("No se actualizo el disco");

Console.ReadLine();


internal class Service
{
    const string UrlService = "http://localhost:5142/api";
    internal string Loggin(string user, string password)
    {
        LoginRequestDTO loginRequestDto = new LoginRequestDTO
        {
            Password = password,
            Username = user
        };

        string endPoint = $"/Login";
        var client = new RestClient(UrlService,
            configureSerialization: s => s.UseNewtonsoftJson());

        var response = client.PostJson<LoginRequestDTO, string>(endPoint, loginRequestDto);

        return response;
    }
    internal void PrintSongs(CancionResponseDTO cancionResponseDTO)
    {
        Console.WriteLine("------Cancion-----");
        Console.WriteLine($"Nombre: {cancionResponseDTO.NombreCancion}");
        Console.WriteLine($"Genero del disco: {cancionResponseDTO.GeneroDelDisco}");
        Console.WriteLine($"Banda: {cancionResponseDTO.Banda}");
        Console.WriteLine($"Fecha de Lanzamiento: {cancionResponseDTO.FechaLanzamientoDelDisco}");
        Console.WriteLine("------------------");
    }
    internal void PrintDiscos(DiscoResponseDTO discoResponseDTO) 
    {
        Console.WriteLine("------Disco-----");
        Console.WriteLine($"Titulo: {discoResponseDTO.TituloDisco}");
        Console.WriteLine($"Genero: {discoResponseDTO.Genero}");
        Console.WriteLine($"Banda: {discoResponseDTO.Banda}");
        Console.WriteLine($"Cantidad vendida: {discoResponseDTO.CantidadVendida}");
        Console.WriteLine($"Cantidad canciones: {discoResponseDTO.CantidadCanciones}");
        Console.WriteLine($"Fecha Lanzamiento: {discoResponseDTO.FechaLanzamiento}");
        Console.WriteLine("------------------");
    }
    internal List<CancionResponseDTO> GetSongsByFilter(string token, CancionFilterRequestDTO filter)
    {
        string endpoint = "/Cancion/GetSongsByFilter";

        var client = new RestClient(UrlService, configureSerialization: s => s.UseNewtonsoftJson());
        var request = new RestRequest(endpoint);
        request.Method = Method.Get;
        request.AddHeader("Authorization", string.Format("Bearer {0}", token));
        if (filter.NombreCancion != null) request.AddQueryParameter("NombreCancion", filter.NombreCancion);
        if (filter.Banda != null) request.AddQueryParameter("Banda", filter.Banda);
        if (filter.DuracionCancion != null) request.AddQueryParameter("DuracionCancion", filter.DuracionCancion.ToString());

        var response = client.Execute<List<CancionResponseDTO>>(request);
        Console.WriteLine(response.StatusCode);
        var result = client.Serializers.DeserializeContent<List<CancionResponseDTO>>(response);
        return result;
    }
    internal List<DiscoResponseDTO> GetTopFiveDisks(string token)
    {
        string endpoint = "/Disco/GetTopFiveDisks";
        var client = new RestClient(UrlService, configureSerialization: s => s.UseNewtonsoftJson());
        var request = new RestRequest(endpoint);
        request.Method = Method.Get;
        
        var response = client.Execute<List<DiscoResponseDTO>>(request);
        Console.WriteLine(response.StatusCode);
        var result = client.Serializers.DeserializeContent<List<DiscoResponseDTO>>(response);
        return result;
    }
    internal List<DiscoResponseDTO> GetDisksByFilter(string token, DiscoFilterRequestDTO filter)
    {
        string endpoint = "/Disco/GetDisksByFilter";
        var client = new RestClient(UrlService, configureSerialization: s => s.UseNewtonsoftJson());
        var request = new RestRequest(endpoint);
        request.Method = Method.Get;
        request.RequestFormat = RestSharp.DataFormat.Json;
        request.AddBody(filter);

        var response = client.Execute<List<DiscoResponseDTO>>(request);
        Console.WriteLine(response.StatusCode);
        var result = client.Serializers.DeserializeContent<List<DiscoResponseDTO>>(response);
        return result;
    } 
    internal bool Create(string token, DiscoCreateRequestDTO create)
    {
        string endpoint = "/Disco/Create";
        var client = new RestClient(UrlService, configureSerialization: s => s.UseNewtonsoftJson());
        var request = new RestRequest(endpoint);
        request.Method = Method.Post;
        request.AddHeader("Authorization", string.Format("Bearer {0}", token));
        if (create.Nombre != null) request.AddQueryParameter("Nombre", create.Nombre);
        if (create.Banda != null) request.AddQueryParameter("Banda", create.Banda);
        if (create.FechaLanzamiento != null) request.AddQueryParameter("FechaLanzamiento", create.FechaLanzamiento);
        if (create.Genero != null) request.AddQueryParameter("Genero", create.Genero);
        if (create.UnidadesVendidas != null) request.AddQueryParameter("UnidadesVendidas", create.UnidadesVendidas);
        if (create.SKU != null) request.AddQueryParameter("SKU", create.SKU);

        var response = client.Execute<bool>(request);
        if (response.StatusCode != System.Net.HttpStatusCode.OK) return false;

        var result = client.Serializers.DeserializeContent<bool>(response);
        return result;

    }
    internal bool Update(string token, string SKU, DiscoUpdateRequestDTO update)
    {
        string endpoint = $"/Disco/Update/{SKU}";
        var client = new RestClient(UrlService, configureSerialization: s => s.UseNewtonsoftJson());
        var request = new RestRequest(endpoint);
        request.Method = Method.Put;
        request.AddHeader("Authorization", string.Format("Bearer {0}", token));
        request.RequestFormat = RestSharp.DataFormat.Json;
        request.AddBody(update);

        var response = client.Execute<bool>(request);
        var result = client.Serializers.DeserializeContent<bool> (response);
        return result;
    }
}