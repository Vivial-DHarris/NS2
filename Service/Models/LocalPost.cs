using Commons.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Models
{
    public class LocalPost : IDbRecord, IContent, IDeal
    {
        public LocalPost(string key, string title, string description) {
            Key = key;
            Title = title;
            Description = description;
        }

        // TODO: A constructor that maps a JSON object to our DataModel??
        // Note that a Migrator function could easily be added to this as Static function

        public string Key { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastEdited { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public HashSet<string> Keywords { get; set; }

        string _heroImage;
        public string HeroImage {
            get {
                return _heroImage;
            }
            set {
                _heroImage = value;

                // TODO: Run compression/downsizing on the original image
                HeroImageThumb = value;
            }
        }
        public string HeroImageThumb { get; private set; }

        public DateTime BeginsOn { get; set; } // For query filtering only!
        public DateTime ExpiresOn { get; set; }
        public double OriginalCost { get; set; }
        public double DealCost { get; set; }
    }
}
