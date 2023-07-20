using System;

namespace CancerPlotWpf.Models;

public class Patient
{
	public int Id { get; set; }
	public string? Surname { get; set; }
	public string? Name { get; set; }
	public string? Patronymic { get; set; }
	public Gender Gender { get; set; }
	public DateOnly? Birthday {get; set; }
	public string? CardId { get; set; }
	public string? Phone { get; set; }

	public Patient()
	{
		
	}

	public Patient(string? surname, string? name, string? patronymic, Gender gender, DateOnly? birthday, string cardId, string? phone)
	{
		Surname = surname;
		Name = name;
		Patronymic = patronymic;
		Gender = gender;
		Birthday = birthday;
		CardId = cardId;
		Phone = phone;
	}
}