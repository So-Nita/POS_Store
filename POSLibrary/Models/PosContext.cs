using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace POSLibrary.Models;

public partial class PosContext : DbContext
{
    public PosContext()
    {
    }

    public PosContext(DbContextOptions<PosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<Advertisement> Advertisements { get; set; }

    public virtual DbSet<AdvertisementLayout> AdvertisementLayouts { get; set; }

    public virtual DbSet<AssetAccount> AssetAccounts { get; set; }

    public virtual DbSet<Attendance> Attendances { get; set; }

    public virtual DbSet<Attribute> Attributes { get; set; }

    public virtual DbSet<AttributeProduct> AttributeProducts { get; set; }

    public virtual DbSet<AttributeValue> AttributeValues { get; set; }

    public virtual DbSet<AuditTable> AuditTables { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Category1> Categories1 { get; set; }

    public virtual DbSet<CheckOutDetail> CheckOutDetails { get; set; }

    public virtual DbSet<CheckOutProductOption> CheckOutProductOptions { get; set; }

    public virtual DbSet<Checkout> Checkouts { get; set; }

    public virtual DbSet<CodePrefix> CodePrefixes { get; set; }

    public virtual DbSet<CodePrefixOwner> CodePrefixOwners { get; set; }

    public virtual DbSet<ConditionAndPrivacy> ConditionAndPrivacies { get; set; }

    public virtual DbSet<ContactU> ContactUs { get; set; }

    public virtual DbSet<CostOfGoodSoldAccount> CostOfGoodSoldAccounts { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<Cover> Covers { get; set; }

    public virtual DbSet<Currency> Currencies { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Delivery> Deliveries { get; set; }

    public virtual DbSet<DeliveryStatusType> DeliveryStatusTypes { get; set; }

    public virtual DbSet<DeliveryType> DeliveryTypes { get; set; }

    public virtual DbSet<Division> Divisions { get; set; }

    public virtual DbSet<DivisionDetail> DivisionDetails { get; set; }

    public virtual DbSet<DriverDetail> DriverDetails { get; set; }

    public virtual DbSet<EvaluateDelivery> EvaluateDeliveries { get; set; }

    public virtual DbSet<EvaluateShop> EvaluateShops { get; set; }

    public virtual DbSet<ExcelTemplate> ExcelTemplates { get; set; }

    public virtual DbSet<Favorite> Favorites { get; set; }

    public virtual DbSet<FavoritesShop> FavoritesShops { get; set; }

    public virtual DbSet<GroupUser> GroupUsers { get; set; }

    public virtual DbSet<IncomeAccount> IncomeAccounts { get; set; }

    public virtual DbSet<Logo> Logos { get; set; }

    public virtual DbSet<MaGazetteer> MaGazetteers { get; set; }

    public virtual DbSet<Measurement> Measurements { get; set; }

    public virtual DbSet<Menu> Menus { get; set; }

    public virtual DbSet<Migration> Migrations { get; set; }

    public virtual DbSet<Module> Modules { get; set; }

    public virtual DbSet<ModuleAccess> ModuleAccesses { get; set; }

    public virtual DbSet<ModuleAction> ModuleActions { get; set; }

    public virtual DbSet<ModuleRelModuleAction> ModuleRelModuleActions { get; set; }

    public virtual DbSet<Notification> Notifications { get; set; }

    public virtual DbSet<NotificationCustomer> NotificationCustomers { get; set; }

    public virtual DbSet<NotificationDriver> NotificationDrivers { get; set; }

    public virtual DbSet<NotificationSeen> NotificationSeens { get; set; }

    public virtual DbSet<OauthAccessToken> OauthAccessTokens { get; set; }

    public virtual DbSet<OauthAuthCode> OauthAuthCodes { get; set; }

    public virtual DbSet<OauthClient> OauthClients { get; set; }

    public virtual DbSet<OauthPersonalAccessClient> OauthPersonalAccessClients { get; set; }

    public virtual DbSet<OauthRefreshToken> OauthRefreshTokens { get; set; }

    public virtual DbSet<ParentCategory> ParentCategories { get; set; }

    public virtual DbSet<PasswordReset> PasswordResets { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }

    public virtual DbSet<PersonalAccessToken> PersonalAccessTokens { get; set; }

    public virtual DbSet<Privacy> Privacies { get; set; }

    public virtual DbSet<ProductByCategory> ProductByCategories { get; set; }

    public virtual DbSet<ProductHeader> ProductHeaders { get; set; }

    public virtual DbSet<ProductVarient> ProductVarients { get; set; }

    public virtual DbSet<Promotion> Promotions { get; set; }

    public virtual DbSet<PromotionsBogo> PromotionsBogos { get; set; }

    public virtual DbSet<PromotionsType> PromotionsTypes { get; set; }

    public virtual DbSet<PurchaseOrder> PurchaseOrders { get; set; }

    public virtual DbSet<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }

    public virtual DbSet<PurchaseOrderHeader> PurchaseOrderHeaders { get; set; }

    public virtual DbSet<PurchaseOrderStatus> PurchaseOrderStatuses { get; set; }

    public virtual DbSet<Quotation> Quotations { get; set; }

    public virtual DbSet<QuotationDetail> QuotationDetails { get; set; }

    public virtual DbSet<QuotationStatusType> QuotationStatusTypes { get; set; }

    public virtual DbSet<Ratting> Rattings { get; set; }

    public virtual DbSet<Receiving> Receivings { get; set; }

    public virtual DbSet<ReceivingDetail> ReceivingDetails { get; set; }

    public virtual DbSet<ReportingPurchaseOrder> ReportingPurchaseOrders { get; set; }

    public virtual DbSet<SellInvoice> SellInvoices { get; set; }

    public virtual DbSet<SellInvoiceCopy1> SellInvoiceCopy1s { get; set; }

    public virtual DbSet<SellOrder> SellOrders { get; set; }

    public virtual DbSet<SellOrderDetail> SellOrderDetails { get; set; }

    public virtual DbSet<SellOrderDetailProduct> SellOrderDetailProducts { get; set; }

    public virtual DbSet<Shop> Shops { get; set; }

    public virtual DbSet<ShopBranch> ShopBranches { get; set; }

    public virtual DbSet<ShopDistance> ShopDistances { get; set; }

    public virtual DbSet<ShopType> ShopTypes { get; set; }

    public virtual DbSet<Slider> Sliders { get; set; }

    public virtual DbSet<Static> Statics { get; set; }

    public virtual DbSet<StockBranchProduct> StockBranchProducts { get; set; }

    public virtual DbSet<StockBranchProductDetail> StockBranchProductDetails { get; set; }

    public virtual DbSet<StockProductAssign> StockProductAssigns { get; set; }

    public virtual DbSet<StockProductMove> StockProductMoves { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<TaxCode> TaxCodes { get; set; }

    public virtual DbSet<TrackDriver> TrackDrivers { get; set; }

    public virtual DbSet<Translate> Translates { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserLog> UserLogs { get; set; }

    public virtual DbSet<UsersDetail> UsersDetails { get; set; }

    public virtual DbSet<WebsocketsStatisticsEntry> WebsocketsStatisticsEntries { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseMySql("server=172.26.16.90;database=pos;port=3306;user=POS01;password=ttDev@2023;persist security info=False;connect timeout=120", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.35-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Address>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("addresses")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(255)
                .HasColumnName("customer_id");
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .HasColumnName("image");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.Lat).HasColumnName("lat");
            entity.Property(e => e.Lng).HasColumnName("lng");
            entity.Property(e => e.Location)
                .HasMaxLength(255)
                .HasColumnName("location");
            entity.Property(e => e.LocationType)
                .HasMaxLength(255)
                .HasColumnName("location_type");
            entity.Property(e => e.Note)
                .HasMaxLength(255)
                .HasColumnName("note");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(255)
                .HasColumnName("phone_number");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Advertisement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("advertisement");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.ImgPath)
                .HasMaxLength(255)
                .HasColumnName("img_path");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("false")
                .HasColumnName("is_deleted");
            entity.Property(e => e.Layout).HasColumnName("layout");
            entity.Property(e => e.Link)
                .HasMaxLength(255)
                .HasColumnName("link");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("true")
                .HasColumnName("status");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<AdvertisementLayout>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("advertisement_layout");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.Hiegh).HasColumnName("hiegh");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("false")
                .HasColumnName("is_deleted");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("true")
                .HasColumnName("status");
            entity.Property(e => e.Width).HasColumnName("width");
        });

        modelBuilder.Entity<AssetAccount>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("asset_account")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AssetAccount1)
                .HasMaxLength(255)
                .HasColumnName("asset_account");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Attendance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("attendances")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AttendanceAddress)
                .HasMaxLength(255)
                .HasColumnName("attendance_address");
            entity.Property(e => e.AttendanceDate).HasColumnName("attendance_date");
            entity.Property(e => e.AttendanceLat).HasColumnName("attendance_lat");
            entity.Property(e => e.AttendanceLong).HasColumnName("attendance_long");
            entity.Property(e => e.AttendanceStatus).HasColumnName("attendance_status");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.DriverId).HasColumnName("driver_id");
            entity.Property(e => e.Reason)
                .HasColumnType("text")
                .HasColumnName("reason");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Attribute>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("attribute")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name")
                .UseCollation("utf8mb4_0900_ai_ci");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<AttributeProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("attribute_product")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AttributeId).HasColumnName("attribute_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.ProductId)
                .HasMaxLength(255)
                .HasColumnName("product_id");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
            entity.Property(e => e.VarientId).HasColumnName("varient_id");
            entity.Property(e => e.VarientName)
                .HasMaxLength(200)
                .HasColumnName("varient_name");
        });

        modelBuilder.Entity<AttributeValue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("attribute_value");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AttrValue)
                .HasMaxLength(250)
                .HasColumnName("attr_value");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.IsDelete)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_delete");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<AuditTable>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("audit_table");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateBy).HasColumnName("create_by");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("create_date");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.NewValue)
                .HasMaxLength(500)
                .HasColumnName("new_value");
            entity.Property(e => e.OldValue)
                .HasMaxLength(500)
                .HasColumnName("old_value");
            entity.Property(e => e.RowId).HasColumnName("row_id");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
            entity.Property(e => e.TableName)
                .HasMaxLength(255)
                .HasColumnName("table_name");
            entity.Property(e => e.Tyle)
                .HasColumnType("enum('insert','update','delete')")
                .HasColumnName("tyle");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("categories")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .HasColumnName("image");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.ParentCategoryId).HasColumnName("parent_category_id");
            entity.Property(e => e.ShopId).HasColumnName("shop_id");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'ENABLE'")
                .HasColumnType("enum('ENABLE','DISABLE','DELETE')")
                .HasColumnName("status");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .HasColumnName("type");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Category1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("category");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Image)
                .HasMaxLength(250)
                .HasColumnName("image");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.MenuId).HasColumnName("menu_id");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .HasColumnName("name");
            entity.Property(e => e.ParentId).HasColumnName("parent_id");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
        });

        modelBuilder.Entity<CheckOutDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("check_out_detail");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CheckOutId).HasColumnName("check_out_id");
            entity.Property(e => e.Choices)
                .HasColumnType("text")
                .HasColumnName("choices")
                .UseCollation("utf8mb4_unicode_ci");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnName("discount");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.ProductName)
                .HasMaxLength(191)
                .HasColumnName("product_name")
                .UseCollation("utf8mb4_unicode_ci");
            entity.Property(e => e.Quantity)
                .HasDefaultValueSql("'1'")
                .HasColumnName("quantity");
            entity.Property(e => e.ShippingCost)
                .HasColumnType("double(8,2)")
                .HasColumnName("shipping_cost");
            entity.Property(e => e.ShippingType)
                .HasMaxLength(191)
                .HasColumnName("shipping_type")
                .UseCollation("utf8mb4_unicode_ci");
            entity.Property(e => e.ShopId).HasColumnName("shop_id");
            entity.Property(e => e.ShopInfo)
                .HasMaxLength(191)
                .HasColumnName("shop_info")
                .UseCollation("utf8mb4_unicode_ci");
            entity.Property(e => e.Tax).HasColumnName("tax");
            entity.Property(e => e.Thumbnail)
                .HasMaxLength(191)
                .HasColumnName("thumbnail")
                .UseCollation("utf8mb4_unicode_ci");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<CheckOutProductOption>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("check_out_product_option");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CheckOutDetailId).HasColumnName("check_out_detail_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.SizeProductId).HasColumnName("size_product_id");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Checkout>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("checkout");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.Discount).HasColumnName("discount");
            entity.Property(e => e.GrandTotal).HasColumnName("grand_total");
            entity.Property(e => e.SaleType)
                .HasMaxLength(255)
                .HasDefaultValueSql("'online'")
                .HasColumnName("sale_type");
            entity.Property(e => e.Shipping).HasColumnName("shipping");
            entity.Property(e => e.Tax)
                .HasMaxLength(255)
                .HasColumnName("tax");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<CodePrefix>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("code_prefix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateBy).HasColumnName("create_by");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("create_date");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.NameEn)
                .HasMaxLength(255)
                .HasColumnName("name_en");
            entity.Property(e => e.NameKh)
                .HasMaxLength(255)
                .HasColumnName("name_kh");
            entity.Property(e => e.Prefix)
                .HasMaxLength(255)
                .HasColumnName("prefix");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
        });

        modelBuilder.Entity<CodePrefixOwner>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("code_prefix_owner");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ChildFormat)
                .HasMaxLength(255)
                .HasColumnName("child_format");
            entity.Property(e => e.CodePrefixId).HasColumnName("code_prefix_id");
            entity.Property(e => e.CreateBy).HasColumnName("create_by");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("create_date");
            entity.Property(e => e.CurrentValue).HasColumnName("current_value");
            entity.Property(e => e.Format)
                .HasMaxLength(255)
                .HasColumnName("format");
            entity.Property(e => e.Id1).HasColumnName("_id");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.MinValue).HasColumnName("min_value");
            entity.Property(e => e.ParentId).HasColumnName("parent_id");
            entity.Property(e => e.ShopBranchDetailId).HasColumnName("shop_branch_detail_id");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<ConditionAndPrivacy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("condition_and_privacy");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("create_date");
            entity.Property(e => e.DescriptionEn)
                .HasMaxLength(2000)
                .HasColumnName("description_en");
            entity.Property(e => e.DescriptionKh)
                .HasMaxLength(2000)
                .HasColumnName("description_kh");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
            entity.Property(e => e.TitleEn)
                .HasMaxLength(255)
                .HasColumnName("title_en");
            entity.Property(e => e.TitleKh)
                .HasMaxLength(255)
                .HasColumnName("title_kh");
            entity.Property(e => e.Type)
                .HasColumnType("enum('Privacy Policy','Terms & Conditions')")
                .HasColumnName("type");
        });

        modelBuilder.Entity<ContactU>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("contact_us")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Message)
                .HasMaxLength(255)
                .HasColumnName("message");
            entity.Property(e => e.ShopId).HasColumnName("shop_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<CostOfGoodSoldAccount>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("cost_of_good_sold_account")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CostOfGoodSold)
                .HasMaxLength(255)
                .HasColumnName("cost_of_good_sold");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("country");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Cover>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("cover");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.Source)
                .HasMaxLength(255)
                .HasColumnName("source");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
        });

        modelBuilder.Entity<Currency>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("currency");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.CreateBy).HasColumnName("create_by");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("create_date");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.Name)
                .HasMaxLength(25)
                .HasColumnName("name");
            entity.Property(e => e.NameKh)
                .HasMaxLength(250)
                .HasColumnName("name_kh");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("customers");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(191)
                .HasColumnName("company_name");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6)")
                .HasColumnName("created_at");
            entity.Property(e => e.DeletedAt)
                .HasColumnType("timestamp")
                .HasColumnName("deleted_at");
            entity.Property(e => e.Email)
                .HasMaxLength(192)
                .HasColumnName("email");
            entity.Property(e => e.GazetteersCode)
                .HasMaxLength(191)
                .HasColumnName("gazetteersCode");
            entity.Property(e => e.HomeNumber)
                .HasMaxLength(255)
                .HasColumnName("home_number");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.Name)
                .HasMaxLength(191)
                .HasColumnName("name")
                .UseCollation("utf8mb4_unicode_ci");
            entity.Property(e => e.Phone)
                .HasMaxLength(255)
                .HasColumnName("phone")
                .UseCollation("utf8mb4_unicode_ci");
            entity.Property(e => e.ShopId).HasColumnName("shop_id");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
            entity.Property(e => e.StreetNumber)
                .HasMaxLength(255)
                .HasColumnName("street_number");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6)")
                .HasColumnName("updated_at");
            entity.Property(e => e.VatNumber)
                .HasMaxLength(255)
                .HasColumnName("vat_number");
        });

        modelBuilder.Entity<Delivery>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("delivery")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.DeliveryNumber)
                .HasMaxLength(10)
                .HasColumnName("delivery_number");
            entity.Property(e => e.DeliveryStatusTypeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("delivery_status_type_id");
            entity.Property(e => e.DriverId).HasColumnName("driver_id");
            entity.Property(e => e.SellOrderId).HasColumnName("sell_order_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<DeliveryStatusType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("delivery_status_type");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Color)
                .HasMaxLength(255)
                .HasColumnName("color");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.IsDeleted)
                .HasMaxLength(255)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<DeliveryType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("delivery_type");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Division>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("division");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.DivisionCode).HasColumnName("division_code");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.ShopId).HasColumnName("shop_id");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<DivisionDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("division_detail");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateBy).HasColumnName("create_by");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("create_date");
            entity.Property(e => e.DivisionId).HasColumnName("division_id");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
        });

        modelBuilder.Entity<DriverDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("driver_detail")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AddressCode)
                .HasMaxLength(20)
                .HasColumnName("address_code")
                .UseCollation("utf8mb4_0900_ai_ci");
            entity.Property(e => e.AddressFull)
                .HasMaxLength(200)
                .HasColumnName("address_full")
                .UseCollation("utf8mb4_0900_ai_ci");
            entity.Property(e => e.BirthDate)
                .HasColumnType("timestamp")
                .HasColumnName("birth_date");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Gender)
                .HasColumnType("enum('male','female')")
                .HasColumnName("gender")
                .UseCollation("utf8mb4_0900_ai_ci");
            entity.Property(e => e.IdCard)
                .HasMaxLength(15)
                .HasColumnName("id_card")
                .UseCollation("utf8mb4_0900_ai_ci");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.JoinDate)
                .HasColumnType("timestamp")
                .HasColumnName("join_date");
            entity.Property(e => e.LicenseExpire)
                .HasColumnType("timestamp")
                .HasColumnName("license_expire");
            entity.Property(e => e.LicenseIssued)
                .HasColumnType("timestamp")
                .HasColumnName("license_issued");
            entity.Property(e => e.LicenseNumber)
                .HasMaxLength(50)
                .HasColumnName("license_number")
                .UseCollation("utf8mb4_0900_ai_ci");
            entity.Property(e => e.NameEn)
                .HasMaxLength(50)
                .HasColumnName("name_en")
                .UseCollation("utf8mb4_0900_ai_ci");
            entity.Property(e => e.NameKh)
                .HasMaxLength(50)
                .HasColumnName("name_kh")
                .UseCollation("utf8mb4_0900_ai_ci");
            entity.Property(e => e.ShopId).HasColumnName("shop_id");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
            entity.Property(e => e.UsersId).HasColumnName("users_id");
            entity.Property(e => e.VehicleModel)
                .HasMaxLength(50)
                .HasColumnName("vehicle_model")
                .UseCollation("utf8mb4_0900_ai_ci");
            entity.Property(e => e.VehicleType)
                .HasColumnType("enum('car','moto','bike')")
                .HasColumnName("vehicle_type")
                .UseCollation("utf8mb4_0900_ai_ci");
        });

        modelBuilder.Entity<EvaluateDelivery>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("evaluate_delivery")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.SellOrderId).HasColumnName("sell_order_id");
            entity.Property(e => e.Star)
                .HasMaxLength(255)
                .HasColumnName("star")
                .UseCollation("utf8mb4_0900_ai_ci");
        });

        modelBuilder.Entity<EvaluateShop>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("evaluate_shop")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.SellOrderId).HasColumnName("sell_order_id");
            entity.Property(e => e.Star)
                .HasMaxLength(255)
                .HasColumnName("star")
                .UseCollation("utf8mb4_0900_ai_ci");
        });

        modelBuilder.Entity<ExcelTemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("excel_template");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.ExcelPath)
                .HasMaxLength(255)
                .HasColumnName("excel_path");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Favorite>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("favorites")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(255)
                .HasColumnName("customer_id");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.ProductId)
                .HasMaxLength(255)
                .HasColumnName("product_id");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<FavoritesShop>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("favorites_shop")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(255)
                .HasColumnName("customer_id");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.ShopId)
                .HasMaxLength(255)
                .HasColumnName("shop_id");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<GroupUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("group_user");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateBy).HasColumnName("create_by");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("create_date");
            entity.Property(e => e.GroupType)
                .HasMaxLength(50)
                .HasColumnName("group_type");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Sequence).HasColumnName("sequence");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
        });

        modelBuilder.Entity<IncomeAccount>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("income_account");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.IncomeAccount1)
                .HasMaxLength(255)
                .HasColumnName("income_account")
                .UseCollation("utf8mb4_unicode_ci");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Logo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("logo");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cover)
                .HasMaxLength(255)
                .HasColumnName("cover");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Source)
                .HasMaxLength(255)
                .HasColumnName("source");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .HasColumnName("type");
        });

        modelBuilder.Entity<MaGazetteer>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ma_gazetteers");

            entity.Property(e => e.Code)
                .HasMaxLength(255)
                .HasColumnName("code");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(255)
                .HasColumnName("create_by");
            entity.Property(e => e.CreateDate)
                .HasMaxLength(255)
                .HasColumnName("create_date");
            entity.Property(e => e.FullAddress)
                .HasMaxLength(255)
                .HasColumnName("full_address");
            entity.Property(e => e.Id)
                .HasMaxLength(255)
                .HasColumnName("id");
            entity.Property(e => e.IsDeleted)
                .HasMaxLength(255)
                .HasColumnName("is_deleted");
            entity.Property(e => e.Latlg)
                .HasMaxLength(255)
                .HasColumnName("latlg");
            entity.Property(e => e.NameKh)
                .HasMaxLength(255)
                .HasColumnName("name_kh");
            entity.Property(e => e.NameLatin)
                .HasMaxLength(255)
                .HasColumnName("name_latin");
            entity.Property(e => e.Note)
                .HasMaxLength(255)
                .HasColumnName("note");
            entity.Property(e => e.OfficialNote)
                .HasMaxLength(255)
                .HasColumnName("official_note");
            entity.Property(e => e.Reference)
                .HasMaxLength(255)
                .HasColumnName("reference");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasColumnName("status");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .HasColumnName("type");
        });

        modelBuilder.Entity<Measurement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("measurement");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(255)
                .HasColumnName("create_by");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Description)
                .HasMaxLength(2000)
                .HasColumnName("description");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.NameAbbr)
                .HasMaxLength(255)
                .HasColumnName("name_abbr");
            entity.Property(e => e.NameKh)
                .HasMaxLength(255)
                .HasColumnName("name_kh");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
            entity.Property(e => e.Types)
                .HasMaxLength(20)
                .HasColumnName("types");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Menu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("menu");

            entity.HasIndex(e => e.RouteHandle, "menu_UN").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.DivisionId).HasColumnName("division_id");
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .HasColumnName("image");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.MenuCode).HasColumnName("menu_code");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.RouteHandle)
                .HasMaxLength(100)
                .HasColumnName("route_handle");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Migration>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("migrations")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Batch).HasColumnName("batch");
            entity.Property(e => e.Migration1)
                .HasMaxLength(255)
                .HasColumnName("migration");
        });

        modelBuilder.Entity<Module>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("module");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(255)
                .HasColumnName("code");
            entity.Property(e => e.CreateBy).HasColumnName("create_by");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("create_date");
            entity.Property(e => e.Icode).HasColumnName("icode");
            entity.Property(e => e.Icon)
                .HasMaxLength(255)
                .HasColumnName("icon");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.IsShow)
                .HasDefaultValueSql("'1'")
                .HasColumnName("is_show");
            entity.Property(e => e.Link)
                .HasMaxLength(255)
                .HasColumnName("link");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.ParentId).HasColumnName("parent_id");
            entity.Property(e => e.Sequence).HasColumnName("sequence");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .HasColumnName("type");
        });

        modelBuilder.Entity<ModuleAccess>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("module_access");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateBy).HasColumnName("create_by");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("create_date");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.MaGroupId).HasColumnName("ma_group_id");
            entity.Property(e => e.MaModuleId).HasColumnName("ma_module_id");
            entity.Property(e => e.MaUserId).HasColumnName("ma_user_id");
            entity.Property(e => e.ModuleCheck).HasColumnName("module_check");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
        });

        modelBuilder.Entity<ModuleAction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("module_action");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateBy).HasColumnName("create_by");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("create_date");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .HasColumnName("name");
            entity.Property(e => e.Sequence).HasColumnName("sequence");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasColumnName("type");
        });

        modelBuilder.Entity<ModuleRelModuleAction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("module_rel_module_action");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateBy).HasColumnName("create_by");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("create_date");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.ModuleActionId).HasColumnName("module_action_id");
            entity.Property(e => e.ModuleId).HasColumnName("module_id");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
        });

        modelBuilder.Entity<Notification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("notifications")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.NotifiableType, e.NotifiableId }, "notifications_notifiable_type_notifiable_id_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Data)
                .HasColumnType("text")
                .HasColumnName("data");
            entity.Property(e => e.NotifiableId).HasColumnName("notifiable_id");
            entity.Property(e => e.NotifiableType).HasColumnName("notifiable_type");
            entity.Property(e => e.ReadAt)
                .HasColumnType("timestamp")
                .HasColumnName("read_at");
            entity.Property(e => e.SeenBy).HasColumnName("seen_by");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .HasColumnName("type");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<NotificationCustomer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("notification_customer");

            entity.HasIndex(e => e.Id, "id").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .HasColumnName("description");
            entity.Property(e => e.Image)
                .HasMaxLength(250)
                .HasColumnName("image");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.PromotionId).HasColumnName("promotion_id");
            entity.Property(e => e.SellOrderId).HasColumnName("sell_order_id");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
            entity.Property(e => e.Title)
                .HasMaxLength(250)
                .HasColumnName("title");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<NotificationDriver>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("notification_driver");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.DriverId).HasColumnName("driver_id");
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .HasColumnName("image");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<NotificationSeen>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("notification_seen");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.RequestStatus).HasColumnName("request_status");
            entity.Property(e => e.SeenBy).HasColumnName("seen_by");
            entity.Property(e => e.SeenDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("seen_date");
            entity.Property(e => e.SeenType)
                .HasMaxLength(20)
                .HasColumnName("seen_type");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
            entity.Property(e => e.TableId).HasColumnName("table_id");
            entity.Property(e => e.TableName)
                .HasMaxLength(50)
                .HasColumnName("table_name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<OauthAccessToken>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("oauth_access_tokens")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.UserId, "oauth_access_tokens_user_id_index");

            entity.Property(e => e.Id)
                .HasMaxLength(100)
                .HasColumnName("id");
            entity.Property(e => e.ClientId).HasColumnName("client_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.ExpiresAt)
                .HasColumnType("datetime")
                .HasColumnName("expires_at");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Revoked).HasColumnName("revoked");
            entity.Property(e => e.Scopes)
                .HasColumnType("text")
                .HasColumnName("scopes");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<OauthAuthCode>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("oauth_auth_codes")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.UserId, "oauth_auth_codes_user_id_index");

            entity.Property(e => e.Id)
                .HasMaxLength(100)
                .HasColumnName("id");
            entity.Property(e => e.ClientId).HasColumnName("client_id");
            entity.Property(e => e.ExpiresAt)
                .HasColumnType("datetime")
                .HasColumnName("expires_at");
            entity.Property(e => e.Revoked).HasColumnName("revoked");
            entity.Property(e => e.Scopes)
                .HasColumnType("text")
                .HasColumnName("scopes");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<OauthClient>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("oauth_clients")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.UserId, "oauth_clients_user_id_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.PasswordClient).HasColumnName("password_client");
            entity.Property(e => e.PersonalAccessClient).HasColumnName("personal_access_client");
            entity.Property(e => e.Provider)
                .HasMaxLength(255)
                .HasColumnName("provider");
            entity.Property(e => e.Redirect)
                .HasColumnType("text")
                .HasColumnName("redirect");
            entity.Property(e => e.Revoked).HasColumnName("revoked");
            entity.Property(e => e.Secret)
                .HasMaxLength(100)
                .HasColumnName("secret");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<OauthPersonalAccessClient>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("oauth_personal_access_clients")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ClientId).HasColumnName("client_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<OauthRefreshToken>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("oauth_refresh_tokens")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.AccessTokenId, "oauth_refresh_tokens_access_token_id_index");

            entity.Property(e => e.Id)
                .HasMaxLength(100)
                .HasColumnName("id");
            entity.Property(e => e.AccessTokenId)
                .HasMaxLength(100)
                .HasColumnName("access_token_id");
            entity.Property(e => e.ExpiresAt)
                .HasColumnType("datetime")
                .HasColumnName("expires_at");
            entity.Property(e => e.Revoked).HasColumnName("revoked");
        });

        modelBuilder.Entity<ParentCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("parent_category");

            entity.HasIndex(e => e.RouteHandle, "parent_category_UN").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .HasColumnName("image");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.MenuId).HasColumnName("menu_id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.RouteHandle)
                .HasMaxLength(100)
                .HasColumnName("route_handle")
                .UseCollation("utf8mb4_unicode_ci");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<PasswordReset>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("password_resets")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Phone, "password_resets_phone_index");

            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Phone).HasColumnName("phone");
            entity.Property(e => e.Token)
                .HasMaxLength(255)
                .HasColumnName("token");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("payments")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasPrecision(24, 4)
                .HasColumnName("amount");
            entity.Property(e => e.Attachment)
                .HasMaxLength(55)
                .HasColumnName("attachment");
            entity.Property(e => e.CcHolder)
                .HasMaxLength(25)
                .HasColumnName("cc_holder");
            entity.Property(e => e.CcMonth)
                .HasMaxLength(2)
                .HasColumnName("cc_month");
            entity.Property(e => e.CcNo)
                .HasMaxLength(20)
                .HasColumnName("cc_no");
            entity.Property(e => e.CcType)
                .HasMaxLength(20)
                .HasColumnName("cc_type");
            entity.Property(e => e.CcYear)
                .HasMaxLength(4)
                .HasColumnName("cc_year");
            entity.Property(e => e.ChequeNo)
                .HasMaxLength(20)
                .HasColumnName("cheque_no");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasColumnName("currency");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.Date)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("date");
            entity.Property(e => e.GcNo)
                .HasMaxLength(20)
                .HasColumnName("gc_no");
            entity.Property(e => e.Note)
                .HasMaxLength(1000)
                .HasColumnName("note");
            entity.Property(e => e.PaidBy)
                .HasMaxLength(20)
                .HasColumnName("paid_by");
            entity.Property(e => e.PosBalance)
                .HasPrecision(25, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasColumnName("pos_balance");
            entity.Property(e => e.PosPaid)
                .HasPrecision(25, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasColumnName("pos_paid");
            entity.Property(e => e.Reference)
                .HasMaxLength(50)
                .HasColumnName("reference");
            entity.Property(e => e.SaleId).HasColumnName("sale_id");
            entity.Property(e => e.StoreId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("store_id");
            entity.Property(e => e.TransactionId)
                .HasMaxLength(50)
                .HasColumnName("transaction_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
        });

        modelBuilder.Entity<PaymentMethod>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("payment_method");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .HasColumnName("image");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
        });

        modelBuilder.Entity<PersonalAccessToken>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("personal_access_tokens")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Token, "personal_access_tokens_token_unique").IsUnique();

            entity.HasIndex(e => new { e.TokenableType, e.TokenableId }, "personal_access_tokens_tokenable_type_tokenable_id_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Abilities)
                .HasColumnType("text")
                .HasColumnName("abilities");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.LastUsedAt)
                .HasColumnType("timestamp")
                .HasColumnName("last_used_at");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Token)
                .HasMaxLength(64)
                .HasColumnName("token");
            entity.Property(e => e.TokenableId).HasColumnName("tokenable_id");
            entity.Property(e => e.TokenableType).HasColumnName("tokenable_type");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Privacy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("privacies")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'ENABLE'")
                .HasColumnType("enum('ENABLE','DISABLE')")
                .HasColumnName("status");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<ProductByCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("product_by_categories")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.Barcode)
                .HasMaxLength(255)
                .HasColumnName("barcode");
            entity.Property(e => e.Brand)
                .HasMaxLength(250)
                .HasColumnName("brand");
            entity.Property(e => e.CategoryId).HasColumnName("category_id");
            entity.Property(e => e.ChoiceOptions)
                .HasColumnType("text")
                .HasColumnName("choice_options");
            entity.Property(e => e.Code)
                .HasMaxLength(255)
                .HasColumnName("code");
            entity.Property(e => e.CodePrefixOwnerId).HasColumnName("code_prefix_owner_id");
            entity.Property(e => e.Cost)
                .HasColumnType("double(8,2)")
                .HasColumnName("cost");
            entity.Property(e => e.CreateBy).HasColumnName("create_by");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Currency)
                .HasDefaultValueSql("'USD'")
                .HasColumnType("enum('USD','RIEL')")
                .HasColumnName("currency");
            entity.Property(e => e.CurrencyId).HasColumnName("currency_id");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnName("discount");
            entity.Property(e => e.DiscountType)
                .HasDefaultValueSql("'percent'")
                .HasColumnType("enum('percent','price')")
                .HasColumnName("discount_type");
            entity.Property(e => e.ExpirationDate)
                .HasMaxLength(255)
                .HasColumnName("expiration_date");
            entity.Property(e => e.Filename)
                .HasMaxLength(255)
                .HasColumnName("filename");
            entity.Property(e => e.Gp)
                .HasMaxLength(255)
                .HasColumnName("gp");
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .HasColumnName("image");
            entity.Property(e => e.ImageThumbnail)
                .HasMaxLength(255)
                .HasColumnName("image_thumbnail");
            entity.Property(e => e.ItemCode).HasColumnName("item_code");
            entity.Property(e => e.LastSoldDate)
                .HasColumnType("timestamp")
                .HasColumnName("last_sold_date");
            entity.Property(e => e.LastStockPurchase)
                .HasColumnType("timestamp")
                .HasColumnName("last_stock_purchase");
            entity.Property(e => e.MeasurementId).HasColumnName("measurement_id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.NameKh)
                .HasMaxLength(255)
                .HasColumnName("name_kh");
            entity.Property(e => e.Path)
                .HasMaxLength(255)
                .HasColumnName("path");
            entity.Property(e => e.Pathfile)
                .HasMaxLength(255)
                .HasColumnName("pathfile");
            entity.Property(e => e.Price)
                .HasColumnType("double(11,2)")
                .HasColumnName("price");
            entity.Property(e => e.Qty).HasColumnName("qty");
            entity.Property(e => e.ShopId).HasColumnName("shop_id");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'ENABLE'")
                .HasColumnType("enum('ENABLE','DISABLE','DELETE')")
                .HasColumnName("status");
            entity.Property(e => e.Taxation)
                .HasDefaultValueSql("'0'")
                .HasColumnName("taxation");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .HasColumnName("type");
            entity.Property(e => e.UnitPrice)
                .HasDefaultValueSql("'0'")
                .HasColumnName("unit_price");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
            entity.Property(e => e.VendorId).HasColumnName("vendor_id");
        });

        modelBuilder.Entity<ProductHeader>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("product_header");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.HeaderId)
                .HasMaxLength(255)
                .HasColumnName("header_id");
            entity.Property(e => e.HeaderName)
                .HasMaxLength(255)
                .HasColumnName("header_name");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
        });

        modelBuilder.Entity<ProductVarient>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("product_varient");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AssetAccountId).HasColumnName("asset_account_id");
            entity.Property(e => e.Cost).HasColumnName("cost");
            entity.Property(e => e.CostOfGoodSoldId).HasColumnName("cost_of_good_sold_id");
            entity.Property(e => e.Country)
                .HasMaxLength(250)
                .HasColumnName("country");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.DeliveryTypeId).HasColumnName("delivery_type_id");
            entity.Property(e => e.EstimationGp).HasColumnName("estimation_gp");
            entity.Property(e => e.IncomeAccountId).HasColumnName("income_account_id");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.ItemNumber).HasColumnName("item_number");
            entity.Property(e => e.Moq)
                .HasMaxLength(250)
                .HasColumnName("moq");
            entity.Property(e => e.Picking)
                .HasMaxLength(250)
                .HasColumnName("picking");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.Qty)
                .HasDefaultValueSql("'0'")
                .HasColumnName("qty");
            entity.Property(e => e.Remark)
                .HasMaxLength(250)
                .HasColumnName("remark");
            entity.Property(e => e.ReturnPolicy)
                .HasMaxLength(250)
                .HasColumnName("return_policy");
            entity.Property(e => e.SaleGp).HasColumnName("sale_gp");
            entity.Property(e => e.ShelfLife)
                .HasMaxLength(250)
                .HasColumnName("shelf_life");
            entity.Property(e => e.Size)
                .HasMaxLength(250)
                .HasColumnName("size");
            entity.Property(e => e.Sku)
                .HasMaxLength(255)
                .HasColumnName("sku");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
            entity.Property(e => e.TaxCodeId).HasColumnName("tax_code_id");
            entity.Property(e => e.Upc)
                .HasMaxLength(250)
                .HasColumnName("upc");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
            entity.Property(e => e.Varient)
                .HasMaxLength(255)
                .HasColumnName("varient");
        });

        modelBuilder.Entity<Promotion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("promotions")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.EndDate)
                .HasMaxLength(255)
                .HasColumnName("end_date");
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .HasColumnName("image");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Other)
                .HasMaxLength(255)
                .HasColumnName("other");
            entity.Property(e => e.ProductId)
                .HasMaxLength(255)
                .HasColumnName("product_id");
            entity.Property(e => e.Promotion1).HasColumnName("promotion");
            entity.Property(e => e.PromotionPercent)
                .HasDefaultValueSql("'0'")
                .HasColumnName("promotion_percent");
            entity.Property(e => e.PromotionQty)
                .HasDefaultValueSql("'0'")
                .HasColumnName("promotion_qty");
            entity.Property(e => e.PromotionsTypeId).HasColumnName("promotions_type_id");
            entity.Property(e => e.ShopId).HasColumnName("shop_id");
            entity.Property(e => e.StartDate)
                .HasMaxLength(255)
                .HasColumnName("start_date");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
            entity.Property(e => e.SubCategoryId).HasColumnName("sub_category_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<PromotionsBogo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("promotions_bogo");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BuyValue).HasColumnName("buy_value");
            entity.Property(e => e.GetValue).HasColumnName("get_value");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.PromotionsId).HasColumnName("promotions_id");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
        });

        modelBuilder.Entity<PromotionsType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("promotions_type");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsDeleted)
                .HasMaxLength(255)
                .HasColumnName("is_deleted");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasColumnName("status");
        });

        modelBuilder.Entity<PurchaseOrder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("purchase_order");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CategoryId).HasColumnName("category_id");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("create_date");
            entity.Property(e => e.DeliveryDate)
                .HasMaxLength(250)
                .HasColumnName("delivery_date");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.OrderDate)
                .HasMaxLength(250)
                .HasColumnName("order_date");
            entity.Property(e => e.PoNo)
                .HasMaxLength(255)
                .HasColumnName("po_no");
            entity.Property(e => e.PostDate)
                .HasMaxLength(250)
                .HasColumnName("post_date");
            entity.Property(e => e.ReferenceId).HasColumnName("reference_id");
            entity.Property(e => e.ReferenceName)
                .HasMaxLength(250)
                .HasColumnName("reference_name");
            entity.Property(e => e.Remarks)
                .HasMaxLength(250)
                .HasColumnName("remarks");
            entity.Property(e => e.SellFromDate)
                .HasMaxLength(250)
                .HasColumnName("sell_from_date");
            entity.Property(e => e.SellToDate)
                .HasMaxLength(250)
                .HasColumnName("sell_to_date");
            entity.Property(e => e.ShopId).HasColumnName("shop_id");
            entity.Property(e => e.ShopName)
                .HasMaxLength(250)
                .HasColumnName("shop_name");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
            entity.Property(e => e.StatusFilterId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status_filter_id");
            entity.Property(e => e.TotalCost).HasColumnName("total_cost");
            entity.Property(e => e.TotalQty).HasColumnName("total_qty");
            entity.Property(e => e.TransactionDate)
                .HasMaxLength(250)
                .HasColumnName("transaction_date");
            entity.Property(e => e.TransactionNo).HasColumnName("transaction_no");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6)")
                .HasColumnName("updated_at");
            entity.Property(e => e.VendorId).HasColumnName("vendor_id");
            entity.Property(e => e.VendorName)
                .HasMaxLength(250)
                .HasColumnName("vendor_name");
        });

        modelBuilder.Entity<PurchaseOrderDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("purchase_order_detail");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Barcode).HasColumnName("barcode");
            entity.Property(e => e.Cost).HasColumnName("cost");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("create_date");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.ItemNumber).HasColumnName("item_number");
            entity.Property(e => e.NameEng)
                .HasMaxLength(250)
                .HasColumnName("name_eng");
            entity.Property(e => e.NameKh)
                .HasMaxLength(250)
                .HasColumnName("name_kh");
            entity.Property(e => e.OrderQty).HasColumnName("order_qty");
            entity.Property(e => e.PoId).HasColumnName("po_id");
            entity.Property(e => e.Price)
                .HasColumnType("double(11,2)")
                .HasColumnName("price");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.ReceivingStatus)
                .HasColumnType("enum('received','receiving')")
                .HasColumnName("receiving_status");
            entity.Property(e => e.SaleHistory).HasColumnName("sale_history");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
            entity.Property(e => e.SubcatoryId).HasColumnName("subcatory_id");
            entity.Property(e => e.TotalCost).HasColumnName("total_cost");
            entity.Property(e => e.VariantId).HasColumnName("variant_id");
        });

        modelBuilder.Entity<PurchaseOrderHeader>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("purchase_order_header");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.HeaderId)
                .HasMaxLength(255)
                .HasColumnName("header_id");
            entity.Property(e => e.HeaderName)
                .HasMaxLength(255)
                .HasColumnName("header_name");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
        });

        modelBuilder.Entity<PurchaseOrderStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("purchase_order_status");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("create_date");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .HasColumnName("name");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
        });

        modelBuilder.Entity<Quotation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("quotations");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6)")
                .HasColumnName("created_at");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.DeletedAt)
                .HasColumnType("timestamp")
                .HasColumnName("deleted_at");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnName("discount");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.Notes)
                .HasColumnType("text")
                .HasColumnName("notes");
            entity.Property(e => e.QuotationStatusTypeId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("quotation_status_type_id");
            entity.Property(e => e.Ref).HasMaxLength(192);
            entity.Property(e => e.Shipping)
                .HasDefaultValueSql("'0'")
                .HasColumnName("shipping");
            entity.Property(e => e.ShopId).HasColumnName("shop_id");
            entity.Property(e => e.TaxNet).HasDefaultValueSql("'0'");
            entity.Property(e => e.TaxRate)
                .HasDefaultValueSql("'0'")
                .HasColumnName("tax_rate");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6)")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<QuotationDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("quotation_details");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6)")
                .HasColumnName("created_at");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnName("discount");
            entity.Property(e => e.DiscountMethod)
                .HasDefaultValueSql("'percent'")
                .HasColumnType("enum('percent','number')")
                .HasColumnName("discount_method");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.ProductVariantId).HasColumnName("product_variant_id");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.QuotationId).HasColumnName("quotation_id");
            entity.Property(e => e.SaleUnitId).HasColumnName("sale_unit_id");
            entity.Property(e => e.TaxMethod)
                .HasMaxLength(192)
                .HasDefaultValueSql("'1'")
                .HasColumnName("tax_method");
            entity.Property(e => e.TaxNet).HasDefaultValueSql("'0'");
            entity.Property(e => e.Total).HasColumnName("total");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6)")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<QuotationStatusType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("quotation_status_type");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Color)
                .HasMaxLength(255)
                .HasColumnName("color");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.NameEn)
                .HasMaxLength(255)
                .HasColumnName("name_en");
            entity.Property(e => e.NameKh)
                .HasMaxLength(255)
                .HasColumnName("name_kh");
            entity.Property(e => e.Sequence).HasColumnName("sequence");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Ratting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("rattings")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Attachment)
                .HasMaxLength(255)
                .HasColumnName("attachment");
            entity.Property(e => e.Comment)
                .HasColumnType("mediumtext")
                .HasColumnName("comment");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.Star).HasColumnName("star");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Receiving>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("receiving");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CategoryId)
                .HasMaxLength(250)
                .HasColumnName("category_id");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("create_date");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.PoNo)
                .HasMaxLength(255)
                .HasColumnName("po_no");
            entity.Property(e => e.PostDate)
                .HasMaxLength(250)
                .HasColumnName("post_date");
            entity.Property(e => e.ReferenceName)
                .HasMaxLength(250)
                .HasColumnName("reference_name");
            entity.Property(e => e.Remarks)
                .HasMaxLength(250)
                .HasColumnName("remarks");
            entity.Property(e => e.ShopId).HasColumnName("shop_id");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
            entity.Property(e => e.StatusFilterId).HasColumnName("status_filter_id");
            entity.Property(e => e.TotalCost).HasColumnName("total_cost");
            entity.Property(e => e.TotalQty).HasColumnName("total_qty");
            entity.Property(e => e.TransactionDate)
                .HasMaxLength(250)
                .HasColumnName("transaction_date");
            entity.Property(e => e.TransactionNo).HasColumnName("transaction_no");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6)")
                .HasColumnName("updated_at");
            entity.Property(e => e.VendorId).HasColumnName("vendor_id");
        });

        modelBuilder.Entity<ReceivingDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("receiving_detail");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cost).HasColumnName("cost");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("create_date");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.OrderQty).HasColumnName("order_qty");
            entity.Property(e => e.PoQty).HasColumnName("po_qty");
            entity.Property(e => e.Price)
                .HasColumnType("double(11,2)")
                .HasColumnName("price");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.ReceivingId).HasColumnName("receiving_id");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
            entity.Property(e => e.SubcatoryId).HasColumnName("subcatory_id");
            entity.Property(e => e.TotalCost).HasColumnName("total_cost");
            entity.Property(e => e.VariantId).HasColumnName("variant_id");
        });

        modelBuilder.Entity<ReportingPurchaseOrder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("reporting_purchase_order");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CategoryId)
                .HasMaxLength(250)
                .HasColumnName("category_id");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("create_date");
            entity.Property(e => e.DeliveryDate)
                .HasMaxLength(250)
                .HasColumnName("delivery_date");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.OrderDate)
                .HasMaxLength(250)
                .HasColumnName("order_date");
            entity.Property(e => e.PoId).HasColumnName("po_id");
            entity.Property(e => e.PoNo)
                .HasMaxLength(255)
                .HasColumnName("po_no");
            entity.Property(e => e.PostDate)
                .HasMaxLength(250)
                .HasColumnName("post_date");
            entity.Property(e => e.ReferenceId).HasColumnName("reference_id");
            entity.Property(e => e.ReferenceName)
                .HasMaxLength(250)
                .HasColumnName("reference_name");
            entity.Property(e => e.Remarks)
                .HasMaxLength(250)
                .HasColumnName("remarks");
            entity.Property(e => e.SellFromDate)
                .HasMaxLength(250)
                .HasColumnName("sell_from_date");
            entity.Property(e => e.SellToDate)
                .HasMaxLength(250)
                .HasColumnName("sell_to_date");
            entity.Property(e => e.ShopId).HasColumnName("shop_id");
            entity.Property(e => e.ShopName)
                .HasMaxLength(250)
                .HasColumnName("shop_name");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
            entity.Property(e => e.StatusFilterId)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status_filter_id");
            entity.Property(e => e.TotalCost).HasColumnName("total_cost");
            entity.Property(e => e.TotalQty).HasColumnName("total_qty");
            entity.Property(e => e.TransactionDate)
                .HasMaxLength(250)
                .HasColumnName("transaction_date");
            entity.Property(e => e.TransactionNo).HasColumnName("transaction_no");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6)")
                .HasColumnName("updated_at");
            entity.Property(e => e.VendorId).HasColumnName("vendor_id");
            entity.Property(e => e.VendorName)
                .HasMaxLength(250)
                .HasColumnName("vendor_name");
        });

        modelBuilder.Entity<SellInvoice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("sell_invoice");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.InvoiceNumber)
                .HasMaxLength(255)
                .HasColumnName("invoice_number");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.IsPaid).HasColumnName("is_paid");
            entity.Property(e => e.Ref)
                .HasMaxLength(255)
                .HasColumnName("ref");
            entity.Property(e => e.ReleaseDate)
                .HasColumnType("timestamp")
                .HasColumnName("release_date");
            entity.Property(e => e.SellBy).HasColumnName("sell_by");
            entity.Property(e => e.SellOrdersId).HasColumnName("sell_orders_id");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
        });

        modelBuilder.Entity<SellInvoiceCopy1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("sell_invoice_copy1");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.InvoiceNumber)
                .HasMaxLength(255)
                .HasColumnName("invoice_number");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.IsPaid).HasColumnName("is_paid");
            entity.Property(e => e.Ref)
                .HasMaxLength(255)
                .HasColumnName("ref");
            entity.Property(e => e.ReleaseDate)
                .HasColumnType("timestamp")
                .HasColumnName("release_date");
            entity.Property(e => e.SellBy).HasColumnName("sell_by");
            entity.Property(e => e.SellOrdersId).HasColumnName("sell_orders_id");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
        });

        modelBuilder.Entity<SellOrder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("sell_orders")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .HasColumnName("address");
            entity.Property(e => e.Changed).HasColumnName("changed");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.CustomerAddressId).HasColumnName("customer_address_id");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.CustomerLat)
                .HasMaxLength(255)
                .HasColumnName("customer_lat");
            entity.Property(e => e.CustomerLng)
                .HasMaxLength(255)
                .HasColumnName("customer_lng");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(255)
                .HasColumnName("customer_name");
            entity.Property(e => e.DeliveryInstruction)
                .HasMaxLength(255)
                .HasColumnName("delivery_instruction");
            entity.Property(e => e.DeliveryPrice)
                .HasPrecision(50, 2)
                .HasColumnName("delivery_price");
            entity.Property(e => e.DeliveryStatus)
                .HasMaxLength(255)
                .HasColumnName("delivery_status");
            entity.Property(e => e.GrandTotal)
                .HasPrecision(50, 2)
                .HasColumnName("grand_total");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.Message)
                .HasMaxLength(255)
                .HasColumnName("message");
            entity.Property(e => e.MinutePending).HasColumnName("minute_pending");
            entity.Property(e => e.OrderStatus)
                .HasDefaultValueSql("'new'")
                .HasColumnType("enum('new','confirmed','preparing','complete','ready','delivery','arrival','paid','canceled','acceptedByDriver','assignedToDriver')")
                .HasColumnName("order_status");
            entity.Property(e => e.Other)
                .HasMaxLength(255)
                .HasColumnName("other");
            entity.Property(e => e.PaymentMethodId).HasColumnName("payment_method_id");
            entity.Property(e => e.PaymentOnline)
                .HasMaxLength(100)
                .HasColumnName("payment_online");
            entity.Property(e => e.PaymentStatus)
                .HasMaxLength(255)
                .HasColumnName("payment_status");
            entity.Property(e => e.ProductsPrice)
                .HasPrecision(50, 2)
                .HasColumnName("products_price");
            entity.Property(e => e.PromoteCode)
                .HasMaxLength(255)
                .HasColumnName("promote_code");
            entity.Property(e => e.QuoteId).HasColumnName("quote_id");
            entity.Property(e => e.Received).HasColumnName("received");
            entity.Property(e => e.SaleType)
                .HasColumnType("enum('walk-in','online')")
                .HasColumnName("sale_type");
            entity.Property(e => e.SellOrderDetailId).HasColumnName("sell_order_detail_id");
            entity.Property(e => e.SellerBy).HasColumnName("seller_by");
            entity.Property(e => e.ShopId).HasColumnName("shop_id");
            entity.Property(e => e.ShopLatlong)
                .HasMaxLength(255)
                .HasColumnName("shop_latlong");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'Enable'")
                .HasColumnType("enum('Enable','Disable')")
                .HasColumnName("status");
            entity.Property(e => e.Tax).HasColumnName("tax");
            entity.Property(e => e.TotalItem)
                .HasPrecision(50, 2)
                .HasColumnName("total_item");
            entity.Property(e => e.TotalPrice)
                .HasColumnType("double(255,2)")
                .HasColumnName("total_price");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
            entity.Property(e => e.UsersId).HasColumnName("users_id");
        });

        modelBuilder.Entity<SellOrderDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("sell_order_detail")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Discount)
                .HasDefaultValueSql("'0'")
                .HasColumnName("discount");
            entity.Property(e => e.DiscountType)
                .HasColumnType("enum('percent','number')")
                .HasColumnName("discount_type");
            entity.Property(e => e.ItemTax)
                .HasPrecision(24, 2)
                .HasColumnName("item_tax");
            entity.Property(e => e.Items).HasColumnName("items");
            entity.Property(e => e.Price)
                .HasPrecision(10, 2)
                .HasColumnName("price");
            entity.Property(e => e.ProductCode)
                .HasMaxLength(45)
                .HasColumnName("product_code");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.ProductImage)
                .HasMaxLength(255)
                .HasColumnName("product_image");
            entity.Property(e => e.ProductName)
                .HasMaxLength(255)
                .HasColumnName("product_name");
            entity.Property(e => e.Qty)
                .HasDefaultValueSql("'0'")
                .HasColumnName("qty");
            entity.Property(e => e.SellOrderId).HasColumnName("sell_order_id");
            entity.Property(e => e.Size)
                .HasMaxLength(10)
                .HasColumnName("size");
            entity.Property(e => e.SubTotal)
                .HasPrecision(24, 2)
                .HasColumnName("sub_total");
            entity.Property(e => e.Tax)
                .HasMaxLength(45)
                .HasColumnName("tax");
            entity.Property(e => e.UnitPrice)
                .HasPrecision(24, 2)
                .HasColumnName("unit_price");
            entity.Property(e => e.VariantId).HasColumnName("variant_id");
        });

        modelBuilder.Entity<SellOrderDetailProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("sell_order_detail_product");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.SellOrderDetailId).HasColumnName("sell_order_detail_id");
            entity.Property(e => e.SizeProductsId).HasColumnName("size_products_id");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
        });

        modelBuilder.Entity<Shop>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("shops")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.RouteHandle, "unique_route_handle").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .HasColumnName("address");
            entity.Property(e => e.Code)
                .HasMaxLength(255)
                .HasColumnName("code");
            entity.Property(e => e.CodePrefixOwnerId)
                .HasMaxLength(45)
                .HasColumnName("code_prefix_owner_id");
            entity.Property(e => e.Cover)
                .HasMaxLength(255)
                .HasColumnName("cover");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(255)
                .HasColumnName("create_by");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Description)
                .HasMaxLength(2000)
                .HasColumnName("description");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.GazetteersCode).HasColumnName("gazetteers_code");
            entity.Property(e => e.HouseNumber)
                .HasMaxLength(255)
                .HasColumnName("house_number");
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .HasColumnName("image");
            entity.Property(e => e.Initial)
                .HasMaxLength(255)
                .HasDefaultValueSql("'test'")
                .HasColumnName("initial");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.Latitude)
                .HasColumnType("double(11,8)")
                .HasColumnName("latitude");
            entity.Property(e => e.Longitude)
                .HasColumnType("double(11,8)")
                .HasColumnName("longitude");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Phone)
                .HasMaxLength(255)
                .HasColumnName("phone");
            entity.Property(e => e.RouteHandle)
                .HasMaxLength(500)
                .HasColumnName("route_handle");
            entity.Property(e => e.ShopDivisionId).HasColumnName("shop_division_id");
            entity.Property(e => e.ShopTypeId).HasColumnName("shop_type_id");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
            entity.Property(e => e.Street)
                .HasMaxLength(255)
                .HasColumnName("street");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
            entity.Property(e => e.Website)
                .HasMaxLength(255)
                .HasColumnName("website");
        });

        modelBuilder.Entity<ShopBranch>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("shop_branch");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .HasColumnName("address");
            entity.Property(e => e.Branch)
                .HasMaxLength(250)
                .HasColumnName("branch");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.CodePrefixOwnerId).HasColumnName("code_prefix_owner_id");
            entity.Property(e => e.Contact)
                .HasMaxLength(250)
                .HasColumnName("contact");
            entity.Property(e => e.Description)
                .HasMaxLength(2550)
                .HasColumnName("description");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'1'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.Latitude).HasColumnName("latitude");
            entity.Property(e => e.Longitude).HasColumnName("longitude");
            entity.Property(e => e.Shop)
                .HasMaxLength(250)
                .HasColumnName("shop");
            entity.Property(e => e.ShopId).HasColumnName("shop_id");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
        });

        modelBuilder.Entity<ShopDistance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("shop_distance");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("create_at");
            entity.Property(e => e.Distance)
                .HasMaxLength(50)
                .HasColumnName("distance");
            entity.Property(e => e.DistanceType)
                .HasMaxLength(20)
                .HasColumnName("distance_type");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.MeasurementId).HasColumnName("measurement_id");
            entity.Property(e => e.Price)
                .HasMaxLength(20)
                .HasColumnName("price");
            entity.Property(e => e.ShopId).HasColumnName("shop_id");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
        });

        modelBuilder.Entity<ShopType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("shop_type")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'Enable'")
                .HasColumnType("enum('Enable','Disable')")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Slider>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("sliders")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .HasColumnName("image");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Order).HasColumnName("order");
            entity.Property(e => e.ShopId).HasColumnName("shop_id");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
            entity.Property(e => e.Subtitle)
                .HasMaxLength(255)
                .HasColumnName("subtitle");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Static>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("statics")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'ENABLE'")
                .HasColumnType("enum('ENABLE','DISABLE')")
                .HasColumnName("status");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
        });

        modelBuilder.Entity<StockBranchProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("stock_branch_product");

            entity.HasIndex(e => e.SupplierId, "fk_shop_branch_by_supplier");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActionBy).HasColumnName("action_by");
            entity.Property(e => e.ActionType)
                .HasColumnType("enum('in','out','new','return','delete','edit')")
                .HasColumnName("action_type");
            entity.Property(e => e.ApproveBy).HasColumnName("approve_by");
            entity.Property(e => e.CreateBy).HasColumnName("create_by");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("create_date");
            entity.Property(e => e.DeleteBy).HasColumnName("delete_by");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.No).HasColumnName("no");
            entity.Property(e => e.ShopBranchDetailId).HasColumnName("shop_branch_detail_id");
            entity.Property(e => e.ShopBranchId).HasColumnName("shop_branch_id");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
            entity.Property(e => e.SupplierId).HasColumnName("supplier_id");
        });

        modelBuilder.Entity<StockBranchProductDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("stock_branch_product_detail");

            entity.HasIndex(e => e.StockBranchProductId, "fk_stock_product_move_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateBy).HasColumnName("create_by");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("create_date");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.ProStatus)
                .HasMaxLength(255)
                .HasColumnName("pro_status");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
            entity.Property(e => e.StockBranchProductDetail1)
                .HasMaxLength(45)
                .HasColumnName("stock_branch_product_detail");
            entity.Property(e => e.StockBranchProductId).HasColumnName("stock_branch_product_id");
            entity.Property(e => e.StockProductMoveId).HasColumnName("stock_product_move_id");
        });

        modelBuilder.Entity<StockProductAssign>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("stock_product_assign");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActionBy).HasColumnName("action_by");
            entity.Property(e => e.ActionType)
                .HasColumnType("enum('in','out','new','return','delete','edit')")
                .HasColumnName("action_type");
            entity.Property(e => e.CreateBy).HasColumnName("create_by");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("create_date");
            entity.Property(e => e.CurrencyId).HasColumnName("currency_id");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.Price)
                .HasPrecision(24, 4)
                .HasColumnName("price");
            entity.Property(e => e.Qty)
                .HasPrecision(10)
                .HasColumnName("qty");
            entity.Property(e => e.ShopBranchDetailId).HasColumnName("shop_branch_detail_id");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
            entity.Property(e => e.StockProductId).HasColumnName("stock_product_id");
            entity.Property(e => e.UpdateQty)
                .HasPrecision(10)
                .HasColumnName("update_qty");
        });

        modelBuilder.Entity<StockProductMove>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("stock_product_move");

            entity.HasIndex(e => e.CurrencyId, "fk_currency_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActionBy).HasColumnName("action_by");
            entity.Property(e => e.ActionType)
                .HasColumnType("enum('in','out','new','return','delete','edit','cancel')")
                .HasColumnName("action_type");
            entity.Property(e => e.Cost).HasColumnName("cost");
            entity.Property(e => e.CreateBy).HasColumnName("create_by");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("create_date");
            entity.Property(e => e.CurrencyId).HasColumnName("currency_id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.Price)
                .HasPrecision(24, 4)
                .HasColumnName("price");
            entity.Property(e => e.Qty)
                .HasPrecision(10)
                .HasColumnName("qty");
            entity.Property(e => e.SellOrderId).HasColumnName("sell_order_id");
            entity.Property(e => e.ShopBranchDetailId).HasColumnName("shop_branch_detail_id");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
            entity.Property(e => e.StockBranchProductId).HasColumnName("stock_branch_product_id");
            entity.Property(e => e.StockProductId).HasColumnName("stock_product_id");
            entity.Property(e => e.StockStorageDetailId).HasColumnName("stock_storage_detail_id");
            entity.Property(e => e.UpdateQty)
                .HasPrecision(10)
                .HasColumnName("update_qty");
            entity.Property(e => e.VariantId).HasColumnName("variant_id");

            entity.HasOne(d => d.Currency).WithMany(p => p.StockProductMoves)
                .HasForeignKey(d => d.CurrencyId)
                .HasConstraintName("fk_currency_id");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("supplier");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(500)
                .HasColumnName("address");
            entity.Property(e => e.Contact)
                .HasMaxLength(250)
                .HasColumnName("contact");
            entity.Property(e => e.CreateBy).HasColumnName("create_by");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("create_date");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.GazetteersCode)
                .HasMaxLength(255)
                .HasColumnName("gazetteers_code");
            entity.Property(e => e.HomeNumber)
                .HasMaxLength(100)
                .HasColumnName("home_number");
            entity.Property(e => e.Hotline)
                .HasMaxLength(100)
                .HasColumnName("hotline");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.Latlng)
                .HasMaxLength(100)
                .HasColumnName("latlng");
            entity.Property(e => e.ShopId).HasColumnName("shop_id");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
            entity.Property(e => e.Street)
                .HasMaxLength(100)
                .HasColumnName("street");
            entity.Property(e => e.SupplierCode).HasColumnName("supplier_code");
            entity.Property(e => e.SupplierName)
                .HasMaxLength(250)
                .HasColumnName("supplier_name");
            entity.Property(e => e.VendorCode)
                .HasMaxLength(20)
                .HasColumnName("vendor_code");
            entity.Property(e => e.Website)
                .HasMaxLength(255)
                .HasColumnName("website");
        });

        modelBuilder.Entity<TaxCode>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("tax_code")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
            entity.Property(e => e.TaxCode1)
                .HasMaxLength(255)
                .HasColumnName("tax_code");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<TrackDriver>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("track_driver")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.DriverId).HasColumnName("driver_id");
            entity.Property(e => e.Latitude)
                .HasColumnType("double(11,8)")
                .HasColumnName("latitude");
            entity.Property(e => e.Longitude)
                .HasColumnType("double(11,8)")
                .HasColumnName("longitude");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Translate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("translates")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Key)
                .HasMaxLength(255)
                .HasColumnName("key");
            entity.Property(e => e.Language)
                .HasDefaultValueSql("'EN'")
                .HasColumnType("enum('EN','KH')")
                .HasColumnName("language");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasColumnName("value");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("users")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .HasColumnName("address");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.CustomerLat).HasColumnName("customer_lat");
            entity.Property(e => e.CustomerLng).HasColumnName("customer_lng");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.EmailVerifiedAt)
                .HasColumnType("timestamp")
                .HasColumnName("email_verified_at");
            entity.Property(e => e.Gender)
                .HasColumnType("enum('Male','Female','Other')")
                .HasColumnName("gender");
            entity.Property(e => e.GroupUserId)
                .HasDefaultValueSql("'4'")
                .HasColumnName("group_user_id");
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .HasColumnName("image");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.NotificationToken)
                .HasMaxLength(1000)
                .HasColumnName("notification_token");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasColumnName("password");
            entity.Property(e => e.Phone)
                .HasMaxLength(255)
                .HasColumnName("phone");
            entity.Property(e => e.RememberToken)
                .HasMaxLength(100)
                .HasColumnName("remember_token");
            entity.Property(e => e.ShopBranchDetailId).HasColumnName("shop_branch_detail_id");
            entity.Property(e => e.ShopBranchId).HasColumnName("shop_branch_id");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserRole)
                .HasMaxLength(255)
                .HasColumnName("user_role");
        });

        modelBuilder.Entity<UserLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("user_logs")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(255)
                .HasColumnName("action");
            entity.Property(e => e.AdminUserId).HasColumnName("admin_user_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Detail)
                .HasColumnType("text")
                .HasColumnName("detail");
            entity.Property(e => e.LastActive)
                .HasColumnType("datetime")
                .HasColumnName("last_active");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.UserType)
                .HasMaxLength(255)
                .HasColumnName("user_type");
            entity.Property(e => e.Username)
                .HasMaxLength(255)
                .HasColumnName("username");
        });

        modelBuilder.Entity<UsersDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("users_detail");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BirthDate)
                .HasMaxLength(255)
                .HasColumnName("birth_date");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Gender)
                .HasMaxLength(255)
                .HasColumnName("gender");
            entity.Property(e => e.IdCard)
                .HasMaxLength(255)
                .HasColumnName("id_card");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_deleted");
            entity.Property(e => e.Lat)
                .HasMaxLength(255)
                .HasColumnName("lat");
            entity.Property(e => e.Lng)
                .HasMaxLength(255)
                .HasColumnName("lng");
            entity.Property(e => e.ShopId).HasColumnName("shop_id");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'1'")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<WebsocketsStatisticsEntry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("websockets_statistics_entries")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApiMessageCount).HasColumnName("api_message_count");
            entity.Property(e => e.AppId)
                .HasMaxLength(255)
                .HasColumnName("app_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.PeakConnectionCount).HasColumnName("peak_connection_count");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
            entity.Property(e => e.WebsocketMessageCount).HasColumnName("websocket_message_count");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
