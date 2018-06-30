CREATE TABLE tbl_language(
	id SMALLINT(6) UNSIGNED NOT NULL COMMENT 'Mã ngôn ngữ',
	name VARCHAR(50)  NOT NULL COMMENT 'Tên ngôn ngữ',
	title VARCHAR(50)  NOT NULL COMMENT 'Tiêu đề'
) DEFAULT CHARSET=utf8 COMMENT='Ngôn ngữ';
ALTER TABLE tbl_language
	ADD PRIMARY KEY (id),
	ADD UNIQUE KEY UN_tbl_language2 (id),
	ADD UNIQUE KEY UN_tbl_language3 (name);
CREATE TABLE tbl_country(
	id SMALLINT(6) UNSIGNED NOT NULL COMMENT 'Mã quốc gia bằng số',
	country_code VARCHAR(50)  NOT NULL COMMENT 'Mã quốc gia bằng ký tự',
	iso_code VARCHAR(50)  NOT NULL COMMENT 'Mã iso cho quốc gia',
	name VARCHAR(50)  NOT NULL COMMENT 'Tên quốc gia',
	title VARCHAR(50)  NOT NULL COMMENT 'Tiêu đề',
	primary_language SMALLINT(6) UNSIGNED NOT NULL COMMENT 'Ngôn ngữ sử dụng',
	FOREIGN KEY (primary_language) REFERENCES tbl_language(id)
) DEFAULT CHARSET=utf8 COMMENT='Quốc gia';
ALTER TABLE tbl_country
	ADD PRIMARY KEY (id),
	ADD UNIQUE KEY UN_tbl_country2 (id),
	ADD UNIQUE KEY UN_tbl_country3 (country_code),
	ADD UNIQUE KEY UN_tbl_country4 (iso_code),
	ADD UNIQUE KEY UN_tbl_country5 (name);
CREATE TABLE tbl_gender(
	id TINYINT(3) UNSIGNED NOT NULL COMMENT 'Mã giới tính',
	name VARCHAR(50)  NOT NULL COMMENT 'Tên giới tính',
	title VARCHAR(50)  NOT NULL COMMENT 'Tiêu đề'
) DEFAULT CHARSET=utf8 COMMENT='Giới tính';
ALTER TABLE tbl_gender
	ADD PRIMARY KEY (id),
	ADD UNIQUE KEY UN_tbl_gender2 (id),
	ADD UNIQUE KEY UN_tbl_gender3 (name);
