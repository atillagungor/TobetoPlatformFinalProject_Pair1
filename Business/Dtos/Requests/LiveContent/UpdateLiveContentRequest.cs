﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Requests.LiveContent
{
    public class UpdateLiveContentRequest
    {
        public Guid Id { get; set; }
        public Guid LikeId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
    }
}