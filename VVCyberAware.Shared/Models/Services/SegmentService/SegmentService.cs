using Newtonsoft.Json;
using System.Net.Http.Json;
using VVCyberAware.Shared.Models.ApiModels;

namespace VVCyberAware.Shared.Models.Services.SegmentService
{
    public class SegmentService : ISegmentService
    {
        public HttpClient client { get; set; } = new()
        {
            BaseAddress = new Uri("http://localhost:5142/api/")
        };

        public async Task<SegmentApiModel> GetSegmentByIdAsync(int id)
        {
            var response = await client.GetAsync($"Segment/Segment/{id}");

            if (response.IsSuccessStatusCode)
            {
                string segmentJson = await response.Content.ReadAsStringAsync();

                SegmentApiModel? segment = JsonConvert.DeserializeObject<SegmentApiModel>(segmentJson);

                if (segment != null)
                {
                    return segment;
                }

                throw new JsonException();
            }

            throw new HttpRequestException();
        }

        public async Task<List<SegmentApiModel>> GetSegmentsAsync()
        {
            var response = await client.GetAsync("Segment/Segments");

            if (response.IsSuccessStatusCode)
            {
                string segmentJson = await response.Content.ReadAsStringAsync();

                List<SegmentApiModel>? segments = JsonConvert.DeserializeObject<List<SegmentApiModel>>(segmentJson);

                if (segments != null)
                {
                    return segments;
                }

                throw new JsonException();
            }

            throw new HttpRequestException();
        }

        public async Task PostSegment(SegmentApiModel segment)
        {
            await client.PostAsJsonAsync("Segment/Post", segment);
        }
    }
}
