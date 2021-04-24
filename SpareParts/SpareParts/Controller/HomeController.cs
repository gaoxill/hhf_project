using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SpareParts.Data.AppDbContext;
using SpareParts.Data.Model;
using SpareParts.Helpers;
using SpareParts.Iservice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpareParts.Controller
{
    [Route("api/Home")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ILoginService _login;
        private readonly IRegisterService _register;
        private readonly AppDbContext _myContext;

        public HomeController(ILoginService login,IRegisterService register,AppDbContext context)
        {
            _login = login;
            _register = register;
            _myContext = context;
        }
        //====== 通过用户名、密码登录======//
        [AllowAnonymous]
        [HttpGet("login")]
        public IActionResult Login(string querystring, string password)
        {
            var result = new LoginReturnMessage();

            if (!_register.UserNameIsExist(querystring))
            {
                result.Success = 0;
                result.Message = "该用户名尚未注册";
                return Ok(result);
            }

            if (!_login.Login(querystring, password))
            {
                result.Success = 0;
                result.Message = "登录失败，用户名或密码错误";
                return Ok(result);
            }
            else
            {
                var user = _myContext.new_account
                    .Where(x => x.new_account_mail.Contains(querystring) ||
                                        x.new_account_name.Contains(querystring) ||
                                        x.new_account_phone.Contains(querystring)).ToList().FirstOrDefault();
                result.Success = 1;
                result.Message = "登录成功";
                result.user = user;
                return Ok(result);
            }

        }

        //通过用户名注册
        [AllowAnonymous]
        [HttpPost("registerByUserName")]
        public async Task<IActionResult> registerByUserName([FromBody]account model)
        {
            var uid = Guid.NewGuid();
            model.new_account_id = uid;
             Result result = new Result();

            if (_register.UserNameIsExist(model.new_account_name))
            {
                result.Success = 0;
                result.Message = "该用户名已存在";
                return Ok(result);
            }
          
            account user = model;

            if (!_register.AddUser(user))
            {
                result.Success = 0;
                result.Message = "注册失败";
                return Ok(result);
            }

            var falg =  await _myContext.SaveChangesAsync() > 0; ;
            if (!falg)
            {
                result.Success = 0;
                result.Message = "注册失败";
                return Ok(result);
            }

            result.Success = 1;
            result.Message = "注册成功";
            return Ok(result);
        }

    }
}
