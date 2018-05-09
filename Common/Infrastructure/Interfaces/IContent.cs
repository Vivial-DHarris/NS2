using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Common.Infrastructure.Interfaces
{
    public interface IContent
    {
        string Title { get; set; }
        string Description { get; set; }
        HashSet<string> Keywords { get; set; }
        string HeroImage { get; set; } 
    }
}
