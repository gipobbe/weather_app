using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using weather_app.Modules.Alerts.Entities;

namespace weather_app.Modules.Alerts.Repositories
{
    public class AlertRepository
    {
        private AppDbContext _appDbContext;

        public AlertRepository(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }

        public ICollection<Alert> GetAll()
        {
            return _appDbContext.MeteoAlerts.ToList();
        }

        public Alert GetById(Guid id)
        {
            return _appDbContext.MeteoAlerts.Find(id);
        }

        public void Create(Alert alert)
        {
            _appDbContext.MeteoAlerts.Add(alert);
        }

        public Alert Delete(Guid id)
        {
            Alert alert = _appDbContext.MeteoAlerts.Find(id);
            _appDbContext.MeteoAlerts.Remove(alert);
            return alert;
        }

        public Alert Update(Alert alert)
        {
            _appDbContext.Entry(alert).State = EntityState.Modified;
            return alert;
        }

        public async Task Save()
        {
            await _appDbContext.SaveChangesAsync();
        }
    }
}