using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CRMChatbot.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CRMChatbot.Infrastructure.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users { get; set; }

    public DbSet<Vehicle> Vehicles { get; set; }

    public DbSet<ServiceBooking> ServiceBookings { get; set; }

    public DbSet<ChatMessage> ChatMessages { get; set; }

    public DbSet<Complaint> Complaints { get; set; }
}