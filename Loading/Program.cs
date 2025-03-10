using Loading;
using Microsoft.EntityFrameworkCore;
Console.WriteLine("Select\n1 - Category\n2 - Author\n3 - Theme");

var choice = Console.ReadLine();

switch (choice)
{
    case "1":
        using (var db = new LibraryContext())
        {
            var categories = db.Categories
                               .Include(c => c.Books)
                               .ToList();

            foreach (var category in categories)
            {
                Console.WriteLine($"{category.Id} Category: {category.Name}");

            }
            var select = Console.ReadLine();
            int.TryParse(select, out int SelectId);
            var selectedCategory = categories.FirstOrDefault(c => c.Id == SelectId);
            foreach (var book in selectedCategory.Books)
            {
                Console.WriteLine(book.Name);
            }
        }


        break;

    case "2":
        using (var db = new LibraryContext())
        {
            var Author = db.Authors
                               .Include(c => c.Books)
                               .ToList();

            foreach (var A in Author)
            {
                Console.WriteLine($"{A.Id} Author: {A.FirstName}");

            }
            var select = Console.ReadLine();
            int.TryParse(select, out int SelectId);
            var selectedCategory = Author.FirstOrDefault(c => c.Id == SelectId);
            foreach (var book in selectedCategory.Books)
            {
                Console.WriteLine(book.Name);
            }
        }
        break;
    case "3":

        using (var db = new LibraryContext())
        {
            var theme = db.Themes
                               .Include(c => c.Books)
                               .ToList();

            foreach (var T in theme)
            {
                Console.WriteLine($"{T.Id} Themes: {T.Name}");

            }
            var select = Console.ReadLine();
            int.TryParse(select, out int SelectId);
            var selectedCategory = theme.FirstOrDefault(c => c.Id == SelectId);
            foreach (var book in selectedCategory.Books)
            {
                Console.WriteLine(book.Name);
            }
            break;
        }
}

