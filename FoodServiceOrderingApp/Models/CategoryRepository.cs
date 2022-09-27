namespace FoodServiceOrderingApp.Models
{ 
    public class CategoryRepository : ICategoryRepository
    {
        private readonly FoodServiceOrderingAppDbContext _foodServiceOrderingAppDbContext;

        public CategoryRepository(FoodServiceOrderingAppDbContext foodServiceOrderingAppDbContext)
        {
            _foodServiceOrderingAppDbContext = foodServiceOrderingAppDbContext;
        }

        public IEnumerable<Category> AllCategories =>
            _foodServiceOrderingAppDbContext.Categories.OrderBy(p => p.CategoryName);
    }
}
