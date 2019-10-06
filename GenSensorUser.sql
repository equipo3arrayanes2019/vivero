DROP USER IF EXISTS 'sensor'@'%';
CREATE USER 'sensor'@'%' IDENTIFIED WITH mysql_native_password BY '123';
GRANT ALL PRIVILEGES ON MeGusta.* TO 'sensor'@'%';