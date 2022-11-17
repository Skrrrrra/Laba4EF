using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4EF.Tables
{
    public class FirstTable
    {
        [Key]
        public int gameID { get; set; }
        public string name { get; set; }
        public string platform { get; set; }
        public string yearOfRelease { get; set; }
        public string genre { get; set; }
        public string publisher { get; set; }
        public string criticScore { get; set; }
        public string criticCount { get; set; }
        public string userScore { get; set; }
        public string userCount { get; set; }
        public string developer { get; set; }
        public string rating { get; set; }
        public FirstTable()
        {

        }
        public FirstTable(string Name, string Platform, string Year, string Genre, string Publisher, string CriticScore, string CriticCount, string UserScore, string UserCount, string Dev, string Rating)
        {
            name = Name;
            platform = Platform;
            yearOfRelease = Year;
            genre = Genre;
            publisher = Publisher;
            criticScore = CriticScore;
            criticCount = CriticCount;
            userScore = UserScore;
            userCount = UserCount;
            developer = Dev;
            rating = Rating;
        }
    }
}
