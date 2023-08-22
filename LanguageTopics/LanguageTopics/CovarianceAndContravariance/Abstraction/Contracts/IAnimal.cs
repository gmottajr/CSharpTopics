using LanguageTopics.CovarianceAndContravariance.Abstraction.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageTopics.CovarianceAndContravariance.Abstraction.Contracts
{
    public interface IAnimal<T> where T : Being
    {
        string MakeSound();
        IAnimalReaction ReactsDefensively(T being);
        Type WhoAmI();

        string Sound { get; set; }

    }
}
