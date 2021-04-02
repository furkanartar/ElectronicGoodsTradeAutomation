﻿namespace Business.Constants
{
    public static class Messages
    {
        public static string MaintenanceTime = "Sistem bakımda.";
        public static string Error = "Bir hata oluştu.";
        public static string NotFound = "Hiç bir kayıt bulunamadı";

        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";

        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string ProductNameAlreadyExists = "Ürün ismi zaten mevcut";


        public static class Products
        {
            public static string Add(string productName)
            {
                return $"{productName} isimli ürün sisteme başarı ile eklenmiştir.";
            }
            public static string Update(string productName)
            {
                return $"{productName} isimli ürün bilgileri başarılı bir şekilde güncellenmiştir.";
            }
            public static string Delete(string productName)
            {
                return $"{productName} isimli ürün sistemden başarılı bir şekilde silinmiştir.";
            }
            public static string Exists(string productName)
            {
                return $"{productName} bilgilerine sahip bir ürün sistemde kayıtlıdır.";
            }
            public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 farklı ürün olabilir.";
        }

        public static class Categories
        {
            public static string CategoryLimitExceeded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor.";

            public static string Add(string categoryName)
            {
                return $"{categoryName} isimli kategori sisteme başarı ile eklenmiştir.";
            }
            public static string Update(string categoryName)
            {
                return $"{categoryName} isimli kategori bilgileri başarılı bir şekilde güncellenmiştir.";
            }
            public static string Delete(string categoryName)
            {
                return $"{categoryName} isimli kategori sistemden başarılı bir şekilde silinmiştir.";
            }
            public static string Exists(string categoryName)
            {
                return $"{categoryName} bilgilerine sahip bir kategori sistemde kayıtlıdır.";
            }
        }
        public static class Customers
        {
            public static string Add(string firstName, string lastName)
            {
                return $"{firstName} - {lastName} bilgilerine sahip müşteri sisteme başarı ile eklenmiştir.";
            }
            public static string Update(string firstName, string lastName)
            {
                return $"{firstName} - {lastName} müşteri bilgileri başarılı bir şekilde güncellenmiştir.";
            }
            public static string Delete(string firstName, string lastName)
            {
                return $"{firstName} - {lastName} müşteri sistemden başarılı bir şekilde silinmiştir.";
            }
            public static string Exists(string firstName, string lastName)
            {
                return $"{firstName} - {lastName} bilgilerine sahip bir müşteri sistemde kayıtlıdır.";
            }
        }
        public static class Employees
        {
            public static string Add(string firstName, string lastName)
            {
                return $"{firstName} {lastName} isimli çalışan sisteme başarı ile eklenmiştir.";
            }
            public static string Update(string firstName, string lastName)
            {
                return $"{firstName} {lastName} isimli çalışan bilgileri başarılı bir şekilde güncellenmiştir.";
            }
            public static string Delete(string firstName, string lastName)
            {
                return $"{firstName} {lastName} isimli çalışan sistemden başarılı bir şekilde silinmiştir.";
            }
            public static string Exists(string firstName, string lastName)
            {
                return $"{firstName} {lastName} isimli çalışan bilgilerine sahip başka bir kayıt sistemde bulunmaktadır.";
            }
        }

        public static class Suppliers
        {
            public static string Add(string supplierName)
            {
                return $"{supplierName} isimli tedarikçi sisteme başarı ile eklenmiştir.";
            }
            public static string Update(string supplierName)
            {
                return $"{supplierName} isimli tedarikçi bilgileri başarılı bir şekilde güncellenmiştir.";
            }
            public static string Delete(string supplierName)
            {
                return $"{supplierName} isimli tedarikçi sistemden başarılı bir şekilde silinmiştir.";
            }
            public static string Exists(string supplierName)
            {
                return $"{supplierName} bilgilerine sahip bir tedarikçi sistemde kayıtlıdır.";
            }
        }

        public static class Orders
        {
            public static string Add()
            {
                return $"Siparişiniz işleme alınmıştır.";
            }
            public static string Update()
            {
                return $"Sipariş bilgileriniz başarılı bir şekilde güncellenmiştir.";
            }
            public static string Delete()
            {
                return $"Siparişiniz sistemden başarılı bir şekilde silinmiştir.";
            }
        }


    }
}