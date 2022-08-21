using Otto.products.DTO;

namespace Otto.products.Models.Responses
{
    public class StockResponse
    {

        public StockResponse(Response r, string v, List<StockDTO> _stockDTO)
        {
            res = r;
            msg = v;
            stockDTOs = _stockDTO;
        }

        public Response res { get; set; }

        public string msg { get; set; }

        public List<StockDTO> stockDTOs { get; set; }
    }
}