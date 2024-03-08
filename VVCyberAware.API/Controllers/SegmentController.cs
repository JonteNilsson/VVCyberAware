using Microsoft.AspNetCore.Mvc;
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




        [HttpDelete("Segment/{id}")]
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


    }
}
