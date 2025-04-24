create database  Controledeacesso;

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
CREATE TABLE Usuarios (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Nome VARCHAR(45),
    Cpf VARCHAR(11), 
     email VARCHAR(100) NOT NULL UNIQUE,
    Tipo_usuario ENUM('Administrador', 'Funcionário', 'Visitante') NOT NULL,
    Senha VARCHAR(255), 
    Foto BLOB,
    criado_em TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    Ativo BOOLEAN
);

CREATE TABLE RegistroDeAcesso (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Usuario_Id INT,
    DataHora DATETIME,
    TipoOperacao VARCHAR(45),
    FOREIGN KEY (Usuario_Id) REFERENCES Usuarios(Id)
);

CREATE TABLE Autenticador (
    id INT PRIMARY KEY AUTO_INCREMENT,
    ValidarLogin BIT(1),
    Usuario_Id INT,
    FOREIGN KEY (Usuario_Id) REFERENCES Usuario(Id)
);