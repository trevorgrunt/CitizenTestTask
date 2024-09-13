using System.ComponentModel.DataAnnotations;

namespace CitizenTestTask.Classes
{
    public class Citizen
    {
        [Required]
        [MaxLength(128)]
        public string Surname { get; set; } = null!;

        [Required]
        [MaxLength(128)]
        public string Name { get; set; } = null!;

        [MaxLength(128)]
        public string? MiddleName { get; set; }

        [Required]
        public DateTime Birthday { get; set; }

        [Required]
        [MaxLength(128)]
        public string City { get; set; } = null!;

        [Required]
        public EmployeeGenderType Gender { get; set; }

        public Citizen(string surname, string name, string? middleName, DateTime birthday, string city, EmployeeGenderType gender)
        {
            Surname = surname;
            Name = name;
            MiddleName = middleName;
            Birthday = birthday;
            City = city;
            Gender = gender;
        }

        public override string ToString()
        {
            return $"Имя: {Name}, Фамилия: {Surname}, Отчество: {MiddleName}, Пол: {Gender}, Дата рождения: {Birthday:dd.MM.yyyy}, Город: {City}";
        }
    }
}
