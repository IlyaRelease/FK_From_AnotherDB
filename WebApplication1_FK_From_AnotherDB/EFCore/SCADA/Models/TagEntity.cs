﻿using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace WebApplication1_FK_From_AnotherDB.EFCore.SCADA.Models
{
    public class TagEntity
    {
        public Guid Id { get; set; }
        public string Property { get; set; }
    }
}