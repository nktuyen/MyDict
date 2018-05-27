CREATE TABLE tbl_relationtype(
	id SMALLINT(6) UNSIGNED NOT NULL COMMENT 'Mã kiểu',
	name VARCHAR(50)  NOT NULL COMMENT 'Tên kiểu quan hệ',
	title VARCHAR(50)  NOT NULL COMMENT 'Tiêu đề'
) DEFAULT CHARSET=utf8 COMMENT='Kiểu quan hệ';
ALTER TABLE tbl_relationtype
	ADD PRIMARY KEY (id),
	ADD UNIQUE KEY UN_tbl_relationtype2 (id),
	ADD UNIQUE KEY UN_tbl_relationtype3 (name);
