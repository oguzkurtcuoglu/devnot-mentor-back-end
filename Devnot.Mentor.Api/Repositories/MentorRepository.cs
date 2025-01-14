﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevnotMentor.Api.Entities;
using DevnotMentor.Api.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DevnotMentor.Api.Repositories
{
    public class MentorRepository : BaseRepository<Mentor>, IMentorRepository
    {
        public MentorRepository(MentorDBContext context) : base(context)
        {
        }

        public async Task<int> GetIdByUserId(int userId)
        {
            return await DbContext.Mentor.Where(i => i.UserId == userId).Select(i => i.Id).FirstOrDefaultAsync();
        }

        public async Task<Mentor> GetByUserId(int userId)
        {
            return await DbContext.Mentor.Where(i => i.UserId == userId).FirstOrDefaultAsync();
        }

        public async Task<bool> IsExistsByUserId(int userId)
        {
            return await DbContext.Mentor.AnyAsync(i => i.UserId == userId);
        }
    }
}
