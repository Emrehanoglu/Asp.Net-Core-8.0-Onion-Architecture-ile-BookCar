using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Dto.BlogDtos;

public class ResultBlogWithAuthorByBlogIdDto
{
    public int BlogId { get; set; }
    public int AuthorId { get; set; }
    public string AuthorName { get; set; }
    public string AuthorDescription { get; set; }
    public string AuthorImage { get; set; }
}
