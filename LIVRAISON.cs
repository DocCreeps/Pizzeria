//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pizzeria
{
    using System;
    using System.Collections.Generic;
    
    public partial class LIVRAISON
    {
        public int NumLivraison { get; set; }
        public int NumBonLiv { get; set; }
        public Nullable<System.DateTime> DateDepart { get; set; }
        public Nullable<System.DateTime> DateArrivee { get; set; }
        public int NumAdresse { get; set; }
    
        public virtual ADRESSE ADRESSE { get; set; }
        public virtual BON_LIV BON_LIV { get; set; }
    }
}
