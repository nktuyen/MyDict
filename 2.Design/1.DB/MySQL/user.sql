CREATE TABLE tbl_user(
	id BIGINT(20) UNSIGNED NOT NULL COMMENT 'Mã người dùng',
	name VARCHAR(255)  NOT NULL COMMENT 'Tên đăng nhập',
	alias VARCHAR(255)  NOT NULL COMMENT 'Bí danh',
	password VARCHAR(255)  NOT NULL COMMENT 'Mật khẩu',
	email VARCHAR(255)  NOT NULL COMMENT 'Địa chỉ email',
	phone VARCHAR(50)  NOT NULL COMMENT 'Số điện thoại',
	first_name VARCHAR(50)  NOT NULL COMMENT 'Tên',
	last_name VARCHAR(50)  COMMENT 'Họ',
	birth_day TINYINT(3)  NOT NULL COMMENT 'Ngày sinh',
	birth_month TINYINT(3)  NOT NULL COMMENT 'tháng sinh',
	birth_year SMALLINT(6)  NOT NULL COMMENT 'năm sinh',
	gender TINYINT(3)  NOT NULL COMMENT 'Giới tính',
	registered_date TIMESTAMP  NOT NULL DEFAULT CURRENT_TIMESTAMP COMMENT 'Ngày đăng ký',
	FOREIGN KEY (gender) REFERENCES tbl_gender(id)
) DEFAULT CHARSET=utf8 COMMENT='Người dùng';
ALTER TABLE tbl_user
	ADD PRIMARY KEY (id),
	ADD UNIQUE KEY UN_tbl_user2 (id),
	ADD UNIQUE KEY UN_tbl_user3 (name),
	ADD UNIQUE KEY UN_tbl_user4 (alias),
	ADD UNIQUE KEY UN_tbl_user5 (email),
	ADD UNIQUE KEY UN_tbl_user6 (phone);