CREATE TABLE tbl_user(
	id BIGINT(20) UNSIGNED NOT NULL COMMENT 'Mã người dùng',
	name VARCHAR(255)  NOT NULL COMMENT 'Tên đăng nhập',
	alias VARCHAR(255)  COMMENT 'Bí danh',
	password VARCHAR(255)  NOT NULL COMMENT 'Mật khẩu',
	email VARCHAR(255)  NOT NULL COMMENT 'Địa chỉ email',
	phone VARCHAR(50)  NOT NULL COMMENT 'Số điện thoại',
	first_name VARCHAR(50)  NOT NULL COMMENT 'Tên',
	last_name VARCHAR(50)  COMMENT 'Họ',
	birth_day TINYINT(3)  NOT NULL COMMENT 'Ngày sinh',
	birth_month TINYINT(3)  NOT NULL COMMENT 'tháng sinh',
	birth_year SMALLINT(6)  NOT NULL COMMENT 'năm sinh',
	gender TINYINT(3) UNSIGNED NOT NULL COMMENT 'Giới tính',
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
CREATE TABLE tbl_class(
	id TINYINT(3) UNSIGNED NOT NULL COMMENT 'Mã lớp từ',
	name VARCHAR(50)  NOT NULL COMMENT 'Tên lớp từ',
	title VARCHAR(50)  NOT NULL COMMENT 'Tiêu đề'
) DEFAULT CHARSET=utf8 COMMENT='Lớp từ vựng (danh từ, động từ, …)';
ALTER TABLE tbl_class
	ADD PRIMARY KEY (id),
	ADD UNIQUE KEY UN_tbl_class2 (id),
	ADD UNIQUE KEY UN_tbl_class3 (name);
CREATE TABLE tbl_category(
	id BIGINT(20) UNSIGNED NOT NULL COMMENT 'Mã danh mục',
	parent_id BIGINT(20) UNSIGNED DEFAULT 0 COMMENT 'Mã danh mục cha',
	name VARCHAR(50)  NOT NULL COMMENT 'Tên danh mục',
	title VARCHAR(50)  NOT NULL COMMENT 'Tiêu đề danh mục'
) DEFAULT CHARSET=utf8 COMMENT='Các danh mục';
ALTER TABLE tbl_category
	ADD PRIMARY KEY (id),
	ADD UNIQUE KEY UN_tbl_category2 (id),
	ADD UNIQUE KEY UN_tbl_category3 (name);
CREATE TABLE tbl_mediatype(
	id SMALLINT(6) UNSIGNED NOT NULL COMMENT 'Mã kiểu',
	name VARCHAR(50)  NOT NULL COMMENT 'Tên kiểu',
	title VARCHAR(50)  NOT NULL COMMENT 'Tiêu đề'
) DEFAULT CHARSET=utf8 COMMENT='Kiểu đa phương tiện';
ALTER TABLE tbl_mediatype
	ADD PRIMARY KEY (id),
	ADD UNIQUE KEY UN_tbl_mediatype2 (id),
	ADD UNIQUE KEY UN_tbl_mediatype3 (name);
CREATE TABLE tbl_media(
	id BIGINT(20) UNSIGNED NOT NULL COMMENT 'Mã đa phương tiện',
	type SMALLINT(6) UNSIGNED NOT NULL COMMENT 'Kiểu đa phương tiện',
	source VARCHAR(255)  NOT NULL COMMENT 'Nguồn',
	FOREIGN KEY (type) REFERENCES tbl_mediatype(id)
) DEFAULT CHARSET=utf8 COMMENT='Đa phương tiện';
ALTER TABLE tbl_media
	ADD PRIMARY KEY (id),
	ADD UNIQUE KEY UN_tbl_media2 (id);
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
CREATE TABLE tbl_relationtype(
	id SMALLINT(6) UNSIGNED NOT NULL COMMENT 'Mã kiểu',
	name VARCHAR(50)  NOT NULL COMMENT 'Tên kiểu quan hệ',
	title VARCHAR(50)  NOT NULL COMMENT 'Tiêu đề'
) DEFAULT CHARSET=utf8 COMMENT='Kiểu quan hệ';
ALTER TABLE tbl_relationtype
	ADD PRIMARY KEY (id),
	ADD UNIQUE KEY UN_tbl_relationtype2 (id),
	ADD UNIQUE KEY UN_tbl_relationtype3 (name);
CREATE TABLE tbl_related(
	source_vocabulary BIGINT(20) UNSIGNED NOT NULL COMMENT 'Từ vựng gốc',
	related_vocabulary BIGINT(20) UNSIGNED NOT NULL COMMENT 'Từ liên quan',
	relation_type SMALLINT(6) UNSIGNED NOT NULL COMMENT 'Kiểu quan hệ',
	FOREIGN KEY (source_vocabulary) REFERENCES tbl_vocabulary(id),
	FOREIGN KEY (related_vocabulary) REFERENCES tbl_vocabulary(id),
	FOREIGN KEY (relation_type) REFERENCES tbl_relationtype(id)
) DEFAULT CHARSET=utf8 COMMENT='Các từ liên quan';
CREATE TABLE tbl_categorization(
	vocabulary_id BIGINT(20) UNSIGNED NOT NULL COMMENT 'Mã từ vựng',
	class_id TINYINT(3) UNSIGNED NOT NULL COMMENT 'Mã class',
	category_id BIGINT(20) UNSIGNED NOT NULL COMMENT 'Mã danh mục',
	FOREIGN KEY (vocabulary_id) REFERENCES tbl_vocabulary(id),
	FOREIGN KEY (class_id) REFERENCES tbl_class(id),
	FOREIGN KEY (category_id) REFERENCES tbl_category(id)
) DEFAULT CHARSET=utf8 COMMENT='Phân loại từ vựng';
CREATE TABLE tbl_entitytype(
	id SMALLINT(6) UNSIGNED NOT NULL COMMENT 'Mã kiểu thực thể',
	name VARCHAR(50)  NOT NULL COMMENT 'Tên kiểu thực thể',
	title VARCHAR(50)  NOT NULL COMMENT 'Tiêu đề'
) DEFAULT CHARSET=utf8 COMMENT='Các kiểu thực thể';
ALTER TABLE tbl_entitytype
	ADD PRIMARY KEY (id),
	ADD UNIQUE KEY UN_tbl_entitytype2 (id),
	ADD UNIQUE KEY UN_tbl_entitytype3 (name);
CREATE TABLE tbl_entity(
	id SMALLINT(6) UNSIGNED NOT NULL COMMENT 'Mã thực thể',
	name VARCHAR(50)  NOT NULL COMMENT 'Tên thực thể',
	title VARCHAR(50)  NOT NULL COMMENT 'Tiêu đề',
	type SMALLINT(6) UNSIGNED NOT NULL COMMENT 'Kiểu',
	FOREIGN KEY (type) REFERENCES tbl_entitytype(id)
) DEFAULT CHARSET=utf8 COMMENT='Các thực thể';
ALTER TABLE tbl_entity
	ADD PRIMARY KEY (id),
	ADD UNIQUE KEY UN_tbl_entity2 (id),
	ADD UNIQUE KEY UN_tbl_entity3 (name);
CREATE TABLE tbl_permission(
	id SMALLINT(6) UNSIGNED NOT NULL COMMENT 'Mã quyền',
	name VARCHAR(50)  NOT NULL COMMENT 'Tên quyền',
	title VARCHAR(50)  NOT NULL COMMENT 'Tiêu đề'
) DEFAULT CHARSET=utf8 COMMENT='Quyền';
ALTER TABLE tbl_permission
	ADD PRIMARY KEY (id),
	ADD UNIQUE KEY UN_tbl_permission2 (id),
	ADD UNIQUE KEY UN_tbl_permission3 (name);
CREATE TABLE tbl_right(
	entity_id SMALLINT(6) UNSIGNED NOT NULL COMMENT 'Mã thực thể',
	permission_id SMALLINT(6) UNSIGNED NOT NULL COMMENT 'Mã quyền',
	user_id BIGINT(20) UNSIGNED NOT NULL COMMENT 'Mã người dùng',
	FOREIGN KEY (entity_id) REFERENCES tbl_entity(id),
	FOREIGN KEY (permission_id) REFERENCES tbl_permission(id),
	FOREIGN KEY (user_id) REFERENCES tbl_user(id)
) DEFAULT CHARSET=utf8 COMMENT='Phân quyền';
CREATE TABLE tbl_phonetic(
	id BIGINT(20) UNSIGNED NOT NULL COMMENT 'Mã phiên âm',
	vocabulary_id BIGINT(20) UNSIGNED NOT NULL COMMENT 'Mã từ vựng',
	class_id TINYINT(3) UNSIGNED NOT NULL COMMENT 'Mã lớp',
	phonetic VARCHAR(50)  NOT NULL COMMENT 'Phiên âm',
	FOREIGN KEY (vocabulary_id) REFERENCES tbl_vocabulary(id),
	FOREIGN KEY (class_id) REFERENCES tbl_class(id)
) DEFAULT CHARSET=utf8 COMMENT='Phiên âm';
ALTER TABLE tbl_phonetic
	ADD PRIMARY KEY (id),
	ADD UNIQUE KEY UN_tbl_phonetic2 (id);
CREATE TABLE tbl_description(
	id BIGINT(20) UNSIGNED NOT NULL COMMENT 'Mã của giải nghĩa',
	phonetic_id BIGINT(20) UNSIGNED NOT NULL COMMENT 'Mã của phiên âm',
	description VARCHAR(255)  NOT NULL COMMENT 'Giải nghĩa',
	FOREIGN KEY (phonetic_id) REFERENCES tbl_phonetic(id)
) DEFAULT CHARSET=utf8 COMMENT='Giải nghĩa';
ALTER TABLE tbl_description
	ADD PRIMARY KEY (id),
	ADD UNIQUE KEY UN_tbl_description2 (id);
CREATE TABLE tbl_example(
	id BIGINT(20) UNSIGNED NOT NULL COMMENT 'Mã ví dụ',
	description_id BIGINT(20) UNSIGNED NOT NULL COMMENT 'Mã của giải nghĩa',
	example VARCHAR(1024)  NOT NULL COMMENT 'Câu ví dụ',
	FOREIGN KEY (description_id) REFERENCES tbl_description(id)
) DEFAULT CHARSET=utf8 COMMENT='Ví dụ';
ALTER TABLE tbl_example
	ADD PRIMARY KEY (id),
	ADD UNIQUE KEY UN_tbl_example2 (id);
CREATE TABLE tbl_currency(
	id SMALLINT(6) UNSIGNED NOT NULL COMMENT 'Mã tiền tệ',
	name VARCHAR(50)  NOT NULL COMMENT 'Tên tiền tệ',
	title VARCHAR(50)  NOT NULL COMMENT 'Tiêu đề',
	country_id SMALLINT(6) UNSIGNED NOT NULL COMMENT 'Quốc gia',
	is_based TINYINT(1) UNSIGNED COMMENT 'Là tiền tệ cơ sở đề các loại tiền khác tính toán theo',
	value FLOAT  NOT NULL COMMENT 'Giá trị đồng tiền so với đồng tiền cơ sở',
	FOREIGN KEY (country_id) REFERENCES tbl_country(id)
) DEFAULT CHARSET=utf8 COMMENT='Tiền tệ';
ALTER TABLE tbl_currency
	ADD PRIMARY KEY (id),
	ADD UNIQUE KEY UN_tbl_currency2 (id);

