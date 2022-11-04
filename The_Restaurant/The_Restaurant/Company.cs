using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Restaurant
{
    internal class Company
    {
        public int NumberOfCompanies { get; set; } = 32;

        Guest guest = new Guest();


        public List<Guest> RandomizeCompany()
        {
            Random rnd = new Random();
            int rndNr = rnd.Next(1, 5);

            List<Guest> guestsToCompany = new List<Guest>();
            for (int i = 0; i < rndNr; i++)
            {
                guestsToCompany.Add(new Guest());
            }
            return guestsToCompany;
        }
        public static string LastName()
        {
            string[] lastnames =
            {
                "Andersson",
                "Johansson",
                "Karlsson",
                "Nilsson",
                "Eriksson",
                "Larsson",
                "Olsson",
                "Persson",
                "Svensson",
                "Gustafsson",
                "Pettersson",
                "Jonsson",
                "Jansson",
                "Hansson",
                "Bengtsson",
                "Jönsson",
                "Lindberg",
                "Jakobsson",
                "Magnusson",
                "Olofsson",
                "Lindström",
                "Lindqvist",
                "Lindgren",
                "Axelsson",
                "Berg",
                "Bergström",
                "Lundberg",
                "Lind",
                "Lundgren",
                "Lundqvist",
                "Mattsson",
                "Berglund",
                "Fredriksson",
                "Sandberg",
                "Henriksson",
                "Forsberg",
                "Sjöberg",
                "Wallin",
                "Ali",
                "Engström",
                "Mohamed",
                "Eklund",
                "Danielsson",
                "Lundin",
                "Håkansson",
                "Björk",
                "Bergman",
                "Gunnarsson",
                "Holm",
                "Wikström",
                "Samuelsson",
                "Isaksson",
                "Fransson",
                "Bergqvist",
                "Nyström",
                "Holmberg",
                "Arvidsson",
                "Löfgren",
                "Söderberg",
                "Nyberg",
                "Blomqvist",
                "Claesson",
                "Nordström",
                "Mårtensson",
                "Lundström",
                "Ahmed",
                "Viklund",
                "Björklund",
                "Eliasson",
                "Pålsson",
                "Hassan",
                "Berggren",
                "Sandström",
                "Lund",
                "Nordin",
                "Ström",
                "Åberg",
                "Hermansson",
                "Ekström",
                "Falk",
                "Holmgren",
                "Dahlberg",
                "Hellström",
                "Hedlund",
                "Sundberg",
                "Sjögren",
                "Ek",
                "Blom",
                "Abrahamsson",
                "Martinsson",
                "Öberg",
                "Andreasson",
                "Strömberg",
                "Månsson",
                "Åkesson",
                "Hansen",
                "Norberg",
                "Lindholm",
                "Dahl",
                "Jonasson"
            };
            Random rnd = new Random();
            int index = rnd.Next(0, lastnames.Length - 1);

            return lastnames[index];
        }
    }
}
