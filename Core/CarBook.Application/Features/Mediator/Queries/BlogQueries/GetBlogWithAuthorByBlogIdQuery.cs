using CarBook.Application.Features.Mediator.Results.BlogResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Queries.BlogQueries;

public class GetBlogWithAuthorByBlogIdQuery:IRequest<GetBlogWithAuthorByBlogIdQueryResult>
{
    public int Id { get; set; }

    public GetBlogWithAuthorByBlogIdQuery(int id)
    {
        Id = id;
    }
}
