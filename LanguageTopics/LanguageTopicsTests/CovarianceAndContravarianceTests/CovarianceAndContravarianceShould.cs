using FluentAssertions;
using LanguageTopics.CovarianceAndContravariance;
using LanguageTopics.CovarianceAndContravariance.Abstraction.Bases;
using LanguageTopics.CovarianceAndContravariance.Abstraction.Contracts;

namespace LanguageTopicsTests.CovarianceAndContravarianceTests
{
    public class CovarianceAndContravarianceShould
    {

        public static IEnumerable<object[]> AnimalTestData()
        {
            yield return new object[]
            {
            new Bird(
                lifeTimeExpectation: 5,
                domain: "Eukarya",
                kingdom: "Animalia",
                phylum: "Chordata",
                @class: "Aves",
                order: "Passeriformes",
                family: "Turdidae",
                genus: "Turdus",
                species: "Merula",
                sound: "Chirp"
            ),
            typeof(Bird),
            "Chirp"
            };

            yield return new object[]
            {
            new Bear(
                lifeTimeExpectation: 20,
                domain: "Eukarya",
                kingdom: "Animalia",
                phylum: "Chordata",
                @class: "Mammalia",
                order: "Carnivora",
                family: "Ursidae",
                genus: "Ursus",
                species: "Arctos",
                sound: "Roar"
            ),
            typeof(Bear),
            "Roar"
            };

            yield return new object[]
            {
            new Dog(
                lifeTimeExpectation: 12,
                domain: "Eukarya",
                kingdom: "Animalia",
                phylum: "Chordata",
                @class: "Mammalia",
                order: "Carnivora",
                family: "Canidae",
                genus: "Canis",
                species: "Lupus",
                sound: "Bark"
            ),
            typeof(Dog),
            "Bark"
            };

            yield return new object[]
            {
                new Cat(
                    lifeTimeExpectation: 15,
                    domain: "Eukarya",
                    kingdom: "Animalia",
                    phylum: "Chordata",
                    @class: "Mammalia",
                    order: "Carnivora",
                    family: "Felidae",
                    genus: "Felis",
                    species: "Catus",
                    sound: "Meow"
                ),
            typeof(Cat),
            "Meow"
            };
        }

        [Theory]
        [MemberData(nameof(AnimalTestData))]
        public void PerformCovariance(Being being, Type expectedType, string expectedSound)
        {
            being.Should().BeOfType(expectedType);
            ((Animal)being).WhoAmI().Name.Should().Be(expectedType.Name);
            ((Animal)being).MakeSound().Should().Be($"This is my sound: {expectedSound}");
        }

        [Theory]
        [MemberData(nameof(AnimalTestData))]
        public void TestCovarianceAsBaseTypeAnimal(Animal animal, Type expectedType, string expectedSound)
        {
            animal.Should().BeOfType(expectedType);
            animal.WhoAmI().Name.Should().Be(expectedType.Name);
            animal.MakeSound().Should().Be($"This is my sound: {expectedSound}");
        }

        [Theory]
        [MemberData(nameof(AnimalTestData))]
        public void PerformContravariance(IAnimal<Being> animal, Type animalType, string expectedSound)
        {
            Action<IAnimal<Being>> animalAction = (target) =>
            {
                StringWriter stringWriter = new StringWriter();
                Console.SetOut(stringWriter); // Redirect console output

                Console.WriteLine(target.MakeSound());
                Console.WriteLine("I'm: {0}", target.WhoAmI().GetType());

                string output = stringWriter.ToString(); // Capture console output
                Console.SetOut(Console.Out); // Restore original console output

                // Assertions based on captured output
                output.Should().Contain(target.MakeSound());
                output.Should().Contain($"I'm: {target.WhoAmI().GetType()}");
            };

            Action<Cat> catAction = animalAction; // Contravariance
            Action<Dog> dogAction = animalAction; // Contravariance
            Action<Bear> bearAction = animalAction; // Contravariance
            Action<Bird> birdAction = animalAction; // Contravariance

            if (animalType.Name == "Cat")
            {
                catAction((Cat)animal);
            }

            if (animalType.Name == "Dog")
            {
                dogAction((Dog)animal);
            }

            if (animalType.Name == "Bear")
            {
                bearAction((Bear)animal);
            }

            if (animalType.Name == "Bird")
            {
                birdAction((Bird)animal);
            }
        }


    }

}
