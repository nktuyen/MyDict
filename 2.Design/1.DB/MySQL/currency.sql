CREATE TABLE tbl_currency(
	id SMALLINT(6) UNSIGNED NOT NULL COMMENT 'Mã tiền tệ',
	name VARCHAR(50)  NOT NULL COMMENT 'Tên tiền tệ',
	title VARCHAR(50)  NOT NULL COMMENT 'Tiêu đề',
	country_id SMALLINT(6) UNSIGNED NOT NULL COMMENT 'Quốc gia',
	is_based TINYINT(1) UNSIGNED COMMENT 'Là tiền tệ cơ sở đề các loại tiền khác tính toán theo',
	value FLOAT  NOT NULL COMMENT 'Giá trị đồng tiền so với đồng tiền cơ sở',
	FOREIGN KEY (country_id) REFERENCES tbl_country(id)
) DEFAULT CHARSET=utf8 COMMENT='Tiền tệ';
ALTER TABLE tbl_currency
	ADD PRIMARY KEY (id),
	ADD UNIQUE KEY UN_tbl_currency2 (id);
