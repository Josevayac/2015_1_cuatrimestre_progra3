CREATE TABLE repuesto(

	id int IDENTITY(1,1) primary key NOT NULL,
	nombre varchar(100) NOT NULL,
	modelo varchar(100) NOT NULL,
	marca varchar(100) NOT NULL,
	cantidad decimal(18,2) NOT NULL,
	precio decimal(18,2) NOT NULL,
	impuesto decimal(18,2) NOT NULL,
	gravado bit NOT NULL
)
