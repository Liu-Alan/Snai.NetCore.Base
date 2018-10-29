CREATE DATABASE ceshi
;

CREATE TABLE students(
	id INT AUTO_INCREMENT PRIMARY KEY,			-- 自增列需为主键
	`name` NVARCHAR(32) NOT NULL DEFAULT ' ',
	sex TINYINT NOT NULL DEFAULT 1,				-- 0 男生，1 女生，2 保密
	age INT NOT NULL DEFAULT 0
)
;

-- alter table students add primary key pk_students (id)  	
ALTER TABLE students ADD INDEX ix_name(`name`)  		-- UNIQUE INDEX 唯一索引