using Microsoft.AspNetCore.Mvc;
using VVCyberAware.Shared.Models.DbModels;

namespace VVCyberAware.API.Controllers
{
    public class QuestionController : Controller
    {
        public List<QuestionModel> Questions { get; set; } = new()
        {

        };

        [HttpGet("Question/{id}")]
        public ActionResult<QuestionModel> GetSingleQuestion(int id)
        {
            var question = Questions.FirstOrDefault(q => q.Id == id);

            if (question == null)
            {
                return NotFound();
            }

            return Ok(question);
        }


        [HttpGet("Questions")]
        public ActionResult<List<QuestionModel>> GetQuestions()
        {
            return Ok(Questions);
        }


        [HttpDelete("Question")]
        public ActionResult DeleteQuestion(int id)
        {
            var questionToDelete = Questions.FirstOrDefault(q => q.Id == id);

            if (questionToDelete == null)
            {
                return NotFound();
            }

            Questions.Remove(questionToDelete);
            return Ok();
        }
    }
}
