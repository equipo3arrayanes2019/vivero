DROP USER IF EXISTS 'programa'@'%';
CREATE USER 'programa'@'%' IDENTIFIED WITH mysql_native_password BY '123';
GRANT ALL PRIVILEGES ON MeGusta.* TO 'programa'@'%';
FLUSH PRIVILEGES;
