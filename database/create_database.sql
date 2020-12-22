CREATE TABLE `States` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `PropName` longtext CHARACTER SET utf8mb4 NOT NULL,
    `IntValue` int NULL,
    `StringValue` longtext CHARACTER SET utf8mb4 NULL,
    `DoubleValue` double NULL,
    CONSTRAINT `PK_States` PRIMARY KEY (`Id`)
);