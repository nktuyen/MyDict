CREATE TABLE tbl_permission(
	id SMALLINT(6) UNSIGNED NOT NULL COMMENT 'Mã quyền',
	name VARCHAR(50)  NOT NULL COMMENT 'Tên quyền',
	title VARCHAR(50)  NOT NULL COMMENT 'Tiêu đề'
) DEFAULT CHARSET=utf8 COMMENT='Quyền';
ALTER TABLE tbl_permission
	ADD PRIMARY KEY (id),
	ADD UNIQUE KEY UN_tbl_permission2 (id),
	ADD UNIQUE KEY UN_tbl_permission3 (name);
