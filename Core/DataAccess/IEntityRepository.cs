using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.DataAccess
{
    //generic constraint
    //class = referans tip
    //new() = new'lenebilir olmalı

    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        // Refactoring, mövcud kodun funksionallığını dəyişmədən onun strukturunu və oxunaqlılığını yaxşılaşdırmaq məqsədilə yenidən təşkil edilməsidir.
        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
