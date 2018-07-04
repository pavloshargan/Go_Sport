using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace WCF
{
    public static class TokenConverter
    {
        public static Token ToToken(TokenInfo token)
        {
            using (DataModel context = new DataModel())
            {
                return context.Tokens.FirstOrDefault(x => x.Session.Login == token.Session.Login);
            }
        }
        public static TokenInfo ToTokenInfo(Token token)
        {
            return new TokenInfo() { Key = token.Key, Date = token.Date, Session = UserConverter.ToUserInfo(token.Session) };
        }
    }
}
