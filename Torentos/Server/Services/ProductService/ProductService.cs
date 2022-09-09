namespace Torentos.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly DataContext _context;

        public ProductService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<Product>> GetProductAsync(int productId)
        {
            var response = new ServiceResponse<Product>();
            var product = await _context.Products
                .Include(p=>p.Variants)
                .ThenInclude(p=>p.ProductType)
                .FirstOrDefaultAsync(p=>p.Id == productId);
            if(product == null)
            {
                response.Success = false;
                response.Message = "Sorry but this product does not exist.";
            }
            else
            {
                response.Data = product;
            }
            return response;
        }

        public async Task<ServiceResponse<List<Product>>> GetProductsAsync()
        {
            var response = new ServiceResponse<List<Product>>
            {
                Data = await _context.Products.Include(p=>p.Variants).ToListAsync()
            };
            return response;
        }
        public async Task<ServiceResponse<ProductSearchResultDTO>> SearchProducts(string searchText, int page)
        {
            var pageResults = 2f;
            var pageCount = Math.Ceiling((await FindProductsBySearchText(searchText)).Count / pageResults);
            var products = await _context.Products
                .Where(x => x.Title.ToLower().Contains(searchText.ToLower()) ||
            x.Description.ToLower().Contains(searchText.ToLower()))
                .Include(p => p.Variants)
                .Skip((page - 1) * (int)pageResults)
                .Take((int)pageResults)
                .ToListAsync();

            var response = new ServiceResponse<ProductSearchResultDTO>
            {
                Data = new ProductSearchResultDTO
                {
                    Products = products,
                    CurrentPage = page,
                    Pages = (int)pageCount
                }
            };
            return response;
        }
        public async Task<ServiceResponse<List<Product>>> GetProductsByCategory(string categoryUrl)
        {
            var response = new ServiceResponse<List<Product>>
            {
                Data = await _context.Products
                         .Where(x => x.Category.Url.ToLower().Equals(categoryUrl.ToLower()))
                         .Include(p => p.Variants)
                         .ToListAsync()
            };
            return response;
        }
        public async Task<ServiceResponse<List<string>>> GetProductSearchSuggestions(string searchText)
        {
            var products = await FindProductsBySearchText(searchText);

              List<string> result = new List<string>();

            foreach (var product in products)
            {
                if(product.Title.Contains(searchText,StringComparison.OrdinalIgnoreCase))
                {
                    result.Add(product.Title);
                }
                 if(product.Description != null)
                {
                    var punctuation = product.Description.Where(char.IsPunctuation)
                        .Distinct().ToArray();
                    var words = product.Description.Split()
                        .Select(x => x.Trim(punctuation));

                    foreach (var word in words)
                    {
                        if(word.Contains(searchText, StringComparison.OrdinalIgnoreCase) && !result.Contains(word))
                        {
                            result.Add(word);
                        }
                    }
                }   

            }

            return new ServiceResponse<List<string>> { Data = result };
        }

        private async Task<List<Product>> FindProductsBySearchText(string searchText)
        {
            return await _context.Products
                .Where(x => x.Title.ToLower().Contains(searchText.ToLower()) ||
            x.Description.ToLower().Contains(searchText.ToLower()))
                .Include(p => p.Variants)
                .ToListAsync();
        }

        public async Task<ServiceResponse<List<Product>>> GetFeaturedProducts()
        {
            var response = new ServiceResponse<List<Product>>
            {
                Data = await _context.Products
                .Where(x => x.Featured)
                .Include(x => x.Variants)
                .ToListAsync()
            };
            return response;
        }

        public async Task<ServiceResponse<Product>> CreateProduct(Product product)
        {
            foreach (var variant in product.Variants)
            {
                variant.ProductType = null;
            }
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return new ServiceResponse<Product> { Data = product };
        }

        public async Task<ServiceResponse<bool>> DeleteProduct(int productId)
        {
            var dbProduct = await _context.Products.FindAsync(productId);
            if (dbProduct == null)
            {
                return new ServiceResponse<bool>
                {
                    Success = false,
                    Data = false,
                    Message = "Product not found"
                };
            }
            dbProduct.IsDeleted = true;
            await _context.SaveChangesAsync();
            return new ServiceResponse<bool> { Data = true };
        }

        public async Task<ServiceResponse<Product>> UpdateProduct(Product product)
        {
            var dbProduct = await _context.Products.FindAsync(product.Id);
            if (dbProduct == null)
            {
                return new ServiceResponse<Product>
                {
                    Success = false,
                    Message = "Product not found"
                };
            }
            dbProduct.Title = product.Title;
            dbProduct.Description = product.Description;
            dbProduct.Image = dbProduct.Image;
            dbProduct.CategoryId = dbProduct.CategoryId;

            foreach (var variant in product.Variants)
            {
                var dbVariant = await _context.ProductVariants
                    .SingleOrDefaultAsync(v => v.ProductId == variant.ProductId
                    && v.ProductTypeId == variant.ProductTypeId);
                if(dbVariant == null)
                {
                    variant.ProductType = null;
                    _context.ProductVariants.Add(variant);
                }
                else
                {
                    dbVariant.ProductTypeId = variant.ProductTypeId;
                    dbVariant.Price = variant.Price;
                    dbVariant.OriginalPrice = variant.OriginalPrice;
                    
                }
            }
            await _context.SaveChangesAsync();
            return new ServiceResponse<Product> { Data = product };
        }
    }
}
