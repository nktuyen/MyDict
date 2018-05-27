CREATE TABLE tbl_language(
	id SMALLINT(6) UNSIGNED NOT NULL COMMENT 'Mã ngôn ngữ',
	name VARCHAR(50)  NOT NULL COMMENT 'Tên ngôn ngữ',
	title VARCHAR(50)  NOT NULL COMMENT 'Tiêu đề'
) DEFAULT CHARSET=utf8 COMMENT='Ngôn ngữ';
ALTER TABLE tbl_language
	ADD PRIMARY KEY (id),
	ADD UNIQUE KEY UN_tbl_language2 (id),
	ADD UNIQUE KEY UN_tbl_language3 (name);
