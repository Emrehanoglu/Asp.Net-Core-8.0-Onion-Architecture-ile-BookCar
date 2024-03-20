using CarBook.Application.Features.Mediator.Queries.TagCloudQueries;
using CarBook.Application.Features.Mediator.Results.TagCloudResults;
using CarBook.Application.Interfaces.TagCloudInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.TagCloudHandlers;

public class GetTagCloudByBlogIdQueryHandler : IRequestHandler<GetTagCloudByBlogIdQuery, List<GetTagCloudByBlogIdQueryResult>>
{
    private readonly ITagCloudRepository _tagCloudRepository;

    public GetTagCloudByBlogIdQueryHandler(ITagCloudRepository tagCloudRepository)
    {
        _tagCloudRepository = tagCloudRepository;
    }

    public async Task<List<GetTagCloudByBlogIdQueryResult>> Handle(GetTagCloudByBlogIdQuery request, CancellationToken cancellationToken)
    {
        var values = _tagCloudRepository.GetTagCloudByBlodId(request.Id);
        return values.Select(x => new GetTagCloudByBlogIdQueryResult
        {
            BlogId = x.BlogId,
            TagCloudId = x.TagCloudId,
            Title = x.Title
        }).ToList();
    }
}
