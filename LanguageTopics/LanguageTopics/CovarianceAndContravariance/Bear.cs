using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageTopics.CovarianceAndContravariance
{
    public class Bear : Animal
    {
        public Bear(int lifeTimeExpectation, string domain, string kingdom, string phylum, string @class, string order, string family, string genus, string species, string sound) : base(lifeTimeExpectation, domain, kingdom, phylum, @class, order, family, genus, species, sound)
        {
        }
    }
}
