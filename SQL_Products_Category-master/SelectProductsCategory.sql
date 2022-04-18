SELECT Products.name, Category.name
FROM Products
LEFT JOIN ProductsCategory  ON Products.id = ProductsCategory.Products_id
LEFT JOIN Category  ON ProductsCategory.Category_id = Category.id
ORDER BY Products.name
