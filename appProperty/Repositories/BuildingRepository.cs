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
    public class BuildingRepository : IBuildingRepository
    {
        private PropertyDBContext _context;
        private readonly ILogger<BuildingRepository> _logger;
        private IMapper _mapper;



        public BuildingRepository(PropertyDBContext context, ILogger<BuildingRepository> logger)
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

        #region Unit

        /// <summary>
        /// AddUnit: It is used to Add Unit to Database
        /// </summary>
        public int AddUnit(CssUnit model)
        {
            try
            {
                var result = _context.Unit.Add(model);
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
        /// UpdateUnit: It is used to Update Unit
        /// </summary>
        public bool UpdateUnit(CssUnit model)
        {
            try
            {
                var result = _context.Unit.Update(model);
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
        /// GetUnitList: It is used to Get Unit List
        /// </summary>
        public List<CssUnit> GetUnitList()
        {
            try
            {
                var result = _context.Unit.ToList();
                return result;
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                return null;
            }
        }

        /// <summary>
        /// GetUnit: It is used to Get Unit By Id
        /// </summary>
        public CssUnit GetUnit(int code)
        {
            try
            {
                var result = _context.Unit.Where(x => x.Code == code).FirstOrDefault();
                return result;
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                return null;
            }
        }

        /// <summary>
        /// DeleteUnit: It is used to Delete Unit By Id
        /// </summary>
        public bool DeleteUnit(int code)
        {
            try
            {
                var result = _context.Unit.Where(x => x.Code == code).FirstOrDefault();
                var response = _context.Unit.Remove(result);
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

        #region UnitHas

        /// <summary>
        /// AddUnitHas: It is used to Add UnitHas to Database
        /// </summary>
        public int AddUnitHas(CssUnitHas model)
        {
            try
            {
                var result = _context.UnitHas.Add(model);
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
        /// UpdateUnitHas: It is used to Update UnitHas
        /// </summary>
        public bool UpdateUnitHas(CssUnitHas model)
        {
            try
            {
                var result = _context.UnitHas.Update(model);
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
        /// GetUnitHasList: It is used to Get UnitHas List
        /// </summary>
        public List<CssUnitHas> GetUnitHasList()
        {
            try
            {
                var result = _context.UnitHas.ToList();
                return result;
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                return null;
            }
        }

        /// <summary>
        /// GetUnitHas: It is used to Get UnitHas By Id
        /// </summary>
        public CssUnitHas GetUnitHas(int code)
        {
            try
            {
                var result = _context.UnitHas.Where(x => x.Code == code).FirstOrDefault();
                return result;
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                return null;
            }
        }

        /// <summary>
        /// DeleteUnitHas: It is used to Delete UnitHas By Id
        /// </summary>
        public bool DeleteUnitHas(int code)
        {
            try
            {
                var result = _context.UnitHas.Where(x => x.Code == code).FirstOrDefault();
                var response = _context.UnitHas.Remove(result);
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

        #region Amenities

        /// <summary>
        /// AddAmenities: It is used to Add Amenities to Database
        /// </summary>
        public int AddAmenities(CssAmenities model)
        {
            try
            {
                var result = _context.Amenities.Add(model);
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
        /// UpdateAmenities: It is used to Update Amenities
        /// </summary>
        public bool UpdateAmenities(CssAmenities model)
        {
            try
            {
                var result = _context.Amenities.Update(model);
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
        /// GetAmenitiesList: It is used to Get Amenities List
        /// </summary>
        public List<CssAmenities> GetAmenitiesList()
        {
            try
            {
                var result = _context.Amenities.ToList();
                return result;
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                return null;
            }
        }

        /// <summary>
        /// GetAmenities: It is used to Get Amenities By Id
        /// </summary>
        public CssAmenities GetAmenities(int code)
        {
            try
            {
                var result = _context.Amenities.Where(x => x.Code == code).FirstOrDefault();
                return result;
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                return null;
            }
        }

        /// <summary>
        /// DeleteAmenities: It is used to Delete Amenities By Id
        /// </summary>
        public bool DeleteAmenities(int code)
        {
            try
            {
                var result = _context.Amenities.Where(x => x.Code == code).FirstOrDefault();
                var response = _context.Amenities.Remove(result);
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

        #region Building

        /// <summary>
        /// AddAmenities: It is used to Add Building to Database
        /// </summary>
        public int AddBuilding(CssBuilding model)
        {
            try
            {
                var result = _context.Building.Add(model);
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
        /// UpdateBuilding: It is used to Update Building
        /// </summary>
        public bool UpdateBuilding(CssBuilding model)
        {
            try
            {
                var result = _context.Building.Update(model);
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
        /// GetBuildingList: It is used to Get Building List
        /// </summary>
        public List<CssBuilding> GetBuildingList()
        {
            try
            {
                var result = _context.Building.ToList();
                return result;
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                return null;
            }
        }

        /// <summary>
        /// GetBuilding: It is used to Get Building By Id
        /// </summary>
        public CssBuilding GetBuilding(int code)
        {
            try
            {
                var result = _context.Building.Where(x => x.Code == code).FirstOrDefault();
                return result;
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                return null;
            }
        }

        /// <summary>
        /// DeleteBuilding: It is used to Delete Building By Id
        /// </summary>
        public bool DeleteBuilding(int code)
        {
            try
            {
                var result = _context.Building.Where(x => x.Code == code).FirstOrDefault();
                var response = _context.Building.Remove(result);
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
