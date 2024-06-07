using PBL.Models;
using PBL.Models.Answer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL._Repositories
{
    public class AnswerRepository : IAnswerRepository
    {
        public void Add(AnswerModel answerModel)
        {
            using (var ctx = new PBLContext())
            {
                ctx.Answers.Add(new AnswerModel
                {
                    Id = answerModel.Id,
                    Content = answerModel.Content,
                    Id_Question = answerModel.Id_Question
                });
                ctx.SaveChanges();
            }
        }

        public void Edit(AnswerModel answerModel)
        {
            using (var ctx = new PBLContext())
            {
                var answer = ctx.Answers.Find(answerModel.Id);
                answer.Content = answerModel.Content;
                ctx.SaveChanges();
            }
        }

        public IEnumerable<AnswerModel> GetByQuestion(int questionId)
        {
            return new PBLContext().Questions.Find(questionId).Answers;
        }
    }
}
