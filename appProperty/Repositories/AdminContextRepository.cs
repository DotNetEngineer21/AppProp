using appProperty.Models;
using appProperty.Repositories.Interfaces;
using AutoMapper;
using Microsoft.Extensions.Logging;
using PropertyDB;
using PropertyDB.Admin;
using System;
using System.Collections.Generic;
using System.Linq;

namespace appProperty.Repositories
{
    public class AdminContextRepository : IAdminContextRepository
    {
        private PropertyDBContext _context;
        private readonly ILogger<AdminContextRepository> _logger;
        private IMapper _mapper;

        public AdminContextRepository(PropertyDBContext context, ILogger<AdminContextRepository> logger)
        {
            _context = context;
            _logger = logger;

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<OfferContextView, CssOfferContext>();

            });
            _mapper = config.CreateMapper();

        }
        #region OfferContext

        /// <summary>
        /// Add Offer Context
        /// </summary>
        public int AddOfferContext(OfferContextView model)
        {
            try
            {
        //        var offercontext = _mapper.Map<CssOfferContext>(model);
        ////var pagetogo = _context.Item.Where(x => x.Code == model.Code).FirstOrDefault();
        //offercontext.Code = pagetogo;
        //        var result = _context.Item.Add(pagetogo);
        //_context.SaveChanges();
                return 0;

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
        public bool UpdateOfferContext(CssOfferContext model)
        {
            try
            {
                var result = _context.OfferContext.Update(model);
                return true;
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                return false;
            }
        }

        /// <summary>
        /// Get List Offer Context
        /// </summary>
        public List<CssOfferContext> GetOfferContextList()
        {
            try
            {
                var result = _context.OfferContext.ToList();
                return result;
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                return null;
            }
        }

        /// <summary>
        /// Get Offer Context
        /// </summary>
        public CssGeneral GetOfferContext(int code)
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
        /// Delete Offer Context
        /// </summary>
        public bool DeleteOfferContext(int code)
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

        CssOfferContext IAdminContextRepository.GetOfferContext(int code)
        {
            throw new NotImplementedException();
        }

        
        #endregion
    }
}
