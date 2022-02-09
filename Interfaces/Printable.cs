using System;
namespace Interfaces
{
    public interface Printable
    {
        void Print();
        int Status { get; } // read only
    }
}
