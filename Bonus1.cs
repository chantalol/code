using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus1
{
    public abstract class Bibliotheekvoorwerp
    {
        public string ObjectType { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        public Bibliotheekvoorwerp(string objectType, string title, string author)
        {
            ObjectType = objectType;
            Title = title;
            Author = author;
        }

        public abstract void GetInformation();
    }

    public class Boek : Bibliotheekvoorwerp
    {
        public string Genre { get; set; }

        public Boek(string objectType, string title, string author, string genre) : base(objectType, title, author)
        {
            Genre = genre;
        }
        public override void GetInformation()
        {
            Console.WriteLine($"ObjectType: {ObjectType}\nTitle: {Title}\nAuthor: {Author}");
        }
    }

    public interface Leenbaar
    {
        public void BorrowItem();
        public void ReturnItem();
    }

    public class Lid

    {
        public int LidID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public Lid(int lidID, string name, string email)
        {
            LidID = lidID;
            Name = name;
            Email = email;
        }

        public void BorrowItem(Bibliotheekvoorwerp voorwerp)
        {
            if (voorwerp is Leenbaar leenbaarVoorwerp)
            {
                leenbaarVoorwerp.BorrowItem();
            }   
            else
            {
                Console.WriteLine($"{voorwerp.Title} is not borrowable");
            }
        }

        public void ReturnItem(Bibliotheekvoorwerp voorwerp)
        {
            if (voorwerp is Leenbaar leenbaarVoorwerp)
            {
                leenbaarVoorwerp.ReturnItem();
            }
            else
            {
                Console.WriteLine($"{voorwerp.Title} is not returnable");
            }
        }
    }

    public class Leenbaarboek : Boek, Leenbaar
    {
        public bool Uitgeleend { get; set; }
        public Leenbaarboek(string objectType, string title, string author, string genre, bool uitgeleend) : base(objectType, title, author, genre)
        {
            Uitgeleend = uitgeleend;
        }
        public void BorrowItem()
        {
            if (!Uitgeleend)
            {
                Uitgeleend = true;
                Console.WriteLine($"{Title} is succesvol geleend ");
            }
            else
            {
                Console.WriteLine($"{Title} is al uitgeleend en kan niet worden geleend");
            }
        }

        public void ReturnItem()
        {
            if (Uitgeleend)
            {
                Uitgeleend = false;
                Console.WriteLine($"{Title} is succesvol terug gebracht");
            }
            else
            {
                Console.WriteLine($"{Title} is niet uitgeleend, kan niet worden terug gebracht");
            }
        }
    }
}







