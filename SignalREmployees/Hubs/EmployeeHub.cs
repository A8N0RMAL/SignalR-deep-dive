using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using SignalREmployees.Data;
using SignalREmployees.Models;

namespace SignalREmployees.Hubs
{
    public class EmployeeHub(ApplicationDbContext context) : Hub
    {
        private readonly ApplicationDbContext _context = context;
        
        public async Task AddEmployee(Employee employee)
        {
            // Save into database
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();

            // Broadcast to all clients
            await Clients.All.SendAsync("ReceiveEmployee", employee);
        }

        public async Task<List<Employee>> GetEmployees()
        {
            return await _context.Employees.ToListAsync();
        }
    }
}
