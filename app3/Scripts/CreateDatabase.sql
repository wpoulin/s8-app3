create database app3;
 
 create table app3.Users (
   id INT NOT NULL AUTO_INCREMENT,
   username VARCHAR(50) NOT NULL,
   password VARCHAR(50) NOT NULL,
   PRIMARY KEY ( id )
);
 
 create table app3.Nuclear_codes (
   id INT NOT NULL AUTO_INCREMENT,
   code VARCHAR(50) NOT NULL,
   PRIMARY KEY ( id )
);

INSERT INTO app3.users (username, password) 
VALUES ("kim", "jongun");

INSERT INTO app3.nuclear_codes (code)
VALUES ("uh-oh");

INSERT INTO app3.nuclear_codes (code)
VALUES ("byebyeTrump");
