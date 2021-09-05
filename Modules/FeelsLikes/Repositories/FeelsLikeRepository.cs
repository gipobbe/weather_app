using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using weather_app.Modules.FeelsLikes.Entities;

namespace weather_app.Modules.FeelsLikes.Repositories
{
    public class FeelsLikeRepository
    {
        private AppDbContext _appDbContext;

        public FeelsLikeRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public ICollection<FeelsLike> GetAll()
        {
            return _appDbContext.FeelsLikes.ToList();
        }

        public FeelsLike GetById(Guid id)
        {
            return _appDbContext.FeelsLikes.Find(id);
        }

        public void Create(FeelsLike feelsLike)
        {
            _appDbContext.FeelsLikes.Add(feelsLike);
        }

        public FeelsLike Delete(Guid id)
        {
            FeelsLike feelsLike = _appDbContext.FeelsLikes.Find(id);
            _appDbContext.FeelsLikes.Remove(feelsLike);
            return feelsLike;
        }

        public FeelsLike Update(FeelsLike feelsLike)
        {
            _appDbContext.Entry(feelsLike).State = EntityState.Modified;
            return feelsLike;
        }

        public async Task Save()
        {
            await _appDbContext.SaveChangesAsync();
        }
    }
}