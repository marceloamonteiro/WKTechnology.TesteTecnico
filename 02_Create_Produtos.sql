CREATE TABLE Produtos(
	ProdutoId INT AUTO_INCREMENT PRIMARY KEY,
	ProdutoGuid VARCHAR(50) UNIQUE NOT NULL, 
	CategoriaId INT NOT NULL,
	Nome VARCHAR(100) NOT NULL,
	Descricao VARCHAR(5000) NULL,
	DataCriacao DATETIME NOT NULL,
	DataAlteracao DATETIME NULL,
	Ativo BIT DEFAULT 1,
	FOREIGN KEY (CategoriaId) REFERENCES Categorias(CategoriaId)
) ENGINE = innodb;