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
        public static string CategoryAdded = "Kategori bilgisi eklendi.";
        public static string CategoryDeleted = "Kategori bilgisi silindi.";
        public static string CategoryUpdated = "Kategori bilgileri güncellendi.";
        public static string CategoriesListed = "Kategoriler listelendi.";

        public static string ClothesAdded = "Kıyafet bilgisi eklendi.";
        public static string ClothesDeleted = "Kıyafet bilgisi silindi.";
        public static string ClothesUpdated = "Kıyafet bilgisi güncellendi.";
        public static string ClothesListed = "Kıyafetler listelendi.";

        public static string ColorAdded = "Renk bilgisi eklendi.";
        public static string ColorDeleted = "Renk bilgisi silindi.";
        public static string ColorUpdated = "Renk bilgisi güncellendi.";
        public static string ColorsListed = "Renkler listelendi.";


        public static string CustomerAdded = "Müşteri bilgileri eklendi.";
        public static string CustomerDeleted = "Müşteri bilgileri silindi.";
        public static string CustomerUpdated = "Müşteri bilgileri güncellendi.";
        public static string CustomersListed = "Müşteriler listelendi";


        public static string ShipperAdded = "Kargo bilgileri eklendi.";
        public static string ShipperDeleted = "Kargo bilgileri silindi.";
        public static string ShipperUpdated = "Kargo bilgileri güncellendi.";

        public static string OrderAdded = "Sipariş bilgisi eklendi.";
        public static string OrderDeleted = "Sipariş bilgisi silindi.";
        public static string OrdersListed = "Siparişler listelendi.";
        public static string OrderUpdated = "Sipariş bilgisi güncellendi.";

        public static string UserUpdated = "Kullanıcı bilgileri güncellendi.";
        public static string UserAdded = "Kullanıcı bilgileri eklendi.";
        public static string UserDeleted = "Kullanıcı bilgileri silindi.";
        public static string UsersListed = "Kullanıcılar listlendi.";

        public static string ClothesImageDeleted = "Ürün görseli silindi.";
        public static string NoImages = "Görsel yok.";
        public static string ImageNotFound = "Görsel bulunamadı.";
        public static string ImagesUpdated = "Görsel güncellendi.";
        public static string ClothesImageAdded = "Görsel eklendi.";
        public static string ClothesImageLimitExceded = "Bir ürüne ait en fazla 3 görsel olabilir.";

        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError="Hatalı şifre.";
        public static string SuccessfulLogin="Başarılı giriş.";
        public static string UserAlreadyExists = "Kullanıcı zaten mevcut.";
        public static string AccessTokenCreated = "Giriş yapıldı";
        public static string UserRegistered = "Kullanıcı eklendi.";
        public static string UserNotAdded="Kullanıcı eklenemedi";
    }
}
