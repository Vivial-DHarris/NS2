using Services.Infrastructure.Interfaces;
using System;
using System.Linq;
using Commons.Infrastructure.Interfaces;

namespace Services.Infrastructure.Abstracts
{
    public abstract class BaseCrud<TModel> : IRead<TModel> 
        where TModel : IDbRecord
    {
        public BaseCrud() {
            // TODO: Initialize DbContext
        }

        // Basic implementation, virtual allows to override later if we want an explicit implementation
        public virtual IQueryable<TModel> Read() {
            // Generic implementation returning all records of DbType TModel
            throw new NotImplementedException();
        }

        public TModel Read(string key) {
            // Generic implementation return a record of DbType TModel, matching the given Key
            return Read().First(data => data.Key.Equals(key));
        }

        // TODO: Create, Update, Destroy functions (+ Interfaces)
    }
}
