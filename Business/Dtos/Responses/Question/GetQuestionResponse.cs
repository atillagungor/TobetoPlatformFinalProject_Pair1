﻿namespace Business.Dtos.Responses.Question
{
    public class GetQuestionResponse
    {
        public Guid Id { get; set; }
        public Guid TrueAnswerId { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
