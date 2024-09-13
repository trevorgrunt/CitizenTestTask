using CitizenTestTask.Classes;

namespace CitizenTestTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Citizen[] citizens = new Citizen[]
            {
                new Citizen("Иванов", "Иван", "Иванович", new DateTime(2000, 5, 10), "Москва", EmployeeGenderType.Male),
                new Citizen("Петрова", "Анна", "Сергеевна", new DateTime(2009, 8, 15), "Москва", EmployeeGenderType.Female),
                new Citizen("Сидоров", "Петр", "Николаевич", new DateTime(1990, 2, 20), "Санкт-Петербург", EmployeeGenderType.Male),
                new Citizen("Кузнецова", "Елена", "Викторовна", new DateTime(1985, 12, 1), "Новосибирск", EmployeeGenderType.Female),
                new Citizen("Морозов", "Алексей", "Андреевич", new DateTime(1998, 7, 3), "Москва", EmployeeGenderType.Male),
                new Citizen("Смирнова", "Ольга", "Игоревна", new DateTime(2003, 11, 5), "Улан-Удэ", EmployeeGenderType.Female),
                new Citizen("Васильев", "Николай", "Дмитриевич", new DateTime(1975, 9, 9), "Санкт-Петербург", EmployeeGenderType.Male),
                new Citizen("Захарова", "Мария", "Петровна", new DateTime(1995, 3, 25), "Новосибирск", EmployeeGenderType.Female),
                new Citizen("Погосян", "Лев", "Ашотович", new DateTime(2002, 11, 4), "Улан-Удэ", EmployeeGenderType.Male),
                new Citizen("Михайлова", "Татьяна", "Александровна", new DateTime(2011, 6, 10), "Москва", EmployeeGenderType.Female)
            };

            Console.WriteLine("Все граждане:");
            foreach (var citizen in citizens)
            {
                Console.WriteLine(citizen);
            }
            
            Console.WriteLine("\nВ алфавитном порядке:");
            var sortedCitizens = citizens
                .OrderBy(c => $"{c.Name} {c.Surname}")
                .ToArray();
            foreach (var citizen in sortedCitizens)
            {
                Console.WriteLine(citizen);
            }

            Console.WriteLine("\nГраждане старше 18 лет:");
            var adults = citizens.Where(c => (DateTime.Now.Year - c.Birthday.Year) >= 18).ToArray();
            foreach (var citizen in adults)
            {
                Console.WriteLine(citizen);
            }

            Console.WriteLine("\nЕсли поменять всем пол:");
            foreach (var citizen in citizens)
            {
                citizen.Gender = citizen.Gender == EmployeeGenderType.Male ? EmployeeGenderType.Female : EmployeeGenderType.Male;
            }

            foreach (var citizen in citizens)
            {
                Console.WriteLine(citizen);
            }

            Console.WriteLine("\nКоличество мужчин по городам:");
            var maleCountByCity = citizens
                .Where(c => c.Gender == EmployeeGenderType.Male)
                .GroupBy(c => c.City)
                .Select(g => new
                {
                    City = g.Key,
                    Count = g.Count()
                })
                .ToArray();

            foreach (var group in maleCountByCity)
            {
                Console.WriteLine($"{group.City}: {group.Count} мужчин");
            }
        }
    }
}
