CREATE TABLE tbl_right(
	entity_id SMALLINT(6) UNSIGNED NOT NULL COMMENT 'Mã thực thể',
	permission_id SMALLINT(6) UNSIGNED NOT NULL COMMENT 'Mã quyền',
	user_id BIGINT(20) UNSIGNED NOT NULL COMMENT 'Mã người dùng',
	FOREIGN KEY (entity_id) REFERENCES tbl_entity(id),
	FOREIGN KEY (permission_id) REFERENCES tbl_permission(id),
	FOREIGN KEY (user_id) REFERENCES tbl_user(id)
) DEFAULT CHARSET=utf8 COMMENT='Phân quyền';
