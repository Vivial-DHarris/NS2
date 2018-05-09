using System.Collections.Generic;

namespace Common.Infrastructure.Interfaces
{
    public interface IContent
    {
        // TODO: For some reason it won't let me use .NET Core which contains this, and link it to the application??
        //[StringLength(25)] 
        string Title { get; set; }

        string Description { get; set; }
        HashSet<string> Keywords { get; set; }
        string HeroImage { get; set; } 
    }
}
