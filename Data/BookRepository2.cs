using MVCFormPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFormPractice.Data
{
    public class BookRepository2
    {

        public List<Book> GetEntries()
        {
            return Data.Books
                .Join(
                    Data.Genres, // The inner collection
                    e => e.GenreId, // The outer selector
                    a => a.Id,  // The inner selector
                    (e, a) =>  // The result selector
                    {
                        e.Genre = a; // Set the entry's Genre property
                        return e; // Return the entry
                    }
                    )
                .ToList();
        }

        public Book GetBook(int id) 
        { 
            Book book = Data.Books
                .Where(e => e.Id == id)
                .SingleOrDefault();

            return book;
        }
        public void AddEntry(Book book)
        {
            // Get the next available entry ID.
            int nextAvailableEntryId = Data.Books
                .Max(e => e.Id) + 1;

            book.Id = nextAvailableEntryId;

            Data.Books.Add(book);
        }

        public void UpdateEntry(Book entry)
        {
            // Find the index of the entry that we need to update.
            int entryIndex = Data.Books.FindIndex(e => e.Id == entry.Id);

            if (entryIndex == -1)
            {
                throw new Exception(
                    string.Format("Unable to find an entry with an ID of {0}", entry.Id));
            }

            Data.Books[entryIndex] = entry;
        }

        public void DeleteEntry(int id)
        {
            // Find the index of the entry that we need to delete.
            int entryIndex = Data.Books.FindIndex(e => e.Id == id);

            if (entryIndex == -1)
            {
                throw new Exception(
                    string.Format("Unable to find an entry with an ID of {0}", id));
            }

            Data.Books.RemoveAt(entryIndex);
        }



        public List<Cart> GetCarts()
        {
            return Data.Carts.ToList();
        }

        public void AddCart(Cart cart)
        {
            // Get the next available entry ID.
            //int nextAvailableEntryId = Data.Books
            //    .Max(e => e.Id) + 1;

            //book.Id = nextAvailableEntryId;

            Data.Carts.Add(cart);
        }

        public void DeleteFromCart(int id)
        {
            // Find the index of the entry that we need to delete.
            int entryIndex = Data.Carts.FindIndex(e => e.Id == id);

            if (entryIndex == -1)
            {
                throw new Exception(
                    string.Format("Unable to find an entry with an ID of {0}", id));
            }

            Data.Carts.RemoveAt(entryIndex);
        }





    }
}