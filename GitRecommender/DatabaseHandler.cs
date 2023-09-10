using System;
using SQLite; 
namespace GitRecommender
{
	public class DatabaseHandler
	{

		private SQLiteConnection _db;

		public DatabaseHandler()
		{
			_db = new SQLiteConnection("sqlite.db");
			_db.CreateTable<User>();
			_db.CreateTable<Repository>();
			_db.CreateTable<Star>();
			_db.CreateTable<Action>();
		}

		public void AddUser(string username, string description, int star_count)
		{
			var user = new User
			{
				Username = username,
				Description = description,
				StarCount = star_count
			};

			_db.Insert(user);
		}

		public void AddRepo(string owner, string name, string description)
		{
			var repo = new Repository
			{
				Owner = owner,
				Name = name,
				Description = description
			};

			_db.Insert(repo);
		}

		public void AddStar(int user_id, int repo_id, bool starred)
		{
			var star = new Star
			{
				UserId = user_id,
				RepoId = repo_id,
				Starred = starred
			};

			_db.Insert(star);
		}
	}
}

