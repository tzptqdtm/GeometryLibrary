SELECT P.Name AS [Product name], C.Name AS [Category]
FROM Products P
LEFT JOIN ProductCategory PC
	ON P.Id = PC.ProductId
LEFT JOIN Category C
	ON PC.CategoryId = C.Id