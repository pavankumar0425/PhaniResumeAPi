using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using PhaniResume.BusinessLayer.Interfaces;
using PhaniResume.Entities;

namespace PhaniResumeAPi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [RoutePrefix("PhaniResume")]
    public class PhaniResumeController : ApiController
    {
        private readonly IPhaniResumeBussinessLayer _phaniResumeBussinessLayer;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="phaniResumeBussinessLayer"></param>
        public PhaniResumeController(IPhaniResumeBussinessLayer phaniResumeBussinessLayer)
        {
            _phaniResumeBussinessLayer = phaniResumeBussinessLayer;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetAllResumeDetailsByCustomer")]
        [ResponseType(typeof(List<ResumeDetail>))]
        public IHttpActionResult GetAllResumeDetailsByCustomer(int customerId)
        {
            try
            {
                var result = _phaniResumeBussinessLayer.GetAllResumeDetailsByCustomer(customerId);
                return Ok(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return ResponseMessage(Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e.Message));
            }

        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetcustomerByCustomer")]
        [ResponseType(typeof(CustomerDetail))]
        public IHttpActionResult GetcustomerByCustomer(int customerId)
        {
            try
            {
                var result = _phaniResumeBussinessLayer.GetcustomerByCustomer(customerId);
                return Ok(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return ResponseMessage(Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e.Message));
            }

        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("SaveResumeDetails")]
        [ResponseType(typeof(bool))]
        public IHttpActionResult GetcustomerByCustomer(CustomerDetail customerDetail)
        {
            try
            {
                var result = _phaniResumeBussinessLayer.SaveResumeDetails(customerDetail);
                return Ok(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return ResponseMessage(Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e.Message));
            }

        }
    }
}
