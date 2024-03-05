using VVCyberAware.Shared.Models.DbModels;

namespace VVCyberAware.Shared.Models.Services.QuestionService
{
    public interface IQuestionService
    {
        public HttpClient client { get; set; }

        public Task<List<QuestionModel>> GetQuestionsAsync();

        public Task<QuestionModel> GetQuestionByIdAsync(int id);

        public Task PostQuestion(QuestionModel question);
    }
}
