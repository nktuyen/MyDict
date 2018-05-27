CREATE TABLE tbl_dictionary(
	id SMALLINT(6) UNSIGNED NOT NULL COMMENT 'Mã từ điển',
	name VARCHAR(50)  NOT NULL COMMENT 'Tên từ điển',
	title VARCHAR(50)  NOT NULL COMMENT 'Tiêu đề',
	source_language SMALLINT(6) UNSIGNED NOT NULL COMMENT 'Ngôn ngữ nguồn',
	dest_language SMALLINT(6) UNSIGNED NOT NULL COMMENT 'Ngôn ngữ đích',
	user_id BIGINT(20) UNSIGNED NOT NULL COMMENT 'Mã người dùng tạo từ điển',
	created_time TIMESTAMP  DEFAULT CURRENT_TIMESTAMP COMMENT 'Thời gian tạo từ điển',
	major TINYINT(3) UNSIGNED NOT NULL DEFAULT 1 COMMENT 'Số phiên bản',
	minor TINYINT(3) UNSIGNED DEFAULT 0 COMMENT 'Số minor phiên bản',
	build_number TINYINT(3) UNSIGNED DEFAULT 0 COMMENT 'Số dựng phiên bản',
	FOREIGN KEY (source_language) REFERENCES tbl_language(id),
	FOREIGN KEY (dest_language) REFERENCES tbl_language(id),
	FOREIGN KEY (user_id) REFERENCES tbl_user(id)
) DEFAULT CHARSET=utf8 COMMENT='Từ điển';
ALTER TABLE tbl_dictionary
	ADD PRIMARY KEY (id),
	ADD UNIQUE KEY UN_tbl_dictionary2 (id),
	ADD UNIQUE KEY UN_tbl_dictionary3 (name);
