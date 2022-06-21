using SchoolManagementSystem.Domain.Entities;


namespace SchoolManagementSystem.Domain.Services;

public interface ICourseService : IService<Course>
{
    // Selecciona a un estudiante con cierto id
    // y toma toda su informaci�n
    Course GetCourseById(string id);
}