using CRMChatbot.Application.DTOs;
using CRMChatbot.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace CRMChatbot.API.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class VehicleController : ControllerBase
{
    private readonly IVehicleService _vehicleService;

    public VehicleController(IVehicleService vehicleService)
    {
        _vehicleService = vehicleService;
    }

    [HttpGet]
    public async Task<IActionResult> GetVehicles()
    {
        var vehicles = await _vehicleService.GetVehiclesAsync();

        return Ok(vehicles);
    }

    [HttpPost]
    public async Task<IActionResult> AddVehicle(
        VehicleRequest request)
    {
        var result = await _vehicleService
            .AddVehicleAsync(request);

        return Ok(result);
    }
}