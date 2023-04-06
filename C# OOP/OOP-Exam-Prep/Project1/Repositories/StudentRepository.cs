using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityCompetition.Models;
using UniversityCompetition.Models.Contracts;
using UniversityCompetition.Repositories.Contracts;

namespace UniversityCompetition.Repositories
{
    public class StudentRepository : IRepository<IStudent>
    {
        private List<IStudent> models = new List<IStudent>();

        public IReadOnlyCollection<IStudent> Models => models.AsReadOnly();

        public void AddModel(IStudent model)
        {
            Student newStudent = new(models.Count + 1, model.FirstName, model.LastName);
            
            models.Add(newStudent);
        }

        public IStudent FindById(int id) => models.FirstOrDefault(x => x.Id == id);

        public IStudent FindByName(string name)
        {
            string[] names = name.Split(" ");
            return models.FirstOrDefault(x => x.FirstName == names[0] && x.LastName == names[1]) ;
        }

    }
}
