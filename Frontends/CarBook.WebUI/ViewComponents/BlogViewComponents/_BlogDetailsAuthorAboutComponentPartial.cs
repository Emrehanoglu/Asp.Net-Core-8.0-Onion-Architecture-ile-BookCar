using CarBook.Dto.BlogDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.ViewComponents.BlogViewComponents;

public class _BlogDetailsAuthorAboutComponentPartial:ViewComponent
{
    private readonly IHttpClientFactory _httpClientFactory;

    public _BlogDetailsAuthorAboutComponentPartial(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IViewComponentResult> InvokeAsync(int id)
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync($"https://localhost:7195/api/Blogs/GetBlogWithAuthorByBlogId?id="+id);
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var value = JsonConvert.DeserializeObject<ResultBlogWithAuthorByBlogIdDto>(jsonData);
            return View(value);
        }
        return View();
    }
}
