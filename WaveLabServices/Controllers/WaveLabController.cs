//------------------------------------------------------------------------------
//----- HttpController ---------------------------------------------------------
//------------------------------------------------------------------------------

//-------1---------2---------3---------4---------5---------6---------7---------8
//       01234567890123456789012345678901234567890123456789012345678901234567890
//-------+---------+---------+---------+---------+---------+---------+---------+

// copyright:   2017 WiM - USGS

//    authors:  Jeremy K. Newson USGS Web Informatics and Mapping
//              
//  
//   purpose:   Handles resources through the HTTP uniform interface.
//
//discussion:   Controllers are objects which handle all interaction with resources. 
//              
//
// 

using Microsoft.AspNetCore.Mvc;
using System;
using WaveLabAgent;
using WaveLabServices.Resources;
using System.Threading.Tasks;
using System.Collections.Generic;
using WiM.Resources;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.Linq;

namespace WaveLabServices.Controllers
{
    [Route("[controller]")]
    public class WaveLabController : WiM.Services.Controllers.ControllerBase
    {
        public IWaveLabAgent agent { get; set; }
        private IHostingEnvironment _hostingEnvironment;
        public WaveLabController(IWaveLabAgent agent, IHostingEnvironment hostingEnvironment ) : base()
        {
            this.agent = agent;
            this._hostingEnvironment = hostingEnvironment;
        }
        #region METHODS
        [HttpGet()]
        public async Task<IActionResult> Get()
        {
            //returns list of available Navigations
            try
            {
                return Ok(agent.GetAvailableProcedures());
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }
        [HttpGet("{codeOrID}")]
        public async Task<IActionResult> Get(string codeOrID)
        {
            //returns list of available Navigations
            try
            {
                if (string.IsNullOrEmpty(codeOrID)) return new BadRequestResult(); // This returns HTTP 404
                return Ok(agent.GetProcedure(codeOrID));
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }
        [HttpPost()]
        public async Task<IActionResult> Execute(Upload items)
        {
            //https://docs.microsoft.com/en-us/aspnet/core/mvc/models/file-uploads?view=aspnetcore-2.2
            //https://www.google.com/search?rlz=1C1GCEA_en&ei=YuJdXJKuH4mk0wL32YXgCQ&q=dotnet+core+2.2+IEnumerable+IFormFile&oq=dotnet+core+2.2+IEnumerable+IFormFile&gs_l=psy-ab.3...4522.16761..17279...1.0..0.264.2912.0j18j1......0....1..gws-wiz.......0i22i30j0j0i13j0i13i30.oLzztIHM0Fw

            try
            {

                //if (!isValid(entity)) return new BadRequestResult();
                //create temp folder
                var workingdirectory = "";

                //deserialize files to directory
                //agent.GetProcedureFiles(entity, workingdirectory);

                //serialize result files from directory and return
                return Ok();
            }
            catch (Exception ex)
            {
                return await HandleExceptionAsync(ex);
            }
        }
        #endregion
        #region HELPER METHODS
        private void sm(List<Message> messages)
        {
            if (messages.Count < 1) return;
            HttpContext.Items[WiM.Services.Middleware.X_MessagesExtensions.msgKey] = messages;
        }
        #endregion
    }
}
