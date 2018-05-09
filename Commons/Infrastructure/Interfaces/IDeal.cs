using System;
using System.Collections.Generic;
using System.Text;

namespace Commons.Infrastructure.Interfaces
{
    public interface IDeal
    {
        DateTime ExpiresOn { get; set; }
        double OriginalCost { get; set; }
        double DealCost { get; set; }
    }
}
