CREATE TABLE tbl_related(
	source_vocabulary BIGINT(20) UNSIGNED NOT NULL COMMENT 'Từ vựng gốc',
	related_vocabulary BIGINT(20) UNSIGNED NOT NULL COMMENT 'Từ liên quan',
	relation_type SMALLINT(6) UNSIGNED NOT NULL COMMENT 'Kiểu quan hệ',
	FOREIGN KEY (source_vocabulary) REFERENCES tbl_vocabulary(id),
	FOREIGN KEY (related_vocabulary) REFERENCES tbl_vocabulary(id),
	FOREIGN KEY (relation_type) REFERENCES tbl_relationtype(id)
) DEFAULT CHARSET=utf8 COMMENT='Các từ liên quan';
