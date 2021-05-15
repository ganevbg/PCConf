using Microsoft.AspNetCore.Mvc;
using PCConf.Domain.Services;
using System;
using System.Threading.Tasks;

namespace PCConf.RestApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PartsController : ControllerBase
    {
        private readonly IPartService _partService;

        public PartsController(IPartService partService)
        {
            _partService = partService;
        }

        [HttpGet]
        [Route("GetProcessors")]
        public async Task<IActionResult> GetProcessors()
        {
            return Ok(await _partService.GetAllProcessorsAsync());
        }

        [HttpGet]
        [Route("GetMotherBoards/{socket}")]
        public async Task<IActionResult> GetMotherBoards(string socket)
        {
            return Ok(await _partService.GetMotherBoardsByCpuSocketAsync(socket));
        }

        [HttpGet]
        [Route("GetRams/{type}")]
        public async Task<IActionResult> GetRams(string type)
        {
            return Ok(await _partService.GetRamsByTypeAsync(type));
        }

        [HttpGet]
        [Route("GetVideCards")]
        public async Task<IActionResult> GetVideCards()
        {
            return Ok(await _partService.GetVideoCardsAsync());
        }

        [HttpGet]
        [Route("GetDrives")]
        public async Task<IActionResult> GetDrives()
        {
            return Ok(await _partService.GetDrivesAsync());
        }

        [HttpGet]
        [Route("GetCases")]
        public async Task<IActionResult> GetCases([FromQuery] Guid mbId, [FromQuery] Guid gpuId)
        {
            return Ok(await _partService.GetCaseByMotherBoardAndVideCardAsync(mbId, gpuId));
        }

        [HttpGet]
        [Route("GetPowerSuplies")]
        public async Task<IActionResult> GetPowerSupliesAsync()
        {
            return Ok(await _partService.GetPowerSupliesAsync());
        }
    }
}
