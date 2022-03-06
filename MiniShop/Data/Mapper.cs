using AutoMapper;
using MiniShop.Entities;
using MiniShop.Entities.DTO;

namespace MiniShop.Data
{

    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Customer, CustomerDto>().ForMember(c => c.FullName, x => x.MapFrom(c => string.Join(" ", c.LastName, c.FirstName)));
            CreateMap<Invoice, InvoiceDto>();
            CreateMap<DiscountType, DiscountDto>();

            CreateMap<CreateCustomerDto, Customer>();
            CreateMap<CreateDiscountDto, DiscountType>();
        }
    }

}
