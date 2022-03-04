using ConsoleUI;

PersonModel person = new PersonModel();

person.FirstName = "Mike";
person.LastName = "Robards";
person.Age = 50;
person.SSN = "123-45-6789";

Console.WriteLine(person.SSN);
