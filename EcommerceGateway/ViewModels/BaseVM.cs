namespace EcommerceGateway.ViewModels
{
    public class BaseVM
    {
        public long Id { get; set; }
        // Audit fields 
        public string? CreateDate { get; set; }
        public long? CreatedBy { get; set; }
        public string? EditDate { get; set; }
        public long? EditedBy { get; set; }
        public string? EntityStatusText { get; set; }
    }
}
