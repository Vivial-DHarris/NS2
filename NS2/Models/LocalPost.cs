using Common.Infrastructure.Interfaces;
using Commons.Infrastructure.Interfaces;
using Services.Models;
using System;
using System.Collections.Generic;

namespace NS2.Models
{
    public class LocalPostFull : IContent
    {
        public LocalPostFull(LocalPost dbo) {
            // TODO: This kind of thing can be done via AutoMapper!
            // AutoMapper generates these kinds of name => name object mappings making this no longer needed and saving redundancies
            //  altName => name mappings can easily be setup as well.

            Title = dbo.Title;
            Description = dbo.Description;
            Keywords = dbo.Keywords;
            HeroImage = dbo.HeroImage;
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public HashSet<string> Keywords { get; set; }
        public string HeroImage { get; set; }
    }

    public class LocalPostSimple : LocalPostFull
    {
        public LocalPostSimple(LocalPost dbo) : base(dbo) {
            HeroImage = dbo.HeroImageThumb; // Only need the down-sized thumb for Simple display
        }
    }

    public class LocalPostDealFull : LocalPostFull, IDeal
    {
        public LocalPostDealFull(LocalPost dbo) : base(dbo) {
            // . . .
        }

        public DateTime ExpiresOn { get; set; }
        public double OriginalCost { get; set; }
        public double DealCost { get; set; }

        // Example expansion utilized for the View vs What we have in the Db
        public double AmountSaved {
            get {
                return OriginalCost - DealCost;
            }
        }
    }

    public class LocalPostDealSimple : LocalPostDealFull
    {
        public LocalPostDealSimple(LocalPost dbo) : base(dbo) {
            HeroImage = dbo.HeroImageThumb; // Only need the down-sized thumb for Simple display
        }
    }
}