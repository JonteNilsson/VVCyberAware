using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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



        [HttpPost("PostQuestion")]
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
				SubCategoryId = newQuestion.SubCategoryId,
			};

			await _questionRepo.Add(model);


			return Ok(newQuestion);
		}


		[HttpDelete("DeleteQuestion/{id}")]
		public async Task<ActionResult> DeleteQuestion(int id)
		{
			var questionToDelete = await _questionRepo.GetModelById(id);

			if (questionToDelete == null)
			{
				return NotFound();
			}

			await _questionRepo.Delete(questionToDelete.Id);

			return Ok(questionToDelete);
		}


		[HttpPut("UpdateQuestion/{id}")]
		public async Task<IActionResult> UpdateQuestion(int id, [FromBody] QuestionViewModel updatedQuestion)
		{
			if (id != updatedQuestion.Id)
			{
				return BadRequest("ID's do not match");
			}

			var existingQuestion = await _context.Questions.FirstOrDefaultAsync(q => q.Id == id);

			if (existingQuestion == null)
			{
				return NotFound($"Question with ID {id} not found");
			}

			existingQuestion.Id = updatedQuestion.Id;
			existingQuestion.Explanation = updatedQuestion.Explanation;
			existingQuestion.SubCategoryId = updatedQuestion.SubCategoryId;
			existingQuestion.Answers = updatedQuestion.Answers;

			_questionRepo.Update(existingQuestion);

			try
			{
				await _context.SaveChangesAsync();
				return Ok($"Question with ID {id} updated successfully");
			}
			catch (DbUpdateConcurrencyException)
			{

				return StatusCode(500, "Concurrency error occurred");
			}
		}
	}
}
