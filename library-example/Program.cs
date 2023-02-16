// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Book book = new Book("Dune", "9781111111", 2345612);

book.Display();
book.CheckOut();
book.Display();
book.CheckIn();
book.Display();
book.ShowBookDetails();

DVD dvd = new DVD("Star Wars", "George Lucas"); 

// Magazine mag = new Magazine(1,"Avengers");