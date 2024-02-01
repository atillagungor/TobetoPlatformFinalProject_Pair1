﻿using Business.Dtos.Requests.Announcement;
using Business.Dtos.Requests.CourseLikedByUser;
using Business.Dtos.Responses.Announcement;
using Business.Dtos.Responses.CourseLikedByUser;
using Core.DataAccess.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICourseLikedByUserService
    {
        Task<CreatedCourseLikedByUserResponse> AddAsync(CreateCourseLikedByUserRequest createCourseLikedByUserRequest);
        Task<IPaginate<GetListCourseLikedByUserResponse>> GetListAsync(PageRequest pageRequest);
        Task<DeletedCourseLikedByUserResponse> DeleteAsync(DeleteAnnouncementRequest deleteAnnouncementRequest);
        Task<GetCourseLikedByUserResponse> GetByIdAsync(GetCourseLikedByUserRequest getCourseLikedByUserRequest);
    }
}