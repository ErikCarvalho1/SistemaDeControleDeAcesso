create database  Controledeacesso;

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
    Entrada DATETIME,
    Saida datetime,
    FOREIGN KEY (Usuario_Id) REFERENCES Usuarios(Id)
);


select * from  RegistroDeAcesso;
