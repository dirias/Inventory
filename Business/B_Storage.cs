using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Business
{
    public class B_Storage
    {
        public static List<StorageEntity> StorageList()
        {
            using (var db = new InventaryContext())
            {
                return db.Storages.ToList();
            }
        }

        public static List<StorageEntity> StorageProductsByWarehouseList(string idWarehouse)
        {
            using (var db = new InventaryContext())
            {
                return db.Storages.Include(x => x.Product).Include(x => x.Warehouse).Where(x => x.WarehouseId == idWarehouse).ToList();
            }
        }
        public static void CreateStorage(StorageEntity oStorage)
        {
            using (var db = new InventaryContext())
            {
                db.Storages.Add(oStorage);
                db.SaveChanges();
            }
        }
        public static bool IsProductInWarehouse(string id)
        {
            using (var db = new InventaryContext())
            {
                var product = db.Storages.ToList().Where(x => x.StorageId == id);
                var x = product.Any();
                return x;
            }
        }
        public static void UpdateStorage(StorageEntity oStorage)
        {
            using (var db = new InventaryContext())
            {
                db.Storages.Update(oStorage);
                db.SaveChanges();
            }
        }
    }
}
