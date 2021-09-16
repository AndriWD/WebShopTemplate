using NewWebShopStream.Domain.Intefaces;
using NewWebShopStream.Domain.Models;
using NewWebShopStream.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewWebShopStream.Domain.Repositories
{
    public class ServiceItemRepository : IServiceItemRepository
    {
        private readonly AppDbContext db;
        public ServiceItemRepository(AppDbContext appDbContext)
        {
            db = appDbContext;
        }
        public void DeleteServiceItem(Guid id)
        {
            var serviceItem = db.ServiceItems.FirstOrDefault(s => s.Id.Equals(id));
            if (serviceItem != null)
                db.ServiceItems.Remove(serviceItem);
        }

        public ServiceItem GetServiceItemById(Guid id)
        {
            return db.ServiceItems.FirstOrDefault(s => s.Id.Equals(id));
        }

        public IQueryable<ServiceItem> GetServiceItems()
        {
            return db.ServiceItems;
        }

        public void SaveServiceItem(ServiceItem serviceItem)
        {
            if (serviceItem.Id == default)
                db.Entry<ServiceItem>(serviceItem).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            else
                db.Entry(serviceItem).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
