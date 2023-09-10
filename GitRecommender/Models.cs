using System;
using SQLite;
namespace GitRecommender
{
    [Table("Users")]
    public class User
    {
        [PrimaryKey, AutoIncrement]
        [Column("id")]
        public int Id { get; set; }

        [Column("username")]
        public string Username { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("star_count")]
        public int StarCount { get; set; }

    }

    [Table("Repositories")]
    public class Repository
    {
        [PrimaryKey, AutoIncrement]
        [Column("id")]
        public int Id { get; set; }

        //sqlite net is at github.com/praeclarum/sqlite-net

        // 'praeclarum' for sqlite-net
        [Column("owner")]
        public string Owner { get; set; }

        // 'sqlite-net' for instance 
        [Column("name")]
        public string Name { get; set; }


        [Column("description")]
        public string Description { get; set; }


    }

    [Table("Stars")]
    public class Star
    {
        [PrimaryKey, AutoIncrement]
        [Column("id")]
        public int Id { get; set; }

        [Column("user_id")]
        public int UserId { get; set; }

        [Column("repo_id")]
        public int RepoId { get; set; }

        [Column("starred")]
        public bool Starred { get; set; }

    }



    [Table("Actions")]
    public class Action
    {
        [PrimaryKey, AutoIncrement]
        [Column("id")]
        public int Id { get; set; }

        [Column("stargazer_id")]
        public int StargazerId { get; set; }

        [Column("complete")]
        public bool Complete { get; set; }

    }

    [Table("Recommendations")]
    public class Recommendation
    {
        [PrimaryKey, AutoIncrement]
        [Column("id")]
        public int Id { get; set; }

        [Column("user_id")]
        public int UserId { get; set; }

        [Column("repo_id")]
        public int RepoId { get; set; }

        [Column("rating")]
        public int Rating { get; set; } 
    }



//	public class Models
//	{
//		public Models()
//		{
//		}
//	}
}

