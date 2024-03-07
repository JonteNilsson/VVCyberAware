using Newtonsoft.Json;
using System.Net.Http.Json;
using VVCyberAware.Shared.Models.ApiModels;

namespace VVCyberAware.Shared.Models.Services.QuestionService
{
    public class QuestionService : IQuestionService
    {
        public HttpClient client { get; set; } = new()
        {
            BaseAddress = new Uri("http://localhost:5142/api/")
        };

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

        public async Task PostQuestion(QuestionApiModel question)
        {
            await client.PostAsJsonAsync("Question/Post", question);
        }
    }
}
