using Newtonsoft.Json;
using System.Net.Http.Json;
using VVCyberAware.Shared.Models.DbModels;

namespace VVCyberAware.Shared.Models.Services.SegmentService
{
    public class SegmentService : ISegmentService
    {
        public HttpClient client { get; set; } = new()
        {
            BaseAddress = new Uri("https://localhost:7214/api/")
        };

        public async Task<SegmentModel> GetSegmentByIdAsync(int id)
        {
            var response = await client.GetAsync($"Segment/{id}");

            if (response.IsSuccessStatusCode)
            {
                string segmentJson = await response.Content.ReadAsStringAsync();

                SegmentModel? segment = JsonConvert.DeserializeObject<SegmentModel>(segmentJson);

                if (segment != null)
                {
                    return segment;
                }

                throw new JsonException();
            }

            throw new HttpRequestException();
        }

        public async Task<List<SegmentModel>> GetSegmentsAsync()
        {
            var response = await client.GetAsync("Segment/Segments");

            if (response.IsSuccessStatusCode)
            {
                string segmentJson = await response.Content.ReadAsStringAsync();

                List<SegmentModel>? segments = JsonConvert.DeserializeObject<List<SegmentModel>>(segmentJson);

                if (segments != null)
                {
                    return segments;
                }

                throw new JsonException();
            }

            throw new HttpRequestException();
        }

        public async Task PostSegment(SegmentModel segment)
        {
            await client.PostAsJsonAsync("Segment/Post", segment);
        }
    }
}
