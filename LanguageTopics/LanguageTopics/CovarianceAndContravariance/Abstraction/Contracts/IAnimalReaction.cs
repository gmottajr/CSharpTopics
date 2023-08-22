namespace LanguageTopics.CovarianceAndContravariance.Abstraction.Contracts
{
    public interface IAnimalReaction
    {
        IAnimal<Animal> Agent { get; set; }
        DateTime StartingAt { get; set; }
        int Speed { get; set; } // milliseconds 
    }
}