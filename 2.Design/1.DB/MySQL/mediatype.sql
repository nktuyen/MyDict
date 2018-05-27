CREATE TABLE tbl_mediatype(
	id SMALLINT(6) UNSIGNED NOT NULL COMMENT 'Mã kiểu',
	name VARCHAR(50)  NOT NULL COMMENT 'Tên kiểu',
	title VARCHAR(50)  NOT NULL COMMENT 'Tiêu đề'
) DEFAULT CHARSET=utf8 COMMENT='Kiểu đa phương tiện';
ALTER TABLE tbl_mediatype
	ADD PRIMARY KEY (id),
	ADD UNIQUE KEY UN_tbl_mediatype2 (id),
	ADD UNIQUE KEY UN_tbl_mediatype3 (name);
