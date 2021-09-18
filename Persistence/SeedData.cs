using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
  public class SeedData
  {
    public static async Task Seed(DataContext context)
    {
      if (context.Books.Any()) return;

      var books = new List<Book>
      {
        new Book
        {
          Title = "Adventures of Tom Sawye",
          Author = "Mark Twain"
        },
        new Book
        {
          Title = "Alice in Wonderland",
          Author = "Lewis Carrol"
        },
        new Book
        {
          Title = "Agni Veena",
          Author = "Kazi Nasrul Islam"
        },
        new Book
        {
          Title = "Ben Hur",
          Author = "Lewis Wallace"
        },
        new Book
        {
          Title = "Pride and Prejudice",
          Author = "Jane Austen"
        },
        new Book
        {
          Title = "Le Contract Social",
          Author = "Jean Jacques Rousseau"
        },
        new Book
        {
          Title = "A Dangerous place",
          Author = "D.P. Moynihan"
        },
        new Book
        {
          Title = "The Decline and Fall of the Roman Empire",
          Author = "Edward Gibbon"
        },
        new Book
        {
          Title = "Adventures of Sherlock Holmes",
          Author = "Arthur Conan Doyle"
        },
        new Book
        {
          Title = "Divine Comedy",
          Author = "Dante"
        }
      };

      var loans = new List<Loan>
      {
        new Loan
        {
          User = "Tiago Barbosa",
          Borrowed = DateTime.Now.AddDays(-10),
          Returned = DateTime.Now.AddDays(10)
        },
        new Loan
        {
          User = "Barbara Silva",
          Borrowed = DateTime.Now.AddDays(-5),
          Returned = DateTime.Now.AddDays(15)
        },
        new Loan
        {
          User = "Maria Justina",
          Borrowed = DateTime.Now.AddDays(-45),
          Returned = DateTime.Now.AddDays(-5)
        },
        new Loan
        {
          User = "Just Bob",
          Borrowed = DateTime.Now.AddDays(-2),
          Returned = DateTime.Now.AddDays(25)
        },
        new Loan
        {
          User = "Thanos",
          Borrowed = DateTime.Now,
          Returned = DateTime.Now.AddDays(50)
        }
      };

      await context.Books.AddRangeAsync(books);
      await context.Loans.AddRangeAsync(loans);
      await context.SaveChangesAsync();
    }
  }
}