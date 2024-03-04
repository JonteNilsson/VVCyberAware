using Microsoft.AspNetCore.Mvc;
using VVCyberAware.Shared.Models.DbModels;

namespace VVCyberAware.API.Controllers
{
    public class SegmentController : Controller
    {
        public List<SegmentModel> Segments { get; set; } = new()
        {

        };



        [HttpGet("Segments")]
        public ActionResult<List<SegmentModel>> GetAllSegments()
        {
            return Ok(Segments);
        }


        [HttpGet("Segment")]
        public ActionResult<SegmentModel> GetSingleSegment(int id)
        {
            var segment = Segments.FirstOrDefault(s => s.Id == id);

            if (segment == null)
            {
                return NotFound();
            }

            return Ok(segment);
        }

        [HttpDelete("Segment")]
        public ActionResult DeleteSegment(int id)
        {
            var segment = Segments.FirstOrDefault(s => s.Id == id);

            if (segment == null)
            {
                return NotFound();
            }

            Segments.Remove(segment);
            return Ok();
        }


    }
}
