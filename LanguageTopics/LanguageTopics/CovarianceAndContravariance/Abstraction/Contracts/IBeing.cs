namespace LanguageTopics.CovarianceAndContravariance.Abstraction.Contracts
{
    public interface IBeing
    {
        string RespondToStimuli(string stimuli);
        void Eating(IFood food);
        int LifeTimeExpectation { get; set; }
        string Domain { get; set; }
        string Kingdom { get; set; }
        string Phylum { get; set; }
        string Class { get; set; }
        string Order { get; set; }
        string Family { get; set; }
        string Genus { get; set; }
        string Species { get; set; }


    }
}
