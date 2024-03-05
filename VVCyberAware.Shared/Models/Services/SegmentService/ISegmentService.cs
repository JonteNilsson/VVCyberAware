using VVCyberAware.Shared.Models.DbModels;

namespace VVCyberAware.Shared.Models.Services.SegmentService
{
    public interface ISegmentService
    {
        public HttpClient client { get; set; }

        public Task<List<SegmentModel>> GetSegmentsAsync();

        public Task<SegmentModel> GetSegmentByIdAsync(int id);

        public Task PostSegment(SegmentModel category);
    }
}
