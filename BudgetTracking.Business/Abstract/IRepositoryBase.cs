using Dapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetTracking.Business.Abstract
{
    public interface IRepositoryBase<T> where T : class
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        int Insert(T content);
        bool Update(T content);
        bool Delete(T content);
        bool DeleteAll(T content);
    }
}
