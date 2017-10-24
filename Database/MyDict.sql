
-- phpMyAdmin SQL Dump
-- version 3.5.2.2
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Oct 24, 2017 at 06:27 PM
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
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=18 ;

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
(9, 'literary', 'Văn học'),
(10, 'phrase-verb', 'Cụm động từ'),
(11, 'fashion', 'Thời trang'),
(12, 'love', 'Tình yêu'),
(13, 'sexual ', 'Tình dục'),
(14, 'Life', 'Cuộc sống'),
(15, 'electronic', 'Điện tử'),
(16, 'telecom', 'Viễn thông'),
(17, 'Health', 'Sức khỏe');

-- --------------------------------------------------------

--
-- Table structure for table `Categorization`
--

CREATE TABLE IF NOT EXISTS `Categorization` (
  `phonetic_id` bigint(20) unsigned NOT NULL,
  `category_id` bigint(20) unsigned NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

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
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=8 ;

--
-- Dumping data for table `Classes`
--

INSERT INTO `Classes` (`id`, `name`, `title`) VALUES
(1, 'noun', 'Danh từ'),
(2, 'verb', 'Động từ'),
(3, 'adverb', 'Trạng từ'),
(4, 'adjective', 'Tính từ'),
(5, 'preposition', 'Giới từ'),
(6, 'conjunction', 'Liên từ'),
(7, 'article', 'Mạo từ');

-- --------------------------------------------------------

--
-- Table structure for table `Description`
--

CREATE TABLE IF NOT EXISTS `Description` (
  `id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `phonetic_id` bigint(20) unsigned NOT NULL,
  `description` varchar(255) CHARACTER SET utf8 NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=5 ;

--
-- Dumping data for table `Description`
--

INSERT INTO `Description` (`id`, `phonetic_id`, `description`) VALUES
(1, 1, 'Chữ A trong bảng chữ cái'),
(3, 2, 'Một (đứng trước danh từ số ít bắt đầu bằng phụ âm)'),
(4, 3, 'Một (đứng trước danh từ số ít bắt đầu bằng nguyên âm)');

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
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=10 ;

--
-- Dumping data for table `Dictionaries`
--

INSERT INTO `Dictionaries` (`id`, `name`, `title`) VALUES
(1, 'eng-vie', 'Anh - Việt'),
(2, 'vie-eng', 'Việt - Anh'),
(3, 'fre-vie', 'Pháp - Việt'),
(4, 'vie-fre', 'Việt - Pháp'),
(5, 'kor-vie', 'Hàn - Việt'),
(6, 'vie-kor', 'Việt - Hàn'),
(7, 'jap-vie', 'Nhật - Việt'),
(8, 'vie-jap', 'Việt - Nhật'),
(9, 'chn-vie', 'Việt - Trung');

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
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=4 ;

--
-- Dumping data for table `Examples`
--

INSERT INTO `Examples` (`id`, `description_id`, `example`) VALUES
(1, 1, 'A is the first character in alphabet table.'),
(2, 3, 'I have a pen.'),
(3, 3, 'She has a red hair');

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
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=5 ;

--
-- Dumping data for table `Phonetics`
--

INSERT INTO `Phonetics` (`id`, `vocabulary_id`, `class_id`, `phonetic`) VALUES
(1, 1, 1, 'ei'),
(3, 2, 7, 'ən'),
(2, 1, 7, 'ə');

-- --------------------------------------------------------

--
-- Table structure for table `Phrases`
--

CREATE TABLE IF NOT EXISTS `Phrases` (
  `id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `vocabulary1_id` bigint(20) unsigned NOT NULL,
  `vocabulary2_id` bigint(20) unsigned DEFAULT NULL,
  `vocabulary3_id` bigint(20) unsigned DEFAULT NULL,
  `vocabulary4_id` bigint(20) unsigned DEFAULT NULL,
  `vocabulary5_id` bigint(20) unsigned DEFAULT NULL,
  `dictionary_id` bigint(20) unsigned NOT NULL,
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
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=4 ;

--
-- Dumping data for table `Translation`
--

INSERT INTO `Translation` (`id`, `example_id`, `translation`) VALUES
(1, 1, 'A là chữ cái đầu tiên trong bảng chữ cái'),
(2, 2, 'Tôi có một chiếc bút bi'),
(3, 3, 'Cô ấy có một mái tóc màu đỏ');

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
(2, 'tuyen', 'Tuyen', 'Khac', 'Nguyen', 'nktuyen@hotmail.com', 18, 3, 1988, '2017-10-24 16:41:55'),
(1, 'administrator', 'Administrator', NULL, NULL, 'admin@nktuyen.com', 18, 3, 1988, '2017-10-24 16:41:06');

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
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=178 ;

--
-- Dumping data for table `Vocabularies`
--

INSERT INTO `Vocabularies` (`id`, `name`, `dictionary_id`) VALUES
(1, 'a', 1),
(2, 'an', 1),
(3, 'aback', 1),
(4, 'abacus', 1),
(5, 'abaddon', 1),
(6, 'abaft', 1),
(7, 'abalone', 1),
(8, 'abandon', 1),
(9, 'abandoned', 1),
(10, 'abandonment', 1),
(11, 'abase', 1),
(12, 'abasement', 1),
(13, 'abbacy', 1),
(14, 'abbatial', 1),
(15, 'can', 1),
(16, 'teach', 1),
(17, 'you', 1),
(18, 'me', 1),
(19, 'it', 1),
(20, 'he', 1),
(21, 'she', 1),
(22, 'him', 1),
(23, 'they', 1),
(24, 'us', 1),
(25, 'young', 1),
(26, 'old', 1),
(27, 'aim', 1),
(28, 'air', 1),
(29, 'absent', 1),
(30, 'abstract', 1),
(31, 'ban', 1),
(32, 'bag', 1),
(33, 'course', 1),
(34, 'count', 1),
(35, 'ceil', 1),
(36, 'cut', 1),
(37, 'capture', 1),
(38, 'cable', 1),
(39, 'die', 1),
(40, 'day', 1),
(41, 'delay', 1),
(42, 'delivery', 1),
(43, 'develop', 1),
(44, 'developer', 1),
(45, 'draft', 1),
(46, 'driver', 1),
(47, 'eat', 1),
(48, 'earn', 1),
(49, 'free', 1),
(50, 'french', 0),
(51, 'grey', 1),
(52, 'gray', 1),
(53, 'grow', 1),
(54, 'group', 1),
(55, 'hat', 1),
(56, 'height', 1),
(57, 'hot', 1),
(58, 'hold', 1),
(59, 'hit', 1),
(60, 'heavy', 1),
(61, 'intger', 1),
(62, 'information', 1),
(63, 'infinite', 1),
(64, 'ink', 1),
(65, 'join', 1),
(66, 'just', 1),
(67, 'journey', 1),
(68, 'lay', 1),
(69, 'language', 1),
(70, 'land', 1),
(71, 'noun', 1),
(72, 'no', 1),
(73, 'national', 1),
(74, 'nation', 1),
(75, 'note', 1),
(76, 'notice', 1),
(77, 'nothing', 1),
(78, 'none', 1),
(79, 'not', 1),
(80, 'nail', 1),
(81, 'now', 1),
(82, 'nice', 1),
(83, 'oil', 1),
(84, 'on', 1),
(85, 'in', 1),
(86, 'out', 1),
(87, 'over', 1),
(88, 'order', 1),
(89, 'pink', 1),
(90, 'pipe', 1),
(91, 'preposition', 1),
(92, 'practise', 1),
(93, 'practice', 1),
(94, 'pround', 1),
(95, 'print', 1),
(96, 'present', 1),
(97, 'quit', 1),
(98, 'quite', 1),
(99, 'quiet', 1),
(100, 'query', 1),
(101, 'question', 1),
(102, 'rain', 1),
(103, 'round', 1),
(104, 'rush', 1),
(105, 'run', 1),
(106, 'star', 1),
(107, 'start', 1),
(108, 'stair', 1),
(109, 'stom', 1),
(110, 'saw', 1),
(111, 'see', 1),
(112, 'still', 1),
(113, 'sleep', 1),
(114, 'think', 1),
(115, 'that', 1),
(116, 'this', 1),
(117, 'those', 1),
(118, 'these', 1),
(119, 'then', 1),
(120, 'thought', 1),
(121, 'through', 1),
(122, 'threw', 1),
(123, 'throw', 1),
(124, 'toe', 1),
(125, 'top', 1),
(126, 'tip', 1),
(127, 'tool', 1),
(128, 'till', 1),
(129, 'treat', 1),
(130, 'tree', 1),
(131, 'true', 1),
(132, 'false', 1),
(133, 'failure', 1),
(134, 'united', 1),
(135, 'unit', 1),
(136, 'unique', 1),
(137, 'uniform', 1),
(138, 'various', 1),
(139, 'variable', 1),
(140, 'variant', 1),
(141, 'b', 1),
(142, 'c', 1),
(143, 'd', 1),
(144, 'e', 1),
(145, 'f', 1),
(146, 'g', 1),
(147, 'h', 1),
(148, 'i', 1),
(149, 'j', 1),
(150, 'k', 1),
(151, 'l', 2),
(152, 'm', 1),
(153, 'n', 1),
(154, 'o', 1),
(155, 'p', 1),
(156, 'q', 1),
(157, 'r', 1),
(158, 's', 1),
(159, 't', 1),
(160, 'u', 1),
(161, 'v', 1),
(162, 'x', 1),
(163, 'y', 1),
(164, 'z', 1),
(165, 'w', 1),
(166, 'zoo', 1),
(167, 'zero', 1),
(168, 'while', 1),
(169, 'what', 1),
(170, 'which', 1),
(171, 'when', 1),
(172, 'where', 1),
(173, 'want', 1),
(174, 'will', 1),
(175, 'west', 1),
(176, 'your', 1),
(177, 'yours', 1);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
