using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.Infrastructure.Interfaces
{
    interface IRead<IDbRecord>
    {
        IQueryable<IDbRecord> Read();
        IDbRecord Read(string Key);
    }
}
