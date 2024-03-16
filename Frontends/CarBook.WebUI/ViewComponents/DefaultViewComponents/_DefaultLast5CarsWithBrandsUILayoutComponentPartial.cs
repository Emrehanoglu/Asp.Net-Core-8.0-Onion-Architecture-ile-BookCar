using CarBook.Dto.CarDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.ViewComponents.DefaultViewComponents;

public class _DefaultLast5CarsWithBrandsUILayoutComponentPartial:ViewComponent
{
    private readonly IHttpClientFactory _httpClientFactory;

    public _DefaultLast5CarsWithBrandsUILayoutComponentPartial(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var client = _httpClientFactory.CreateClient();
        var responsemessage = await client.GetAsync("https://localhost:7195/api/Cars/GetLast5CarsWithBrand");
        if (responsemessage.IsSuccessStatusCode)
        {
            var jsonData = await responsemessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultLast5CarsWithBrandDto>>(jsonData);
            return View(values);
        }
        return View();
    }
}
