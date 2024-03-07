using Microsoft.AspNetCore.Mvc;
using VVCyberAware.Data;
using VVCyberAware.Database.Repositories;
using VVCyberAware.Shared.Models.DbModels;
using VVCyberAware.Shared.Models.ViewModels;

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
        public async Task<ActionResult<List<QuestionModel>>> GetQuestions()
        {
            var questions = await _questionRepo.GetAll();

            if (questions != null)
            {
                return Ok(questions);
            }

            return BadRequest();
        }




        [HttpGet("Question/{id}")]
        public async Task<ActionResult<QuestionModel>> GetSingleQuestion(int id)
        {
            var question = await _questionRepo.GetModelById(id);

            if (question == null)
            {
                return NotFound();
            }

            return Ok(question);
        }


        [HttpPost("Question")]
        public async Task<ActionResult> PostQuestion(QuestionViewModel newQuestion)
        {
            if (newQuestion == null)
            {
                return BadRequest();
            }

            QuestionModel model = new()
            {
                QuestionText = newQuestion.QuestionText!,
                Explanation = newQuestion.Explanation,
                Answers = newQuestion.Answers,
            };

            await _questionRepo.Add(model);
            _context.SaveChanges();

            return Ok(newQuestion);
        }


        [HttpDelete("Question/{id}")]
        public async Task<ActionResult> DeleteQuestion(int id)
        {
            var questionToDelete = _questionRepo.GetModelById(id);

            if (questionToDelete == null)
            {
                return NotFound();
            }


            await _questionRepo.Delete(questionToDelete.Id);

            _context.SaveChanges();

            return Ok();
        }
    }
}
