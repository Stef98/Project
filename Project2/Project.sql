/*CREATE DATABASE Simulator2;*/

/*USE Simulator2
CREATE TABLE tblPlane2(
PlaneID INT PRIMARY KEY IDENTITY(1,1),
PlaneName VARCHAR(225),
HealthPoints INT,
Speed INT,
Weight INT,
Damage INT,
Inventory INT,
FeulLevel INT
);*/

/*USE Simulator2
INSERT INTO dbo.tblPlane2 VALUES
('CropDuster',30,1,1,5,1,20),
('Cobra',40,3,2,8,1,22),
('Tiger',50,5,3,8,1,25),
('Rhino',65,5,5,10,1,25),
('Sting Ray',70,7,7,12,1,23)*/

USE Simulator2
SELECT * FROM dbo.tblPlane2

