CREATE TABLE tbl_vocabulary(
	id BIGINT(20) UNSIGNED NOT NULL COMMENT 'Mã từ vựng',
	name VARCHAR(255)  NOT NULL COMMENT 'Từ vựng',
	dictionary_id SMALLINT(6) UNSIGNED NOT NULL COMMENT 'Mã từ điển của từ vựng',
	user_id BIGINT(20) UNSIGNED NOT NULL COMMENT 'Mã người dùng đã tạo từ vựng',
	FOREIGN KEY (dictionary_id) REFERENCES tbl_dictionary(id),
	FOREIGN KEY (user_id) REFERENCES tbl_user(id)
) DEFAULT CHARSET=utf8 COMMENT='Từ vựng';
ALTER TABLE tbl_vocabulary
	ADD PRIMARY KEY (id),
	ADD UNIQUE KEY UN_tbl_vocabulary2 (id),
	ADD UNIQUE KEY UN_tbl_vocabulary3 (name);
