﻿namespace FKFromAnotherDB.EFCore.Configurator.Models
{
    public class DeviceEntity
    {
        public int Id { get; set; }
        public string Protocol { get; set; }
        public string Name { get; set; }
        public List<SignalEntity> Signals { get; set; }
    }
}
