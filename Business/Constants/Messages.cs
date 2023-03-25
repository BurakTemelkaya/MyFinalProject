using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";

        public static string ProductNameInvalid = "Ürün ismi geçersiz.";

        public static string MaintenanceTime = "Sistem bakımda.";

        public static string ProductListed = "Ürünler listelendi.";

        public static string ProductCountOfCategoryError = "Eklenmek istenen kategoride en fazla 10 ürün olabilir.";

        public static string ProductNameAlreadyExist = "Aynı isimde birden fazla ürün olamaz";

        public static string IfMoreThan15Categories = "15'den fazla kategori olduğu için ürün eklenemez.";

        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor.";
    }
}
