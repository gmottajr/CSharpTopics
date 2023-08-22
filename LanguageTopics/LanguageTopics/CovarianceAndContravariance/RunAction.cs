using LanguageTopics.CovarianceAndContravariance.Abstraction.Contracts;

namespace LanguageTopics.CovarianceAndContravariance
{
    public class RunAction : IAnimalReaction
    {
        public RunAction(DateTime startingAt, IAnimal<Animal> agent, int speed = 200)
        {
            StartingAt = startingAt;
            Speed = speed;
            Agent = agent;
        }

        public DateTime StartingAt { get; set ; }
        public int Speed { get ; set; }
        public IAnimal<Animal> Agent { get; set ; }
    }
}