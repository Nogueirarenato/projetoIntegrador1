CREATE DATABASE DESPERDICIOZERO;

USE DESPERDICIOZERO;

CREATE TABLE TIPO (
	IDTIPO INT IDENTITY PRIMARY KEY
	, TIPO VARCHAR (30)
);

CREATE TABLE USUARIO(
	IDUSUARIO INT IDENTITY PRIMARY KEY
	, ID_TIPO INT
	, EMAIL VARCHAR (100)
	, SENHA TEXT
	, ENDERECO TEXT
	, DOCUMENTO TEXT
	, TELEFONE VARCHAR (30)
	, CONSTRAINT FK_ID_TIPO FOREIGN KEY (ID_TIPO) REFERENCES TIPO (IDTIPO)

);

CREATE TABLE ESTOQUE(
	IDESTOQUE INT IDENTITY PRIMARY KEY
	, ID_USUARIO INT
	, CONSTRAINT FK_ID_USUARIO FOREIGN KEY (ID_USUARIO) REFERENCES USUARIO (IDUSUARIO)
);

CREATE TABLE PRODUTO (
	IDPRODUTO INT IDENTITY PRIMARY KEY
	, NOME TEXT NOT NULL
	, DATA_DE_VALIDADE DATE NOT NULL
	, PRAZO INT NOT NULL 
	, VALOR_COMPRA DECIMAL (10,2)
	, VALOR_VENDA DECIMAL (10,2)
	, DESCONTO DECIMAL (10,2)
	, ID_ESTOQUE INT
	, QUANTIDADE INT
	, DESCRICAO TEXT
	, CONSTRAINT FK_ID_ESTOQUE FOREIGN KEY (ID_ESTOQUE) REFERENCES ESTOQUE (IDESTOQUE)

);

CREATE TABLE PEDIDO (
	IDPEDIDO INT IDENTITY PRIMARY KEY
	, VALOR DECIMAL (10,2)
	, ID_USUARIO INT
	, CONSTRAINT FK_ID_USUARIO_PEDIDO FOREIGN KEY (ID_USUARIO) REFERENCES USUARIO (IDUSUARIO)
);

CREATE TABLE PRODUTO_PEDIDO(
	IDPRODUTO_PEDIDO INT IDENTITY PRIMARY KEY
	, ID_PEDIDO INT
	, ID_PRODUTO INT
	, QUANTIDADE INT
	, CONSTRAINT FK_ID_PRODUTO_PEDIDO FOREIGN KEY (ID_PEDIDO) REFERENCES PEDIDO (IDPEDIDO)
	, CONSTRAINT FK_ID_PROUTO_PRODUTO FOREIGN KEY (ID_PRODUTO) REFERENCES PRODUTO (IDPRODUTO)
);