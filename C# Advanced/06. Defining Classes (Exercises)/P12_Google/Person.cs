namespace P12_Google
{
    using System.Collections.Generic;

    class Person
    {
        public Person(Pokemon pokemon)
        {
            if (this.Pokemons.Count > 0)
            {
                this.Pokemons.Add(pokemon);
            }
            else
            {
                this.Pokemons.Add(pokemon);
            }
        }

        public Person(Children children)
        {
            if (this.Childrens.Count > 0)
            {
                this.Childrens.Add(children);
            }
            else
            {
                this.Childrens.Add(children);
            }

        }

        public Person(Parent parent) 
        {
            if (this.Parents.Count > 0)
            {
                this.Parents.Add(parent);
            }
            else
            {
                this.Parents.Add(parent);
            }
        }

        public Person(Car car)
        {
            this.Car = car;
        }

        public Person(Company company)
        {
            this.Company = company;
        }

        public Person()
        {
            
        }
        
        public Car Car { get; set; }

        public List<Children> Childrens { get; set; } = new List<Children>();

        public Company Company { get; set; }

        public List<Parent> Parents { get; set; } = new List<Parent>();

        public List<Pokemon> Pokemons { get; set; } = new List<Pokemon>();

        //public override string ToString()
        //{
        //    string carForPrint;
        //    string childrensForPrint;
        //    string companyForPrint;
        //    string parentsForPrint;
        //    string pokemonsForPrint;

        //    if (this.Car != null)
        //    {
        //        carForPrint = this.Car.ToString();
        //    }

        //    if (this.Childrens != null)
        //    {
        //        childrensForPrint = string.Join(" ", this.Childrens);
        //    }

        //    if (this.Company != null)
        //    {
        //        companyForPrint = this.Company.ToString();
        //    }
        //    else
        //    {
                
        //    }

        //    if (this.Parents != null)
        //    {
        //        parentsForPrint = this.Parents.ToString();
        //    }

        //    if (this.Pokemons != null)
        //    {
        //        pokemonsForPrint = this.Pokemons.ToString();
        //    }

        //    return $"{companyForPrint} {}";
        //}
    }
}
