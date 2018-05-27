CREATE TABLE tbl_dictionary(
	id SMALLINT(6) UNSIGNED NOT NULL COMMENT 'Mã từ điển',
	name VARCHAR(50)  NOT NULL COMMENT 'Tên từ điển',
	title VARCHAR(50)  NOT NULL COMMENT 'Tiêu đề',
	source_language SMALLINT(6) UNSIGNED NOT NULL COMMENT 'Ngôn ngữ nguồn',
	dest_language SMALLINT(6) UNSIGNED NOT NULL COMMENT 'Ngôn ngữ đích',
	FOREIGN KEY (source_language) REFERENCES tbl_language(id),
	FOREIGN KEY (dest_language) REFERENCES tbl_language(id)
) DEFAULT CHARSET=utf8 COMMENT='Từ điển';
ALTER TABLE tbl_dictionary
	ADD PRIMARY KEY (id),
	ADD UNIQUE KEY UN_tbl_dictionary2 (id),
	ADD UNIQUE KEY UN_tbl_dictionary3 (name);
