﻿using CarBook.Application.Interfaces.BlogInterfaces;
using CarBook.Domain.Entities;
using CarBook.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Persistance.Repositories.BlogRepositories;

public class BlogRepository : IBlogRepository
{
    private readonly CarBookContext _carBookContext;

    public BlogRepository(CarBookContext carBookContext)
    {
        _carBookContext = carBookContext;
    }

    public List<Blog> GetAllBlogsWithAuthors()
    {
        var values = _carBookContext.Blogs.Include(x => x.Author).Include(y=>y.Category).ToList();
        return values;
    }

    public Blog GetBlogWithAuthorByBlogId(int id)
    {
        var value = _carBookContext.Blogs.Include(x => x.Author).Where(y => y.BlogId == id).FirstOrDefault();
        return value;
    }

    public List<Blog> GetLast3BlogsWithAuthors()
    {
        var values = _carBookContext.Blogs.Include(x => x.Author).OrderByDescending(x => x.BlogId).Take(3).ToList();
        return values;
    }
}
