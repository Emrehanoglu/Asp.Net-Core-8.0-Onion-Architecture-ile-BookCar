using CarBook.Application.Features.CQRS.Results.CarResults;
using CarBook.Application.Interfaces.CarInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers;

public class GetLast5CarsWithBrandQueryHandler
{
    private readonly ICarRepository _repository;

    public GetLast5CarsWithBrandQueryHandler(ICarRepository repository)
    {
        _repository = repository;
    }
    public List<GetLast5CarsWithBrandQueryResult> Handle()
    {
        var values = _repository.GetLast5CarsListWithBrands();
        return values.Select(x => new GetLast5CarsWithBrandQueryResult
        {
            BigImageUrl = x.BigImageUrl,
            BrandId = x.BrandId,
            BrandName = x.Brand.Name,
            CarId = x.CarId,
            CoverImageUrl = x.CoverImageUrl,
            Fuel = x.Fuel,
            Km = x.Km,
            Luggage = x.Luggage,
            Model = x.Model,
            Seat = x.Seat,
            Transmission = x.Transmission
        }).ToList();
    }
}
