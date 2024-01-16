﻿using AutoMapper;
using Business.Dtos.Requests.HomeworkFile;
using Business.Dtos.Responses.HomeworkFile;
using Core.DataAccess.Paging;
using Entities.Concretes.CrossTables;

namespace Business.Profiles;

public class HomeworkFileProfile : Profile
{
    public HomeworkFileProfile()
    {
        CreateMap<CreateHomeworkFileRequest, HomeworkFile>().ReverseMap();
        CreateMap<HomeworkFile, CreatedHomeworkFileResponse>().ReverseMap();

        CreateMap<DeleteHomeworkFileRequest, HomeworkFile>().ReverseMap();
        CreateMap<HomeworkFile, DeletedHomeworkFileResponse>().ReverseMap();

        CreateMap<UpdateHomeworkFileRequest, HomeworkFile>().ReverseMap();
        CreateMap<HomeworkFile, UpdatedHomeworkFileResponse>().ReverseMap();

        CreateMap<Paginate<HomeworkFile>, Paginate<GetListHomeworkFileResponse>>().ReverseMap();
        CreateMap<HomeworkFile, GetListHomeworkFileResponse>().ReverseMap();
    }
}
