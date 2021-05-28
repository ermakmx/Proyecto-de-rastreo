using System;
using System.Net;
using bakend.Models;
using System.Threading;
using System.Web.Http;


namespace bakend.Controllers
{
    [AllowAnonymous]
    [RoutePrefix("api/login")]
    public class LoginController : ApiController{
        [HttpGet]
        [Route("echoping")]
        public IHttpActionResult EchoPing(){
            return Ok(true);
        }
        public IHttpActionResult EchoUser(){
            var identity = Thread.CurrentPrincipal.Identity;
            return Ok($" IPrincipal-user: {identity.Name} - 
            IsAuthenticated: {identity.IsAuthenticated}");
        }
        [HttpPost]
        [Route("authenticate")]
        public IHttpActionResult Authenticate(LoginRequest login){
            if(login == null){
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            bool isCredentialValid = (login.password=="12345678");

            if(isCredentialValid){
                var token = TokenGenerator.GenerateTokenJwt(login.email);
                return Ok(token);
            }else
            {
                return Unauthorized();
            }

        }


        
    }
}