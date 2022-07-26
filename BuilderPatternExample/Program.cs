using System.Text.Json;
using BuilderPatternExample;

var p = new Person
{
    FirstName = "Juldhais",
    LastName = "Hengkyawan",
    BirthDate = new DateTime(1990, 7, 3),
    Address = new Address
    {
        Line = "Jl. Dharmawangsa No. 10",
        City = "Bogor",
        Province = "Jawa Barat",
        PostCode = "16131"
    },
    Phones = new List<Phone>
    {
        new Phone
        {
            PhoneNumber = "02518334455", 
            PhoneType = PhoneType.Home
        },
        new Phone
        {
            PhoneNumber = "02518334455", 
            PhoneType = PhoneType.Mobile
        },
    }
};

var person = new PersonBuilder()
    .SetName("Juldhais", "Hengkyawan")
    .SetBirthDate(new DateTime(1990, 7, 3))
    .SetAddress(new Address
    {
        Line = "Jl. Dharmawangsa No. 10",
        City = "Bogor",
        Province = "Jawa Barat",
        PostCode = "16131"
    })
    .AddHomePhone("02518334455")
    .AddMobilePhone("081312345678")
    .Build();
    
Console.WriteLine(JsonSerializer.Serialize(person));