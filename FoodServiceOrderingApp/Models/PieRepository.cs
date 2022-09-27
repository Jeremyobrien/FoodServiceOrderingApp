using Microsoft.EntityFrameworkCore;

namespace FoodServiceOrderingApp.Models
{
    public class PieRepository: IPieRepository
    {
        private readonly FoodServiceOrderingAppDbContext _foodServiceOrderingAppDbContext;

        public PieRepository(FoodServiceOrderingAppDbContext foodServiceOrderingAppDbContext)
        {
            _foodServiceOrderingAppDbContext = foodServiceOrderingAppDbContext;
        }

        public IEnumerable<Pie> AllPies
        {
            get
            {
                return _foodServiceOrderingAppDbContext.Pies.Include(c => c.Category);
            }
        }

        public IEnumerable<Pie> PiesOfTheWeek
        {
            get
            {
                return _foodServiceOrderingAppDbContext.Pies.Include(c => c.Category).Where(p =>
                p.IsPieOfTheWeek);
            }
        }

        public Pie? GetPieById(int pieId)
        {
            return _foodServiceOrderingAppDbContext.Pies.FirstOrDefault(p => p.PieId == pieId);
        }
    }
}
