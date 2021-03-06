﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QuestStore.Core.Entities
{
    public abstract class ResourceEntity : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
