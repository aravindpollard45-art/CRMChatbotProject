using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CRMChatbot.Application.DTOs;
using CRMChatbot.Domain.Entities;

namespace CRMChatbot.Application.Interfaces;

public interface IVehicleService
{
    Task<List<Vehicle>> GetVehiclesAsync();

    Task<string> AddVehicleAsync(VehicleRequest request);
}