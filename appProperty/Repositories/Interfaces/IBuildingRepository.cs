using System.Collections.Generic;
using PropertyDB.Building;

namespace appProperty.Repositories.Interfaces
{
    public interface IBuildingRepository
    {
        #region Unit
        int AddUnit(CssUnit model);
        bool UpdateUnit(CssUnit model);
        List<CssUnit> GetUnitList();
        CssUnit GetUnit(int code);
        bool DeleteUnit(int code);
        #endregion

        #region UnitHas
        int AddUnitHas(CssUnitHas model);
        bool UpdateUnitHas(CssUnitHas model);
        List<CssUnitHas> GetUnitHasList();
        CssUnitHas GetUnitHas(int code);
        bool DeleteUnitHas(int code);
        #endregion

        #region Amenities
        int AddAmenities(CssAmenities model);
        bool UpdateAmenities(CssAmenities model);
        List<CssAmenities> GetAmenitiesList();
        CssAmenities GetAmenities(int code);
        bool DeleteAmenities(int code);
        #endregion

        #region Building
        int AddBuilding(CssBuilding model);
        bool UpdateBuilding(CssBuilding model);
        List<CssBuilding> GetBuildingList();
        CssBuilding GetBuilding(int code);
        bool DeleteBuilding(int code);
        #endregion
    }

}
