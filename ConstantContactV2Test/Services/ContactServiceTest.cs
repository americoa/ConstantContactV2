
using System.Threading.Tasks;
using Aarvani.ConstantContactV2.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Aarvani.ConstantContactV2Test.Services
{
    [TestClass]
    public class ContactServiceTest
    {
        [TestMethod]
        public async Task ShouldGetContacts()
        {
            // arrange
            ContactService contactService = new ContactService();

            // act
            var listContact = await contactService.GetContacts();

            // assert
            Assert.IsNotNull(listContact);
        }
    }
}
