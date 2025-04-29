using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EVP
{
    public class userdata
    {
        public string Name { get; set; } // User's name
        public string ProfilePicture { get; set; } // Path to the profile picture
        public string FavoriteTrainClass { get; set; } // User's favorite train class
        public string CreateDate { get; set; }
    }
}
