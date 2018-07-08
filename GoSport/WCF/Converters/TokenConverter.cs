using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using BLL.BLL_DTO;
using WCF.DataContracts;
using AutoMapper;
namespace WCF
{
    public static class TokenConverter
    {
        public static Token_BLL_DTO ToToken_BLL_DTO(TokenInfo token)
        {
            var dest = Mapper.Map<TokenInfo,Token_BLL_DTO>(token);
            return dest;
        }
      /*  public static TokenInfo ToTokenInfo(Token token)
        {
            return new TokenInfo() { Key = token.Key, Date = token.Date, Session = UserConverter.ToUserInfo(token.Session) };
        }*/
    }
}
