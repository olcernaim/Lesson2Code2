namespace Lesson2Code2.WebApi.Interfaces
{
    public interface IBase : IGet
    {
        void Post(Person pers);
        void Put(int id, Person pers);
        void Delete(int id);
    }
}
