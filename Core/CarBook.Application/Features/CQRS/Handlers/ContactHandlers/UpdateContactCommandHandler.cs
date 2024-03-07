using CarBook.Application.Features.CQRS.Commands.ContactCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.ContactHandlers;

public class UpdateContactCommandHandler
{
	private readonly IRepository<Contact> _repository;

	public UpdateContactCommandHandler(IRepository<Contact> repository)
	{
		_repository = repository;
	}
	public async Task Handle(UpdateContactCommand command)
	{
		var value = await _repository.GetByIdAsync(command.ContactId);
		if (value != null) 
		{
			value.Email = command.Email;
			value.Message = command.Message;
			value.Name = command.Name;
			value.SendDate = command.SendDate;
			value.Subject = command.Subject;

			await _repository.UpdateAsync(value);
		};
	}
}
