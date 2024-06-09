using PBL.Models;
using PBL.Models.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL._Repositories
{
    public class TestRepository : ITestRepository
    {
        public void Add(TestModel testModel)
        {
            using (var ctx = new PBLContext())
            {
                ctx.Tests.Add(testModel);
                ctx.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var ctx = new PBLContext())
            {
                var test = ctx.Tests.Find(id);
                ctx.Tests.Remove(test);
                ctx.SaveChanges();
            }
        }

        public void Edit(TestModel testModel)
        {
            using (var ctx = new PBLContext())
            {
                var test = ctx.Tests.Find(testModel.Id);
                test.Name = testModel.Name;
                test.Description = testModel.Description;
                test.Id_Teacher = testModel.Id_Teacher;
                if(testModel.Audio != null) test.Audio = testModel.Audio;
                ctx.SaveChanges();
            }
        }

        public IEnumerable<TestModel> GetByValue(string search)
        {
            int testId = int.TryParse(search, out _) ? Convert.ToInt32(search) : 0;
            if (testId > 0) return new PBLContext().Tests.Where(p => p.Id == testId).ToList();
            else return new PBLContext().Tests.Where(p => p.Name.Contains(search)).ToList();
        }

        public IEnumerable<TestModel> GetAll()
        {
            return new PBLContext().Tests.ToList();
        }

        public int GetLast()
        {
            return new PBLContext().Tests.ToList().Last().Id;
        }
    }
}
