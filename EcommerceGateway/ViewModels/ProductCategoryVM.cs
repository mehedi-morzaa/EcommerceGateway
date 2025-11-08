namespace EcommerceGateway.ViewModels
{
    public class ProductCategoryVM : BaseVM
    {
        public Guid? CategoryId { get; init; }
        public string? CategoryName { get; init; }
        public string? SecondaryName { get; init; }
        public long? ParentCategoryId { get; init; }

        public int CatLevel { get; init; }

        public string? ThumbImage { get; init; }
        public string? IconImage { get; init; }
        public string? ImageAltText { get; init; }
        public int ProductCount { get; init; } = 0;
    }
}
