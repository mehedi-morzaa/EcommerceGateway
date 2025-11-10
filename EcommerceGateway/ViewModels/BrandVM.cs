namespace EcommerceGateway.ViewModels
{
    public class BrandVM : BaseVM
    {
        public string? Name { get; set; }

        public string? ThumbImage { get; set; }

        public string? WebSite { get; set; }

        public int BrandTypeId { get; set; }

        public int ProductCount { get; init; } = 0;
    }
}
