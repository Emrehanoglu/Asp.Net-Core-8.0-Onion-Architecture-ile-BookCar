using CarBook.Application.Features.Mediator.Queries.BlogQueries;
using CarBook.Application.Features.Mediator.Results.BlogResults;
using CarBook.Application.Interfaces.BlogInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.BlogHandlers;

public class GetBlogWithAuthorByBlogIdQueryHandler
    : IRequestHandler<GetBlogWithAuthorByBlogIdQuery, GetBlogWithAuthorByBlogIdQueryResult>
{
    private readonly IBlogRepository _blogRepository;

    public GetBlogWithAuthorByBlogIdQueryHandler(IBlogRepository blogRepository)
    {
        _blogRepository = blogRepository;
    }

    public async Task<GetBlogWithAuthorByBlogIdQueryResult> Handle(GetBlogWithAuthorByBlogIdQuery request, CancellationToken cancellationToken)
    {
        var value = _blogRepository.GetBlogWithAuthorByBlogId(request.Id);
        return new GetBlogWithAuthorByBlogIdQueryResult
        {
            BlogId = value.BlogId,
            AuthorId = value.AuthorId,
            AuthorName = value.Author.Name,
            AuthorDescription = value.Author.Description,
            AuthorImage = value.Author.ImageUrl
        };
    }
}
