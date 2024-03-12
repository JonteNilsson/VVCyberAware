using VVCyberAware.Shared.Models.ApiModels;
using VVCyberAware.Shared.Models.ViewModels;

namespace VVCyberAware.Shared.Models.Services.SegmentService
{
    public interface ISegmentService
    {
        public HttpClient client { get; set; }

        public Task<List<SegmentApiModel>> GetSegmentsAsync();

        public Task<SegmentApiModel> GetSegmentByIdAsync(int id);

        public Task PostSegment(SegmentApiModel category);

        public Task DeleteSegment(int id);

        public Task UpdateSegmentAsync(int id, SegmentViewModel updatedSegment);
    }
}
