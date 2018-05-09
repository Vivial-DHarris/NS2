using System;
using System.Collections.Generic;
using System.Text;

namespace Commons.Infrastructure.Interfaces
{
    public interface IDbRecord
    {
        string Key { get; set; }
        DateTime DateCreated { get; set; }
        DateTime LastEdited { get; set; }
    }
}
