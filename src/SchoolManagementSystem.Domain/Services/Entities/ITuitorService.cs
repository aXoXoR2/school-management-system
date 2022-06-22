using SchoolManagementSystem.Domain.Entities;


namespace SchoolManagementSystem.Domain.Services.Entities;

public interface ITuitorService : IService<Tuitor>
{
    // Selecciona a un tutor con cierto id
    // y toma toda su informaci�n
    Tuitor GetTuitorById(string id);
}