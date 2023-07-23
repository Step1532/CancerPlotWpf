using CancerPlot.Core.Models;

namespace CancerPlot.Core;

public class PersonalDataBuilder
{
    private PersonalData data;
    public PersonalDataBuilder()
    {
        data = new PersonalData();
    }
    public PersonalDataBuilder SetSurname(string surname)
    {
        data.Surname = surname;
        return this;
    }
    public PersonalDataBuilder SetName(string name)
    {
        data.Name = name;
        return this;
    }
    public PersonalDataBuilder SetPatronymic(string patronymic)
    {
        data.Patronymic = patronymic;
        return this;
    }

    public PersonalDataBuilder SetGender(Gender gender)
    {
        data.Gender = gender;
        return this;
    }

    public PersonalDataBuilder SetBirthday(DateOnly date)
    {
        data.Birthday = date;
        return this;
    }
    public PersonalDataBuilder SetCardId(string id)
    {
        data.CardId = id;
        return this;
    }

    public PersonalDataBuilder SetPhone(string phone)
    {
        data.Phone = phone;
        return this;
    }

    public static implicit operator PersonalData(PersonalDataBuilder builder)
    {
        return builder.data;
    }
}