-- MySQL dump 10.16  Distrib 10.1.37-MariaDB, for Win32 (AMD64)
--
-- Host: 127.0.0.1    Database: calendae
-- ------------------------------------------------------
-- Server version	10.1.37-MariaDB

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
-- Table structure for table `events`
--

DROP TABLE IF EXISTS `events`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `events` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `event_name` varchar(100) DEFAULT NULL,
  `venue` varchar(255) DEFAULT NULL,
  `date_from` varchar(100) DEFAULT NULL,
  `date_to` varchar(100) DEFAULT NULL,
  `time` varchar(100) DEFAULT NULL,
  `student_registration` int(11) DEFAULT NULL,
  `student_slots` int(11) DEFAULT NULL,
  `event_details` text,
  `allow_guests` tinyint(1) DEFAULT NULL,
  `guest_registration` int(11) DEFAULT NULL,
  `guest_slots` int(11) DEFAULT NULL,
  `is_activated` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `event_name` (`event_name`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `events`
--

LOCK TABLES `events` WRITE;
/*!40000 ALTER TABLE `events` DISABLE KEYS */;
INSERT INTO `events` VALUES (10,'Shot','Bahay ni Ian','December 01, 2020','December 03, 2020','08:00 am - 10:00 pm',0,0,'Lasing gabi gabi',0,0,0,1),(11,'Shot manen','Bahay ni Isiah','December 09, 2020','December 09, 2020','08:00 am - 05:00 pm',0,4,'Shot again',0,0,0,1);
/*!40000 ALTER TABLE `events` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `guest_registrations`
--

DROP TABLE IF EXISTS `guest_registrations`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `guest_registrations` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `event_id` int(11) DEFAULT NULL,
  `guest_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `event_id` (`event_id`),
  KEY `guest_id` (`guest_id`),
  CONSTRAINT `guest_registrations_ibfk_1` FOREIGN KEY (`event_id`) REFERENCES `events` (`id`),
  CONSTRAINT `guest_registrations_ibfk_2` FOREIGN KEY (`guest_id`) REFERENCES `guests` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `guest_registrations`
--

LOCK TABLES `guest_registrations` WRITE;
/*!40000 ALTER TABLE `guest_registrations` DISABLE KEYS */;
/*!40000 ALTER TABLE `guest_registrations` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `guests`
--

DROP TABLE IF EXISTS `guests`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `guests` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `first_name` varchar(100) DEFAULT NULL,
  `middle_name` varchar(100) DEFAULT NULL,
  `last_name` varchar(100) DEFAULT NULL,
  `address` varchar(255) DEFAULT NULL,
  `contact` varchar(11) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `gender` char(1) DEFAULT NULL,
  `school_name` varchar(100) DEFAULT NULL,
  `course` varchar(100) DEFAULT NULL,
  `year` varchar(50) DEFAULT NULL,
  `works_at` varchar(100) DEFAULT NULL,
  `position` varchar(100) DEFAULT NULL,
  `code` varchar(10) DEFAULT NULL,
  `is_activated` tinyint(1) DEFAULT NULL,
  `event_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `event_id` (`event_id`),
  CONSTRAINT `guests_ibfk_1` FOREIGN KEY (`event_id`) REFERENCES `events` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `guests`
--

LOCK TABLES `guests` WRITE;
/*!40000 ALTER TABLE `guests` DISABLE KEYS */;
/*!40000 ALTER TABLE `guests` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `officers`
--

DROP TABLE IF EXISTS `officers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `officers` (
  `id` varchar(100) NOT NULL,
  `position` varchar(100) DEFAULT NULL,
  `first_name` varchar(100) DEFAULT NULL,
  `middle_name` varchar(100) DEFAULT NULL,
  `last_name` varchar(100) DEFAULT NULL,
  `address` varchar(255) DEFAULT NULL,
  `contact` varchar(11) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `gender` char(1) DEFAULT NULL,
  `course` varchar(100) DEFAULT NULL,
  `year_and_section` char(2) DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `officers`
--

LOCK TABLES `officers` WRITE;
/*!40000 ALTER TABLE `officers` DISABLE KEYS */;
INSERT INTO `officers` VALUES ('181-1665-2','President','Ian Justin','Banera','Salazar','Concepcion, Rosario, La Union','09467170412','ian,salazar94@gmail.com','M','BS InfoTech','3F','hacZB3e1ty1FjPADMciLYV+lsN6e2CNPly6WkWjda9H0v8P/Yr63IA=='),('181-1668-2','Adviser','Noel Xavier','Milana','Ulpindo','Rosario, La Union','09126238743','noel.ulpindo@gmail.com','M','BS Information Technology','3F','f/HmDNuU9CXLH3JlNHYV1lznGGQ19l8oAkK6h16ZPtlLIBBm7fI9Hw=='),('181-1669-2','CEO','Isiah Neil','Boado','Villanueva','San Nicolas, Agoo, La Union','09123456789','isiahneil@gmail.com','M','BS Information Technology','3F','u3sQwlmDf7NVEqE3RxDXJov4BVkuXluLv/yeJEil4Sy0cTDsW7VneA=='),('181-2475-2','Hipster','Irish','Perez','Lagasca','Damortis Rosario La Union','09511847443','iris.lagasca@gmail.com','M','BSIT','3-','kiNtDk3bz3ecORbeUGDKWr+n6pwVZPaGM7GQGQb2/Y6C2Qc+80iR8w==');
/*!40000 ALTER TABLE `officers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `student_registrations`
--

DROP TABLE IF EXISTS `student_registrations`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `student_registrations` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `event_id` int(11) DEFAULT NULL,
  `student_id` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `event_id` (`event_id`),
  KEY `student_id` (`student_id`),
  CONSTRAINT `student_registrations_ibfk_1` FOREIGN KEY (`event_id`) REFERENCES `events` (`id`),
  CONSTRAINT `student_registrations_ibfk_2` FOREIGN KEY (`student_id`) REFERENCES `students` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `student_registrations`
--

LOCK TABLES `student_registrations` WRITE;
/*!40000 ALTER TABLE `student_registrations` DISABLE KEYS */;
INSERT INTO `student_registrations` VALUES (1,10,'181-1666-2');
/*!40000 ALTER TABLE `student_registrations` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `students`
--

DROP TABLE IF EXISTS `students`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `students` (
  `id` varchar(100) NOT NULL,
  `first_name` varchar(100) DEFAULT NULL,
  `middle_name` varchar(100) DEFAULT NULL,
  `last_name` varchar(100) DEFAULT NULL,
  `address` varchar(255) DEFAULT NULL,
  `contact` varchar(11) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `gender` char(1) DEFAULT NULL,
  `course` varchar(100) DEFAULT NULL,
  `year_and_section` char(2) DEFAULT NULL,
  `is_activated` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `students`
--

LOCK TABLES `students` WRITE;
/*!40000 ALTER TABLE `students` DISABLE KEYS */;
INSERT INTO `students` VALUES ('181-1665-2','Ian Justin','Banera','Salazar','Concepcion, Rosario, La Union','09467170412','ian.salazar94@gmail.com','M','BS Information Technology','3F',0),('181-1666-2','Iris','Perez','Lagasca','Damortis, Rosario, La Union','09283922122','irislagasca@gmail.com','M','BS Information Technology','3F',1);
/*!40000 ALTER TABLE `students` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-12-04 21:22:58
