using VVCyberAware.Shared.Models.ApiModels;

namespace VVCyberAware.Shared.Models.Services.QuestionService
{
    public interface IQuestionService
    {
        public HttpClient client { get; set; }

        public Task<List<QuestionApiModel>> GetQuestionsAsync();

        public Task<QuestionApiModel> GetQuestionByIdAsync(int id);

        public Task PostQuestion(QuestionApiModel question);

        public Task DeleteQuestion(int id);

        public Task UpdateQuestionAsync(int id, QuestionApiModel updatedQuestion);
    }
}
