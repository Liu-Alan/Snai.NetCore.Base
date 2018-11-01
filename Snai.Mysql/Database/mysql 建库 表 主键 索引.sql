CREATE DATABASE ceshi
;

USE ceshi
;

CREATE TABLE student(
	id INT AUTO_INCREMENT PRIMARY KEY,			-- 自增列需为主键
	`name` NVARCHAR(32) NOT NULL DEFAULT '',
	sex TINYINT NOT NULL DEFAULT 1,				-- 0 男生，1 女生，2 保密
	age INT NOT NULL DEFAULT 0
)
;

-- alter table student add primary key pk_student (id)  	
ALTER TABLE student ADD INDEX ix_name(`name`)  		-- UNIQUE INDEX 唯一索引