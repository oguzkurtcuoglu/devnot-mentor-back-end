﻿using DevnotMentor.Api.Entities;
using DevnotMentor.Api.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevnotMentor.Api.Repositories
{
    public class MentorLinksRepository : BaseRepository<MentorLinks>, IMentorLinksRepository
    {
        public MentorLinksRepository(MentorDBContext context) : base(context)
        {
        }

        public void Create(int mentorId, List<string> list)
        {
            foreach (var item in list)
            {
                Create(new MentorLinks { Link = item, MentorId = mentorId });
            }
        }
    }
}
