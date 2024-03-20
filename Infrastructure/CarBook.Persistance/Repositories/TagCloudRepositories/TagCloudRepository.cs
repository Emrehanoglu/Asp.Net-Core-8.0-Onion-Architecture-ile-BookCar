using CarBook.Application.Interfaces.TagCloudInterfaces;
using CarBook.Domain.Entities;
using CarBook.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Persistance.Repositories.TagCloudRepositories;

public class TagCloudRepository : ITagCloudRepository
{
    private readonly CarBookContext _carBookContext;

    public TagCloudRepository(CarBookContext carBookContext)
    {
        _carBookContext = carBookContext;
    }

    public List<TagCloud> GetTagCloudByBlodId(int id)
    {
        var values = _carBookContext.TagClouds.Where(x => x.BlogId == id).ToList();
        return values;
    }
}
