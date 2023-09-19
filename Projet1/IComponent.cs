using System;
using System.Collections.Generic;
using System.Text;

namespace Projet1
{
    public interface IComponent
    {
        string m_nom { get; set; }
        int m_qte { get; set; }
        double GetCout();
    }
}
