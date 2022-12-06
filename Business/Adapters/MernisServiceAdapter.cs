using Entity.Concrete;
using InterfaceAbstractDemo.Abstract;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(
                    Convert.ToInt64(
                    customer.NationalityId),
                    customer.FirstName.ToUpper(),
                    customer.LastName.ToUpper(),
                    customer.DateOfBirth.Year)
                .Result.Body.TCKimlikNoDogrulaResult;

        }
    }
}
