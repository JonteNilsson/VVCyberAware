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

        /// <summary>
        /// Makes an API call looking for a specific Segment with its inputted ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Returns the Segemnt matching the ID</returns>
        /// <exception cref="JsonException"></exception>
        /// <exception cref="HttpRequestException"></exception>
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
        /// <summary>
        /// Make an API call to get all Segments
        /// </summary>
        /// <returns>Returns a list of Segments</returns>
        /// <exception cref="JsonException"></exception>
        /// <exception cref="HttpRequestException"></exception>
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

        /// <summary>
        /// Posts a Segment and stores it in Database
        /// </summary>
        /// <param name="segment"></param>
        /// <returns></returns>
        public async Task PostSegment(SegmentApiModel segment)
        {
            await client.PostAsJsonAsync("Segment/Post", segment);
        }
    }
}
