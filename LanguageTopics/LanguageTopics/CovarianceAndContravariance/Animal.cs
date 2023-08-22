using LanguageTopics.CovarianceAndContravariance.Abstraction.Bases;
using LanguageTopics.CovarianceAndContravariance.Abstraction.Contracts;

namespace LanguageTopics.CovarianceAndContravariance
{
    public class Animal : Being, IAnimal<Being>
    {
        public Animal(int lifeTimeExpectation, string domain, string kingdom, string phylum, string @class, string order, string family, string genus, string species, string sound) : base(lifeTimeExpectation, domain, kingdom, phylum, @class, order, family, genus, species)
        {
            Sound = sound;
        }

        public string Sound { get; set ; }

        public override void Eating(IFood food)
        {
            ProcessFood(food);
        }

        protected virtual void ProcessFood(IFood food)
        {
            throw new NotImplementedException();
        }

        public virtual string MakeSound()
        {
            return $"This is my sound: {this.Sound}";
        }

        public virtual IAnimalReaction ReactsDefensively(Being being)
        {
            return new RunAction(DateTime.Now, (IAnimal<Animal>)this);
        }

        public override string RespondToStimuli(string stimuli)
        {
            throw new NotImplementedException();
        }

        public virtual Type WhoAmI()
        {
            return this.GetType();
        }
    }
}
