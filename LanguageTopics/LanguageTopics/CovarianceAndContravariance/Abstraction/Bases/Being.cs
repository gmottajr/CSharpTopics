using LanguageTopics.CovarianceAndContravariance.Abstraction.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageTopics.CovarianceAndContravariance.Abstraction.Bases
{
    public abstract class Being : IBeing
    {
        protected Being(int lifeTimeExpectation, string domain, string kingdom, string phylum, string @class, string order, string family, string genus, string species)
        {
            LifeTimeExpectation = lifeTimeExpectation;
            Domain = domain;
            Kingdom = kingdom;
            Phylum = phylum;
            Class = @class;
            Order = order;
            Family = family;
            Genus = genus;
            Species = species;
        }

        public int LifeTimeExpectation { get; set ; }
        public string Domain { get; set; }
        public string Kingdom { get; set; }
        public string Phylum { get; set; }
        public string Class { get; set; }
        public string Order { get; set; }
        public string Family { get; set; }
        public string Genus { get; set; }
        public string Species { get; set; }


        public abstract void Eating(IFood food);

        public abstract string RespondToStimuli(string stimuli);
    }
}
