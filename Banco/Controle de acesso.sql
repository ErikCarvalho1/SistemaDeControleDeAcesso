create database  ControleDeAcesso;

CREATE TABLE usuarios (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    cpf VARCHAR(14) NOT NULL UNIQUE,
    email VARCHAR(100) NOT NULL UNIQUE,
    tipo_usuario ENUM('Administrador', 'Funcionário', 'Visitante') NOT NULL,
    senha VARCHAR(255) NOT NULL,
    foto BLOB,
    criado_em TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    ativo TINYINT(1) NOT NULL DEFAULT 1

);
select * from  usuarios;
 