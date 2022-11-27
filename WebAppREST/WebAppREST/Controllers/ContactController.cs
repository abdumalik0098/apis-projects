using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppREST.Models;
using WebAppREST.Services;

namespace WebAppREST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private ContactRepository contactRepository;
        public ContactController()
        {
            contactRepository = new ContactRepository();
        }
        public Contact[] Get()
        {
            return contactRepository.GetAllContacts();
        } 
    }
}
