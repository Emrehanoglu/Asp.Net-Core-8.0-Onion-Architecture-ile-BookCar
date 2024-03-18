using CarBook.Application.Features.Mediator.Queries.CarPricingQueries;
using CarBook.Application.Features.Mediator.Results.CarPricingResults;
using CarBook.Application.Interfaces.CarPricingInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.CarPricingHandlers;

public class GetCarPricingQueryHandler : IRequestHandler<GetCarPricingWithCarQuery, List<GetCarPricingWithCarQueryResult>>
{
    private readonly ICarPricingRepository _carPricingRepository;

    public GetCarPricingQueryHandler(ICarPricingRepository carPricingRepository)
    {
        _carPricingRepository = carPricingRepository;
    }

    public async Task<List<GetCarPricingWithCarQueryResult>> Handle(GetCarPricingWithCarQuery request, CancellationToken cancellationToken)
    {
        var values = _carPricingRepository.GetCarPricingWithCars();
        return values.Select(x => new GetCarPricingWithCarQueryResult
        {
            Amount = x.Amount,
            Brand = x.Car.Brand.Name,
            CarPricingId = x.CarPricingId,
            CoverImageUrl = x.Car.CoverImageUrl,
            Model = x.Car.Model
        }).ToList();
    }
}
