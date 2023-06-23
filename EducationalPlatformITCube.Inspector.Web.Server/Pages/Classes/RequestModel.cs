using System.ComponentModel.DataAnnotations;

namespace EducationalPlatformITCube.Inspector.Web.Server.Pages.Classes
{
    public class RequestModel
    {

        public int Id { get; set; }
        public string Date { get; set; }
        [Required(ErrorMessage = "Поле Почта обязательно для заполнения")]
        [EmailAddress(ErrorMessage = "Некорректный формат адреса почты")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Поле Фамилия обязательно для заполнения")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Поле Имя обязательно для заполнения")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Поле Отчество ребенка обязательно для заполнения")]
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Поле Дата рождения обязательно для заполнения")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Поле Возраст обязательно для заполнения")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Поле № Школы обязательно для заполнения")]
        public int SchoolNumber { get; set; }

        [Required(ErrorMessage = "Поле Класс в школе обязательно для заполнения")]
        public string SchoolClass { get; set; }

        [Required(ErrorMessage = "Поле Выбор смены обучения обязательно для заполнения")]
        public string Session { get; set; }

        [Required(ErrorMessage = "Поле Выбор направления обучения обязательно для заполнения")]
        public string StudyDirection { get; set; }

        [Required(ErrorMessage = "Поле Фамилия родителя обязательно для заполнения")]
        public string ParentLastName { get; set; }

        [Required(ErrorMessage = "Поле Имя родителя обязательно для заполнения")]
        public string ParentFirstName { get; set; }

        [Required(ErrorMessage = "Поле Отчество родителя обязательно для заполнения")]
        public string ParentMiddleName { get; set; }

        [Required(ErrorMessage = "Поле Контактный телефон родителя обязательно для заполнения")]
        [Phone(ErrorMessage = "Некорректный формат телефона")]
        public string ParentPhoneNumber { get; set; }

        [Range(typeof(bool), "true", "true", ErrorMessage = "Необходимо дать согласие на обработку персональных данных")]
        public bool Consent { get; set; }

        public string Comment { get; set; }
        public int posInQuery { get; set; }
        public string AdminComment { get; set; }
        public string Status { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
