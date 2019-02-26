CREATE DATABASE  IF NOT EXISTS `museu` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `museu`;
-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: museu
-- ------------------------------------------------------
-- Server version	5.7.22-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `eventos`
--

DROP TABLE IF EXISTS `eventos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `eventos` (
  `id` smallint(6) NOT NULL AUTO_INCREMENT,
  `titulo` varchar(50) NOT NULL,
  `responsavel` int(11) NOT NULL,
  `dataInicio` date NOT NULL,
  `dataFim` date NOT NULL,
  `obra` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `eventos`
--

LOCK TABLES `eventos` WRITE;
/*!40000 ALTER TABLE `eventos` DISABLE KEYS */;
INSERT INTO `eventos` VALUES (1,'Van Gogh',1,'2018-05-14','2018-05-18','Lírios'),(2,'Picasso',1,'2018-06-13','2018-06-15','Guernica'),(3,'Leonardo da Vinci',1,'2018-06-08','2018-06-09','Mona Lisa');
/*!40000 ALTER TABLE `eventos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `funcionario`
--

DROP TABLE IF EXISTS `funcionario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `funcionario` (
  `id` smallint(6) NOT NULL AUTO_INCREMENT,
  `nome` varchar(50) NOT NULL,
  `login` varchar(50) NOT NULL,
  `senha` varchar(50) NOT NULL,
  `tipo` int(11) NOT NULL,
  `email` varchar(50) NOT NULL,
  `telefone` varchar(15) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `funcionario`
--

LOCK TABLES `funcionario` WRITE;
/*!40000 ALTER TABLE `funcionario` DISABLE KEYS */;
INSERT INTO `funcionario` VALUES (1,'Administrador','admin','admin',1,'admin@mail.com','(11) 97583-4930'),(2,'Nayara','nayara','ifsp',1,'nayarawatanuki@mail.com','(11) 94493-3190'),(3,'Igor ','igor','123456',2,'igor@mail.com','(11) 94567-8990'),(4,'Felipe','felipe','123',2,'felipe@mail.com','(11) 97749-7478'),(5,'Professora','prof','123',1,'professora@mail.com','(11) 97484-7848'),(7,'Ana','ana','123',1,'ana@mail.com','(11) 94495-3127'),(8,'Gabriel','gabriel','1234',1,'gabriel@mail.com','(11) 96878-7447');
/*!40000 ALTER TABLE `funcionario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `itensevento`
--

DROP TABLE IF EXISTS `itensevento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `itensevento` (
  `id` smallint(6) NOT NULL AUTO_INCREMENT,
  `idObra` int(11) NOT NULL,
  `idEvento` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=678 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `itensevento`
--

LOCK TABLES `itensevento` WRITE;
/*!40000 ALTER TABLE `itensevento` DISABLE KEYS */;
INSERT INTO `itensevento` VALUES (675,2,1),(676,1,2),(677,3,3);
/*!40000 ALTER TABLE `itensevento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `obras`
--

