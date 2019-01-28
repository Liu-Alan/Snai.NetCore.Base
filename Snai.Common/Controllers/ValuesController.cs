using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Snai.Common.Encrypt;
using Snai.Common.Extension;
using Snai.Common.Utils;

namespace Snai.Common.Controllers
{
    public class ValuesController : ControllerBase
    {
        public ActionResult<string> GetIp()
        {
            return HttpContext.GetUserIp();
        }

        public ActionResult<string> GetMd5(string source)
        {
            return EncryptMd5.EncryptByte(source);
        }

        public ActionResult<string> GetRandom()
        {
            return RandomUtil.CreateRandom(6);
        }

        public ActionResult<string> GetTimestamp(string datetime)
        {
            DateTime dateValue;
            DateTime.TryParse(datetime, out dateValue);
            if (dateValue != null && dateValue > DateTime.MinValue)
            {
                return DateTimeUtil.DateTimeToUnixTimeStamp(dateValue).ToString();
            }
            else
            {
                return $"{DateTimeUtil.DateTimeToUnixTimeStamp(DateTime.Now).ToString()}，失败";
            }
        }

        public ActionResult<String> GetDateTime(string timestamp)
        {
            long timestampValue;
            long.TryParse(timestamp, out timestampValue);
            return DateTimeUtil.UnixTimeStampToDateTime(timestampValue).ToString();
        }
    }
}