using CarBook.Application.Features.CQRS.Commands.CategoryCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.CategoryHandlers;

public class CreateCategoryCommandHandler
{
	private readonly IRepository<Category> _repository;

	public CreateCategoryCommandHandler(IRepository<Category> repository)
	{
		_repository = repository;
	}
	public async Task Handle(CreateCategoryCommand command)
	{
		var value = new Category { Name = command.Name };
		await _repository.CreateAsync(value);
	}
}
