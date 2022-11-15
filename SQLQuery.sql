
CREATE TABLE Products (
	Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Name_Prod nvarchar(50)
);

INSERT INTO Products
VALUES
	('����'),
	('������'),
	('���'),
	('����'),
	('�������'),
	('����� ��� ������'),
	('����'),
	('�������'),
	('�����'),
	('��������');

CREATE TABLE Categories (
	Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Name_Categorie TEXT
);

INSERT INTO Categories
VALUES
	('������'),
	('�������'),
	('�������'),
	('��������'),
	('��� ����'),
	('������');

CREATE TABLE ProductCategories (
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
	ProductId INT FOREIGN KEY REFERENCES Products(Id),
	PRIMARY KEY (ProductId, CategoryId)
);

INSERT INTO ProductCategories
VALUES
	(1, 1),--����
	(4, 2),--������
	(3, 2),--������
	(4, 3),--���
	(3, 4),--����
	(2, 5),--�������
	(5, 6),--����� ��� ������
	(3, 7),--����
	(2, 8),--�������
	(6, 9);--�����


SELECT P."Name_Prod", C."Name_Categorie"
FROM Products P
LEFT JOIN ProductCategories PC
	ON P.Id = PC.ProductId
LEFT JOIN Categories C
	ON PC.CategoryId = C.Id;