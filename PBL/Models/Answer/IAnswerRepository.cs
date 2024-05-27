using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.Models.Answer
{
    public interface IAnswerRepository
    {
        void Add(AnswerModel answerModel);
        void Edit(AnswerModel answerModel);
        IEnumerable<AnswerModel> GetByQuestion(int questionId);
    }
}
