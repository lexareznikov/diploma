using System.ComponentModel.DataAnnotations;

namespace Demography.Infrastructure.Enums
{
    public enum FieldLogs
    {
        [Display(Name = "Номер свидетельства ")]
        Number = 1,

        [Display(Name = "Статус свидетельства")]
        StatusId = 4,

        [Display(Name = "Подразделение")]
        DepartmentId = 5,

        [Display(Name = "Главный врач МО")]
        DirectorClinicId = 6,

        [Display(Name = "Фамилия получателя")]
        RecipientLastname = 7,

        [Display(Name = "Имя получателя")]
        RecipientFirstname = 8,

        [Display(Name = "Отчество получателя")]
        RecipientMiddlename = 9,

        [Display(Name = "Дата рождения получателя")]
        RecipientBirthDate = 10,

        [Display(Name = "Тип документа получателя")]
        RecipientDoctypeId = 11,

        [Display(Name = "Номер докумета получателя")]
        RecipientDocSeries = 12,

        [Display(Name = "Серия докумета получателя")]
        RecipientDocNumber = 13,

        [Display(Name = "Кем выдан документ получателя")]
        RecipientDocWhomIssued = 14,

        [Display(Name = "СНИЛС получателя")]
        RecipientSnils = 15,

        [Display(Name = "Юр. лицо получателя")]
        RecipientLegalOrganization = 16,

        [Display(Name = "ФИО")]
        Name = 17,

        [Display(Name = "Дата рождения")]
        BirthDate = 18,

        [Display(Name = "Пол")]
        Sex = 19,

        [Display(Name = "Дата смерти")]
        DeathDate = 20,

        [Display(Name = "ФИО заполнившего")]
        FillingFullName = 21,

        [Display(Name = "Основная причина смерти")]
        ReasonDeath = 22,

        [Display(Name = "Логин (СНИЛС) удалившего")]
        FillingLogin = 23
    }
}
