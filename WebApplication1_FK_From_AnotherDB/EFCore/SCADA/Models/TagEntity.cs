namespace FKFromAnotherDB.EFCore.SCADA.Models
{
    public class TagEntity
    {
        public Guid Id { get; set; }
        public string Property { get; set; }
        public BondSignalToTagEntity? BondSignalToTagEntity { get; set; }
    }
}