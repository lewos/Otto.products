﻿using Otto.products.DTO;

namespace Otto.products.Models.Responses
{
    public class MAccessTokenResponse
    {
        public MAccessTokenResponse(Response r, string v, MTokenDTO mToken)
        {
            res = r;
            msg = v;
            token = mToken;
        }

        public Response res { get; set; }

        public string msg { get; set; }

        public MTokenDTO token { get; set; }
    }
}
