using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "ürün ismi geçersiz ";
        public static string MaintenanceTime="sistem bakımda";
        public static string ProductsListed="ürünler listelendi";
        public static string ProductCountOfCategoryId = "ürünler listelendi";
        public static string ProductNameAlreadyExist = "Bu isimde zaten başka bir ürün var";
        public static string CategoryLimitExceded = "kategori limiti aştığı için ürün eklenemiyor";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserRegistered = "kullanıcı kayıt oldu";
        public static string UserNotFound="kullanıcı bulunamadı";
        public static string PasswordError="şifre hatalı";
        public static string SuccessfulLogin="giriş başarılı";
        public static string UserAlreadyExists="kullanıcı mevcut";
        public static string AccessTokenCreated;
    }
}
