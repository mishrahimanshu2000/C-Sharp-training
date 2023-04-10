﻿using SuperHeroAPI.Model;
using SuperHeroAPI.Services;

namespace SuperHeroAPI.Services
{

    public class SuperHeroService : ISuperHeroService
    {
        List<SuperHero> SuperHeroes { get; }
        static int nextId = 3;

        public SuperHeroService()
        {
            SuperHeroes = new List<SuperHero>
                {
                    new SuperHero
                    {
                        Id = 1,
                        Name = "Spider Man",
                        FirstName = "Peter",
                        LastName = "Parker",
                        Place = "New York City"
                    },
                    new SuperHero
                    {
                        Id = 2,
                        Name = "Iron Man",
                        FirstName = "Tony",
                        LastName = "Stark",
                        Place = "Long Island"
                    }
            };

        }

        public List<SuperHero> GetAll() => SuperHeroes;

        public SuperHero? Get(int id) => SuperHeroes.FirstOrDefault(s => s.Id == id);

        public void Add(SuperHero superHero)
        {
            superHero.Id = nextId++;
            SuperHeroes.Add(superHero);
        }

        public void Delete(int id)
        {
            var superhero = Get(id);
            if (superhero is null)
            {
                return;
            }
            SuperHeroes.Remove(superhero);
        }

        public void Update(SuperHero superHero)
        {
            var index = SuperHeroes.FindIndex(s => s.Id == superHero.Id);
            if (index == -1)
            {
                return;
            }
            SuperHeroes[index] = superHero;
        }
    }
}