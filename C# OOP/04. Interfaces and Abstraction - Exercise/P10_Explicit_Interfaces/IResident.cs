﻿namespace P10_Explicit_Interfaces
{
    public interface IResident
    {
        string Name { get; }
        
        string Country { get; }

        string GetName();
    }
}