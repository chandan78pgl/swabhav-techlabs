using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using TenantManagementApi.Models.DTO;
using TenantManagementApi.Models.Login;
using TenantManagementApi.Models.MasterModel;
using TenantManagementApi.Models.Tenant;
using TenantManagementApi.Repository;
using TenantManagementApi.Repository.Specification;

namespace TenantManagementApi.Controllers
{
    [EnableCors(origins:"*",headers:"*",methods:"*")]
    [RoutePrefix("api/tenant")]
    public class TenantController : ApiController
    {
        ITenantRepository<User> _tenantRepository = new TenantRepository();

        [Route("User/Register")]
        public IHttpActionResult PostRegisterUser(UserDTO userDTO)
            {
            User user = new User();
            user.Name = userDTO.UserDetails.Name;
            user.Role = "customer";
            user.ShortName = userDTO.UserDetails.ShortName;
            user.Currency = userDTO.UserDetails.Currency;
            user.WebUrl = userDTO.UserDetails.WebUrl;

            user.AddressDetail = new List<Address>();

            foreach (var addressDetail in userDTO.UserDetails.AddressDetails)
            {
                user.AddressDetail.Add(new Address
                {
                    Street = addressDetail.Street,
                    City = addressDetail.City,
                    State = addressDetail.State,
                    Country = addressDetail.Country,
                    ZipCode = addressDetail.ZipCode,
                });
            }
            

            user.ContactDetail = new List<ContactDetail>();

            foreach (var contactDetail in userDTO.UserDetails.ContactDetails)
            {
                user.ContactDetail.Add(new ContactDetail
                {
                    FirstName = contactDetail.FirstName,
                    LastName = contactDetail.LastName,
                    PhoneNumber = contactDetail.Mobile,
                    Email = contactDetail.Email
                });
            }
            

            user.UserLoginDetails = new LoginDetail
            {
                Username = userDTO.LoginDetails.Username,
                Password = userDTO.LoginDetails.Password,
                Captcha = userDTO.LoginDetails.Captcha
            };

            Master userMaster = new Master();
            userMaster.ModuleMaster = new List<Module>();
            userMaster.ServiceMaster = new List<Service>();
            userMaster.PartnerMaster = new List<Partner>();

            foreach (var item in userDTO.SubscriptionDetails.Modules)
            {
                userMaster.ModuleMaster.Add(new Module { Name = item });
            }
            
            foreach (var item in userDTO.SubscriptionDetails.Services)
            {
                userMaster.ServiceMaster.Add(new Service { Name = item });
            }
            
            userMaster.PartnerMaster.Add(new Partner
            {
                Name = "AurionPro"
            });

            user.UserMasterDetails = userMaster;
            user.UserSubscriptionDetails = new List<Subscription>();

            user.UserSubscriptionDetails.Add(new Subscription {
                Type = userDTO.SubscriptionDetails.Type,
                NoOfNamedUsers = userDTO.SubscriptionDetails.NoOfNamedUsers,
                UserModules = userMaster.ModuleMaster,
                UserServices = userMaster.ServiceMaster
            });

            return Ok(_tenantRepository.Add(user));
        }

        [Route("User/Update")]
        public IHttpActionResult PutUpdateUser(UserDetailsDTO userdetails)
        {
            User user = new User();
            
            _tenantRepository.Update(user);
            return Ok("Update Successfull");
        }

        [Route("User/Delete/Id")]
        public IHttpActionResult DeleteUser(string Id)
        {
            _tenantRepository.Delete(Guid.Parse(Id));
            return Ok("Delete Successfull");
        }

        [Route("User/Id")]
        [ResponseType(typeof(UserDTO))]
        public IHttpActionResult GetUserById(string Id)
        {
            return Ok(GetSingleUserDTO(_tenantRepository.GetById(Guid.Parse(Id))));
        }

        [Route("User/Search/name")]
        [ResponseType(typeof(UserDetailsDTO[]))]
        public IHttpActionResult SearchUserByName(string name)
        {
            return Ok(GetListOfDTO(_tenantRepository.Find(new UserSpecificationForSearch(new UserSearchCriteria { UserName=name}))));
        }

        [Route("User/AllUsers")]
        [ResponseType(typeof(UserDetailsDTO[]))]
        public IHttpActionResult GetAllUsers()
        {
            return Ok(GetListOfDTO(_tenantRepository.GetAll()));
        }

        private UserDetailsDTO GetSingleDTO(User userDetail)
        {
            return new UserDetailsDTO()
            {
                Id = userDetail.Id,
                Name = userDetail.Name,
                Role = userDetail.Role,
                Currency = userDetail.Currency,
                ShortName = userDetail.ShortName,
                WebUrl = userDetail.WebUrl,
                AddressDetails =  GetListOfAddressDTO(userDetail.AddressDetail),
                ContactDetails = GetListOfContactDTO(userDetail.ContactDetail)
            };
        }

        private LoginDetailsDTO GetSingleLoginDetailDTO(LoginDetail loginDetail)
        {
            return new LoginDetailsDTO
            {
                Id = loginDetail.Id,
                Username = loginDetail.Username,
                Password = loginDetail.Password,
                Captcha = loginDetail.Captcha
            };
        }

        private UserDTO GetSingleUserDTO(User userDetail)
        {
            return new UserDTO()
            {
                UserDetails = GetSingleDTO(userDetail),
                LoginDetails = GetSingleLoginDetailDTO(userDetail.UserLoginDetails),
                SubscriptionDetails = null
            
            };
        }



        private List<ContactDetailsDTO> GetListOfContactDTO(List<ContactDetail> contactDetails)
        {
            List<ContactDetailsDTO> _contactDetailsDTO = new List<ContactDetailsDTO>();

            foreach (var detail in contactDetails)
            {
                _contactDetailsDTO.Add(new ContactDetailsDTO {
                    Id=detail.Id,
                    FirstName = detail.FirstName,
                    LastName = detail.LastName,
                    Mobile = detail.PhoneNumber,
                    Email = detail.Email
                });
            }

            return _contactDetailsDTO;
        }

        private List<AddressDetailsDTO> GetListOfAddressDTO(List<Address> addressDetails)
        {
            List<AddressDetailsDTO> _addressDetailsDTO = new List<AddressDetailsDTO>();

            foreach (var detail in addressDetails)
            {
                _addressDetailsDTO.Add(new AddressDetailsDTO
                {
                    Id = detail.Id,
                    Street = detail.Street,
                    City  = detail.City,
                    State = detail.State,
                    Country = detail.Country,
                    ZipCode = detail.ZipCode
                });
            }

            return _addressDetailsDTO;
        }

        private List<UserDetailsDTO> GetListOfDTO(IList<User> _userDetails)
        {
            List<UserDetailsDTO> _userDetailsDTO = new List<UserDetailsDTO>();
            foreach (var userDetail in _userDetails)
            {
                _userDetailsDTO.Add(new UserDetailsDTO()
                {
                    Id = userDetail.Id,
                    Name = userDetail.Name,
                    Role = userDetail.Role,
                    Currency = userDetail.Currency,
                    ShortName = userDetail.ShortName,
                    WebUrl = userDetail.WebUrl
                });
            }

            return _userDetailsDTO;
        }
    }
}