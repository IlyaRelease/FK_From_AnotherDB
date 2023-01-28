namespace WebApplication1_FK_From_AnotherDB.EFCore.SCADA.Models
{
    public class BondSignalToTagEntity
    {
        public Guid Id { get; set; }
        public Guid TagId { get; set; }
        public Guid SignalId { get; set; }
    }
}
