namespace P08_Military_Elite.Contracts.Privates.SpecialisedSoldiers
{
    using System.Collections.Generic;
    using Model.Privates.SpecialisedSoldiers;

    public interface ICommando
    {
        ICollection<Mission> Missions { get; }

        void CompleteMission(string codeName);
    }
}