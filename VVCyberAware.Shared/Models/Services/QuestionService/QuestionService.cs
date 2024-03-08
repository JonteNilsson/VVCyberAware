using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Text;
using VVCyberAware.Shared.Models.ApiModels;

namespace VVCyberAware.Shared.Models.Services.QuestionService
{
    public class QuestionService : IQuestionService
    {
        public HttpClient client { get; set; } = new()
        {
            BaseAddress = new Uri("http://localhost:5142/api/")
        };

        /// <summary>
        /// Makes an API call looking for a specific Question with its inputted ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Returns the Question matching the ID</returns>
        /// <exception cref="JsonException"></exception>
        /// <exception cref="HttpRequestException"></exception>
        public async Task<QuestionApiModel> GetQuestionByIdAsync(int id)
        {
            var response = await client.GetAsync($"Question/{id}");

            if (response.IsSuccessStatusCode)
            {
                string questionJson = await response.Content.ReadAsStringAsync();

                QuestionApiModel? question = JsonConvert.DeserializeObject<QuestionApiModel>(questionJson);

                if (question != null)
                {
                    return question;
                }

                throw new JsonException();
            }

            throw new HttpRequestException();
        }
        /// <summary>
        /// Make an API call to get all Questions
        /// </summary>
        /// <returns>Returns a list of Questions</returns>
        /// <exception cref="JsonException"></exception>
        /// <exception cref="HttpRequestException"></exception>
        public async Task<List<QuestionApiModel>> GetQuestionsAsync()
        {
            var response = await client.GetAsync("Question/Questions");

            if (response.IsSuccessStatusCode)
            {
                string questionJson = await response.Content.ReadAsStringAsync();

                List<QuestionApiModel>? questions = JsonConvert.DeserializeObject<List<QuestionApiModel>>(questionJson);

                if (questions != null)
                {
                    return questions;
                }

                throw new JsonException();
            }

            throw new HttpRequestException();
        }

        /// <summary>
        /// Posts a Question and stores it in Database
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        public async Task PostQuestion(QuestionApiModel question)
        {
            await client.PostAsJsonAsync("Question/Post", question);
        }

        public async Task UpdateQuestionAsync(int id, QuestionApiModel updatedQuestion)
        {
            // Convert the updatedQuestion to JSON
            string updatedQuestionJson = JsonConvert.SerializeObject(updatedQuestion);

            // Create a StringContent with the JSON data
            var content = new StringContent(updatedQuestionJson, Encoding.UTF8, "application/json");

            // Make the PUT request
            var response = await client.PutAsync($"Question/UpdateQuestion/{id}", content);

            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException();
            }
        }
    }
}
