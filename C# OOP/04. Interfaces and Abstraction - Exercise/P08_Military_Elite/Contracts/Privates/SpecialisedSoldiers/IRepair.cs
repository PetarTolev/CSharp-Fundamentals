namespace P08_Military_Elite.Contracts.Privates.SpecialisedSoldiers
{
    public interface IRepair
    {
        string PartName { get; }

        int HoursWorked { get; }
    }
}