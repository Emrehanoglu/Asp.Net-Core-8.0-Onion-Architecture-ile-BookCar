using CarBook.Application.Interfaces.CarInterfaces;
using CarBook.Domain.Entities;
using CarBook.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Persistance.Repositories.CarRepositories;

public class CarRepository : ICarRepository
{
	private readonly CarBookContext _carBookContext;

	public CarRepository(CarBookContext carBookContext)
	{
		_carBookContext = carBookContext;
	}
	public List<Car> GetCarsListWithBrands()
	{
		var values = _carBookContext.Cars.Include(x => x.Brand).ToList();
		return values;
	}

    public List<CarPricing> GetCarsWithPricings()
    {
		var values = _carBookContext.CarPricings.Include(x => x.Car).ThenInclude(y => y.Brand)
			.Include(z => z.Pricing).ToList();
		return values;
    }

    public List<Car> GetLast5CarsListWithBrands()
    {
        var values = _carBookContext.Cars.Include(x => x.Brand).OrderByDescending(x=>x.CarId).Take(5).ToList();
		return values;
    }
}
