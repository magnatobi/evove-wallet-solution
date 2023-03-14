using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using evoveWallet.Data.Interfaces;

namespace evoveWallet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserAccountController : ControllerBase
    {
        private readonly IUserAccountRepository _repository;

        public UserAccountController(IUserAccountRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<UserAccount>> GetAllUserAccounts()
        {
            var users = _repository.GetAllUserAccounts;
            return OK(users);
        }

        [HttpGet("{id}")]
        public ActionResult<UserAccount> GetUserAccountById(int id)
        {
            var user = _repository.GetUserAccountById(id);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }
    }
}