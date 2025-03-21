﻿using System;
using System.Collections.Generic;

namespace DevnotMentor.Api.Entities
{
    public partial class MenteeLinks
    {
        public int Id { get; set; }
        public int? MenteeId { get; set; }
        public int? LinkTypeId { get; set; }
        public string Link { get; set; }

        public virtual LinkType LinkType { get; set; }
        public virtual Mentee Mentee { get; set; }
    }
}
