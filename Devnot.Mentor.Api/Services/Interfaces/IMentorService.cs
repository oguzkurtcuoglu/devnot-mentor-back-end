﻿using DevnotMentor.Api.Common;
using DevnotMentor.Api.Entities;
using DevnotMentor.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevnotMentor.Api.Services.Interfaces
{
    public interface IMentorService
    {
        ApiResponse<MentorProfileModel> GetMentorProfile(string userName);
        Task<ApiResponse<MentorProfileModel>> CreateMentorProfile(MentorProfileModel model);
        Task UpdateMentorProfile(MentorProfileModel model);
        Task<List<MentorProfileModel>> SearchMentor(SearchMentorModel model);
        Task<ApiResponse> AcceptMentee(int mentorUserId, int menteeUserId);
        Task<ApiResponse> RejectMentee(int mentorUserId, int menteeUserId);
    }
}
