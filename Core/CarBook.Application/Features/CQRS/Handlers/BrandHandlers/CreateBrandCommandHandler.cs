using CarBook.Application.Features.CQRS.Commands.BrandCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.BrandHandlers;

public class CreateBrandCommandHandler
{
	private readonly IRepository<Brand> _repository;

	public CreateBrandCommandHandler(IRepository<Brand> repository)
	{
		_repository = repository;
	}
	public async Task Handle(CreateBrandCommand command)
	{
		var value = new Brand { Name = command.Name };
		await _repository.CreateAsync(value);
	}
}
