using CarBook.Dto.FeatureDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.Controllers;

public class AdminFeatureController : Controller
{
    private readonly IHttpClientFactory _httpClientFactory;

    public AdminFeatureController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync("https://localhost:7195/api/Features");
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultFeatureDto>>(jsonData);
            return View(values);
        }
        return View();
    }
}
