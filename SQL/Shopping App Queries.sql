create table customer(
	ID integer NOT NULL PRIMARY KEY,
	FNAME varchar(50) NOT NULL,
	LNAME varchar(50),
	MOB varchar(20) NOT NULL
 );

create table corder(
 ID integer NOT NULL PRIMARY KEY,
 ODATE DATE,
 CID integer NOT NULL,
 CONSTRAINT ORDER_FOREIGN_KEY FOREIGN KEY (CID) REFERENCES customer(ID));

  create table product(
 ID integer NOT NULL PRIMARY KEY,
 PNAME varchar(50) NOT NULL,
 PRICE int NOT NULL
 );

 create table lineitem(
 ID integer NOT NULL PRIMARY KEY,
 QTY integer,
 OID integer NOT NULL,
 PID integer NOT NULL Unique,
 CONSTRAINT LINEITEM_PID_FOREIGN_KEY FOREIGN KEY (PID) REFERENCES product(ID),
 CONSTRAINT LINEITEM_FOREIGN_KEY FOREIGN KEY (OID) REFERENCES corder(ID));

 select * from product;

/*Get no of order of each customer*/
 select customer.FNAME, COUNT(*) As 'No of order of customer' from corder 
 left join customer on corder.CID = customer.ID group by customer.FNAME;

 /*Customer total bill of order*/
 /*select customer.FNAME, COUNT(*) As 'No of order of customer' from corder 
 left join customer on corder.CID = customer.ID group by customer.FNAME;*/

/*Get Total Price of each line-item*/
select product.PNAME, product.PRICE,lineitem.QTY,product.PRICE * lineitem.QTY as 'Total Price' 
from product left join lineitem on lineitem.PID = product.ID
