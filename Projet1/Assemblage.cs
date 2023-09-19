using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Projet1
{
    class Assemblage : IComponent
    {
        public string m_nom { get; set; }
        public int m_qte { get; set; }
        public int m_nbMainDoeuvre { get; set; }
        public double m_prixMainDoeuvre { get; set; }
        public int m_nbHeureFabrication { get; set; }


        private readonly List<IComponent> _components = new();

        public Assemblage(string nom, int qte, IEnumerable<IComponent> components)
        {
            m_nom = nom;
            m_qte = qte;
            _components.AddRange(components);
        }
        public Assemblage(string nom, int qte, int nbMainDoeuvre, double prixMainDoeuvre, int nbHeureFabrication, IEnumerable<IComponent> components)
        {
            m_nom = nom;
            m_qte = qte;
            m_nbMainDoeuvre = nbMainDoeuvre;
            m_prixMainDoeuvre = prixMainDoeuvre;
            m_nbHeureFabrication = nbHeureFabrication;
            _components.AddRange(components);
        }

        public double GetCout() => _components.Sum(component => component.GetCout() + m_nbMainDoeuvre * (m_prixMainDoeuvre * m_nbHeureFabrication));

    }
}
