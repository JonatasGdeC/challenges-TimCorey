using ForeachChallenge;

namespace ConsoleUI
{
    class Program {
        static void Main(string[] args) { 
        
            List<string> people = GetPeopleStrings();
            
            foreach (string person in people)
            {
                Console.WriteLine("Hello " + person);
            }

            Console.ReadLine();

            List <PersonModel> completeName = GetPersonModels();

            foreach (PersonModel name in completeName) {
                Console.WriteLine("Good morning " + name.FirstName+ " " + name.LastName);
            }

            Console.ReadLine();
        }

        private static List<string> GetPeopleStrings() { 
            List<string> namePeople = new List<string>();

            namePeople.Add("People 1");
            namePeople.Add("People 2");
            namePeople.Add("People 3");
            namePeople.Add("People 4");
            namePeople.Add("People 5");

            return namePeople;
        }

        private static List<PersonModel> GetPersonModels()
        {
            List<PersonModel> completeName = new List<PersonModel>();

            completeName.Add(new PersonModel { FirstName = "First Name1", LastName = "Last Name1" });
            completeName.Add(new PersonModel { FirstName = "First Name2", LastName = "Last Name2" });
            completeName.Add(new PersonModel { FirstName = "First Name3", LastName = "Last Name3" });
            completeName.Add(new PersonModel { FirstName = "First Name4", LastName = "Last Name4" });


            return completeName;
        }
    } 
}
