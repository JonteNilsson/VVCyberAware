using Newtonsoft.Json;
using System.Net.Http.Json;
using VVCyberAware.Shared.Models.DbModels;

namespace VVCyberAware.Shared.Models.Services.QuestionService
{
    public class QuestionService : IQuestionService
    {
        public HttpClient client { get; set; } = new()
        {
            BaseAddress = new Uri("https://localhost:7214/api/")
        };

        public async Task<QuestionModel> GetQuestionByIdAsync(int id)
        {
            var response = await client.GetAsync($"Question/{id}");

            if (response.IsSuccessStatusCode)
            {
                string questionJson = await response.Content.ReadAsStringAsync();

                QuestionModel? question = JsonConvert.DeserializeObject<QuestionModel>(questionJson);

                if (question != null)
                {
                    return question;
                }

                throw new JsonException();
            }

            throw new HttpRequestException();
        }

        public async Task<List<QuestionModel>> GetQuestionsAsync()
        {
            var response = await client.GetAsync("Question/Questions");

            if (response.IsSuccessStatusCode)
            {
                string questionJson = await response.Content.ReadAsStringAsync();

                List<QuestionModel>? questions = JsonConvert.DeserializeObject<List<QuestionModel>>(questionJson);

                if (questions != null)
                {
                    return questions;
                }

                throw new JsonException();
            }

            throw new HttpRequestException();
        }

        public async Task PostQuestion(QuestionModel question)
        {
            await client.PostAsJsonAsync("Question/Post", question);
        }
    }
}
