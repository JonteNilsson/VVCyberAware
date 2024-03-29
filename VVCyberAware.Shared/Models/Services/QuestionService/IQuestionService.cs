﻿using VVCyberAware.Shared.Models.ApiModels;
using VVCyberAware.Shared.Models.ViewModels;

namespace VVCyberAware.Shared.Models.Services.QuestionService
{
	public interface IQuestionService
	{
		public HttpClient client { get; set; }

		public Task<List<QuestionApiModel>> GetQuestionsAsync();

		public Task<QuestionApiModel> GetQuestionByIdAsync(int id);

		public Task PostQuestion(QuestionViewModel question);

		public Task DeleteQuestion(int id);


    public Task UpdateQuestionAsync(int id, QuestionViewModel updatedQuestion);
    }

}
