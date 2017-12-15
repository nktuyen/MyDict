-- phpMyAdmin SQL Dump
-- version 4.7.1
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Dec 15, 2017 at 07:16 PM
-- Server version: 5.5.45
-- PHP Version: 7.1.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `mydict`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_country`
--

CREATE TABLE `tbl_country` (
  `id` smallint(6) UNSIGNED NOT NULL COMMENT 'Mã quốc gia bằng số',
  `country_code` varchar(50) NOT NULL COMMENT 'Mã quốc gia bằng ký tự',
  `iso_code` varchar(50) NOT NULL COMMENT 'Mã quốc gia theo ISO',
  `name` varchar(50) NOT NULL COMMENT 'Tên quốc gia',
  `title` varchar(50) NOT NULL COMMENT 'Tiêu đề',
  `primary_language` smallint(6) UNSIGNED NOT NULL COMMENT 'Ngôn ngữ chính'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Quốc gia';

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_country`
--
ALTER TABLE `tbl_country`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `UN_country1` (`country_code`),
  ADD UNIQUE KEY `UN_country2` (`iso_code`),
  ADD UNIQUE KEY `UN_country3` (`name`),
  ADD UNIQUE KEY `id` (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_country`
--
ALTER TABLE `tbl_country`
  MODIFY `id` smallint(6) UNSIGNED NOT NULL AUTO_INCREMENT COMMENT 'Mã quốc gia bằng số';COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
