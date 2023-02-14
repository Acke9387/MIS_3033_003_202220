using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_Serialization
{
    public class Game
    {
        public string name { get; set; }
        public string platform { get; set; }
        public DateTime? release_date { get; set; }
        public string summary { get; set; }
        public int meta_score { get; set; }
        public string user_review { get; set; }

        public Game()
        {
            name = string.Empty;
            platform = string.Empty;
            release_date = null;
            summary = string.Empty;
            meta_score = 0;
            user_review = string.Empty;
        }

        public Game(string line)
        {
            string[] pieces = line.Split(",");
            //name,platform,release_date,summary,meta_score,user_review
            name = pieces[0];
            platform = pieces[1];
            release_date = Convert.ToDateTime(pieces[2]);
            summary = pieces[3];
            meta_score = Convert.ToInt32(pieces[4]);
            user_review = pieces[5];


        }

        public override string ToString()
        {
            return $"{name} - {platform}";
        }

    }
}
