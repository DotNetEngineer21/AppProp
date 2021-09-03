using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using appProperty.Models;
using PropertyDB.Admin;
using PropertyDB.Building;

namespace appProperty.Repositories.Interfaces
{
    public interface IAdminRepository
    {
        bool AuthenticateUser(LoginViewModel loginViewModel);
        int RegisterUser(UserViewModel userViewModel);

        #region General
        int AddGeneral(GeneralViewModel model);
        bool UpdateGeneral(CssGeneral model);
        List<CssGeneral> GetGeneralList();
        CssGeneral GetGeneral(int code);
        bool DeleteGeneral(int code);
        #endregion

        #region Kind
        List<CssKind> GetKindList();
        #endregion

        #region Address
        int AddAddress(AddressViewModel model);
        bool UpdateAddress(CssAddress model);
        List<CssAddress> GetAddressList();
        CssAddress GetAddress(int code);
        bool DeleteAddress(int code);
        #endregion

     
    }

}
