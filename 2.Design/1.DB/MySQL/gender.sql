CREATE TABLE tbl_gender(
	id TINYINT(3) UNSIGNED NOT NULL COMMENT 'Mã giới tính',
	name VARCHAR(50)  NOT NULL COMMENT 'Tên giới tính',
	title VARCHAR(50)  NOT NULL COMMENT 'Tiêu đề'
) DEFAULT CHARSET=utf8 COMMENT='Giới tính';
ALTER TABLE tbl_gender
	ADD PRIMARY KEY (id),
	ADD UNIQUE KEY UN_tbl_gender2 (id),
	ADD UNIQUE KEY UN_tbl_gender3 (name);
