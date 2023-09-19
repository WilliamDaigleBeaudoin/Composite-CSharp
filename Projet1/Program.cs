using System;
using System.Collections.Generic;

namespace Projet1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Pièce
            Assemblage salon = new Assemblage(
                "Salon",
                2,
                10,
                20.18,
                29,
                new List<IComponent> {
                    new Materiel("Bois",843,2.69),
                    new Materiel("DryWall",56,51.10),
                    new Materiel("Peinture",600,5.80)

                }
            );
            Assemblage cuisine = new Assemblage(
                "Cuisine",
                1,
                6,
                20.18,
                18,
                new List<IComponent> {
                    new Materiel("Bois",54,2.69),
                    new Materiel("DryWall",10,51.10),
                    new Materiel("Peinture",150,5.65)
                }
            );
            Assemblage chambre = new Assemblage(
                "Chambre",
                4,
                4,
                20.18,
                20,
                new List<IComponent> {
                    new Materiel("Bois",254,2.69),
                    new Materiel("DryWall",100,51.10),
                    new Materiel("Peinture",800,5.66)
                }
            );
            Assemblage salleDeBain = new Assemblage(
                "Salle de Bain",
                12,
                6,
                20.18,
                5,
                new List<IComponent> {
                    new Materiel("Bois",28,2.69),
                    new Materiel("DryWall",18,51.10),
                    new Materiel("Peinture",20,5.65)
                }
            );
            #endregion

            Assemblage maison = new Assemblage(
                "maison",
                1, 
                new List<IComponent> {
                salon,
                cuisine,
                chambre,
                salleDeBain
            }
        );

            Console.WriteLine("Le prix de la maison est de "+ maison.GetCout() + "$");
        }
    }
}
