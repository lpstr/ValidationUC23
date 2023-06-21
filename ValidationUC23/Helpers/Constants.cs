using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationUC23.Helpers
{
    public static class Constants
    {

        public static string FileDir = "~/test.csv";


        //Added empty string in lists for invalid data testing

        public static string[] Characters = new string[] { "Actor", "Actress" };

        public static string[] Roles = new string[]
        {
            "Director",
            "Producer",
            "Screenwriter",
            "Actor",
            "Actress",
            "Cinematographer",
            "Film Editor",
            "Production Designer",
            "Costume Designer",
            "Music Composer",
            string.Empty
        };

        public static string[] AgeCertification = new string[]
        {
            "G",
            "PG",
            "PG-13",
            "R",
            "NC-17",
            "U",
            "U/A",
            "A",
            "S",
            "AL",
            "6",
            "9",
            "12",
            "12A",
            "15",
            "18",
            "18R",
            "R18",
            "R21",
            "M",
            "MA15+",
            "R16",
            "R18+",
            "X18",
            "T",
            "E",
            "E10+",
            "EC",
            "C",
            "CA",
            "GP",
            "M/PG",
            "TV-Y",
            "TV-Y7",
            "TV-G",
            "TV-PG",
            "TV-14",
            "TV-MA",
            string.Empty
        };

        public static string[] Genres = new string[]
        {
            "Action",
            "Adventure",
            "Animation",
            "Comedy",
            "Crime",
            "Documentary",
            "Drama",
            "Family",
            "Fantasy",
            "Historical",
            "Horror",
            "Musical",
            "Mystery",
            "Romance",
            "Science Fiction",
            "Thriller",
            "War",
            "Western",
            "Biography",
            "Sports",
            "Supernatural",
            "Suspense",
            "Film Noir",
            "Disaster",
            "Martial Arts",
            "Spy",
            "Music",
            "Psychological",
            "Coming of Age",
            "Satire",
            "Parody",
            "Anime",
            "Silent",
            "Experimental",
            "Educational",
            "Found Footage",
            "Road Trip",
            "Time Travel",
            "Zombie",
            "Crime Drama",
            "Cyberpunk",
            "Historical Drama",
            "Political Drama",
            "Romantic Comedy",
            "Superhero",
            "Techno Thriller",
            "Courtroom Drama",
            "Medical Drama",
            "Action Comedy",
            "Disaster Drama",
            string.Empty
        };

    }
}
