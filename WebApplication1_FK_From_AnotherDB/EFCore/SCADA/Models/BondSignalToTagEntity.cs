namespace WebApplication1_FK_From_AnotherDB.EFCore.SCADA.Models
{
    public class BondSignalToTagEntity
    {
        public Guid TagId { get; set; }
        public Guid SignalId { get; set; }
        public TagEntity? TagEntity { get; set; }
    }
}