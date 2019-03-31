using MbmStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Infrastructure
{
    public class Repository
    {
        //properties
        public static List<Product> Products = new List<Product>();
        public static List<Invoice> Invoices = new List<Invoice>();
        public static List<Customer> Customers = new List<Customer>();

        //constructors
        static Repository()
        {
            // movies
            Movie jungleBook = new Movie(1,"Jungle Book", 160.50m, "junglebook.jpg", "Elgars Logins",2000);
            Products.Add(jungleBook);
            Movie Movie2 = new Movie(2,"Die Hard", 160.50m, "die.png", "Roderick Thorp", 1988);
            Products.Add(Movie2);
            Movie Movie3 = new Movie(3,"The Wolf of Wall Street", 160.50m, "wolf.jpg", "Martin Scorsese", 2013);
            Products.Add(Movie3);
            Movie Movie4 = new Movie(4,"Rocky Balboa", 160.50m, "rocky.jpeg", "Sylvester Stallone", 2006);
            Products.Add(Movie4);
            Movie Movie5 = new Movie(5,"Creed II", 160.50m, "creed.jpg", "Steven Caple Jr.", 2018);
            Products.Add(Movie5);

            //books
            Book Book1 = new Book(6,"Paulo Coelho", "The Alchemist", 300m, 1988, "HarperTorch", "404", "alchemist.jpg");
            Products.Add(Book1);
            Book Book2 = new Book(7,"Dmitry Glukhovsky", "Metro 2030", 179m, 2016, "Saxo", "400", "saxo.jpg");
            Products.Add(Book2);
            Book Book3 = new Book(8,"Jesse Liberty", "Programming C# 3.0", 579m, 2002, "AbeBooks", "400", "cc.jpg");
            Products.Add(Book3);
            Book Book4 = new Book(9,"Douglas Crockford", "JavaScript: The Good Parts", 551m, 2008, "AbeBooks", "400", "js.png");
            Products.Add(Book4);

            //musicCDs
            MusicCD MusicCD1 = new MusicCD(10,"Nickelback", "Feed the Machine", 200m, 2017, "nickelback.jpg");
            MusicCD1.AddTrack(new Track("Coin for the Ferryman", "Nickelback", new TimeSpan(0, 4, 50)));
            MusicCD1.AddTrack(new Track("Song on Fire", "Nickelback", new TimeSpan(0, 3, 50)));
            MusicCD1.AddTrack(new Track("Must Be Nice", "Nickelback", new TimeSpan(0, 3, 42)));
            MusicCD1.AddTrack(new Track("After the rain", "Nickelback", new TimeSpan(0, 3, 35)));
            MusicCD1.AddTrack(new Track("For the River", "Nickelback", new TimeSpan(0, 3, 29)));
            MusicCD1.AddTrack(new Track("Home", "Nickelback", new TimeSpan(0, 3, 52)));
            Products.Add(MusicCD1);

            MusicCD MusicCD2 = new MusicCD(11,"21 Pilots", "Blurryface", 100m, 2015, "pilots.png");
            MusicCD2.AddTrack(new Track("HeavyDirtySoul", "21 pilots", new TimeSpan(0, 3, 55)));
            MusicCD2.AddTrack(new Track("Stressed Out", "21 Pilots", new TimeSpan(0, 3, 22)));
            MusicCD2.AddTrack(new Track("Ride", "21 Pilots", new TimeSpan(0, 3, 34)));
            MusicCD2.AddTrack(new Track("Fairly Local", "21 Pilots", new TimeSpan(0, 3, 27)));
            MusicCD2.AddTrack(new Track("Tear in My Heart", "21 Pilots", new TimeSpan(0, 3, 08)));
            MusicCD2.AddTrack(new Track("Lane Boy", "21 Pilots", new TimeSpan(0, 4, 13)));
            Products.Add(MusicCD2);

            //customers
            Customer Customer1 = new Customer(1,"Valerija", "Krastina", "Engtoften 6", "8260", "Viby J", new DateTime(1997, 5, 20));
            Customer1.AddPhoneNumber("50334779");
            Customer1.AddPhoneNumber("26533280");
            Customers.Add(Customer1);
            Customer Customer2 = new Customer(2,"Elgars", "Logins", "Engtoften 6", "8260", "Viby J", new DateTime(1994, 8, 3));
            Customer2.AddPhoneNumber("91945329");
            Customer2.AddPhoneNumber("53672132");
            Customers.Add(Customer2);

            //invoices
            Invoice Invoice1 = new Invoice(1, new DateTime(2019, 3, 8), Customer1);
            Invoice1.AddOrderItem(Movie2, 1);
            Invoice1.AddOrderItem(Book4, 1);
            Invoices.Add(Invoice1);
            Invoice Invoice2 = new Invoice(2, new DateTime(2019, 3, 6), Customer2);
            Invoice2.AddOrderItem(MusicCD2, 1);
            Invoice2.AddOrderItem(Book1, 1);
            Invoices.Add(Invoice2);

        }

    }
}