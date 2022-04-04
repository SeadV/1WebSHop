using MojWebShop;
List<Person> persons = new();
persons.Add(new Admin { _name="john",_surname="doe",_email="john@gmail.com",_password="john",_username="john"});
persons.Add(new Admin { _name="sead",_surname="seki",_email="sead@gmail.com",_password="sead",_username="seki"});
persons.Add(new User { _name="ana",_surname="muller",_email="ana@gmail.com",_password="ana", _username = "ana" });
persons.Add(new User { _name="tomy",_surname="hilfiger",_email="tomy@gmail.com",_password="tomy", _username = "tomy" });

Person? loggedIn = null;
do
{

Console.WriteLine("------------------------");
    if(loggedIn is not null)
    {
        Console.WriteLine($"---- Zdravo {loggedIn._name} ! ----");
    }
Console.WriteLine("1. Napravi novi nalog");
    if (loggedIn is null)
    {
        Console.WriteLine("2. Uloguj se");
    }
    else
    {
        Console.WriteLine("2. Izloguj se");
    }
Console.WriteLine("3. Izlistaj sve");
Console.WriteLine("4. Izadji");
Console.WriteLine("------------------------");
var unos = Console.ReadKey();

    switch (unos.Key)
    {
        case ConsoleKey.D1:
            Console.WriteLine("Ako zelite da napravite admina pritisnite A ,za korisnika K !");
            var unos2 = Console.ReadKey();

            switch (unos2.Key)
            {
                case ConsoleKey.A:
                    Admin admin = new();
                    Console.Write("Unesite ime: ");
                    admin._name = Console.ReadLine();
                    Console.Write("Unesite prezime: ");
                    admin._surname = Console.ReadLine();
                    Console.WriteLine("Unesite username");
                    admin._username = Console.ReadLine();
                    Console.Write("Unesite email: ");
                    admin._email = Console.ReadLine();
                    Console.Write("Unesite sifru: ");
                    admin._password = Console.ReadLine();
                    Console.Write("Unesite grad: ");
                    admin._address._city = Console.ReadLine();
                    Console.Write("Unesite postanski kod: ");
                    admin._address._poBox = Console.ReadLine();
                    Console.Write("Unesite adresu: ");
                    admin._address._address = Console.ReadLine();
                    Console.Write("Unesite broj adrese: ");
                    admin._address._streetNo = Console.ReadLine();
                    persons.Add(admin);
                    break;
                case ConsoleKey.K:
                    User user = new();
                    Console.Write("Unesite ime: ");
                    user._name = Console.ReadLine();
                    Console.Write("Unesite prezime: ");
                    user._surname = Console.ReadLine();
                    Console.WriteLine("Unesite username");
                    user._username = Console.ReadLine();
                    Console.Write("Unesite email: ");
                    user._email = Console.ReadLine();
                    Console.Write("Unesite sifru: ");
                    user._password = Console.ReadLine();
                    Console.Write("Unesite grad: ");
                    user._address._city = Console.ReadLine();
                    Console.Write("Unesite postanski kod: ");
                    user._address._poBox = Console.ReadLine();
                    Console.Write("Unesite adresu: ");
                    user._address._address = Console.ReadLine();
                    Console.Write("Unesite broj adrese: ");
                    user._address._streetNo = Console.ReadLine();
                    persons.Add(user);
                    break;
                default: Console.WriteLine("Pogresan unos,pokusaj ponovo");
                    break;
            }

            break;
        case ConsoleKey.D2:
            if (loggedIn is null)
            {
                Console.Write("Unesite username: ");
                string username = Console.ReadLine();
                Console.Write("Unesite sifru: ");
                string pass = Console.ReadLine();

                loggedIn = persons.Where(person => person._username == username && person._password == pass).FirstOrDefault();
                if (loggedIn is not null)
                {
                    Console.WriteLine("Ulogovan si");
                }
            }
            else
            {
                loggedIn = null;
                Console.WriteLine("Izlogovan si !");
            }

            break;
        case ConsoleKey.D3:
            Console.WriteLine("Izlistaces sve strpi se");
            foreach (Person p in persons)
            {
                Console.WriteLine($"Ime:{p._name} Prezime:{p._surname} email:{p._email}");
            }
            break;
        case ConsoleKey.D4:
            Console.WriteLine("Izadji na vrata");
            break;
        default: Console.WriteLine("Pogresan unos,pokusajte ponovo!");
            break;
    }
    
    if(unos.Key == ConsoleKey.D4)
    {
        break;
    }

} while (true);