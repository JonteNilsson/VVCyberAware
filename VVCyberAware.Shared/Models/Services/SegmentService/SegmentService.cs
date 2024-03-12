using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Text;
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
            await client.PostAsJsonAsync("PostSegment/Post", segment);
        }

        /// <summary>
        /// Updates the model sent in to the method
        /// </summary>
        /// <param name="id"></param>
        /// <param name="updatedCategory"></param>
        /// <returns></returns>
        /// <exception cref="HttpRequestException"></exception>
        public async Task UpdateSegmentAsync(int id, SegmentApiModel updatedSegment)
        {
            // Convert the updatedSegment to JSON
            string updatedSegmentJson = JsonConvert.SerializeObject(updatedSegment);

            // Create a StringContent with the JSON data
            var content = new StringContent(updatedSegmentJson, Encoding.UTF8, "application/json");

            // Make the PUT request
            var response = await client.PutAsync($"Segment/UpdateSegment/{id}", content);

            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException();
            }
        }
    }
}
