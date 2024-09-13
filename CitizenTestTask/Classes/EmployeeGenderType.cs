using System.ComponentModel.DataAnnotations;

namespace CitizenTestTask.Classes;

public enum EmployeeGenderType
{
    [Display(Name = "Мужчина")]
    Male = 1,

    [Display(Name = "Женщина")]
    Female = 2
}