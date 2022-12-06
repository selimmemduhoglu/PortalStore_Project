using API.Controllers;
using Business.Abstract;
using Entity.Concrete;


namespace Portal_TestProject
{
    public class UnitTest1
    {
        IAddressService _addressService;
        private Address ist;

        public UnitTest1(IAddressService addressService)
        {
            _addressService = addressService;
        }


        [Fact]
        public void API_AddressesController_AddMethod()
        {
            var sonuc =_addressService.Add(ist);
            //object value = Assert.Equal(sonuc,);

        }
    }
}