using CarBook.Application.Features.CQRS.Results.CarResults;
using CarBook.Application.Interfaces.CarInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers;

public class GetCarWithPricingsQueryHandler
{
    private readonly ICarRepository _carRepository;

    public GetCarWithPricingsQueryHandler(ICarRepository carRepository)
    {
        _carRepository = carRepository;
    }
    public List<GetCarWithPricingQueryResult> Handle()
    {
        var values = _carRepository.GetCarsWithPricings();
        return values.Select(x => new GetCarWithPricingQueryResult
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
            Transmission = x.Transmission,
            PricingAmount = x.CarPricings.Amo
        }).ToList();
    }
}
