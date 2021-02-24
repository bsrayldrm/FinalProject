using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "ürün ismi geçersiz ";
        internal static string MaintenanceTime="sistem bakımda";
        internal static string ProductsListed="ürünler listelendi";
        public static string ProductCountOfCategoryId = "ürünler listelendi";
        public static string ProductNameAlreadyExist = "Bu isimde zaten başka bir ürün var";
        public static string CategoryLimitExceded = "kategori limiti aştığı için ürün eklenemiyor";
    }
}
