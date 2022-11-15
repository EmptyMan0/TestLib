
CREATE TABLE Products (
	Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Name_Prod nvarchar(50)
);

INSERT INTO Products
VALUES
	('Хлеб'),
	('Молоко'),
	('Сыр'),
	('Вода'),
	('Шоколад'),
	('Губки для посуды'),
	('Кофе'),
	('Конфеты'),
	('Чипсы'),
	('Кириешки');

CREATE TABLE Categories (
	Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Name_Categorie TEXT
);

INSERT INTO Categories
VALUES
	('Мучное'),
	('Сладкое'),
	('Питевое'),
	('Молочное'),
	('Для дома'),
	('Снейки');

CREATE TABLE ProductCategories (
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
	ProductId INT FOREIGN KEY REFERENCES Products(Id),
	PRIMARY KEY (ProductId, CategoryId)
);

INSERT INTO ProductCategories
VALUES
	(1, 1),--хлеб
	(4, 2),--молоко
	(3, 2),--молоко
	(4, 3),--сыр
	(3, 4),--вода
	(2, 5),--шоколад
	(5, 6),--губки для посуды
	(3, 7),--кофе
	(2, 8),--конфеты
	(6, 9);--чипсы


SELECT P."Name_Prod", C."Name_Categorie"
FROM Products P
LEFT JOIN ProductCategories PC
	ON P.Id = PC.ProductId
LEFT JOIN Categories C
	ON PC.CategoryId = C.Id;