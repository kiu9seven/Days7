using Day5_MVC_core.Models;

namespace Days7.Services;

public interface IPersonService
{
    List<Person> GetAll();
    Person GetOne(int index);
    
    void Create(Person person);
    void Update(int Index, Person person);
    void Delete(int index);

}