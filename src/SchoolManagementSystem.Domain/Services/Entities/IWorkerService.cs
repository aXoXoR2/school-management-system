using SchoolManagementSystem.Domain.Entities;


namespace SchoolManagementSystem.Domain.Services.Entities;

public interface IWorkerService : IService<Worker>
{
    // Selecciona al trabajador con cierto id
    // y toma toda su informaci�n
    Worker GetWorkerById(string id);
}