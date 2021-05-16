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
        [Route("GetBrands")]
        public async Task<IActionResult> GetBrands()
        {
            return Ok(await _partService.GetBrandsAsync());
        }


        [HttpGet]
        [Route("GetProcessors")]
        public async Task<IActionResult> GetProcessors()
        {
            return Ok(await _partService.GetAllProcessorsAsync());
        }

        [HttpGet]
        [Route("GetMotherBoards/{cpuId}")]
        public async Task<IActionResult> GetMotherBoards(Guid cpuId)
        {
            return Ok(await _partService.GetMotherBoardsByCpuSocketAsync(cpuId));
        }

        [HttpGet]
        [Route("GetRams/{mbId}")]
        public async Task<IActionResult> GetRams(Guid mbId)
        {
            return Ok(await _partService.GetRamsByTypeAsync(mbId));
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

        [HttpGet]
        [Route("GetCpuSockets")]
        public async Task<IActionResult> GetCpuSockets()
        {
            return Ok(await _partService.GetCpuSocketsAsync());
        }

        [HttpGet]
        [Route("GetRamTypes")]
        public async Task<IActionResult> GetRamTypes()
        {
            return Ok(await _partService.GetRamTypesAsync());
        }
        
    }
}
