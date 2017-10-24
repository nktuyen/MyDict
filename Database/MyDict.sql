
-- phpMyAdmin SQL Dump
-- version 3.5.2.2
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Oct 24, 2017 at 04:55 PM
-- Server version: 10.1.24-MariaDB
-- PHP Version: 5.2.17

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `u483080646_mydic`
--

-- --------------------------------------------------------

--
-- Table structure for table `Categories`
--

CREATE TABLE IF NOT EXISTS `Categories` (
  `id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `name` varchar(255) CHARACTER SET utf8 NOT NULL,
  `title` varchar(255) CHARACTER SET utf8 NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id` (`id`),
  UNIQUE KEY `name` (`name`),
  KEY `id_2` (`id`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=10 ;

--
-- Dumping data for table `Categories`
--

INSERT INTO `Categories` (`id`, `name`, `title`) VALUES
(1, 'all', '(Tất cả)'),
(2, 'math', 'Toán học'),
(3, 'it', 'Công nghệ thông tin'),
(4, 'graphics', 'Đồ họa'),
(5, 'agri', 'Nông nghiệp'),
(6, 'software', 'Phần mềm'),
(7, 'hardware', 'Phần cứng'),
(8, 'cuisines', 'Ẩm thực'),
(9, 'literary', 'Văn học');

-- --------------------------------------------------------

--
-- Table structure for table `Classes`
--

CREATE TABLE IF NOT EXISTS `Classes` (
  `id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `name` varchar(255) CHARACTER SET utf8 NOT NULL,
  `title` varchar(255) CHARACTER SET utf8 NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id` (`id`),
  UNIQUE KEY `name` (`name`),
  KEY `id_2` (`id`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=7 ;

--
-- Dumping data for table `Classes`
--

INSERT INTO `Classes` (`id`, `name`, `title`) VALUES
(1, 'noun', 'Danh từ'),
(2, 'verb', 'Động từ'),
(3, 'adverb', 'Trạng từ'),
(4, 'adjective', 'Tính từ'),
(5, 'preposition', 'Giới từ'),
(6, 'conjunction', 'Liên từ');

-- --------------------------------------------------------

--
-- Table structure for table `Description`
--

CREATE TABLE IF NOT EXISTS `Description` (
  `id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `phonetic_id` bigint(20) unsigned NOT NULL,
  `description` varchar(255) CHARACTER SET utf8 NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `Dictionaries`
--

CREATE TABLE IF NOT EXISTS `Dictionaries` (
  `id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `name` varchar(255) CHARACTER SET utf8 NOT NULL,
  `title` varchar(255) CHARACTER SET utf8 NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id` (`id`),
  UNIQUE KEY `name` (`name`),
  KEY `id_2` (`id`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=3 ;

--
-- Dumping data for table `Dictionaries`
--

INSERT INTO `Dictionaries` (`id`, `name`, `title`) VALUES
(1, 'eng-vie', 'Anh Việt'),
(2, 'vie-eng', 'Việt Anh');

-- --------------------------------------------------------

--
-- Table structure for table `Examples`
--

CREATE TABLE IF NOT EXISTS `Examples` (
  `id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `description_id` bigint(20) unsigned NOT NULL,
  `example` varchar(1024) CHARACTER SET utf8 NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id` (`id`),
  KEY `id_2` (`id`),
  KEY `id_3` (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `Favorites`
--

CREATE TABLE IF NOT EXISTS `Favorites` (
  `id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `vocabulary_id` bigint(20) unsigned NOT NULL,
  `user_id` bigint(20) unsigned NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `Functions`
--

CREATE TABLE IF NOT EXISTS `Functions` (
  `id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `name` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `title` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `name` (`name`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `Modules`
--

CREATE TABLE IF NOT EXISTS `Modules` (
  `id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `name` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `title` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `name` (`name`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `Permission`
--

CREATE TABLE IF NOT EXISTS `Permission` (
  `id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `name` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `title` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `name` (`name`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=4 ;

--
-- Dumping data for table `Permission`
--

INSERT INTO `Permission` (`id`, `name`, `title`) VALUES
(1, 'read', 'Đọc'),
(2, 'write', 'Ghi'),
(3, 'delete', 'Xóa');

-- --------------------------------------------------------

--
-- Table structure for table `Phonetics`
--

CREATE TABLE IF NOT EXISTS `Phonetics` (
  `id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `vocabulary_id` bigint(20) unsigned NOT NULL,
  `class_id` bigint(20) unsigned NOT NULL,
  `phonetic` varchar(255) CHARACTER SET utf8 NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id` (`id`),
  KEY `id_2` (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `Rights`
--

CREATE TABLE IF NOT EXISTS `Rights` (
  `id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `user_id` bigint(20) unsigned NOT NULL,
  `module_id` bigint(20) unsigned NOT NULL,
  `function_id` bigint(20) unsigned NOT NULL,
  `permission_id` bigint(20) unsigned NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `Translation`
--

CREATE TABLE IF NOT EXISTS `Translation` (
  `id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `example_id` bigint(20) unsigned NOT NULL,
  `translation` varchar(1024) CHARACTER SET utf8 NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id` (`id`),
  KEY `id_2` (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `Users`
--

CREATE TABLE IF NOT EXISTS `Users` (
  `id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `name` varchar(255) CHARACTER SET utf8 NOT NULL,
  `first_name` varchar(50) CHARACTER SET utf8 NOT NULL,
  `midle_name` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `last_name` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `email` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  `birth_day` smallint(6) unsigned DEFAULT NULL,
  `birth_month` smallint(6) unsigned DEFAULT NULL,
  `birth_year` int(11) unsigned DEFAULT NULL,
  `created_time` timestamp NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id` (`id`),
  UNIQUE KEY `name` (`name`),
  KEY `name_2` (`name`),
  KEY `name_3` (`name`),
  KEY `id_2` (`id`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=4 ;

--
-- Dumping data for table `Users`
--

INSERT INTO `Users` (`id`, `name`, `first_name`, `midle_name`, `last_name`, `email`, `birth_day`, `birth_month`, `birth_year`, `created_time`) VALUES
(3, 'tuyen', 'Tuyen', 'Khac', 'Nguyen', 'nktuyen@hotmail.com', 18, 3, 1988, '2017-10-24 16:41:55'),
(2, 'administrator', 'Administrator', NULL, NULL, 'admin@nktuyen.com', 18, 3, 1988, '2017-10-24 16:41:06');

-- --------------------------------------------------------

--
-- Table structure for table `Vocabularies`
--

CREATE TABLE IF NOT EXISTS `Vocabularies` (
  `id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `name` varchar(255) CHARACTER SET utf8 NOT NULL,
  `dictionary_id` bigint(20) unsigned NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `name` (`name`),
  UNIQUE KEY `id` (`id`),
  KEY `name_2` (`name`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=1 ;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
