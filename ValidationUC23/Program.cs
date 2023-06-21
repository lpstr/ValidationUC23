// See https://aka.ms/new-console-template for more information
using Bogus;
using ValidationUC23;
using ValidationUC23.Helpers;
using ValidationUC23.Models;


Console.WriteLine("Begin generating data...");
///First list generation
///
var movieFaker = new Faker<Title>()
                //ID
                .RuleFor(m => m.Id, f => f.UniqueIndex)
                //Movie title name
                .RuleFor(m => m.MovieTitle, f => f.Commerce.ProductName())
                //Description 
                .RuleFor(m => m.Description, f => f.Lorem.Paragraph())
                //Common era format date
                .RuleFor(m => m.ReleaseYear, f => f.Random.Bool(0.1f) ? f.Random.Int(-5000, 5000) : f.Random.Int(1880, 2023))
                //Age ceritification list
                .RuleFor(m => m.AgeCertification, f => f.PickRandom(Constants.AgeCertification))
                //Movie length in minutes
                .RuleFor(m => m.Runtime, f => f.Random.Bool(0.1f) ? f.Random.Int(-1000, 1000) : f.Random.Int(40, 220))
                //Genres list
                .RuleFor(m => m.Genres, f => f.PickRandom(Constants.Genres))
                //Country ISO 3166-1 Alpha-3 code
                .RuleFor(m => m.ProductionCountry, f => f.Address.CountryCode())
                //Random season or null for movie
                .RuleFor(m => m.Seasons, f => f.Random.Bool(0.5f) ? f.Random.Int(-2, 10) : null);

var movies = movieFaker.Generate(10000);

/// Second list generation
///
var creditFaker = new Faker<Credit>()
    .RuleFor(c => c.Id, p => p.UniqueIndex)
    //Random movie title
    .RuleFor(c => c.TitleId, p => p.PickRandom(movies).Id)
    //Random full name
    .RuleFor(c => c.RealName, p => p.Name.FullName())
    //Random role
    .RuleFor(c => c.Role, p => p.PickRandom(Constants.Roles))
    //Character name, only if actress or actor (added random for incorrect and correct data)
    .RuleFor(c => c.CharacterName, (p, c) => !Constants.Characters.Contains(c.Role) && p.Random.Bool() ? string.Empty : p.Name.FirstName())
    ;

List<Credit> credits = creditFaker.Generate(100000);


Console.WriteLine("Data successfully generated.");

Console.WriteLine("Saving data into CSV file...");

//File saving directory (Change if needed)
string fileDir = Environment.CurrentDirectory;

//Write movies
Actions.SaveToFile(fileDir + "/movies.csv", movies);

//Write credits
Actions.SaveToFile(fileDir + "/credits.csv", credits);

Console.WriteLine("Files are successfully saved!");

