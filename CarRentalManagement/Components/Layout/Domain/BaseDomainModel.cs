namespace CarRentalManagement.Components.Layout.Domain
{
    public class BaseDomainModel
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public String? CreatedBy { get; set; }
        public String? UpdatedBy { get; set; }
    }

}
