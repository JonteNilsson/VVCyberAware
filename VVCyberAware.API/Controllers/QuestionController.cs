using Microsoft.AspNetCore.Mvc;
using VVCyberAware.Data;
using VVCyberAware.Database.Repositories;
using VVCyberAware.Shared.Models.DbModels;

namespace VVCyberAware.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly GenericRepository<QuestionModel> _questionRepo;

        public QuestionController(ApplicationDbContext context, GenericRepository<QuestionModel> questionRepo)
        {
            _context = context;
            _questionRepo = questionRepo;
        }

        public List<QuestionModel> Questions { get; set; } = new()
        {

        };



        [HttpGet("Questions")]
        public ActionResult<List<QuestionModel>> GetQuestions()
        {
            return Ok(Questions);
        }




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


        [HttpPost("Question")]
        public ActionResult PostQuestion(QuestionModel newQuestion)
        {
            if (newQuestion == null)
            {
                return BadRequest();
            }

            Questions.Add(newQuestion);

            _questionRepo.Add(newQuestion);
            _context.SaveChanges();

            return Ok(newQuestion);
        }


        [HttpDelete("Question/{id}")]
        public ActionResult DeleteQuestion(int id)
        {
            var questionToDelete = Questions.FirstOrDefault(q => q.Id == id);

            if (questionToDelete == null)
            {
                return NotFound();
            }

            Questions.Remove(questionToDelete);

            _questionRepo.Delete(questionToDelete.Id);

            _context.SaveChanges();

            return Ok();
        }
    }
}
