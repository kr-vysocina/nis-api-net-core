using System.ComponentModel.DataAnnotations;
using cz.kr_vysocina.nis.v11.core.Models;
using cz.kr_vysocina.nis.v11.core.Providers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace cz.kr_vysocina.nis.v11.api.Controllers
{
    [ApiController]
    [Route("/api/nixzd/v11")]
    public class NisApiV11Controller : ControllerBase
    {
        private readonly ILogger<NisApiV11Controller> m_logger;
        private readonly IDataProvider m_dataProvider;

        public NisApiV11Controller(
            IDataProvider dataProvider,
            ILogger<NisApiV11Controller> logger
        )
        {
            m_logger = logger;
            m_dataProvider = dataProvider;
        }

        [HttpGet]
        [Route("sayHello.xml")]
        [Produces("application/xml")]
        public IActionResult SayHello()
        {
            if (m_logger.IsEnabled(LogLevel.Debug))
            {
                m_logger.LogDebug("Running sayHello");
            }
            
            var result = m_dataProvider.GetSayHelloData();
            
            if (m_logger.IsEnabled(LogLevel.Debug))
            {
                m_logger.LogDebug("Returning result of sayHello");
            }

            if (result != null)
            {
                return Ok(result);
            }

            return StatusCode(StatusCodes.Status500InternalServerError);
        }

        [HttpGet]
        [Route("getPsExists.xml")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Produces("application/xml")]
        public IActionResult GetPsExists(
            [FromQuery] [Required] IdType? idType,
            [FromQuery] [Required] string idValue,
            [FromQuery] [Required] PurposeOfUse? purposeOfUse,
            [FromQuery] [Required] string subjectNameId,
            [FromQuery] string requestOrgId,
            [FromQuery] [Required] string requestId
        )
        {
            if (m_logger.IsEnabled(LogLevel.Debug))
            {
                m_logger.LogDebug("Running getPsExists.xml");
            }

            if (idType == null
                || purposeOfUse == null
                || string.IsNullOrEmpty(idValue)
                || string.IsNullOrEmpty(subjectNameId)
                || string.IsNullOrEmpty(requestId)
            )
            {
                if (m_logger.IsEnabled(LogLevel.Debug))
                {
                    m_logger.LogDebug("Bad request to getPsExists.xml");
                }

                return BadRequest("Required parameter is null or empty");
            }

            var result = m_dataProvider.GetPsExistsData(idType.Value, idValue, purposeOfUse.Value, subjectNameId, requestOrgId, requestId);

            if (m_logger.IsEnabled(LogLevel.Debug))
            {
                m_logger.LogDebug("Returning result of getPsExists.xml");
            }

            if (result != null)
            {
                return Ok(result);
            }

            return StatusCode(StatusCodes.Status500InternalServerError);
        }

        [HttpGet]
        [Route("getPs.cda")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Produces("application/octet-stream")]
        public IActionResult GetPsCda(
            [FromQuery] [Required] string sourceIdentifier,
            [FromQuery] [Required] IdType? idType,
            [FromQuery] [Required] string idValue,
            [FromQuery] [Required] PurposeOfUse? purposeOfUse,
            [FromQuery] [Required] string subjectNameId,
            [FromQuery] string requestOrgId,
            [FromQuery] [Required] CDAType cdaType,
            [FromQuery] [Required] string cdaId,
            [FromQuery] [Required] string cdaOid,
            [FromQuery] [Required] string requestId
        )
        {
            if (m_logger.IsEnabled(LogLevel.Debug))
            {
                m_logger.LogDebug("Running getPs.cda");
            }

            if (idType == null
                || purposeOfUse == null
                || string.IsNullOrEmpty(idValue)
                || string.IsNullOrEmpty(subjectNameId)
                || string.IsNullOrEmpty(requestId)
            )
            {
                if (m_logger.IsEnabled(LogLevel.Debug))
                {
                    m_logger.LogDebug("Bad request to getPs.cda");
                }

                return BadRequest("Required parameter is null or empty");
            }

            var result = m_dataProvider.GetPsCdaData(sourceIdentifier, idType.Value, idValue, purposeOfUse.Value, subjectNameId,
                requestOrgId, cdaType, cdaId, cdaOid, requestId);

            if (m_logger.IsEnabled(LogLevel.Debug))
            {
                m_logger.LogDebug("Returning result of getPs.cda");
            }

            if (result != null)
            {
                return File(result, "application/octet-stream");
            }

            return NotFound();
        }
    }
}
