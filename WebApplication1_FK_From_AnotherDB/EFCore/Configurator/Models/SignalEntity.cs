﻿namespace WebApplication1_FK_From_AnotherDB.EFCore.Configurator.Models
{
    public class SignalEntity
    {
        public Guid Id { get; set; }
        public string Property { get; set; }
        public int DeviceId { get; set; }
        public DeviceEntity Device { get; set; }
    }
}