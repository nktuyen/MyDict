CREATE TABLE tbl_class(
	id TINYINT(3) UNSIGNED NOT NULL COMMENT 'Mã lớp từ',
	name VARCHAR(50)  NOT NULL COMMENT 'Tên lớp từ',
	title VARCHAR(50)  NOT NULL COMMENT 'Tiêu đề'
) DEFAULT CHARSET=utf8 COMMENT='Lớp từ vựng (danh từ, động từ, …)';
ALTER TABLE tbl_class
	ADD PRIMARY KEY (id),
	ADD UNIQUE KEY UN_tbl_class2 (id),
	ADD UNIQUE KEY UN_tbl_class3 (name);
