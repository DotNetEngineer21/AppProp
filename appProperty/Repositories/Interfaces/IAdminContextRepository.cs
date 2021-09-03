using appProperty.Models;
using Microsoft.CodeAnalysis;
using PropertyDB.Admin;
using System.Collections.Generic;

namespace appProperty.Repositories.Interfaces
{
    public interface IAdminContextRepository
    {
        int AddOfferContext(OfferContextView model);
        bool UpdateOfferContext(CssOfferContext model);
        List<CssOfferContext> GetOfferContextList();
        CssOfferContext GetOfferContext(int code);
        bool DeleteOfferContext(int code);

        
    }
}
