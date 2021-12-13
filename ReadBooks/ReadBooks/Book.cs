using Microsoft.AppCenter.Crashes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReadBooks
{
    public class Book
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string ISBN { get; set; }

        public bool SaveBook()
        {
            // Save to some db
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>
                {
                    { "book_info", this.ToString() },
                    { "network", "Cellular" }
                };
            AppCenterHelper.TrackEvent("book_saved", keyValuePairs);
            return true;
        }

        public override string ToString()
        {
            return $"{Name} - {Author}";
        }
    }
}
