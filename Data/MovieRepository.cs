using System.Data.Common;
using System.Collections.Generic;
using System.Linq;
using MovieApp.Models;

namespace MovieApp.Data
{
    public static class MovieRepository
    {
        private static List<Movie> _movies = null;

        static MovieRepository()
        {
            _movies = new List<Movie>()
            {
                new Movie() 
                {
                    Id=1, 
                    Name="Shazam", 
                    ShortDescription="Shazam", 
                    Description="<p>In Philadelphia, Billy Batson is an abandoned child who is proving a nuisance to Child Services and the authorities with his stubborn search for his lost mother. However, in his latest foster home, Billy makes a new friend, Freddy, and finds himself selected by the Wizard Shazam to be his new champion. Now endowed with the ability to instantly become an adult superhero by speaking the wizard's name, Billy gleefully explores his new powers with Freddy. However, Billy soon learns that he has a deadly enemy, Dr. Thaddeus Sivana, who was previously rejected by the wizard and has accepted the power of the Seven Deadly Sins instead. Now pursued by this mad scientist for his own power as well, Billy must face up to the responsibilities of his calling while learning the power of a special magic with his true family that Sivana can never understand</p>", 
                    ImageUrl="1.jpg",
                    CategoryId=1},
                new Movie() 
                {
                    Id=2, 
                    Name="Amazing Grace", 
                    ShortDescription="Amazing Grace", 
                    Description="<p>In Philadelphia, Billy Batson is an abandoned child who is proving a nuisance to Child Services and the authorities with his stubborn search for his lost mother. However, in his latest foster home, Billy makes a new friend, Freddy, and finds himself selected by the Wizard Shazam to be his new champion. Now endowed with the ability to instantly become an adult superhero by speaking the wizard's name, Billy gleefully explores his new powers with Freddy. However, Billy soon learns that he has a deadly enemy, Dr. Thaddeus Sivana, who was previously rejected by the wizard and has accepted the power of the Seven Deadly Sins instead. Now pursued by this mad scientist for his own power as well, Billy must face up to the responsibilities of his calling while learning the power of a special magic with his true family that Sivana can never understand</p>", 
                    ImageUrl="2.jpg",
                    CategoryId=2
                },
                new Movie() 
                {
                    Id=3, 
                    Name="High Life", 
                    ShortDescription="High Life", 
                    Description="<p>In Philadelphia, Billy Batson is an abandoned child who is proving a nuisance to Child Services and the authorities with his stubborn search for his lost mother. However, in his latest foster home, Billy makes a new friend, Freddy, and finds himself selected by the Wizard Shazam to be his new champion. Now endowed with the ability to instantly become an adult superhero by speaking the wizard's name, Billy gleefully explores his new powers with Freddy. However, Billy soon learns that he has a deadly enemy, Dr. Thaddeus Sivana, who was previously rejected by the wizard and has accepted the power of the Seven Deadly Sins instead. Now pursued by this mad scientist for his own power as well, Billy must face up to the responsibilities of his calling while learning the power of a special magic with his true family that Sivana can never understand</p>", 
                    ImageUrl="3.jpg",
                    CategoryId=2
                },
                new Movie() 
                {
                    Id=4, 
                    Name="Billboard", 
                    ShortDescription="Billboard", 
                    Description="<p>In Philadelphia, Billy Batson is an abandoned child who is proving a nuisance to Child Services and the authorities with his stubborn search for his lost mother. However, in his latest foster home, Billy makes a new friend, Freddy, and finds himself selected by the Wizard Shazam to be his new champion. Now endowed with the ability to instantly become an adult superhero by speaking the wizard's name, Billy gleefully explores his new powers with Freddy. However, Billy soon learns that he has a deadly enemy, Dr. Thaddeus Sivana, who was previously rejected by the wizard and has accepted the power of the Seven Deadly Sins instead. Now pursued by this mad scientist for his own power as well, Billy must face up to the responsibilities of his calling while learning the power of a special magic with his true family that Sivana can never understand</p>", 
                    ImageUrl="4.jpg",
                    CategoryId=3
                },
                new Movie() 
                {
                    Id=5, 
                    Name="Storm Boy", 
                    ShortDescription="Storm Boy", 
                    Description="<p>In Philadelphia, Billy Batson is an abandoned child who is proving a nuisance to Child Services and the authorities with his stubborn search for his lost mother. However, in his latest foster home, Billy makes a new friend, Freddy, and finds himself selected by the Wizard Shazam to be his new champion. Now endowed with the ability to instantly become an adult superhero by speaking the wizard's name, Billy gleefully explores his new powers with Freddy. However, Billy soon learns that he has a deadly enemy, Dr. Thaddeus Sivana, who was previously rejected by the wizard and has accepted the power of the Seven Deadly Sins instead. Now pursued by this mad scientist for his own power as well, Billy must face up to the responsibilities of his calling while learning the power of a special magic with his true family that Sivana can never understand</p>", 
                    ImageUrl="5.jpg",
                    CategoryId=3
                }
            };
        }

        public static List<Movie> Movies
        {
            get 
            {
                return _movies;
            }
        }

        public static void AddMovie(Movie entity)
        {
            _movies.Add(entity);
        }

        public static Movie GetById(int id)
        {
            return _movies.FirstOrDefault(i => i.Id==id);
        }
    }

    
}