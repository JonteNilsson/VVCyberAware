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



        [HttpGet("Questions")]
        public ActionResult<List<QuestionModel>> GetQuestions()
        {
            var questions = _questionRepo.GetAll();

            if (questions != null)
            {
                return Ok(questions);
            }

            return BadRequest();
        }




        [HttpGet("Question/{id}")]
        public ActionResult<QuestionModel> GetSingleQuestion(int id)
        {
            var question = _questionRepo.GetModelById(id);

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


            _questionRepo.Add(newQuestion);
            _context.SaveChanges();

            return Ok(newQuestion);
        }


        [HttpDelete("Question/{id}")]
        public ActionResult DeleteQuestion(int id)
        {
            var questionToDelete = _questionRepo.GetModelById(id);

            if (questionToDelete == null)
            {
                return NotFound();
            }


            _questionRepo.Delete(questionToDelete.Id);

            _context.SaveChanges();

            return Ok();
        }
    }
}
