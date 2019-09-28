namespace P08_Military_Elite.Contracts.Privates
{
    using System.Collections.Generic;
    using Model;

    public interface ILieutenantGeneral
    {
        ICollection<Private> Privates { get; }
    }
}