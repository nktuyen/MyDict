CREATE TABLE tbl_phonetic(
	id BIGINT(20) UNSIGNED NOT NULL COMMENT 'Mã phiên âm',
	vocabulary_id BIGINT(20) UNSIGNED NOT NULL COMMENT 'Mã từ vựng',
	class_id BIGINT(20) UNSIGNED NOT NULL COMMENT 'Mã lớp',
	phonetic VARCHAR(50)  NOT NULL COMMENT 'Phiên âm',
	FOREIGN KEY (vocabulary_id) REFERENCES tbl_vocabulary(id),
	FOREIGN KEY (class_id) REFERENCES tbl_class(id)
) DEFAULT CHARSET=utf8 COMMENT='Phiên âm';
ALTER TABLE tbl_phonetic
	ADD PRIMARY KEY (id),
	ADD UNIQUE KEY UN_tbl_phonetic2 (id);
