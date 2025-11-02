namespace EcommerceGateway.ViewModels
{
    public class ProductVM : BaseVM
    {
        // master info
        public long ProductId { get; init; }
        public string ProductName { get; init; } = "";
        public string? ProductDescription { get; init; }
        public string? SecondaryProductName { get; set; }
        public string? SecondaryProductDescription { get; set; }
        public string? ProductCategoryName { get; init; }
        public string? BrandName { get; set; }


        // variant info
        public long ProductVariantId { get; init; }
        public string ProductVariantName { get; set; } = null!;
        public string? SecondaryProductVariantName { get; set; }
        public string? BarCode { get; set; }
        public decimal? SafetyStock { get; set; }
        public decimal? ReOrderingStock { get; set; }
        public string? SKU { get; set; } = null!;
        public string? VariantBy { get; set; }
        public string? VariantValue { get; set; }
        public string? ExpiryDate { get; set; }

        // Stock
        public decimal StockQty { get; set; }
        public bool IsInStock { get; set; }

        // promotion
        public bool IsOnPromotion { get; set; }
        public int PromotionType { get; set; }
        public string? PromotionTitle { get; set; }
        public decimal? Discount { get; set; }
        public decimal? FlatAmount { get; set; }
        public int? RequiredQty { get; set; }
        public int? DiscountedQty { get; set; }
        public string? PromotionEndDate { get; set; }

        // pricing
        public decimal? BasePrice { get; set; }
        public decimal? LatestPrice { get; set; }
    }
}
