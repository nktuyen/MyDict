CREATE TABLE tbl_example(
	id BIGINT(20) UNSIGNED NOT NULL COMMENT 'Mã ví dụ',
	description_id BIGINT(20) UNSIGNED NOT NULL COMMENT 'Mã của giải nghĩa',
	example VARCHAR(1024)  NOT NULL COMMENT 'Câu ví dụ',
	FOREIGN KEY (description_id) REFERENCES tbl_description(id)
) DEFAULT CHARSET=utf8 COMMENT='Ví dụ';
ALTER TABLE tbl_example
	ADD PRIMARY KEY (id),
	ADD UNIQUE KEY UN_tbl_example2 (id);
