using Otto.products.DTO;

namespace Otto.products.Models.Responses
{
    public class MProductsSearchResponse
    {
        public MProductsSearchResponse(Response r, string v, List<MProductsSearchDTO> _mProductsSearch)
        {
            res = r;
            msg = v;
            mProductsSearch = _mProductsSearch;
        }

        public Response res { get; set; }

        public string msg { get; set; }

        public List<MProductsSearchDTO> mProductsSearch { get; set; }
    }
}
