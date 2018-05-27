CREATE TABLE tbl_description(
	id BIGINT(20) UNSIGNED NOT NULL COMMENT 'Mã của giải nghĩa',
	phonetic_id BIGINT(20) UNSIGNED NOT NULL COMMENT 'Mã của phiên âm',
	description VARCHAR(255)  NOT NULL COMMENT 'Giải nghĩa',
	FOREIGN KEY (phonetic_id) REFERENCES tbl_phonetic(id)
) DEFAULT CHARSET=utf8 COMMENT='Giải nghĩa';
ALTER TABLE tbl_description
	ADD PRIMARY KEY (id),
	ADD UNIQUE KEY UN_tbl_description2 (id);
