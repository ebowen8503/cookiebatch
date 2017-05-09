using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieBatch
{
    class BatchCookie
    {
        private List<Cookies> cookieType;

        public List<Cookies> batches{
            get
            {
                return cookieType;
            }
        }
        public int cookieCount{
            get
            {
                return cookieType.Count;
            }
        }
        public BatchCookie()
        {
            cookieType = new List<Cookies>();
        }
        public void createCookies(string cookieName, string cookieShape, string cookieSize, string cookieFilling, string cookieIcing)
        {

            Cookies cookies1 = new Cookies();
            cookies1.cookieName = cookieName;
            cookies1.cookieShape = cookieShape;
            cookies1.cookieSize = cookieSize;
            cookies1.cookieFilling = cookieFilling;
            cookies1.cookieIcing = cookieIcing;

            cookieType.Add(cookies1);
                  
        }
    }
}
