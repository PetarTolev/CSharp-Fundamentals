namespace P08_Military_Elite.Contracts.Privates.SpecialisedSoldiers
{
    using System.Collections.Generic;
    using Model.Privates.SpecialisedSoldiers;

    public interface IEngineer
    {
        ICollection<Repair> Repairs { get; }
    }
}