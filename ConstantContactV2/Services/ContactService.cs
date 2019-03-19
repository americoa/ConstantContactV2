using System.Collections.Generic;
using System.Threading.Tasks;
using Aarvani.ConstantContactV2.Configurations;
using Aarvani.ConstantContactV2.Models.Contacts;
using Aarvani.ConstantContactV2.Requests;

namespace Aarvani.ConstantContactV2.Services
{
    public class ContactService
    {

        public async Task<IList<Contact>> GetContacts()
        {
            RequestGet<Contact> request = new RequestGet<Contact>();
            var url = string.Format("{0}?status={1}&limit={2}", Endpoints.contact, "All", 50);
            var list = await request.GetAll(url);
            return list.Results;
        }
    }
}
