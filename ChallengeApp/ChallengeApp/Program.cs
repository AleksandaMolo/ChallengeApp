using ChallengeApp;

Employee employer1 = new Employee ("Asia", "Nowak",33);
Employee employer2 = new Employee ("Kasia", "Kowalska",45);
Employee employer3 = new Employee ("Andrzej", "Zapart",25);



employer1.AddScore(5);
employer1.AddScore(7);
employer1.AddScore(9);
employer1.AddScore(2);
employer1.AddScore(8);

employer2.AddScore(9);
employer2.AddScore(9);
employer2.AddScore(9);
employer2.AddScore(9);
employer2.AddScore(9);

employer3.AddScore(7);
employer3.AddScore(6);
employer3.AddScore(9);
employer3.AddScore(8);
employer3.AddScore(7);

List<Employee> employers = new List<Employee>()
{
    employer1,
    employer2,
    employer3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employer in employers)
{
    if (employer.Result > maxResult)
    {
        employeeWithMaxResult = employer;
         maxResult = employer.Result;
    }
}

Console.WriteLine("Pracownik z najwyższą liczbą to " + employeeWithMaxResult.Name + " " + employeeWithMaxResult.Surname + " w wieku " + employeeWithMaxResult.Age + "  lat");


