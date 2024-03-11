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
	public class SegmentController : Controller
	{
		private readonly ApplicationDbContext _context;
		private readonly GenericRepository<SegmentModel> _segmentRepo;

		public SegmentController(ApplicationDbContext context, GenericRepository<SegmentModel> segmentRepo)
		{
			_context = context;
			_segmentRepo = segmentRepo;
		}


		[HttpGet("Segments")]
		public async Task<ActionResult<List<SegmentModel>>> GetAllSegments()
		{
			var segments = await _segmentRepo.GetAll();

			if (segments != null)
			{
				return Ok(segments);
			}

			return BadRequest();
		}


		[HttpGet("Segment/{id}")]
		public async Task<ActionResult<SegmentModel>> GetSingleSegment(int id)
		{
			var segment = await _segmentRepo.GetModelById(id);

			if (segment == null)
			{
				return NotFound();
			}

			return Ok(segment);
		}


		[HttpPost("Segment")]
		public async Task<ActionResult> PostSegment(SegmentViewModel newSegment)
		{
			if (newSegment == null)
			{
				return BadRequest();
			}

			SegmentModel model = new()
			{
				Name = newSegment.Name!,
				UserIsComplete = newSegment.UserIsComplete,
				CategoryId = newSegment.CategoryId,
			};

			await _segmentRepo.Add(model);
			_context.SaveChanges();

			return Ok(newSegment);
		}




		[HttpDelete("DeleteSegment/{id}")]
		public async Task<ActionResult> DeleteSegment(int id)
		{
			var segment = await _segmentRepo.GetModelById(id);

			if (segment == null)
			{
				return NotFound();
			}


			await _segmentRepo.Delete(segment.Id);


			return Ok(segment);
		}


		[HttpPut("UpdateSegment/{id}")]
		public async Task<IActionResult> UpdateSegment(int id, [FromBody] SegmentViewModel updatedSegment)
		{

			if (id != updatedSegment.Id)
			{
				return BadRequest("ID's do not match");
			}

			var existingSegment = await _context.Segments
				.FirstOrDefaultAsync(s => s.Id == id);

			if (existingSegment == null)
			{
				return NotFound($"Segment with ID {id} not found");
			}

			existingSegment.Id = updatedSegment.Id;
			existingSegment.Name = updatedSegment.Name!;
			existingSegment.UserIsComplete = updatedSegment.UserIsComplete;
			existingSegment.CategoryId = updatedSegment.CategoryId;

			_segmentRepo.Update(existingSegment);

			try
			{
				await _context.SaveChangesAsync();
				return Ok($"Segment with ID {id} updated successfully");
			}
			catch (DbUpdateConcurrencyException)
			{
				return StatusCode(500, "Concurrency error occurred");
			}
		}


	}
}
