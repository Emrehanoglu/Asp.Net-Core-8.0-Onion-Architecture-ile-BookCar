using CarBook.Application.Features.Repository;
using CarBook.Domain.Entities;
using CarBook.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Persistance.Repositories.CommentRepositories;

public class CommentRepository : IGenericRepository<Comment>
{
    private readonly CarBookContext _carBookContext;

    public CommentRepository(CarBookContext carBookContext)
    {
        _carBookContext = carBookContext;
    }

    public void Create(Comment entity)
    {
        _carBookContext.Comments.Add(entity);
        _carBookContext.SaveChanges();
    }

    public List<Comment> GetAll()
    {
        return _carBookContext.Comments.ToList();
    }

    public Comment GetById(int id)
    {
        return _carBookContext.Comments.Find(id);
    }

    public void Remove(Comment entity)
    {
        _carBookContext.Comments.Remove(entity);
        _carBookContext.SaveChanges();
    }

    public void Update(Comment entity)
    {
        _carBookContext.Comments.Update(entity);
        _carBookContext.SaveChanges();
    }
}
