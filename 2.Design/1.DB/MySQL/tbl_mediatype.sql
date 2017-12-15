-- phpMyAdmin SQL Dump
-- version 4.7.1
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Dec 15, 2017 at 07:17 PM
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
-- Table structure for table `tbl_mediatype`
--

CREATE TABLE `tbl_mediatype` (
  `id` smallint(5) UNSIGNED NOT NULL COMMENT 'Mã kiểu',
  `name` varchar(50) NOT NULL COMMENT 'Tên kiểu',
  `title` varchar(50) NOT NULL COMMENT 'Tiêu đề'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Kiểu đa phương tiện';

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_mediatype`
--
ALTER TABLE `tbl_mediatype`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `UN_mediatype1` (`name`),
  ADD UNIQUE KEY `id` (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_mediatype`
--
ALTER TABLE `tbl_mediatype`
  MODIFY `id` smallint(5) UNSIGNED NOT NULL AUTO_INCREMENT COMMENT 'Mã kiểu';COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
