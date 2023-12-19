using POSLibrary.Constant;
using POSLibrary.DataModels.Results;
using POSLibrary.DataModels.Supplier;
using POSLibrary.Interface;
using POSLibrary.Models;
using POSLibrary.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSLibrary.Service
{
    public class SupplierService : ISupplierService
    {
        private readonly IRepository<Supplier> _repo;
        public SupplierService(IRepository<Supplier> reposiotry) 
        { 
            _repo = reposiotry;
        }
        public Results<SupplierResponse> GetById(ulong id)
        {
            try
            {
                var shops = _repo.Context().Shops.ToList();
                var suppliers = _repo.GetAll()!.Where(e=>e.Id==(int)id).ToList()!;
                var result = new SupplierResponse();
                if (suppliers.Any())
                {
                    foreach (var item in shops)
                    {
                        var data = suppliers.FirstOrDefault(e => e.ShopId == item.Id);
                        if (data != null)
                        {
                            result = new SupplierResponse()
                            {
                                Id = data.Id,
                                ShopId = data.ShopId,
                                ShopName = data.SupplierName,
                                SupplierName = data.SupplierName,
                                Contact = data.Contact,
                                Email = data.Email,
                                Website = data.Website,
                                VendorCode = data.VendorCode
                            };
                        }
                    }
                }
                if (result.Id == 0)
                {
                    return Results<SupplierResponse>.NotFound(result=null);
                }
                return Results<SupplierResponse>.Success(result);   
            }
            catch(ArgumentException ex) 
            {
                return Results<SupplierResponse>.Fail();
            }
        }

        public Results<IEnumerable<SupplierResponse?>> ReadAll()
        {
            try
            {
                var shops = _repo.Context().Shops.ToList();   
                var suppliers = _repo.GetAll()?.ToList()!;
                var result = new List<SupplierResponse>();

                if (suppliers.Any() && shops.Any())
                {
                    foreach (var item in shops)
                    {
                        var data = suppliers.FirstOrDefault(e => e.ShopId == item.Id);
                        if (data!=null)
                        {
                            var supplier = new SupplierResponse()
                            {
                                Id = data.Id,
                                SupplierName = data.SupplierName,
                                Contact = data.Contact,
                                Email = data.Email,
                                ShopId = data.ShopId!,
                                ShopName = item.Name,
                                VendorCode = data.VendorCode,
                                Website = data.Website
                            };
                            result.Add(supplier);
                        }
                    }
                }

                return Results<IEnumerable<SupplierResponse>>.Success(result, result.Count())!;
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message + "\n" + ex.StackTrace);
            }
        }

        public Results<string> Create(SupplierCreateReq req)
        {
            var validaionError = DataValidator<SupplierCreateReq>.ValidateDynamicTypes(req);
            if (validaionError.Count > 0)
            {
                return Results<string>.Fail(validaionError.First().ToString());
            }
            var supplier = new Supplier()
            {
                SupplierName = req.SupplierName,
                ShopId = req.ShopId,
                Contact = req.Contact,
                Email = req.Email,
                SupplierCode = req.SuppplierCode,
                CreateDate = DateTime.Now
            };
            try
            {
                _repo.Add(supplier);
                _repo.SaveChanges();
                return Results<string>.Success(data: "Create Suceessfully. Supplier id : " + supplier.Id);
            }
            catch(Exception ex)
            {
                return Results<string>.Fail("Failed to create the Supplier.");
            }
        }
        public Results<string> Update(SupplierUpdateReq req)
        {
            try
            {
                var supplier = _repo.GetQueryable()!.Where(e=>e.Id == req.Id).First();
                if(supplier == null)
                {
                    return Results<string>.NotFound("Supplier not found.");
                }
                //supplier.Id = req.Id;
                supplier.ShopId = (req.ShopId == 0 || req.ShopId == null) ? supplier.ShopId : req.ShopId;
                supplier.SupplierName = req.SupplierName ?? supplier.SupplierName;
                supplier.SupplierCode = (req.SupplierCode != 0 || req.SupplierCode != null) ? req.SupplierCode : supplier.SupplierCode;
                supplier.ShopId = (req.ShopId == 0 || req.ShopId == null) ? supplier.ShopId : req.ShopId;
                supplier.Contact = req.Contact ?? supplier.Contact;
                supplier.Email = req.Email ?? supplier.Email;
                supplier.Website = req.Website ?? supplier.Website;
               
                _repo.Update(supplier);
                _repo.SaveChanges();

                return Results<string>.Success("Updated Suceessfully.");
            }
            catch
            {
                return Results<string>.Fail("Failed to update the Supplier.");
            }
        }
        public Results<string> Delete(ulong id)
        {
            try
            {
                var supplier = _repo.GetById(id);
                if(supplier == null)
                {
                    return Results<string>.NotFound();
                }
                return Results<string>.Success("Deleted Successfully.");
            }
            catch
            {
                return Results<string>.Fail("Failed to Delete.");
            }
        }
        
        
    }
}
