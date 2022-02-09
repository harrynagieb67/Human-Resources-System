-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema HR_System
-- -----------------------------------------------------
DROP SCHEMA IF EXISTS `HR_System` ;

-- -----------------------------------------------------
-- Schema HR_System
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `HR_System` DEFAULT CHARACTER SET utf8 ;
USE `HR_System` ;

-- -----------------------------------------------------
-- Table `HR_System`.`Department`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `HR_System`.`Department` ;

CREATE TABLE IF NOT EXISTS `HR_System`.`Department` (
  `DP_Code` VARCHAR(45) NOT NULL,
  `Name` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`DP_Code`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `HR_System`.`Licences`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `HR_System`.`Licences` ;

CREATE TABLE IF NOT EXISTS `HR_System`.`Licences` (
  `Code` VARCHAR(45) NOT NULL,
  `Association` VARCHAR(45) NOT NULL,
  `Period` TIME NOT NULL,
  PRIMARY KEY (`Code`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `HR_System`.`Employee`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `HR_System`.`Employee` ;

CREATE TABLE IF NOT EXISTS `HR_System`.`Employee` (
  `ID_Emp` INT NOT NULL,
  `Name` VARCHAR(45) NOT NULL,
  `SSN` INT NOT NULL,
  `salary` DOUBLE NOT NULL,
  `Hire_Date` DATE NOT NULL,
  `Title` VARCHAR(45) NOT NULL,
  `Insurance` TINYINT NOT NULL,
  `Department_DP_Code` VARCHAR(45) NOT NULL,
  `Licences_Code` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`ID_Emp`),
  INDEX `fk_Employee_Department_idx` (`Department_DP_Code` ASC) ,
  INDEX `fk_Employee_Licences1_idx` (`Licences_Code` ASC) ,
  CONSTRAINT `fk_Employee_Department`
    FOREIGN KEY (`Department_DP_Code`)
    REFERENCES `HR_System`.`Department` (`DP_Code`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Employee_Licences1`
    FOREIGN KEY (`Licences_Code`)
    REFERENCES `HR_System`.`Licences` (`Code`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `HR_System`.`Users`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `HR_System`.`Users` ;

CREATE TABLE IF NOT EXISTS `HR_System`.`Users` (
  `Name` VARCHAR(50) NOT NULL,
  `Password` VARCHAR(45) NOT NULL,
  `Title` VARCHAR(45) NULL,
  PRIMARY KEY (`Name`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Data for table `HR_System`.`Department`
-- -----------------------------------------------------
START TRANSACTION;
USE `HR_System`;
INSERT INTO `HR_System`.`Department` (`DP_Code`, `Name`) VALUES ('IT1', 'Information technology');
INSERT INTO `HR_System`.`Department` (`DP_Code`, `Name`) VALUES ('HR2', 'Human Resources');

COMMIT;


-- -----------------------------------------------------
-- Data for table `HR_System`.`Licences`
-- -----------------------------------------------------
START TRANSACTION;
USE `HR_System`;
INSERT INTO `HR_System`.`Licences` (`Code`, `Association`, `Period`) VALUES ('Health110', 'Ministry of health and population', 'year');
INSERT INTO `HR_System`.`Licences` (`Code`, `Association`, `Period`) VALUES ('Food131', 'Ministry of food', '6 months');

COMMIT;


-- -----------------------------------------------------
-- Data for table `HR_System`.`Employee`
-- -----------------------------------------------------
START TRANSACTION;
USE `HR_System`;
INSERT INTO `HR_System`.`Employee` (`ID_Emp`, `Name`, `SSN`, `salary`, `Hire_Date`, `Title`, `Insurance`, `Department_DP_Code`, `Licences_Code`) VALUES (111, 'ahmed nagieb', 29907060102478, 4000, '20/12/2021', 'IT Manager', yes, 'IT1', DEFAULT);
INSERT INTO `HR_System`.`Employee` (`ID_Emp`, `Name`, `SSN`, `salary`, `Hire_Date`, `Title`, `Insurance`, `Department_DP_Code`, `Licences_Code`) VALUES (112, 'Randa khaled', 29904140104669, 5500, '20/12/2021', 'IT_Specialist', no, 'IT1', DEFAULT);
INSERT INTO `HR_System`.`Employee` (`ID_Emp`, `Name`, `SSN`, `salary`, `Hire_Date`, `Title`, `Insurance`, `Department_DP_Code`, `Licences_Code`) VALUES (113, 'mohamed yahia', 29905412367891, 3500, '20/12/2021', 'HR_manager', yes, 'HR2', DEFAULT);

COMMIT;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
