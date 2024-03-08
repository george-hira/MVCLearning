namespace WebApp.Models
{
    public static class CategoriesRepository
    {

        private static List<Category> _categories = new List<Category>()
        {
            new Category { CategoryId=1, Name="Beverage", Description="All type of beverages"},
            new Category { CategoryId=2, Name="Bakery", Description="All type of bakery"},
            new Category { CategoryId=3, Name= "Meat", Description="All type of meat"},
            new Category { CategoryId=4, Name= "Vegetable", Description="All type of vegetables"}
        };

        public static void AddCategory(Category category)
        {
            var maxId=_categories.Max(x => x.CategoryId);
            category.CategoryId = maxId+1;
            _categories.Add(category);
        }

        public static List<Category> GetCategories() => _categories;

        public static Category? GetCategoryByID(int categoryId)
        {
            var category = _categories.FirstOrDefault(x => x.CategoryId == categoryId);
            if (category != null)
            {
                return new Category
                { CategoryId = category.CategoryId,
                    Name = category.Name,
                    Description =category.Description,
                };
            }
            return null;
        }

        public static void UpdateCategory(int categoryId, Category category)
        {
            if (categoryId != category.CategoryId) return;

            var categoryToUpdate = _categories.FirstOrDefault(x => x.CategoryId == categoryId);

            if (categoryToUpdate != null)
            {
                categoryToUpdate.Name= category.Name;
                categoryToUpdate.Description= category.Description;
            }
        }

        public static void DelegateCategory(int categoryId)
        {
            var category = _categories.FirstOrDefault(x=>x.CategoryId == categoryId);

            if (category != null)
            {
                _categories.Remove(category);
            }

        }
        

    }
}
