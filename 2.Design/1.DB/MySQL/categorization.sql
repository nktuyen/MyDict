CREATE TABLE tbl_categorization(
	vocabulary_id BIGINT(20) UNSIGNED NOT NULL COMMENT 'Mã từ vựng',
	class_id TINYINT(3) UNSIGNED NOT NULL COMMENT 'Mã class',
	category_id BIGINT(20) UNSIGNED NOT NULL COMMENT 'Mã danh mục',
	FOREIGN KEY (vocabulary_id) REFERENCES tbl_vocabulary(id),
	FOREIGN KEY (class_id) REFERENCES tbl_class(id),
	FOREIGN KEY (category_id) REFERENCES tbl_category(id)
) DEFAULT CHARSET=utf8 COMMENT='Phân loại từ vựng';
