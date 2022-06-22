using SchoolManagementSystem.Domain.Entities;


namespace SchoolManagementSystem.Domain.Services.Entities;

public interface ICourseGroupService : IService<CourseGroup>
{
    // Selecciona un CourseGroup con cierto id
    // y toma toda su informaci�n
    CourseGroup GetCourseGroupById(string id);
}