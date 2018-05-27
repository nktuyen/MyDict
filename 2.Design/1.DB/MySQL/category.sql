CREATE TABLE tbl_category(
	id BIGINT(20) UNSIGNED NOT NULL COMMENT 'Mã danh mục',
	parent_id BIGINT(20) UNSIGNED NOT NULL COMMENT 'Mã danh mục cha',
	name VARCHAR(50)  NOT NULL COMMENT 'Tên danh mục',
	title VARCHAR(50)  NOT NULL COMMENT 'Tiêu đề danh mục'
) DEFAULT CHARSET=utf8 COMMENT='Các danh mục';
ALTER TABLE tbl_category
	ADD PRIMARY KEY (id),
	ADD UNIQUE KEY UN_tbl_category2 (id),
	ADD UNIQUE KEY UN_tbl_category3 (name);
