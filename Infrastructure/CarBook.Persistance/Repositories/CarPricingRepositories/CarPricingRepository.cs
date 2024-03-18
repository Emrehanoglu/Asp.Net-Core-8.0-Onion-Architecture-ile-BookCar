using CarBook.Application.Interfaces.CarPricingInterfaces;
using CarBook.Domain.Entities;
using CarBook.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Persistance.Repositories.CarPricingRepositories;

public class CarPricingRepository : ICarPricingRepository
{
    private readonly CarBookContext _carBookContext;

    public CarPricingRepository(CarBookContext carBookContext)
    {
        _carBookContext = carBookContext;
    }

    public List<CarPricing> GetCarPricingWithCars()
    {
        var values = _carBookContext.CarPricings.Include(x => x.Car).ThenInclude(y => y.Brand)
            .Include(z => z.Pricing).ToList();
        return values;
    }
}
