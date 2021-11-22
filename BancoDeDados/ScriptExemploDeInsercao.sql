USE DESPERDICIOZERO;

INSERT INTO TIPO (TIPO) VALUES ('ADMINSTRADOR');
INSERT INTO TIPO (TIPO) VALUES ('VENDEDOR');
INSERT INTO TIPO (TIPO) VALUES ('COMPRADOR');

 --SELECT * FROM TIPO;
-- POR PADRÃO RETORNARÁ OS SEGUINTES ID'S
-- ID    NOME
-- 1	ADMINSTRADOR
-- 2	VENDEDOR
-- 3	COMPRADOR

INSERT INTO USUARIO (ID_TIPO, EMAIL, SENHA, ENDERECO, DOCUMENTO, TELEFONE) VALUES('1', 'renato@gmail.com', 'univesp@', 'Rua londres, 354', '50000001', '3689-6172');
INSERT INTO USUARIO (ID_TIPO, EMAIL, SENHA, ENDERECO, DOCUMENTO, TELEFONE) VALUES('1', 'mateus@gmail.com', 'univesp@', 'Rua das Flores, 30 ', '50000002', '3689-6173');
INSERT INTO USUARIO (ID_TIPO, EMAIL, SENHA, ENDERECO, DOCUMENTO, TELEFONE) VALUES('1', 'lucas@gmail.com', 'univesp@', 'Calçadão de Osasco, 80', '50000003', '3689-6174');
INSERT INTO USUARIO (ID_TIPO, EMAIL, SENHA, ENDERECO, DOCUMENTO, TELEFONE) VALUES('2', 'marcelo@gmail.com', 'univesp@', 'Rua da Alegria, 1000', '50000004', '3689-6175');
INSERT INTO USUARIO (ID_TIPO, EMAIL, SENHA, ENDERECO, DOCUMENTO, TELEFONE) VALUES('2', 'carrefour@carrefour.com', 'univesp@', 'Rua da Amargura, 300', '50000092', '3689-6176');
INSERT INTO USUARIO (ID_TIPO, EMAIL, SENHA, ENDERECO, DOCUMENTO, TELEFONE) VALUES('2', 'extra@extra.com', 'univesp@', 'Rua da Decepção, 80', '500000022', '3689-6177');
INSERT INTO USUARIO (ID_TIPO, EMAIL, SENHA, ENDERECO, DOCUMENTO, TELEFONE) VALUES('2', 'walmart@walmart.com', 'univesp@', 'Rua Renato, 80', '5000000123', '3689-6178');
INSERT INTO USUARIO (ID_TIPO, EMAIL, SENHA, ENDERECO, DOCUMENTO, TELEFONE) VALUES('2', 'barbosa@barbosa.com', 'univesp@', 'Rua Isaura, 79', '5000001234', '3689-6179');
INSERT INTO USUARIO (ID_TIPO, EMAIL, SENHA, ENDERECO, DOCUMENTO, TELEFONE) VALUES('2', 'paodeacucar@paodeacucar.com', 'univesp@', 'Rua 2', '50000001999', '3689-6180');
INSERT INTO USUARIO (ID_TIPO, EMAIL, SENHA, ENDERECO, DOCUMENTO, TELEFONE) VALUES('2', 'seujose@seujose.com', 'univesp@', 'Rua 3', '5000000111', '3689-6181');
INSERT INTO USUARIO (ID_TIPO, EMAIL, SENHA, ENDERECO, DOCUMENTO, TELEFONE) VALUES('3', 'pratonamesa@pratonamesa.com', 'univesp@', 'Rua 4', '50000001222', '3689-6182');
INSERT INTO USUARIO (ID_TIPO, EMAIL, SENHA, ENDERECO, DOCUMENTO, TELEFONE) VALUES('3', 'cestasbasicas@cestasbasicas.com', 'univesp@', 'Rua 5', '50000001', '3689-6183');
INSERT INTO USUARIO (ID_TIPO, EMAIL, SENHA, ENDERECO, DOCUMENTO, TELEFONE) VALUES('3', 'ongsemfome@ongsemfome.com', 'univesp@', 'Rua 6', '50222201', '3689-6184');
INSERT INTO USUARIO (ID_TIPO, EMAIL, SENHA, ENDERECO, DOCUMENTO, TELEFONE) VALUES('3', 'ongpratocheio@ongpratocheio.com', 'univesp@', 'Rua 7', '50000001X', '3689-6185');


--SELECT * 
--FROM USUARIO
--INNER JOIN TIPO
--ON USUARIO.ID_TIPO = TIPO.IDTIPO;

--1	1	renato@gmail.com	univesp@	Rua londres, 354	50000001	3689-6172	1	ADMINSTRADOR
--2	1	mateus@gmail.com	univesp@	Rua das Flores, 30 	50000002	3689-6173	1	ADMINSTRADOR
--3	1	lucas@gmail.com	univesp@	Calçadão de Osasco, 80	50000003	3689-6174	1	ADMINSTRADOR
--4	2	marcelo@gmail.com	univesp@	Rua da Alegria, 1000	50000004	3689-6175	2	VENDEDOR
--5	2	carrefour@carrefour.com	univesp@	Rua da Amargura, 300	50000092	3689-6176	2	VENDEDOR
--6	2	extra@extra.com	univesp@	Rua da Decepção, 80	500000022	3689-6177	2	VENDEDOR
--7	2	walmart@walmart.com	univesp@	Rua Renato, 80	5000000123	3689-6178	2	VENDEDOR
--8	2	barbosa@barbosa.com	univesp@	Rua Isaura, 79	5000001234	3689-6179	2	VENDEDOR
--9	2	paodeacucar@paodeacucar.com	univesp@	Rua 2	50000001999	3689-6180	2	VENDEDOR
--10	2	seujose@seujose.com	univesp@	Rua 3	5000000111	3689-6181	2	VENDEDOR
--11	3	pratonamesa@pratonamesa.com	univesp@	Rua 4	50000001222	3689-6182	3	COMPRADOR
--12	3	cestasbasicas@cestasbasicas.com	univesp@	Rua 5	50000001	3689-6183	3	COMPRADOR
--13	3	ongsemfome@ongsemfome.com	univesp@	Rua 6	50222201	3689-6184	3	COMPRADOR
--14	3	ongpratocheio@ongpratocheio.com	univesp@	Rua 7	50000001X	3689-6185	3	COMPRADOR


INSERT INTO ESTOQUE(ID_USUARIO) VALUES(1);

TO_DATE('17/12/2015', 'DD/MM/YYYY')

INSERT INTO PRODUTO (NOME, DATA_DE_VALIDADE, PRAZO, VALOR_COMPRA, VALOR_VENDA, DESCONTO, ID_ESTOQUE, QUANTIDADE, DESCRICAO) VALUES ('Vinagre de Arroz Camil', '2021-12-20', 10, 11, 15, 4, 1, 300,'O Produto vende dia 20/12/2021')
