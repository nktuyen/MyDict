CREATE TABLE tbl_entity(
	id SMALLINT(6) UNSIGNED NOT NULL COMMENT 'Mã thực thể',
	name VARCHAR(50)  NOT NULL COMMENT 'Tên thực thể',
	title VARCHAR(50)  NOT NULL COMMENT 'Tiêu đề',
	type SMALLINT(6) UNSIGNED NOT NULL COMMENT 'Kiểu',
	FOREIGN KEY (type) REFERENCES tbl_entitytype(id)
) DEFAULT CHARSET=utf8 COMMENT='Các thực thể';
ALTER TABLE tbl_entity
	ADD PRIMARY KEY (id),
	ADD UNIQUE KEY UN_tbl_entity2 (id),
	ADD UNIQUE KEY UN_tbl_entity3 (name);