DROP TABLE IF EXISTS `obras`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `obras` (
  `id` smallint(6) NOT NULL AUTO_INCREMENT,
  `titulo` varchar(50) NOT NULL,
  `autor` varchar(50) NOT NULL,
  `aquisicao` date NOT NULL,
  `local` varchar(50) NOT NULL,
  `status` varchar(45) NOT NULL,
  `condicoes` varchar(50) NOT NULL,
  `valor` varchar(20) NOT NULL,
  `descricao` varchar(50) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `obras`
--

LOCK TABLES `obras` WRITE;
/*!40000 ALTER TABLE `obras` DISABLE KEYS */;
INSERT INTO `obras` VALUES (1,'Guernica','Picasso','2016-10-01','Evento: Picasso','Em exposição','Conservada','R$ 650.000.000.000','Data: 1937, \r Dimensões: 350 cm × 776 cm'),(2,'Lírios','Van Gogh','2018-06-02','Evento: Van Gogh','Em exposição','Conservada','R$ 800.000.000.000','Data: 1889, Dimensões: 71 cm x 93 cm\r'),(3,'Mona Lisa','Leonardo da Vinci','2001-04-16','Evento: Leonardo da Vinci','Em exposição','Conservada','R$ 999.000.000.000','Data: 1503, Dimensões: 77 cm x 53 cm'),(4,'A Noite Estrelada','Van Gogh','2005-09-21','sala 2','Disponível','Conservada','R$ 775.000.000.000','Data: 1889, Dimensões: 74 cm x 92 cm'),(5,'A Dança','Picasso','2002-08-15','sala 1','Disponível','Conservada','R$ 400.000.000.000','Data: 1956, Dimensões: 100 cm x 81 cm'),(6,'A Última Ceia','Leonardo da Vinci','1999-06-02','sala 16','Disponível','Conservada','R$ 500.000.000.000','Data: 1495-1498, Dimensões: 4.6 cm x 8.8 cm'),(7,'Les demoiselles d\' Avignon','Picasso','2004-04-11','sala 1\r\n','Disponível','Conservada ','R$ 780.000.000.000','Data: 1907, Dimensões: 243.9 cm x 233.7 cm'),(8,'A Mulher que Chora','Picasso','2002-08-14','sala 1','Disponível','Conservada','R$ 400.000.000.000','Data: 1937, Dimensões: 60 cm x 49 cm'),(9,'Le Rêve','Picasso','2003-03-12','sala 1','Disponível','Conservada ','R$ 300.000.000.000','Data: 1932, Dimensões: 1.3 m x 97 cm');
/*!40000 ALTER TABLE `obras` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'museu'
--

--
-- Dumping routines for database 'museu'
--
/*!50003 DROP PROCEDURE IF EXISTS `InserirEventos` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `InserirEventos`(IN ptitulo VARCHAR(50), IN presponsavel INT(11), IN pdatainicio DATE, IN pdatafim DATE)
BEGIN
	INSERT INTO museu.eventos(titulo, responsavel, dataInicio, dataFim) 
    VALUES (ptitulo, presponsavel, pdatainicio, pdatafim);
    SELECT * FROM museu.eventos WHERE id = LAST_INSERT_ID();
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `InserirFuncionario` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `InserirFuncionario`(IN pnome VARCHAR(50), IN plogin VARCHAR(50), IN psenha VARCHAR(50), IN ptipo INT, IN pemail VARCHAR(50), IN ptelefone VARCHAR(15))
BEGIN
	INSERT INTO museu.funcionario(nome, login, senha, tipo, email, telefone) VALUES (pnome, plogin, psenha, ptipo, pemail, ptelefone);
    SELECT * FROM museu.funcionario WHERE id = LAST_INSERT_ID();
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `InserirItemEvento` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `InserirItemEvento`(IN pidobra INT, IN pidevento INT)
BEGIN
	INSERT INTO museu.itensevento(idObra, idEvento) 
    VALUES (pidobra, pidevento);
    SELECT * FROM museu.itensevento WHERE id = LAST_INSERT_ID();
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `InserirObras` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `InserirObras`(IN ptitulo VARCHAR(50), IN pautor VARCHAR(50), IN paquisicao DATE, IN plocal VARCHAR(50), IN pstatus VARCHAR(45), IN pcondicoes VARCHAR(50), IN pvalor VARCHAR(20), IN pdescricao VARCHAR(50))
BEGIN
	INSERT INTO museu.obras(titulo, autor, aquisicao, local, status, condicoes, valor, descricao) 
    VALUES (ptitulo, pautor, paquisicao, plocal, pstatus, pcondicoes, pvalor, pdescricao);
    SELECT * FROM museu.obras WHERE id = LAST_INSERT_ID();
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Login` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Login`(IN funlogin VARCHAR(50), IN funsenha VARCHAR(50))
BEGIN
	SELECT 
		id, 
		nome, 
		login, 
		senha, 
		tipo, 
		email, 
		telefone
	FROM museu.funcionario
	WHERE login = funlogin AND senha = funsenha;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `RemoveEventos` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `RemoveEventos`(IN pcodigo INT)
BEGIN
	DELETE FROM museu.eventos WHERE id = pcodigo;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `RemoveFuncionario` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `RemoveFuncionario`(IN pcodigo INT)
BEGIN
	DELETE FROM museu.funcionario WHERE id = pcodigo;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `RemoveItemEvento` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `RemoveItemEvento`(IN pcodigo INT)
BEGIN
	DELETE FROM museu.itensevento WHERE id = pcodigo;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `RemoveObras` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `RemoveObras`(IN pcodigo INT)
BEGIN
	DELETE FROM museu.obras WHERE id = pcodigo;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SelectEventos` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SelectEventos`(IN pfiltro VARCHAR(100))
BEGIN
	IF(pfiltro = "") THEN
		SELECT 
			E.id, 
			E.titulo, 
			E.responsavel,
            F.nome AS responsavelNome,
			E.dataInicio, 
			E.dataFim,
            E.obra
		FROM museu.eventos AS E
        INNER JOIN museu.funcionario AS F ON E.responsavel = F.id ;
	ELSE
		SELECT
			E.id, 
			E.titulo, 
			E.responsavel, 
			E.dataInicio, 
			E.dataFim,
            E.obra
		FROM museu.eventos AS E
        INNER JOIN museu.funcionario AS F ON E.responsavel = F.id
		WHERE eventos.id LIKE CONCAT('%', pfiltro, '%')
		OR eventos.titulo LIKE CONCAT('%', pfiltro, '%')
		OR eventos.responsavel LIKE CONCAT('%', pfiltro, '%')
		OR eventos.dataInicio LIKE CONCAT('%', pfiltro, '%')
		OR eventos.dataFim LIKE CONCAT('%', pfiltro, '%')
        OR eventos.obra LIKE CONCAT('%', pfiltro, '%');
	  END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SelectFuncionario` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SelectFuncionario`(IN pfiltro VARCHAR(100))
BEGIN
	IF(pfiltro = "") THEN
		SELECT 
			id, 
			nome, 
			login, 
			senha, 
			tipo, 
			email, 
			telefone
		FROM museu.funcionario;
	ELSE
		SELECT
			id, 
			nome, 
			login, 
			senha, 
			tipo, 
			email, 
			telefone
		FROM museu.funcionario
		WHERE funcionario.id LIKE CONCAT('%', pfiltro, '%')
		OR funcionario.nome LIKE CONCAT('%', pfiltro, '%')
		OR funcionario.login LIKE CONCAT('%', pfiltro, '%')
		OR funcionario.senha LIKE CONCAT('%', pfiltro, '%')
		OR funcionario.tipo LIKE CONCAT('%', pfiltro, '%')
		OR funcionario.email LIKE CONCAT('%', pfiltro, '%')
		OR funcionario.telefone LIKE CONCAT('%', pfiltro, '%');
	  END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SelectItemEvento` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SelectItemEvento`(IN pcodigo INT)
BEGIN
	SELECT 
		I.id, 
		O.titulo,
        O.autor,
        O.local,
        O.status
	FROM museu.itensevento AS I
    INNER JOIN museu.obras AS O ON I.idObra = O.id
    INNER JOIN museu.eventos AS E ON I.idEvento = E.id
    WHERE E.id = pcodigo;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SelectObras` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SelectObras`(IN pfiltro VARCHAR(100))
BEGIN
  IF(pfiltro = "") THEN
	SELECT 
		id, 
        titulo, 
        autor, 
        aquisicao, 
        local, 
        status,
        condicoes, 
        valor,
        descricao
	FROM museu.obras;
  ELSE
	SELECT
		id, 
        titulo, 
        autor, 
        aquisicao, 
        local, 
        status,
        condicoes, 
        valor,
        descricao
	FROM museu.obras
    WHERE obras.id LIKE CONCAT('%', pfiltro, '%')
    OR obras.titulo LIKE CONCAT('%', pfiltro, '%')
    OR obras.autor LIKE CONCAT('%', pfiltro, '%')
    OR obras.aquisicao LIKE CONCAT('%', pfiltro, '%')
    OR obras.local LIKE CONCAT('%', pfiltro, '%')
    OR obras.status LIKE CONCAT('%', pfiltro, '%')
    OR obras.condicoes LIKE CONCAT('%', pfiltro, '%')
    OR obras.valor LIKE CONCAT('%', pfiltro, '%')
    OR obras.descricao LIKE CONCAT('%', pfiltro, '%');
  END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `UpdateEventos` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `UpdateEventos`(IN pid SMALLINT(6), IN ptitulo VARCHAR(50), IN presponsavel INT(11), pdatainicio DATE, IN pdatafim DATE, IN pobra VARCHAR(100))
BEGIN
    UPDATE eventos SET 
    `titulo` = ptitulo,
    `responsavel` = presponsavel, 
    `datainicio` = pdatainicio, 
    `datafim` = pdatafim,
    `obra` = pobra
    WHERE `id` = pid;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `UpdateFuncionario` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `UpdateFuncionario`(IN pid SMALLINT(6), IN pnome VARCHAR(50), IN plogin VARCHAR(50), IN psenha VARCHAR(50), IN ptipo INT(11), IN pemail VARCHAR(50), IN ptelefone VARCHAR(15))
BEGIN
	UPDATE funcionario SET  
    `nome` = pnome, 
    `login` = plogin, 
	`senha` = psenha, 
    `tipo` = ptipo, 
    `email` = pemail, 
    `telefone` = ptelefone
    WHERE `id` = pid;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `UpdateItemEvento` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `UpdateItemEvento`(IN pid SMALLINT(6), IN pidObra INT(11), IN pidEvento INT(11))
BEGIN
	UPDATE museu.itensevento SET
    `idObra` = pidObra,
    `idEvento` = pidEvento
    WHERE `id` = pid;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `UpdateObraEventos` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `UpdateObraEventos`(IN pid SMALLINT(6), IN plocal VARCHAR(50), IN pstatus VARCHAR(45))
BEGIN
	UPDATE museu.obras SET
    `local` = plocal,
    `status` = pstatus
    WHERE `id` = pid;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `UpdateObras` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `UpdateObras`(IN pid SMALLINT(6), IN ptitulo VARCHAR(50), IN pautor VARCHAR(50), IN paquisicao DATE, IN plocal VARCHAR(50), IN pstatus VARCHAR(45), IN pcondicoes VARCHAR(50), IN pvalor VARCHAR(20), IN pdescricao VARCHAR(50))
BEGIN
	UPDATE obras SET  
    `titulo` = ptitulo, 
    `autor` = pautor, 
	`aquisicao` = paquisicao, 
    `local` = plocal,
    `status` = pstatus,
    `condicoes` = pcondicoes,
    `valor` = pvalor,
    `descricao` = pdescricao
    WHERE `id` = pid;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-06-19 16:43:03
