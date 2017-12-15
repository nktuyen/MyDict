-- phpMyAdmin SQL Dump
-- version 4.7.1
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Dec 08, 2017 at 11:09 AM
-- Server version: 5.5.45
-- PHP Version: 5.6.31

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
-- Table structure for table `tbl_category`
--

CREATE TABLE `tbl_category` (
  `id` bigint(20) NOT NULL COMMENT 'Mã danh mục',
  `name` varchar(255) NOT NULL COMMENT 'Tên danh mục',
  `title` varchar(255) NOT NULL COMMENT 'Tiêu đề'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Danh mục';

-- --------------------------------------------------------

--
-- Table structure for table `tbl_class`
--

CREATE TABLE `tbl_class` (
  `id` bigint(20) NOT NULL,
  `name` varchar(255) NOT NULL,
  `title` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Loại từ';

-- --------------------------------------------------------

--
-- Table structure for table `tbl_country`
--

CREATE TABLE `tbl_country` (
  `id` bigint(20) NOT NULL COMMENT 'Mã số',
  `country_code` varchar(50) NOT NULL,
  `iso_code` varchar(50) NOT NULL COMMENT 'Mã ISO',
  `name` varchar(255) NOT NULL COMMENT 'Tên quốc gia',
  `title` varchar(255) DEFAULT NULL COMMENT 'Tiêu đề'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Quốc gia';

--
-- Dumping data for table `tbl_country`
--

INSERT INTO `tbl_country` (`id`, `country_code`, `iso_code`, `name`, `title`) VALUES
(246, '93', 'AFG', 'Afghanistan', 'Afghanistan'),
(247, '355', 'ALB', 'Albania', 'Albania'),
(248, '213', 'DZA', 'Algeria', 'Algeria'),
(249, '1-684', 'ASM', 'American Samoa', 'American Samoa'),
(250, '376', 'AND', 'Andorra', 'Andorra'),
(251, '244', 'AGO', 'Angola', 'Angola'),
(252, '1-264', 'AIA', 'Anguilla', 'Anguilla'),
(253, '672', 'ATA', 'Antarctica', 'Antarctica'),
(254, '1-268', 'ATG', 'Antigua and Barbuda', 'Antigua and Barbuda'),
(255, '54', 'ARG', 'Argentina', 'Argentina'),
(256, '374', 'ARM', 'Armenia', 'Armenia'),
(257, '297', 'ABW', 'Aruba', 'Aruba'),
(258, '61', 'AUS', 'Australia', 'Australia'),
(259, '43', 'AUT', 'Austria', 'Austria'),
(260, '994', 'AZE', 'Azerbaijan', 'Azerbaijan'),
(261, '1-242', 'BHS', 'Bahamas', 'Bahamas'),
(262, '973', 'BHR', 'Bahrain', 'Bahrain'),
(263, '880', 'BGD', 'Bangladesh', 'Bangladesh'),
(264, '1-246', 'BRB', 'Barbados', 'Barbados'),
(265, '375', 'BLR', 'Belarus', 'Belarus'),
(266, '32', 'BEL', 'Belgium', 'Belgium'),
(267, '501', 'BLZ', 'Belize', 'Belize'),
(268, '229', 'BEN', 'Benin', 'Benin'),
(269, '1-441', 'BMU', 'Bermuda', 'Bermuda'),
(270, '975', 'BTN', 'Bhutan', 'Bhutan'),
(271, '591', 'BOL', 'Bolivia', 'Bolivia'),
(272, '387', 'BIH', 'Bosnia and Herzegovina', 'Bosnia and Herzegovina'),
(273, '267', 'BWA', 'Botswana', 'Botswana'),
(274, '55', 'BRA', 'Brazil', 'Brazil'),
(275, '246', 'IOT', 'British Indian Ocean Territory', 'British Indian Ocean Territory'),
(276, '1-284', 'VGB', 'British Virgin Islands', 'British Virgin Islands'),
(277, '673', 'BRN', 'Brunei', 'Brunei'),
(278, '359', 'BGR', 'Bulgaria', 'Bulgaria'),
(279, '226', 'BFA', 'Burkina Faso', 'Burkina Faso'),
(280, '257', 'BDI', 'Burundi', 'Burundi'),
(281, '855', 'KHM', 'Cambodia', 'Cambodia'),
(282, '237', 'CMR', 'Cameroon', 'Cameroon'),
(283, '1', 'CAN', 'Canada', 'Canada'),
(284, '238', 'CPV', 'Cape Verde', 'Cape Verde'),
(285, '1-345', 'CYM', 'Cayman Islands', 'Cayman Islands'),
(286, '236', 'CAF', 'Central African Republic', 'Central African Republic'),
(287, '235', 'TCD', 'Chad', 'Chad'),
(288, '56', 'CHL', 'Chile', 'Chile'),
(289, '86', 'CHN', 'China', 'China'),
(290, '61', 'CXR', 'Christmas Island', 'Christmas Island'),
(291, '61', 'CCK', 'Cocos Islands', 'Cocos Islands'),
(292, '57', 'COL', 'Colombia', 'Colombia'),
(293, '269', 'COM', 'Comoros', 'Comoros'),
(294, '682', 'COK', 'Cook Islands', 'Cook Islands'),
(295, '506', 'CRI', 'Costa Rica', 'Costa Rica'),
(296, '385', 'HRV', 'Croatia', 'Croatia'),
(297, '53', 'CUB', 'Cuba', 'Cuba'),
(298, '599', 'CUW', 'Curacao', 'Curacao'),
(299, '357', 'CYP', 'Cyprus', 'Cyprus'),
(300, '420', 'CZE', 'Czech Republic', 'Czech Republic'),
(301, '243', 'COD', 'Democratic Republic of the Congo', 'Democratic Republic of the Congo'),
(302, '45', 'DNK', 'Denmark', 'Denmark'),
(303, '253', 'DJI', 'Djibouti', 'Djibouti'),
(304, '1-767', 'DMA', 'Dominica', 'Dominica'),
(305, '1-809', 'DOM', 'Dominican Republic', 'Dominican Republic'),
(306, '670', 'TLS', 'East Timor', 'East Timor'),
(307, '593', 'ECU', 'Ecuador', 'Ecuador'),
(308, '20', 'EGY', 'Egypt', 'Egypt'),
(309, '503', 'SLV', 'El Salvador', 'El Salvador'),
(310, '240', 'GNQ', 'Equatorial Guinea', 'Equatorial Guinea'),
(311, '291', 'ERI', 'Eritrea', 'Eritrea'),
(312, '372', 'EST', 'Estonia', 'Estonia'),
(313, '251', 'ETH', 'Ethiopia', 'Ethiopia'),
(314, '500', 'FLK', 'Falkland Islands', 'Falkland Islands'),
(315, '298', 'FRO', 'Faroe Islands', 'Faroe Islands'),
(316, '679', 'FJI', 'Fiji', 'Fiji'),
(317, '358', 'FIN', 'Finland', 'Finland'),
(318, '33', 'FRA', 'France', 'France'),
(319, '689', 'PYF', 'French Polynesia', 'French Polynesia'),
(320, '241', 'GAB', 'Gabon', 'Gabon'),
(321, '220', 'GMB', 'Gambia', 'Gambia'),
(322, '995', 'GEO', 'Georgia', 'Georgia'),
(323, '49', 'DEU', 'Germany', 'Germany'),
(324, '233', 'GHA', 'Ghana', 'Ghana'),
(325, '350', 'GIB', 'Gibraltar', 'Gibraltar'),
(326, '30', 'GRC', 'Greece', 'Greece'),
(327, '299', 'GRL', 'Greenland', 'Greenland'),
(328, '1-473', 'GRD', 'Grenada', 'Grenada'),
(329, '1-671', 'GUM', 'Guam', 'Guam'),
(330, '502', 'GTM', 'Guatemala', 'Guatemala'),
(331, '44-1481', 'GGY', 'Guernsey', 'Guernsey'),
(332, '224', 'GIN', 'Guinea', 'Guinea'),
(333, '245', 'GNB', 'Guinea-Bissau', 'Guinea-Bissau'),
(334, '592', 'GUY', 'Guyana', 'Guyana'),
(335, '509', 'HTI', 'Haiti', 'Haiti'),
(336, '504', 'HND', 'Honduras', 'Honduras'),
(337, '852', 'HKG', 'Hong Kong', 'Hong Kong'),
(338, '36', 'HUN', 'Hungary', 'Hungary'),
(339, '354', 'ISL', 'Iceland', 'Iceland'),
(340, '91', 'IND', 'India', 'India'),
(341, '62', 'IDN', 'Indonesia', 'Indonesia'),
(342, '98', 'IRN', 'Iran', 'Iran'),
(343, '964', 'IRQ', 'Iraq', 'Iraq'),
(344, '353', 'IRL', 'Ireland', 'Ireland'),
(345, '44-1624', 'IMN', 'Isle of Man', 'Isle of Man'),
(346, '972', 'ISR', 'Israel', 'Israel'),
(347, '39', 'ITA', 'Italy', 'Italy'),
(348, '225', 'CIV', 'Ivory Coast', 'Ivory Coast'),
(349, '1-876', 'JAM', 'Jamaica', 'Jamaica'),
(350, '81', 'JPN', 'Japan', 'Japan'),
(351, '44-1534', 'JEY', 'Jersey', 'Jersey'),
(352, '962', 'JOR', 'Jordan', 'Jordan'),
(353, '7', 'KAZ', 'Kazakhstan', 'Kazakhstan'),
(354, '254', 'KEN', 'Kenya', 'Kenya'),
(355, '686', 'KIR', 'Kiribati', 'Kiribati'),
(356, '383', 'XKX', 'Kosovo', 'Kosovo'),
(357, '965', 'KWT', 'Kuwait', 'Kuwait'),
(358, '996', 'KGZ', 'Kyrgyzstan', 'Kyrgyzstan'),
(359, '856', 'LAO', 'Laos', 'Laos'),
(360, '371', 'LVA', 'Latvia', 'Latvia'),
(361, '961', 'LBN', 'Lebanon', 'Lebanon'),
(362, '266', 'LSO', 'Lesotho', 'Lesotho'),
(363, '231', 'LBR', 'Liberia', 'Liberia'),
(364, '218', 'LBY', 'Libya', 'Libya'),
(365, '423', 'LIE', 'Liechtenstein', 'Liechtenstein'),
(366, '370', 'LTU', 'Lithuania', 'Lithuania'),
(367, '352', 'LUX', 'Luxembourg', 'Luxembourg'),
(368, '853', 'MAC', 'Macau', 'Macau'),
(369, '389', 'MKD', 'Macedonia', 'Macedonia'),
(370, '261', 'MDG', 'Madagascar', 'Madagascar'),
(371, '265', 'MWI', 'Malawi', 'Malawi'),
(372, '60', 'MYS', 'Malaysia', 'Malaysia'),
(373, '960', 'MDV', 'Maldives', 'Maldives'),
(374, '223', 'MLI', 'Mali', 'Mali'),
(375, '356', 'MLT', 'Malta', 'Malta'),
(376, '692', 'MHL', 'Marshall Islands', 'Marshall Islands'),
(377, '222', 'MRT', 'Mauritania', 'Mauritania'),
(378, '230', 'MUS', 'Mauritius', 'Mauritius'),
(379, '262', 'MYT', 'Mayotte', 'Mayotte'),
(380, '52', 'MEX', 'Mexico', 'Mexico'),
(381, '691', 'FSM', 'Micronesia', 'Micronesia'),
(382, '373', 'MDA', 'Moldova', 'Moldova'),
(383, '377', 'MCO', 'Monaco', 'Monaco'),
(384, '976', 'MNG', 'Mongolia', 'Mongolia'),
(385, '382', 'MNE', 'Montenegro', 'Montenegro'),
(386, '1-664', 'MSR', 'Montserrat', 'Montserrat'),
(387, '212', 'MAR', 'Morocco', 'Morocco'),
(388, '258', 'MOZ', 'Mozambique', 'Mozambique'),
(389, '95', 'MMR', 'Myanmar', 'Myanmar'),
(390, '264', 'NAM', 'Namibia', 'Namibia'),
(391, '674', 'NRU', 'Nauru', 'Nauru'),
(392, '977', 'NPL', 'Nepal', 'Nepal'),
(393, '31', 'NLD', 'Netherlands', 'Netherlands'),
(394, '599', 'ANT', 'Netherlands Antilles', 'Netherlands Antilles'),
(395, '687', 'NCL', 'New Caledonia', 'New Caledonia'),
(396, '64', 'NZL', 'New Zealand', 'New Zealand'),
(397, '505', 'NIC', 'Nicaragua', 'Nicaragua'),
(398, '227', 'NER', 'Niger', 'Niger'),
(399, '234', 'NGA', 'Nigeria', 'Nigeria'),
(400, '683', 'NIU', 'Niue', 'Niue'),
(401, '850', 'PRK', 'North Korea', 'North Korea'),
(402, '1-670', 'MNP', 'Northern Mariana Islands', 'Northern Mariana Islands'),
(403, '47', 'NOR', 'Norway', 'Norway'),
(404, '968', 'OMN', 'Oman', 'Oman'),
(405, '92', 'PAK', 'Pakistan', 'Pakistan'),
(406, '680', 'PLW', 'Palau', 'Palau'),
(407, '970', 'PSE', 'Palestine', 'Palestine'),
(408, '507', 'PAN', 'Panama', 'Panama'),
(409, '675', 'PNG', 'Papua New Guinea', 'Papua New Guinea'),
(410, '595', 'PRY', 'Paraguay', 'Paraguay'),
(411, '51', 'PER', 'Peru', 'Peru'),
(412, '63', 'PHL', 'Philippines', 'Philippines'),
(413, '64', 'PCN', 'Pitcairn', 'Pitcairn'),
(414, '48', 'POL', 'Poland', 'Poland'),
(415, '351', 'PRT', 'Portugal', 'Portugal'),
(416, '1-787', 'PRI', 'Puerto Rico', 'Puerto Rico'),
(417, '974', 'QAT', 'Qatar', 'Qatar'),
(418, '242', 'COG', 'Republic of the Congo', 'Republic of the Congo'),
(419, '262', 'REU', 'Reunion', 'Reunion'),
(420, '40', 'ROU', 'Romania', 'Romania'),
(421, '7', 'RUS', 'Russia', 'Russia'),
(422, '250', 'RWA', 'Rwanda', 'Rwanda'),
(423, '590', 'BLM', 'Saint Barthelemy', 'Saint Barthelemy'),
(424, '290', 'SHN', 'Saint Helena', 'Saint Helena'),
(425, '1-869', 'KNA', 'Saint Kitts and Nevis', 'Saint Kitts and Nevis'),
(426, '1-758', 'LCA', 'Saint Lucia', 'Saint Lucia'),
(427, '590', 'MAF', 'Saint Martin', 'Saint Martin'),
(428, '508', 'SPM', 'Saint Pierre and Miquelon', 'Saint Pierre and Miquelon'),
(429, '1-784', 'VCT', 'Saint Vincent and the Grenadines', 'Saint Vincent and the Grenadines'),
(430, '685', 'WSM', 'Samoa', 'Samoa'),
(431, '378', 'SMR', 'San Marino', 'San Marino'),
(432, '239', 'STP', 'Sao Tome and Principe', 'Sao Tome and Principe'),
(433, '966', 'SAU', 'Saudi Arabia', 'Saudi Arabia'),
(434, '221', 'SEN', 'Senegal', 'Senegal'),
(435, '381', 'SRB', 'Serbia', 'Serbia'),
(436, '248', 'SYC', 'Seychelles', 'Seychelles'),
(437, '232', 'SLE', 'Sierra Leone', 'Sierra Leone'),
(438, '65', 'SGP', 'Singapore', 'Singapore'),
(439, '1-721', 'SXM', 'Sint Maarten', 'Sint Maarten'),
(440, '421', 'SVK', 'Slovakia', 'Slovakia'),
(441, '386', 'SVN', 'Slovenia', 'Slovenia'),
(442, '677', 'SLB', 'Solomon Islands', 'Solomon Islands'),
(443, '252', 'SOM', 'Somalia', 'Somalia'),
(444, '27', 'ZAF', 'South Africa', 'South Africa'),
(445, '82', 'KOR', 'South Korea', 'South Korea'),
(446, '211', 'SSD', 'South Sudan', 'South Sudan'),
(447, '34', 'ESP', 'Spain', 'Spain'),
(448, '94', 'LKA', 'Sri Lanka', 'Sri Lanka'),
(449, '249', 'SDN', 'Sudan', 'Sudan'),
(450, '597', 'SUR', 'Suriname', 'Suriname'),
(451, '47', 'SJM', 'Svalbard and Jan Mayen', 'Svalbard and Jan Mayen'),
(452, '268', 'SWZ', 'Swaziland', 'Swaziland'),
(453, '46', 'SWE', 'Sweden', 'Sweden'),
(454, '41', 'CHE', 'Switzerland', 'Switzerland'),
(455, '963', 'SYR', 'Syria', 'Syria'),
(456, '886', 'TWN', 'Taiwan', 'Taiwan'),
(457, '992', 'TJK', 'Tajikistan', 'Tajikistan'),
(458, '255', 'TZA', 'Tanzania', 'Tanzania'),
(459, '66', 'THA', 'Thailand', 'Thailand'),
(460, '228', 'TGO', 'Togo', 'Togo'),
(461, '690', 'TKL', 'Tokelau', 'Tokelau'),
(462, '676', 'TON', 'Tonga', 'Tonga'),
(463, '1-868', 'TTO', 'Trinidad and Tobago', 'Trinidad and Tobago'),
(464, '216', 'TUN', 'Tunisia', 'Tunisia'),
(465, '90', 'TUR', 'Turkey', 'Turkey'),
(466, '993', 'TKM', 'Turkmenistan', 'Turkmenistan'),
(467, '1-649', 'TCA', 'Turks and Caicos Islands', 'Turks and Caicos Islands'),
(468, '688', 'TUV', 'Tuvalu', 'Tuvalu'),
(469, '1-340', 'VIR', 'U.S. Virgin Islands', 'U.S. Virgin Islands'),
(470, '256', 'UGA', 'Uganda', 'Uganda'),
(471, '380', 'UKR', 'Ukraine', 'Ukraine'),
(472, '971', 'ARE', 'United Arab Emirates', 'United Arab Emirates'),
(473, '44', 'GBR', 'United Kingdom', 'United Kingdom'),
(474, '1', 'USA', 'United States', 'United States'),
(475, '598', 'URY', 'Uruguay', 'Uruguay'),
(476, '998', 'UZB', 'Uzbekistan', 'Uzbekistan'),
(477, '678', 'VUT', 'Vanuatu', 'Vanuatu'),
(478, '379', 'VAT', 'Vatican', 'Vatican'),
(479, '58', 'VEN', 'Venezuela', 'Venezuela'),
(480, '84', 'VNM', 'Vietnam', 'Vietnam'),
(481, '681', 'WLF', 'Wallis and Futuna', 'Wallis and Futuna'),
(482, '212', 'ESH', 'Western Sahara', 'Western Sahara'),
(483, '967', 'YEM', 'Yemen', 'Yemen'),
(484, '260', 'ZMB', 'Zambia', 'Zambia'),
(485, '263', 'ZWE', 'Zimbabwe', 'Zimbabwe');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_description`
--

CREATE TABLE `tbl_description` (
  `id` bigint(20) NOT NULL,
  `phonetic_id` bigint(20) NOT NULL,
  `description` varchar(1024) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Giải nghĩa';

-- --------------------------------------------------------

--
-- Table structure for table `tbl_dictionary`
--

CREATE TABLE `tbl_dictionary` (
  `id` bigint(20) NOT NULL COMMENT 'Mã từ điển',
  `name` varchar(255) NOT NULL COMMENT 'Tên từ điiển',
  `title` varchar(255) NOT NULL COMMENT 'Tiêu đề',
  `source_language` bigint(20) NOT NULL COMMENT 'Ngôn ngữ nguồn',
  `dest_language` bigint(20) NOT NULL COMMENT 'Ngôn ngữ đích'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Danh sách từ điển';

-- --------------------------------------------------------

--
-- Table structure for table `tbl_entity`
--

CREATE TABLE `tbl_entity` (
  `id` bigint(20) NOT NULL,
  `name` varchar(255) NOT NULL,
  `title` varchar(255) NOT NULL,
  `type` bigint(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Dách sách các thực thể';

-- --------------------------------------------------------

--
-- Table structure for table `tbl_entitytype`
--

CREATE TABLE `tbl_entitytype` (
  `id` bigint(20) NOT NULL,
  `name` varchar(255) NOT NULL,
  `title` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Các kiểu thực thể';

-- --------------------------------------------------------

--
-- Table structure for table `tbl_example`
--

CREATE TABLE `tbl_example` (
  `id` bigint(20) NOT NULL,
  `description_id` bigint(20) NOT NULL,
  `example` varchar(1024) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Các ví dụ';

-- --------------------------------------------------------

--
-- Table structure for table `tbl_favorite`
--

CREATE TABLE `tbl_favorite` (
  `id` bigint(20) NOT NULL,
  `vocabulary_id` bigint(20) NOT NULL,
  `user_id` bigint(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Từ vựng ưa thích';

-- --------------------------------------------------------

--
-- Table structure for table `tbl_language`
--

CREATE TABLE `tbl_language` (
  `id` bigint(20) NOT NULL,
  `name` varchar(255) NOT NULL,
  `title` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Các ngôn ngữ';

-- --------------------------------------------------------

--
-- Table structure for table `tbl_permission`
--

CREATE TABLE `tbl_permission` (
  `id` bigint(20) NOT NULL,
  `name` varchar(255) NOT NULL,
  `title` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Các quyền truy cập';

-- --------------------------------------------------------

--
-- Table structure for table `tbl_phonetic`
--

CREATE TABLE `tbl_phonetic` (
  `id` bigint(20) NOT NULL,
  `vocabulary_id` bigint(20) NOT NULL,
  `class_id` bigint(20) NOT NULL,
  `phonetic` int(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Phiên âm';

-- --------------------------------------------------------

--
-- Table structure for table `tbl_right`
--

CREATE TABLE `tbl_right` (
  `user_id` bigint(20) NOT NULL,
  `entity_id` bigint(20) NOT NULL,
  `permission_id` bigint(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Phân quyền';

-- --------------------------------------------------------

--
-- Table structure for table `tbl_translation`
--

CREATE TABLE `tbl_translation` (
  `id` bigint(20) NOT NULL,
  `example_id` bigint(20) NOT NULL,
  `translation` varchar(1024) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Dịch ví dụ';

-- --------------------------------------------------------

--
-- Table structure for table `tbl_user`
--

CREATE TABLE `tbl_user` (
  `id` bigint(20) NOT NULL,
  `name` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `first_name` varchar(50) NOT NULL,
  `last_name` varchar(50) DEFAULT NULL,
  `birth_day` smallint(6) NOT NULL,
  `birth_month` smallint(6) NOT NULL,
  `birth_year` int(11) NOT NULL,
  `gender` bigint(20) DEFAULT '0',
  `registered_date` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Người dùng';

-- --------------------------------------------------------

--
-- Table structure for table `tbl_usertype`
--

CREATE TABLE `tbl_usertype` (
  `id` bigint(20) NOT NULL,
  `name` varchar(255) NOT NULL,
  `title` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Kiểu tài khoản';

-- --------------------------------------------------------

--
-- Table structure for table `tbl_vocabulary`
--

CREATE TABLE `tbl_vocabulary` (
  `id` bigint(20) NOT NULL,
  `name` varchar(255) NOT NULL,
  `dictinary_id` bigint(20) NOT NULL,
  `user_id` bigint(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='từ vựng';

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_category`
--
ALTER TABLE `tbl_category`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `UN_category` (`name`),
  ADD UNIQUE KEY `id` (`id`);

--
-- Indexes for table `tbl_class`
--
ALTER TABLE `tbl_class`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `UN_class` (`name`),
  ADD UNIQUE KEY `id` (`id`);

--
-- Indexes for table `tbl_country`
--
ALTER TABLE `tbl_country`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `UN_country2` (`iso_code`),
  ADD UNIQUE KEY `UN_country3` (`name`),
  ADD UNIQUE KEY `id` (`id`);

--
-- Indexes for table `tbl_description`
--
ALTER TABLE `tbl_description`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id` (`id`);

--
-- Indexes for table `tbl_dictionary`
--
ALTER TABLE `tbl_dictionary`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `UN_dictionary1` (`name`),
  ADD UNIQUE KEY `id` (`id`);

--
-- Indexes for table `tbl_entity`
--
ALTER TABLE `tbl_entity`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `UN_entity1` (`name`),
  ADD UNIQUE KEY `id` (`id`);

--
-- Indexes for table `tbl_entitytype`
--
ALTER TABLE `tbl_entitytype`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `UN_entitytype1` (`name`),
  ADD UNIQUE KEY `id` (`id`);

--
-- Indexes for table `tbl_example`
--
ALTER TABLE `tbl_example`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tbl_favorite`
--
ALTER TABLE `tbl_favorite`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tbl_language`
--
ALTER TABLE `tbl_language`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `UN_language1` (`name`);

--
-- Indexes for table `tbl_permission`
--
ALTER TABLE `tbl_permission`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `UN_permission` (`name`);

--
-- Indexes for table `tbl_phonetic`
--
ALTER TABLE `tbl_phonetic`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tbl_translation`
--
ALTER TABLE `tbl_translation`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tbl_user`
--
ALTER TABLE `tbl_user`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `UN_user1` (`name`),
  ADD UNIQUE KEY `UN_user2` (`email`);

--
-- Indexes for table `tbl_usertype`
--
ALTER TABLE `tbl_usertype`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `UN_usertype` (`name`);

--
-- Indexes for table `tbl_vocabulary`
--
ALTER TABLE `tbl_vocabulary`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `UN_vocabulary1` (`name`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_category`
--
ALTER TABLE `tbl_category`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT COMMENT 'Mã danh mục';
--
-- AUTO_INCREMENT for table `tbl_class`
--
ALTER TABLE `tbl_class`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tbl_country`
--
ALTER TABLE `tbl_country`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT COMMENT 'Mã số', AUTO_INCREMENT=486;
--
-- AUTO_INCREMENT for table `tbl_description`
--
ALTER TABLE `tbl_description`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tbl_dictionary`
--
ALTER TABLE `tbl_dictionary`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT COMMENT 'Mã từ điển';
--
-- AUTO_INCREMENT for table `tbl_entity`
--
ALTER TABLE `tbl_entity`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tbl_entitytype`
--
ALTER TABLE `tbl_entitytype`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tbl_example`
--
ALTER TABLE `tbl_example`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tbl_favorite`
--
ALTER TABLE `tbl_favorite`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tbl_permission`
--
ALTER TABLE `tbl_permission`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tbl_phonetic`
--
ALTER TABLE `tbl_phonetic`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tbl_translation`
--
ALTER TABLE `tbl_translation`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tbl_user`
--
ALTER TABLE `tbl_user`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tbl_usertype`
--
ALTER TABLE `tbl_usertype`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tbl_vocabulary`
--
ALTER TABLE `tbl_vocabulary`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT;COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
