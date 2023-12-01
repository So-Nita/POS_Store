using Microsoft.EntityFrameworkCore;
using POSLibrary.DataModels.Results;
using POSLibrary.DataModels.SellOrder;
using POSLibrary.Interface.SellOrder;
using POSLibrary.Models;
using POSLibrary.Repository;

namespace POSLibrary.Service
{
    public class SellOrderService : ISellOrderService
    {
        private readonly IRepository<SellOrder> _repo;   
        public SellOrderService(IRepository<SellOrder> repository)
        {
            _repo = repository;
        }
        public Results<IEnumerable<SellOrderResponse?>> ReadAll()
        {
            try
            {
                var orders = _repo.GetAll()?.Where(e => e.Id.ToString() != null).ToList();
              
                var orderDetails = _repo.Context().SellOrderDetails.Where(e => e.SellOrderId != null).ToList();

                var result = new List<SellOrderResponse>();

                foreach (var item in orders!)
                {
                    var data = orderDetails.Where(e => e.SellOrderId.ToString() == item.Id.ToString());
                    if (data!=null)
                    {
                        var t =  data.Select(e => new SellOrderResponse()
                        {
                            CustomerId = item.CustomerId,
                            SaleType = item.SaleType!,
                            ShopId = (long)item.ShopId!,
                            Products = new List<ProductPurchaseResponse>()
                            {
                                new ProductPurchaseResponse()
                                {
                                    ProductId = e.ProductId!,
                                    ProductName = e.ProductName!,
                                    ProductImage = e.ProductImage!,
                                    Price = (decimal)e.Price!,
                                    Discount = e.Discount,
                                    Qty = e.Qty,
                                    ProductTax = e.Tax!,
                                    UnitPrice = e.UnitPrice,
                                    SubTotal = e.SubTotal,
                                    VariantId = e.VariantId
                                }
                            }
                        }).First();
                        result.Add(t);
                    }
                    
                }
                return Results<IEnumerable<SellOrderResponse?>>.Success(result,result.Count());
            }
            catch(Exception ex)
            {
                return Results<IEnumerable<SellOrderResponse?>>.Fail();
            }
        }
        public Results<SellOrderResponse> GetById(ulong id)
        {
            try
            {
                var sellOrder = _repo.GetById(id);
                if(sellOrder == null)
                {
                    return Results<SellOrderResponse>.Fail();
                }
                var data = new SellOrderResponse()
                {
                    OrderId = sellOrder.Id,
                    PaymentMethodId = sellOrder.PaymentMethodId,
                    CustomerId = sellOrder.CustomerId,
                   /* CustomerName = sellOrder.CustomerName,
                    ProductsPrice = sellOrder.ProductsPrice,
                    GrandTotal = sellOrder.GrandTotal,
                    TotalItem = sellOrder.TotalItem,
                    PromoteCode = sellOrder.PromoteCode,
                    TotalPrice = sellOrder.TotalPrice,  
                    Tax = sellOrder.Tax,*/
                    ShopId = sellOrder.ShopId,
                };
                return Results<SellOrderResponse>.Success(data);
            }
            catch (Exception ex)
            {
                return Results<SellOrderResponse>.Fail();   
            }
        }
        public Results<string> Create(SellOrderCreateReq req)
        {
            try
            {
                return Results<string>.Success();   
            }catch(Exception ex)
            {
                return Results<string>.Fail();
            }
        }

        public Results<string> Update(SellOrderUpdateReq req)
        {
            try
            {
                return Results<string>.Success();   
            }catch (Exception ex)
            {
                return Results<string>.Fail();
            }
        }
        public Results<string> Delete(ulong id)
        {
            try
            {
                return Results<string>.Success();
            }
            catch (Exception ex)
            {
                return Results<string>.Fail();
            }
        }
       
    }
}
