SELECT Products.Name as 'Product', Categories.Name as 'Category'
FROM Products 
LEFT JOIN ProductsCategories ON ProductsCategories.ProductId = Products.Id
LEFT JOIN Categories ON ProductsCategories.CategoryId = Categories.Id