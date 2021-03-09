CREATE DATABASE dbapi_weather;
USE dbapi_weather;

CREATE TABLE cidades(
	id INT AUTO_INCREMENT PRIMARY KEY,
	nome VARCHAR(50) NOT NULL
);

INSERT INTO cidades (nome) VALUES ('São Luis'), ('Vitoria'), ('São Paulo'), 
				  ('Rio de Janeiro'), ('Belo Horizonte');
