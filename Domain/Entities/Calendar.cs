using Domain.Validation;

namespace Domain.Entities;

public class Calendar : Entity {

    public string Name { get; private set; }

    public Calendar(string name) {
        ValidateDomain(name);
    }

    public Calendar(int id , string name) {
        DomainValidationException.When(id < 0, "Invalid Id value.");
        Id = id;
        ValidateDomain(name);
    }

    public void Update(string name) {
        ValidateDomain(name);
    }

    private void ValidateDomain(string name) {
        DomainValidationException.When(string.IsNullOrEmpty(name),
            "Invalid name.Name is required");

        DomainValidationException.When(name.Length < 3,
           "Invalid name, too short, minimum 3 characters");

        Name = name;
    }

}
