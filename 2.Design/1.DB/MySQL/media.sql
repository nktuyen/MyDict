CREATE TABLE tbl_media(
	id BIGINT(20) UNSIGNED NOT NULL COMMENT 'Mã đa phương tiện',
	type SMALLINT(6) UNSIGNED NOT NULL COMMENT 'Kiểu đa phương tiện',
	source VARCHAR(255)  NOT NULL COMMENT 'Nguồn',
	FOREIGN KEY (type) REFERENCES tbl_mediatype(id)
) DEFAULT CHARSET=utf8 COMMENT='Đa phương tiện';
ALTER TABLE tbl_media
	ADD PRIMARY KEY (id),
	ADD UNIQUE KEY UN_tbl_media2 (id);
