CREATE TABLE tbl_entitytype(
	id SMALLINT(6) UNSIGNED NOT NULL COMMENT 'Mã kiểu thực thể',
	name VARCHAR(50)  NOT NULL COMMENT 'Tên kiểu thực thể',
	title VARCHAR(50)  NOT NULL COMMENT 'Tiêu đề'
) DEFAULT CHARSET=utf8 COMMENT='Các kiểu thực thể';
ALTER TABLE tbl_entitytype
	ADD PRIMARY KEY (id),
	ADD UNIQUE KEY UN_tbl_entitytype2 (id),
	ADD UNIQUE KEY UN_tbl_entitytype3 (name);
