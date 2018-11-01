using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using TenantManagementApi.Models.DTO;
using TenantManagementApi.Models.Login;
using TenantManagementApi.Repository;
using TenantManagementApi.Repository.Specification;

namespace TenantManagementApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/tenant/Login")]
    public class LoginController:ApiController
    {
        ILoginRepository<LoginDetail> _loginRepository = new LoginRepository();

        [Route("AuthenticateUser")]
        public IHttpActionResult PostLoginUser(loginDTO loginDTO)
        {
            if (_loginRepository.AuthenticateUser(loginDTO.Username, loginDTO.Password))
            {
                return Ok(_loginRepository.GetByUsername(loginDTO.Username).Id);
            }
            return Ok();
        }

        [Route("AddLoginDetails")]
        public IHttpActionResult PostAddLoginUserDetails(LoginDetail loginUser)
        {
            return Ok(_loginRepository.Add(loginUser));
        }

        [Route("AllDetails")]
        [ResponseType(typeof(LoginDetailsDTO[]))]
        public IHttpActionResult GetAllLoginDetails()
        {
            return Ok(GetListOfDTO(_loginRepository.GetAll()));
        }

        [Route("GetbyId/Id")]
        [ResponseType(typeof(LoginDetailsDTO))]
        public IHttpActionResult GetLoginDetailsById(string Id)
        {
            return Ok(GetSingleDTO(_loginRepository.GetById(Guid.Parse(Id))));
        }

        [Route("GetbyName/name")]
        [ResponseType(typeof(LoginDetailsDTO))]
        public IHttpActionResult GetLoginDetailsByName(string name)
        {
            return Ok(GetSingleDTO(_loginRepository.GetByUsername(name)));
        }

        [Route("DeleteLogin/Id")]
        public IHttpActionResult DeleteLoginDetail(string Id)
        {
            _loginRepository.Delete(Guid.Parse(Id));
            return Ok("Delete Successfull");
        }

        [Route("SearchByName/name")]
        [ResponseType(typeof(LoginDetailsDTO[]))]
        public IHttpActionResult SearchLoginDetailByName(string name)
        {
            return Ok(GetListOfDTO(_loginRepository.Find(new LoginDetailSpecificationForSearch(new LoginDetailSearchCriteria { LoginDetailUsername = name}))));
        }

        [Route("Update")]
        public IHttpActionResult PutLoginDetail(LoginDetail loginUserDetail)
        {
            _loginRepository.Update(loginUserDetail);
            return Ok("Update Successfull");
        }

        private LoginDetailsDTO GetSingleDTO(LoginDetail loginDetail)
        {
            return new LoginDetailsDTO()
            {
                Id = loginDetail.Id,
                Username=loginDetail.Username,
                Password=loginDetail.Password,
                Captcha = loginDetail.Captcha
            };
        }

        private List<LoginDetailsDTO> GetListOfDTO(IList<LoginDetail> _loginDetails)
        {
            List<LoginDetailsDTO> _loginDetailsDTO = new List<LoginDetailsDTO>();
            foreach (var detail in _loginDetails)
            {                
                _loginDetailsDTO.Add(new LoginDetailsDTO()
                {
                    Id = detail.Id,
                    Username = detail.Username,
                    Password = detail.Password,
                    Captcha = detail.Captcha
                });
            }

            return _loginDetailsDTO;
        }
    }
}