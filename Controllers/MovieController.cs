using SharpRepository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using test_InMemory.Models;

namespace test_InMemory.Controllers
{
	[RoutePrefix("api/Movie")]
	public class MovieController : ApiController
	{
		IRepository<Movie, int> repo;

		public MovieController(IRepository<Movie,int> movie_repo)
		{
			repo = movie_repo;
		}

		[HttpGet]
		[Route("Get")]
		public IHttpActionResult Get()
		{
			return (Ok(repo.GetAll()));
		}

		[HttpGet]
		[Route("Seed")]
		public IHttpActionResult Seed()
		{
			repo.Add(new Movie { ID = 1, Title = "The Nightmare Before Christmas" });
			repo.Add(new Movie { ID = 2, Title = "A Clockwork Oragne" });
			repo.Add(new Movie { ID = 3, Title = "Angels with Dirty Faces" });

			return (Ok());
		}
	}
}

