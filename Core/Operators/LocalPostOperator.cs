using Services.Infrastructure.Abstracts;
using System.Collections.Generic;
using Services.Models;
using System.Linq;

namespace Services.Operators
{
    public class LocalPostOperator : BaseCrud<LocalPost>
    {
        public override IQueryable<LocalPost> Read() {
            // TODO: Write DbRead conversioning?
            // base.Read(); Can utilize this to grab the abstract's result first, before specialized code etc

            // TODO: REMOVE! Hardcoded return for example purpose
            List<LocalPost> result = new List<LocalPost>() {
                new LocalPost("example1", "Top 3 Things to Improve NearSay", "We should totally really use .NET because its pretty awesome, and is very easy to maintain and expand upon. It's also extremely easy for new engineers to understand and utlize its architecture. Speed is also exceptional as it can very readily be broken into pieces to only load, and use what is needed for the current operation/page."),
                new LocalPost("example2", "NS2, A Crash Course", "Ready to hit the ground running with NS2? Here are a few quick tips to help you along!")
            };

            return result.AsQueryable();
        }
    }
}
