﻿using System;
using System.Collections.Generic;
using QuestStore.API.Dtos;
using QuestStore.API.Dtos.Duplex;
using QuestStore.API.Dtos.InDtos;
using QuestStore.API.Dtos.OutDtos;
using QuestStore.Core.Entities;

namespace QuestStore.API.GenericControllersFactory
{
    public static class ControllersTypes
    {
        public static Dictionary<Type, ControllerConfiguration> Configurations =>
            new Dictionary<Type, ControllerConfiguration>
            {
                {
                    typeof(Quest),
                    new ControllerConfiguration {ResponseType = typeof(Quest), RequestType = typeof(Quest)}
                },
                {
                    typeof(User),
                    new ControllerConfiguration {ResponseType = typeof(User), RequestType = typeof(User)}
                },
                {
                    typeof(Artifact),
                    new ControllerConfiguration
                    {
                        ResponseType = typeof(ArtifactDetailedDto),
                        RequestType = typeof(ArtifactDetailedDto)
                    }
                },
                {
                    typeof(Classroom),
                    new ControllerConfiguration
                    {
                        ResponseType = typeof(ClassroomDetailedDto),
                        RequestType = typeof(ClassroomRequestDto)
                    }
                },
                {
                    typeof(Student),
                    new ControllerConfiguration
                    {
                        ResponseType = typeof(StudentDetailedDto), RequestType = typeof(StudentRequestDto)
                    }
                },
                {
                    typeof(Mentor),
                    new ControllerConfiguration
                    {
                        ResponseType = typeof(MentorDetailedDto), RequestType = typeof(MentorRequestDto)
                    }
                }
            };
    }
}
