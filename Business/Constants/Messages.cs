using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Bakımda";
        public static string ProductListed = "Ürünler listelendi";
        public static string ProductUpdate="Ürün güncellendi";
        public static string ProductCountOfCategoryError="Bir categorinin alabiceği sayıyı aştınız";
        public static string ProductNameAlreadyExists="Bu ürüne sahip bir ürün zaten var.";
        public static string CategoryLimitExceded="Kategori limiti aşıldı ürün ekleme yapamazsınız";
        public static string AuthorizationDenied="yetkiniz yok";
        public static string UserRegistered="kayıt oldu";
        public static string UserNotFound="kullanıcı bulunamadı";
        public static string PasswordError="şifre hatalı";
        public static string SuccessfulLogin="giriş başarılı";
        public static string UserAlreadyExists="kullanıcı zaten mevcut";
        public static string AccessTokenCreated="giriş yetkisi oluşturuldu";
    }
}
