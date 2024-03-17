﻿using CarBook.Application.Features.Mediator.Commands.BlogCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.BlogHandlers;

public class UpdateBlogCommandHandler : IRequestHandler<UpdateBlogCommand>
{
    private readonly IRepository<Blog> _repository;

    public UpdateBlogCommandHandler(IRepository<Blog> repository)
    {
        _repository = repository;
    }
    public async Task Handle(UpdateBlogCommand request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.BlogId);
        value.CreatedDate = request.CreatedDate;
        value.CategoryId = request.CategoryId;
        value.AuthorId = request.AuthorId;
        value.CoverImageUrl = request.CoverImageUrl;
        value.Title = request.Title;
        await _repository.UpdateAsync(value);
    }
}
