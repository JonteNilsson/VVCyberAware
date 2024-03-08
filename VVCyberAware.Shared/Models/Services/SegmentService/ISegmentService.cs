using VVCyberAware.Shared.Models.ApiModels;

namespace VVCyberAware.Shared.Models.Services.SegmentService
{
    public interface ISegmentService
    {
        public HttpClient client { get; set; }

        public Task<List<SegmentApiModel>> GetSegmentsAsync();

        public Task<SegmentApiModel> GetSegmentByIdAsync(int id);

        public Task PostSegment(SegmentApiModel category);

        public Task UpdateSegmentAsync(int id, SegmentApiModel updatedSegment);
    }
}
