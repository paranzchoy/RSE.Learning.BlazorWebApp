using Microsoft.AspNetCore.Components;
using RSE.Learning.BlazorWebApp.Client.Dtos.Persons;

namespace RSE.Learning.BlazorWebApp.Client.Features.Persons;

public class GetPersonsBase : ComponentBase
{
    protected IEnumerable<PersonListDto> Persons = new List<PersonListDto>()
    {
        new PersonListDto
        {
            LastName = "Doe",
            FirstName = "John",
            Gender = "Male",
            Address = "123 Main St"
        },
        new PersonListDto
        {
            LastName = "Smith",
            FirstName = "Jane",
            Gender = "Female",
            Address = "456 Elm St"
        },
        new PersonListDto
        {
            LastName = "Johnson",
            FirstName = "Bob",
            Gender = "Male",
            Address = "789 Oak St"
        }
    };

    protected bool _loading = true;
}
