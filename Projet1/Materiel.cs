using System;
using System.Collections.Generic;
using System.Text;

namespace Projet1
{
    public class Materiel : IComponent
    {
        public string m_nom { get; set; }
        public int m_qte { get; set; }
        public double m_prixMat { get; set; }
        public Materiel(string nom, int qte, double prixMat)
        {
            m_nom = nom;
            m_qte = qte;
            m_prixMat = prixMat;
        }

        public double GetCout()
        {
            return m_qte * m_prixMat ;
        }
    }
}
