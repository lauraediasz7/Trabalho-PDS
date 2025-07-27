CREATE DATABASE IF NOT EXISTS distribuidora;
USE distribuidora;

CREATE TABLE cliente (
  Matricula INT PRIMARY KEY,
  CPF_CGC VARCHAR(20),
  Nome VARCHAR(100),
  Endereco TEXT,
  Telefones VARCHAR(100),
  NomeContato VARCHAR(100),
  CartaoCredito VARCHAR(30),
  Email VARCHAR(100)
);

CREATE TABLE fornecedor (
  Matricula INT PRIMARY KEY,
  CGC VARCHAR(20),
  Nome VARCHAR(100),
  Endereco TEXT,
  Telefone VARCHAR(50),
  Email VARCHAR(100)
);

CREATE TABLE requisicao (
  Numero INT,
  Data DATE,
  Situacao VARCHAR(20),
  FornecedorMatricula INT NOT NULL,
  PRIMARY KEY (Numero, FornecedorMatricula),
  FOREIGN KEY (FornecedorMatricula) REFERENCES fornecedor (Matricula)
);

CREATE TABLE fatura (
  NumeroFatura INT,
  Valor DECIMAL(10,2),
  Situacao VARCHAR(20),
  RequisicaoNumero INT NOT NULL,
  FornecedorMatricula INT NOT NULL,
  PRIMARY KEY (NumeroFatura, RequisicaoNumero, FornecedorMatricula),
  FOREIGN KEY (RequisicaoNumero) REFERENCES requisicao (Numero),
  FOREIGN KEY (FornecedorMatricula) REFERENCES fornecedor (Matricula)
);

CREATE TABLE pedido (
  NumeroSequencial INT,
  Data DATE,
  Situacao VARCHAR(20),
  ClienteMatricula INT NOT NULL,
  PRIMARY KEY (NumeroSequencial, ClienteMatricula),
  FOREIGN KEY (ClienteMatricula) REFERENCES cliente (Matricula)
);

CREATE TABLE produto (
  Codigo INT PRIMARY KEY,
  Descricao VARCHAR(100),
  Unidade VARCHAR(10),
  PrecoVenda DECIMAL(10,2)
);

CREATE TABLE itempedido (
  ID BIGINT UNSIGNED AUTO_INCREMENT,
  PedidoNumero INT NOT NULL,
  ProdutoCodigo INT NOT NULL,
  Quantidade INT,
  SituacaoItem VARCHAR(20),
  PRIMARY KEY (ID, PedidoNumero, ProdutoCodigo),
  FOREIGN KEY (PedidoNumero) REFERENCES pedido (NumeroSequencial),
  FOREIGN KEY (ProdutoCodigo) REFERENCES produto (Codigo)
);

CREATE TABLE itemrequisicao (
  ID BIGINT UNSIGNED AUTO_INCREMENT,
  RequisicaoNumero INT NOT NULL,
  ProdutoCodigo INT NOT NULL,
  Quantidade INT,
  ValorUltimoFornecimento DECIMAL(10,2),
  PRIMARY KEY (ID, ProdutoCodigo, RequisicaoNumero),
  FOREIGN KEY (RequisicaoNumero) REFERENCES requisicao (Numero),
  FOREIGN KEY (ProdutoCodigo) REFERENCES produto (Codigo)
);

CREATE TABLE produtofornecedor (
  ProdutoCodigo INT NOT NULL,
  FornecedorMatricula INT NOT NULL,
  PRIMARY KEY (ProdutoCodigo, FornecedorMatricula),
  FOREIGN KEY (ProdutoCodigo) REFERENCES produto (Codigo),
  FOREIGN KEY (FornecedorMatricula) REFERENCES fornecedor (Matricula)
);
