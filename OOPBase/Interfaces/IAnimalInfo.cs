using System;
using System.Collections.Generic;
using System.Text;

namespace OOPBase.Interfaces
{
    public interface IAnimalInfo
    {
        string Description { get; }
        void PrintDescription();
    }
}