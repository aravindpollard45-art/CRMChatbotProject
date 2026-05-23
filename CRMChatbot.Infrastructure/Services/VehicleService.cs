using CRMChatbot.Application.DTOs;
using CRMChatbot.Application.Interfaces;
using CRMChatbot.Domain.Entities;
using CRMChatbot.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace CRMChatbot.Infrastructure.Services;

public class VehicleService : IVehicleService
{
    private readonly AppDbContext _context;

    public VehicleService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Vehicle>> GetVehiclesAsync()
    {
        return await _context.Vehicles.ToListAsync();
    }

    public async Task<string> AddVehicleAsync(VehicleRequest request)
    {
        var vehicle = new Vehicle
        {
            UserId = request.UserId,
            VehicleType = request.VehicleType,
            Brand = request.Brand,
            Model = request.Model,
            VehicleNumber = request.VehicleNumber
        };

        _context.Vehicles.Add(vehicle);

        await _context.SaveChangesAsync();

        return "Vehicle added successfully";
    }
}