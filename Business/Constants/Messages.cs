using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInValid = "Ürün Geçersiz";
        public static string MaintenanceTime = "Sistem Bakım Saati";
        public static string ProductListed = "Ürünler Listelendi";
        public static string ProductErrorAdd="Eklenemiyor";
        public static string ProductNameAlreadyExists="Aynı Ürün Adı Var";
        public static string CategoryLimitExceded = "Kategori Limiti Aşıldı";
        public static string AuthorizationDenied = "Yetkisiz Erişim";

        public static string UserNotFound ="Yetkisiz Erişim";
        public static string AccessTokenCreated = "Yetkisiz Erişim";
        public static string UserAlreadyExists = "Yetkisiz Erişim";
        public static string SuccessfulLogin = "Yetkisiz Erişim";
        public static string PasswordError = "Yetkisiz Erişim";
        public static string UserRegistered = "Yetkisiz Erişim";
    }
}
