using Otto.products.DTO;

namespace Otto.products.Models.Responses
{
    public class MItemsSearchResponse
    {
        public MItemsSearchResponse(Response r, string v, MItemsSearchDTO _mItemsSearch)
        {
            res = r;
            msg = v;
            mItemsSearch = _mItemsSearch;
        }

        public Response res { get; set; }

        public string msg { get; set; }

        public MItemsSearchDTO mItemsSearch { get; set; }
    }
}
