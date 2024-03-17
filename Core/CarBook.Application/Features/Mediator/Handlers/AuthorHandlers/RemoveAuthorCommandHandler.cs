﻿using CarBook.Application.Features.Mediator.Commands.AuthorCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.AuthorHandlers;

public class RemoveAuthorCommandHandler : IRequestHandler<UpdateAuthorCommand>
{
    private readonly IRepository<Author> _repository;

    public RemoveAuthorCommandHandler(IRepository<Author> repository)
    {
        _repository = repository;
    }
    public async Task Handle(UpdateAuthorCommand request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.AuthorId);
        await _repository.RemoveAsync(value);
    }
}