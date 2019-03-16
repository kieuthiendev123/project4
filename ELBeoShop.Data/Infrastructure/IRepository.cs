﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ELBeoShop.Data.Infrastructure
{
   public  interface IRepository<T> where T: class
    {
        // Genneric sử dụng cho tất cả các lớp
        // Thêm mới
        T Add(T entity);

        // sửa 
        void Update(T entity);

        // xóa
        T Delete(T entity);

        T Delete(int id);
        
        // Xóa nhiều hồ sơ
        void DeleteMulti(Expression<Func<T, bool>> where);

        // Get an entity by int id
        T GetSingleById(int id);

        T GetSingleByCondition(Expression<Func<T, bool>> expression, string[] includes = null);

        IEnumerable<T> GetAll(string[] includes = null);

        IEnumerable<T> GetMulti(Expression<Func<T, bool>> predicate, string[] includes = null);

        IEnumerable<T> GetMultiPaging(Expression<Func<T, bool>> filter, out int total, int index = 0, int size = 50, string[] includes = null);

        int Count(Expression<Func<T, bool>> where);

        bool CheckContains(Expression<Func<T, bool>> predicate);
    }
}
