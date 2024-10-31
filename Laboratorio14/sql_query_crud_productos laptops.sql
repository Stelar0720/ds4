CREATE DATABASE Productos2;
GO

USE Productos2;
GO

CREATE TABLE Laptops (
    id INT NOT NULL IDENTITY,
    nombre VARCHAR(50) NOT NULL,
    precio DECIMAL(10, 2), -- Cambié a 10 para permitir precios más altos
    stock INT, -- Cambié a INT para mantener la cantidad como un número entero
    CONSTRAINT pk_laptops PRIMARY KEY (id)
);