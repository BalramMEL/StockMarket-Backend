using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web_api.Models;

namespace web_api.Interfaces
{
    public interface IStockRepository
    { 
        Task<List<Stock>> GetAllAsync();        
    }
}