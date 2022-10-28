using HttpGateway.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HttpGateway.Data
{
	public class Repository
	{
		private IEnumerable<Author> _authors { get; set; }

		public Repository()
		{
			_authors = new[]
			{
				new Author
				{
					AuthorId = 1,
					Name = "John Doe"
				},
				new Author
				{
					AuthorId = 2,
					Name = "Jane Smith"
				},
                new Author
                {
                    AuthorId = 3,
                    Name = "Jerry Idol"
                }
            };
		}

		public IEnumerable<Author> GetAuthors() => _authors;
	}
}
