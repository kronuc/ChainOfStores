using ChainOfStores.EFData.Entities;
using ChainOfStores.Model.ViewEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.Model.Mappers
{
    class BookingMapper
    {
        public static Booking ToDataEntity(BookingView viewEntity)
        {
            Booking dataEntity = new Booking();
            dataEntity.Id = viewEntity.Id;
            dataEntity.ProductID = viewEntity.ProductID;
            dataEntity.DataOfBooking = viewEntity.DataOfBooking;
            dataEntity.LastDayOfBooking = viewEntity.LastDayOfBooking;
            dataEntity.ClientName = viewEntity.ClientName;
            return dataEntity;
        }

        public static BookingView ToViewEntity(Booking dataEntity)
        {
            BookingView viewEntity = new BookingView();
            viewEntity.Id = dataEntity.Id;
            viewEntity.DataOfBooking = dataEntity.DataOfBooking;
            viewEntity.LastDayOfBooking = dataEntity.LastDayOfBooking;
            viewEntity.ProductID = dataEntity.ProductID;
            viewEntity.ClientName = dataEntity.ClientName;
            return viewEntity;
        }
    }
}
