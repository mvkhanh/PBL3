using PBL.Models;
using PBL.Models.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL._Repositories
{
    public class QuestionRepository : IQuestionRepository
    {
        public void Add(QuestionModel questionModel)
        {
            using(var ctx = new PBLContext())
            {
                ctx.Questions.Add(new QuestionModel
                {
                    Id = questionModel.Id,
                    Content = questionModel.Content,
                    Photo = questionModel.Photo,
                    Id_Test = questionModel.Id_Test
                });
                ctx.SaveChanges();
            }
        }

        public void Edit(QuestionModel questionModel)
        {
            using(var ctx = new PBLContext())
            {
                var question = ctx.Questions.Find(questionModel.Id);
                question.Content = questionModel.Content;
                if(questionModel.Photo != null) question.Photo = questionModel.Photo;
                ctx.SaveChanges();
            }
        }

        public IEnumerable<QuestionModel> GetByTest(int testId)
        {
            return new PBLContext().Tests.Find(testId).Questions;
        }
    }
}
