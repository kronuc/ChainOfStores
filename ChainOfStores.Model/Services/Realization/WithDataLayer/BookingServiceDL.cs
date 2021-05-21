using Abp.EntityFramework.Uow;
using ChainOfStores.EFData.Entities;
using ChainOfStores.EFData.UnitOfWork.Interfaces;
using ChainOfStores.EFData.UnitOfWork.Realisation.EFRealisation;
using ChainOfStores.Model.Mappers;
using ChainOfStores.Model.Services.Interfaces;
using ChainOfStores.Model.ViewEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.Model.Services.Realization.WithDataLayer
{
    public class BookingServiceDL : IBookingService
    {
        private IUnitOfWork _unitOfWork;

        public BookingServiceDL()
        {
            _unitOfWork = new EFUnitOfWork();
        }

        public void DeleteBooking(int bookingID)
        {
            _unitOfWork.BookingRepository.Delete(_unitOfWork.BookingRepository.GetById(bookingID));
            _unitOfWork.Save();
        }

        public IEnumerable<BookingView> GetAllBookings()
        {
            return _unitOfWork.BookingRepository.GetAll().Select(obj => BookingMapper.ToViewEntity(obj));
        }

        public BookingView GetBookingByID(int bookingID)
        {
            return BookingMapper.ToViewEntity(_unitOfWork.BookingRepository.GetById(bookingID));
        }

        public void MakeBooking(int productID, DateTime dataOfBooking)
        {
            Booking booking = new Booking() { ProductID = productID, DataOfBooking = dataOfBooking };
            _unitOfWork.BookingRepository.Create(booking);
            _unitOfWork.Save();
        }
        public bool DoesProductAvailable(int productId)
        {
            return !_unitOfWork.BookingRepository.GetAll().Where(booking => booking.ProductID == productId).Any();
        }
    }
}
