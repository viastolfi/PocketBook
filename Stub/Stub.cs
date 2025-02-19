﻿using System;
using Model;

namespace Stub
{ 
	public class PocketBookStub : ILibManager
	{
		public List<Book> Books = new List<Book>
			{
				new Book("1", "Le temps des Tempêtes"),
				new Book("2", "Promenades")
			};

		public List<Author> Authors = new List<Author>();

		public PocketBookStub()
		{
			Author a = new Author("Nicolas Sarcozy");
			a.WritedBooks = Books;
			Authors.Add(a);
		}

        public List<Author> GetAuthors()
        {
            return Authors;
        }

        public Book GetBookById(string id)
        {
            return Books.Find((b) => b.Id == id);
        }

        public List<Book> GetBooks()
        {
            return Books;
        }
    }
}

