using POSDesignDemo.Constant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace POSDesignDemo.Controllers
{
    public class ControllerBase
    {
        protected static string BaseUrl = "http://172.26.16.113:8082/api";
        protected static string MyUrl = "http://172.20.10.51:8082/api";
        protected Dictionary<string, string> Headers
        {
            get
            {
                var headers = new Dictionary<string, string>();
                headers.Add("Authorization", "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiJ9.eyJhdWQiOiIyNSIsImp0aSI6IjdhNmFhYTMwN2IwZTU4MWVhMjI2MTg5ODcxYjg0MjZlMzQ1MDc0ZmVmZGE3MTdiOWRmNDllM2RmYWVmMGExM2U5MDI3OGM2NGJjYjRiYTk0IiwiaWF0IjoxNjk1MjgyODA2LjIzMjI5NCwibmJmIjoxNjk1MjgyODA2LjIzMjI5OSwiZXhwIjoxNzI2OTA1MjA2LjIxODk1OCwic3ViIjoiMSIsInNjb3BlcyI6W119.O9rP3hjVmS3l8QZeL2lUp4v-QnLYhXIPaPlMr7u0F4Jf2aQTWm7ulYD7yiY3P2JNl_rqfJI4wQtlwX24kMvze1fLy56hJcm-1w0mcLyEOqqm9dHfX9rdzSQdJ1biLuxNWv2ONgtOh2EAEV9PO06w9z33TRO36WO25hTU9sPTxy8fM_zKWjTDleXWz3BOJ3mg2ADFYO-Gtx16prG9nFPSJZTOhXeAbdIBsiHMHLCnqC3c4e7k0B8eDxjZSiD6oB4P_g76ntA4bdtR9CmgheV9m6SB8TN3w0yLelFTCaqVUBM1Wm2K5Nsq3vFOZglWaQ7-A34jUqzkCco2DG5vBEkld25z5HzblzG8eNoOZulTzwzO8xsyoMFN1v1bb9PMpH1e2hsMh-1Of7pA8t2Tks94WJAWttOpbrbY56_y_0ktA4f9bHIbVmYIl17QHKxaNfEU11BJAWGM-S4HCtJiHuK6wmvEP7yt2TSLZYFkn7ADMl5G9_P941QZ7fcpo3wiq-8Mbr_qb3BprJGNOdJ4xqU2E-ddySd0zKOUTHfWYIonodrP78_vu5u_Nonp9BW0bHeX_ygsTFMC-sAqCBOLnXOWjl3SesBNyhNilX36hxpU_tD7eHjYyVBV4lz62-fp2tjRsehX2QrC2PQ7wqWpPuWQt2j9KrqbvAbGRrCvjJXxhUE");
                headers.Add("Cookie", "PHPSESSID=allk35c00u4pvniiin8jkodbvh");
                return headers;
            }
        }
        protected string GetEndPoint(ConstantEndPoint endpoint)
        {
            return endpoint switch
            {
                ConstantEndPoint.AuthLogin => BaseUrl + "/auth/login",
                //ConstantEndPoint.ProductList => BaseUrl + "/product_list",
                //ConstantEndPoint.SubCategoryByShop => BaseUrl + "/subCategpryByShop",
                //ConstantEndPoint.SellOrderedDetail => BaseUrl + "/sell/ordered/detail",
                ConstantEndPoint.PurchaseOrder => BaseUrl + "/purchaseOrder",
                //ConstantEndPoint.Supplier => BaseUrl + "/productSupplier",


                // ** My Api **
                ConstantEndPoint.ProductList => MyUrl + "/product",
                // Get Product By categoryId
                ConstantEndPoint.ProductByCateId => MyUrl + "/product/getProductByCategoryId?categoryId=",
                // Category
                ConstantEndPoint.SubCategoryByShop => MyUrl + "/category/getCategoryProduct",
                // Supplier
                ConstantEndPoint.Supplier=> MyUrl + "/supplier",
                // Supplier
                ConstantEndPoint.SellOrderedDetail => MyUrl + "/sellOrder",
                _ => throw new ArgumentOutOfRangeException()
            };
        } 
    }
}
