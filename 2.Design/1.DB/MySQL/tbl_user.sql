-- phpMyAdmin SQL Dump
-- version 4.7.1
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Dec 15, 2017 at 07:18 PM
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
-- Table structure for table `tbl_user`
--

CREATE TABLE `tbl_user` (
  `id` bigint(20) UNSIGNED NOT NULL COMMENT 'Mã người dùng',
  `name` varchar(255) NOT NULL COMMENT 'Tên đăng nhập',
  `alias` varchar(255) NOT NULL COMMENT 'Bí danh',
  `password` varchar(255) NOT NULL COMMENT 'Mật khẩu',
  `email` varchar(255) NOT NULL COMMENT 'Địa chỉ email',
  `phone` varchar(50) NOT NULL COMMENT 'Số điện thoại',
  `first_name` varchar(50) NOT NULL COMMENT 'Tên',
  `last_name` varchar(50) DEFAULT NULL COMMENT 'Họ',
  `birth_day` tinyint(4) NOT NULL COMMENT 'Ngày sinh',
  `birth_month` tinyint(4) NOT NULL COMMENT 'Tháng sinh',
  `birth_year` smallint(6) NOT NULL COMMENT 'Năm sinh',
  `gender` tinyint(4) NOT NULL COMMENT 'Giới tính',
  `registered_date` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP COMMENT 'Ngày đăng ký'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Người dùng';

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_user`
--
ALTER TABLE `tbl_user`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `UN_user1` (`name`),
  ADD UNIQUE KEY `UN_user2` (`alias`),
  ADD UNIQUE KEY `UN_user3` (`email`),
  ADD UNIQUE KEY `UN_user4` (`phone`),
  ADD UNIQUE KEY `id` (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_user`
--
ALTER TABLE `tbl_user`
  MODIFY `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT COMMENT 'Mã người dùng';COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
