using System;
using System.Collections.Generic;
using System.Linq;

namespace Heroes
{
    public class HeroRepository
    {
        private List<Hero> data;

        public HeroRepository()
        {
            this.data = new List<Hero>();
        }

        public int Count
        {
            get => this.data.Count;
        }

        public void Add(Hero hero)
        {
            this.data.Add(hero);
        }

        public void Remove(string name)
        {
            Hero hero = this.data.FirstOrDefault(x => x.Name == name);

            this.data.Remove(hero);
        }

        public Hero GetHeroWithHighestStrength()
        {
            Hero hero = this.data[0];

            for (int i = 1; i < this.data.Count; i++)
            {
                if (hero.Item.Strength < this.data[i].Item.Strength)
                {
                    hero = this.data[i];
                }
            }

            return hero;
        }

        public Hero GetHeroWithHighestAbility()
        {
            Hero hero = this.data[0];

            for (int i = 1; i < this.data.Count; i++)
            {
                if (hero.Item.Ability < this.data[i].Item.Ability)
                {
                    hero = this.data[i];
                }
            }

            return hero;
        }

        public Hero GetHeroWithHighestIntelligence()
        {
            Hero hero = this.data[0];

            for (int i = 1; i < this.data.Count; i++)
            {
                if (hero.Item.Intelligence < this.data[i].Item.Intelligence)
                {
                    hero = this.data[i];
                }
            }

            return hero;
        }

        public override string ToString()
        {
            return string.Join("", this.data);
        }
    }
}
