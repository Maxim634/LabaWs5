class Program
{
    static void Main()
    {
        Dog dog = new Dog();
        dog.food = "мясо";
        dog.location = "дом";
        dog.breed = "Овчарка";

        Cat cat = new Cat();
        cat.food = "молоко";
        cat.location = "квартира";
        cat.livesLeft = 7;

        Horse horse = new Horse();
        horse.food = "трава";
        horse.location = "пастбище";
        horse.color = "рыжий";

        Veterinarian vet = new Veterinarian();
        vet.TreatAnimal(dog);
        vet.TreatAnimal(cat);
        vet.TreatAnimal(horse);
    }
}