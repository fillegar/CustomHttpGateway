using HttpGateway.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HttpGateway.Data
{
	public class Repository
	{
		private IEnumerable<Book> _books { get; set; }

		public Repository()
		{
			_books = new[]
			{
				new Book
				{
					BookId = 1,
					AuthorId = 1,
					Name = "The Fallen Shore",
					NumberOfPages = 123
				},
				new Book
				{
					BookId = 2,
					AuthorId = 1,
					Name = "Harmony of Joy",
					NumberOfPages = 211
				},
				new Book
				{
					BookId = 3,
					AuthorId = 2,
					Name = "Aliens vs Robots",
					NumberOfPages = 345
				}
			};
		}

		public IEnumerable<Book> GetBooks() => _books;
	}
}
