﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using DataAccesLayer.Abstract;

namespace DataAccesLayer.Concrete
{

    public class Repository<T> : IRepository<T> where T : class
    {
        Context c = new Context();
        DbSet<T> _object;
        public Repository()
        {
            _object = c.Set<T>();
        }

        public int Delete(T p)
        {
            _object.Remove(p);
            return c.SaveChanges();
        }

        public T Find(Expression<Func<T, bool>> where)
        {
            return _object.FirstOrDefault(where);
        }

        public T GetByID(int id)
        {
            return _object.Find(id);
        }

        public int Insert(T p)
        {
            _object.Add(p);
            return c.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> where)
        {
            return _object.Where(where).ToList();
        }

        public int Update(T p)
        {
            return c.SaveChanges();
        }

    }
}
