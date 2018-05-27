CREATE TABLE tbl_country(
	id SMALLINT(6) UNSIGNED NOT NULL COMMENT 'Mã quốc gia bằng số',
	country_code VARCHAR(50)  NOT NULL COMMENT 'Mã quốc gia bằng ký tự',
	iso_code VARCHAR(50)  NOT NULL COMMENT 'Mã iso cho quốc gia',
	name VARCHAR(50)  NOT NULL COMMENT 'Tên quốc gia',
	title VARCHAR(50)  NOT NULL COMMENT 'Tiêu đề',
	primary_language SMALLINT(6) UNSIGNED NOT NULL COMMENT 'Ngôn ngữ sử dụng',
	FOREIGN KEY (primary_language) REFERENCES tbl_language(id)
) DEFAULT CHARSET=utf8 COMMENT='Quốc gia';
ALTER TABLE tbl_country
	ADD PRIMARY KEY (id),
	ADD UNIQUE KEY UN_tbl_country2 (id),
	ADD UNIQUE KEY UN_tbl_country3 (country_code),
	ADD UNIQUE KEY UN_tbl_country4 (iso_code),
	ADD UNIQUE KEY UN_tbl_country5 (name);
