﻿using System.Collections.Generic;
using QuestStore.API.Dtos.Duplex;
using QuestStore.Core.Entities;

namespace QuestStore.API.Dtos.OutDtos
{
    public class StudentDetailedDto : ResourceDto
    {
        public string Surname { get; set; }
        public string Email { get; set; }
        public int Coins { get; set; }
        public ICollection<ArtifactBriefDto> Artifacts { get; set; }
        public ICollection<ClassroomBriefDto> Classrooms { get; set; }
    }
}
