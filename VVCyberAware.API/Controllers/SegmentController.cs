using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VVCyberAware.Data;
using VVCyberAware.Database.Repositories;
using VVCyberAware.Shared.Models.DbModels;

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
        public List<SegmentModel> Segments { get; set; } = new()
        {

        };



        [HttpGet("Segments")]
        public async Task<ActionResult<List<SegmentModel>>> GetAllSegments()
        {
            var segments = await _context.Segments.ToListAsync();

            if (segments != null)
            {
                return Ok(segments);
            }

            return BadRequest();
        }


        [HttpGet("Segment/{id}")]
        public async Task<ActionResult<SegmentModel>> GetSingleSegment(int id)
        {
            var segment = await _context.Segments.FirstOrDefaultAsync(x => x.Id == id);

            if (segment == null)
            {
                return NotFound();
            }

            return Ok(segment);
        }


        [HttpPost("Segment")]
        public ActionResult PostSegment(SegmentModel newSegment)
        {
            if (newSegment == null)
            {
                return BadRequest();
            }

            Segments.Add(newSegment);

            _segmentRepo.Add(newSegment);
            _context.SaveChanges();

            return Ok(newSegment);
        }

        [HttpDelete("Segment/{id}")]
        public ActionResult DeleteSegment(int id)
        {
            var segment = Segments.FirstOrDefault(s => s.Id == id);

            if (segment == null)
            {
                return NotFound();
            }

            Segments.Remove(segment);

            _segmentRepo.Delete(segment.Id);

            _context.SaveChanges();

            return Ok();
        }


    }
}
