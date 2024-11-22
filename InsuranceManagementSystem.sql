--CODING CHALLENGE - INSURANCE MANAGEMENT SYSTEM (22-11-24)


CREATE DATABASE InsuranceManagementSystem

USE InsuranceManagementSystem

--Create Tables
-- Users
CREATE TABLE Users (
    UserId INT IDENTITY(1,1) PRIMARY KEY,
    Username VARCHAR(20) NOT NULL,
    U_Password VARCHAR(20) NOT NULL,
    U_Role VARCHAR(20) NOT NULL
)

-- Client
CREATE TABLE Clients (
    ClientId INT IDENTITY(1,1) PRIMARY KEY,
    ClientName VARCHAR(20) NOT NULL,
    ContactInfo VARCHAR(50) NOT NULL,
    C_Policy VARCHAR(100) 
)

-- Claim
CREATE TABLE Claims (
    ClaimId INT IDENTITY(1,1) PRIMARY KEY,
    ClaimNumber VARCHAR(20) NOT NULL,
    DateFiled DATE NOT NULL,
    ClaimAmount DECIMAL(10, 2) NOT NULL,
    C_Status VARCHAR(20) NOT NULL,
    C_Policy VARCHAR(100),
    ClientId INT, 
    FOREIGN KEY (clientId) REFERENCES Clients(clientId)
)

-- Payment
CREATE TABLE Payments (
    paymentId INT IDENTITY(1,1) PRIMARY KEY,
    paymentDate DATE NOT NULL,
    paymentAmount DECIMAL(10, 2) NOT NULL,
    clientId INT, 
    FOREIGN KEY (clientId) REFERENCES Clients(clientId)
)

CREATE TABLE Policies
(
    PolicyId INT IDENTITY(1,1) PRIMARY KEY,
    PolicyName VARCHAR(50) NOT NULL,
    PolicyDetails VARCHAR(100) NOT NULL
)


insert into Policies(PolicyName,PolicyDetails) values 
('Policy_1','Insurance Policy 1 ....'),
('Policy_2','Insurance Policy 2 ....'),
('Policy_3','Insurance Policy 3 ....')