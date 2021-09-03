using PropertyDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using appProperty.Repositories.Interfaces;
using appProperty.Models;
using PropertyDB.Admin;
using Microsoft.Extensions.Logging;
using AutoMapper;
using PropertyDB.Building;

namespace appProperty.Repositories
{
    public class AdminRepository : IAdminRepository
    {
        private PropertyDBContext _context;
        private readonly ILogger<AdminRepository> _logger;
        private IMapper _mapper;



        public AdminRepository(PropertyDBContext context, ILogger<AdminRepository> logger)
        {
            _context = context;
            _logger = logger;
            //Auto Mapper Configuration
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<UserViewModel, CssUser>();
                cfg.CreateMap<GeneralViewModel, CssGeneral>();
                cfg.CreateMap<AddressViewModel, CssAddress>();
            });
            _mapper = config.CreateMapper();

        }

        #region User

        /// <summary>
        /// AuthenticateUser: This Method is used to authenticate user by checking username and password
        /// </summary>
        public bool AuthenticateUser(LoginViewModel loginViewModel)
        {
            try
            {
                var user = _context.User.Where(x => x.UserName.ToLower() == loginViewModel.Email.ToLower() && x.Password == loginViewModel.Password).FirstOrDefault();
                if (user != null)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                return false;
            }
        }

        /// <summary>
        /// RegisterUser: This Method register user new user to system
        /// </summary>
        public int RegisterUser(UserViewModel userViewModel)
        {
            try
            {
                var user = _mapper.Map<CssUser>(userViewModel);
                var result = _context.User.Add(user);
                _context.SaveChanges();
                return result.Entity.Code;
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                return 0;
            }
        }

        #endregion

        #region General

        /// <summary>
        /// AddGeneral: It is used to Add General to Database
        /// </summary>
        public int AddGeneral(GeneralViewModel model)
        {
            try
            {
                var general = _mapper.Map<CssGeneral>(model);
                var kind = _context.Kind.Where(x => x.Code == model.KindCode).FirstOrDefault();
                general.Kind = kind;
                var result = _context.General.Add(general);
                _context.SaveChanges();
                return result.Entity.Code;
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                return 0;
            }
        }

        /// <summary>
        /// UpdateGeneral: It is used to Update General
        /// </summary>
        public bool UpdateGeneral(CssGeneral model)
        {
            try
            {
                var result = _context.General.Update(model);
                return true;
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                return false;
            }
        }

        /// <summary>
        /// GetGeneralList: It is used to Get General List
        /// </summary>
        public List<CssGeneral> GetGeneralList()
        {
            try
            {
                var result = _context.General.ToList();
                return result;
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                return null;
            }
        }

        /// <summary>
        /// GetGeneral: It is used to Get General By Id
        /// </summary>
        public CssGeneral GetGeneral(int code)
        {
            try
            {
                var result = _context.General.Where(x => x.Code == code).FirstOrDefault();
                return result;
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                return null;
            }
        }

        /// <summary>
        /// DeleteGeneral: It is used to Delete General By Id
        /// </summary>
        public bool DeleteGeneral(int code)
        {
            try
            {
                var result = _context.General.Where(x => x.Code == code).FirstOrDefault();
                var response = _context.General.Remove(result);
                return true;
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                return false;
            }
        }

        #endregion

        #region Kind
        /// <summary>
        /// GetKindList: It is used to Get Kind List
        /// </summary>
        public List<CssKind> GetKindList()
        {
            try
            {
                var result = _context.Kind.ToList();
                return result;
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                return null;
            }
        }
        #endregion

        #region Address

        /// <summary>
        /// AddAddress: It is used to Add Address to Database
        /// </summary>
        public int AddAddress(AddressViewModel model)
        {
            try
            {
                var address = _mapper.Map<CssAddress>(model);
                var city = _context.City.Where(x => x.Code == model.CityCode).FirstOrDefault();
                address.City = city;
                var result = _context.Address.Add(address);
                return result.Entity.Code;
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                return 0;
            }
        }

        /// <summary>
        /// UpdateAddress: It is used to Update Address
        /// </summary>
        public bool UpdateAddress(CssAddress model)
        {
            try
            {
                var result = _context.Address.Update(model);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                return false;
            }
        }

        /// <summary>
        /// GetAddressList: It is used to Get Address List
        /// </summary>
        public List<CssAddress> GetAddressList()
        {
            try
            {
                var result = _context.Address.ToList();
                return result;
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                return null;
            }
        }

        /// <summary>
        /// GetAddress: It is used to Get Address By Id
        /// </summary>
        public CssAddress GetAddress(int code)
        {
            try
            {
                var result = _context.Address.Where(x => x.Code == code).FirstOrDefault();
                return result;
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                return null;
            }
        }

        /// <summary>
        /// DeleteAddress: It is used to Delete Address By Id
        /// </summary>
        public bool DeleteAddress(int code)
        {
            try
            {
                var result = _context.Address.Where(x => x.Code == code).FirstOrDefault();
                var response = _context.Address.Remove(result);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                return false;
            }
        }

        #endregion

        
    }
}
