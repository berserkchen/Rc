using System;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Rc.Models;
using System.Threading.Tasks;
using System.Web;
using System.IO;
using System.Net.Http.Headers;

namespace Rc.Controllers
{
    public class ReportController : ApiController
    {
        private RcContext db = new RcContext();
        // GET api/<controller>
        [HttpGet]
        public async Task<HttpResponseMessage> GetXLSReport(string year)
        {
            string fileName = string.Concat("Costs.xlsx");
            string filePath = HttpContext.Current.Server.MapPath("~/Report/" + fileName);
            var costs = from s in db.Costs
                        select s;
            costs = costs.Where(s => s.Column_A.Contains(year));
            
            List<Cost> costList = costs.ToList();

            await Rc.Report.ReportGenerator.GenerateXLS(costList, filePath);

            HttpResponseMessage result = null;
            result = Request.CreateResponse(HttpStatusCode.OK);
            result.Content = new StreamContent(new FileStream(filePath, FileMode.Open));
            result.Content.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment");
            result.Content.Headers.ContentDisposition.FileName = fileName;

            return result;
        }
    }
}