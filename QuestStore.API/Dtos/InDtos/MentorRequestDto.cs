﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuestStore.API.Dtos.Duplex;
using QuestStore.Core.Entities;

namespace QuestStore.API.Dtos.InDtos
{
    public class MentorRequestDto : ResourceDto
    {
        public string Role { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
    }
}
