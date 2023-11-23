using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POSLibrary.DataModels.Order;
using POSLibrary.DataModels.Results;
using POSLibrary.Interface.Order;

namespace POSLibrary.Service
{
    public class OrderService : IOrderService
    {
        private readonly IOrderService _service;   
        public OrderService(IOrderService service)
        {
            _service = service;
        }
        public Results<IEnumerable<OrderResponse?>> ReadAll()
        {
            throw new NotImplementedException();
        }
        public Results<string> Create(OrderCreateReq req)
        {
            throw new NotImplementedException();
        }

        public Results<bool> Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Results<OrderResponse> GetById(ulong id)
        {
            throw new NotImplementedException();
        }

        

        public Results<string> Update(OrderUpdateReq req)
        {
            throw new NotImplementedException();
        }
    }
}
