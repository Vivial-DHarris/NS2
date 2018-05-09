using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Infrastructure.Interfaces
{
    public interface IDbRecord
    {
        string Key { get; set; }
        DateTime DateCreated { get; set; }
        DateTime LastEdited { get; set; }
    }
}
