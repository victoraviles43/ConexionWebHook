using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conexion.Domain.DbContexto;
using Conexion.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Conexion.Repository
{
    public class WebhookRepository
	{
        private readonly SysIturanContext _context;

        public WebhookRepository(SysIturanContext context)
        {
            _context = context;
        }

		
		
		public async Task<int> Crear(WebhookEven model)
		{
			_context.WebhookEvens.Add(model);

			return await _context.SaveChangesAsync();
		}

		
		public async Task<int> CrearMasivo(List<WebhookEven> eventos)
		{
			await _context.WebhookEvens.AddRangeAsync(eventos);

			return await _context.SaveChangesAsync();
		}

	

    }
}
