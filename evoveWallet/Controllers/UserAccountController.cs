using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using evoveWallet.Data.Interfaces;
using evoveWallet.Data;

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
        public ActionResult<IEnumerable<UserAccount>> GetAllUsersAccount()
        {
            var users = _repository.GetAllUsersAccount();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public ActionResult<UserAccount> GetUserAccountById(Guid id)
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