create table employee(
	id int NOT NULL PRIMARY KEY, 
	name varchar(50) NOT NULL, 
	age int
);

insert into employee(id,name,age) values(1,'Sumit',22);
insert into employee(id,name,age) values(2,'Yogesh',24);

update employee set name='Risab' where id=2;

delete from employee where id = 2;

select * from employee;

insert into employee(name,age) values('Yogesh',24);

CREATE TABLE DEPT (
 DEPTNO              integer NOT NULL,
 DNAME               varchar(14),
 LOC                 varchar(13),
 CONSTRAINT DEPT_PRIMARY_KEY PRIMARY KEY (DEPTNO));

 select * from DEPT

INSERT INTO DEPT VALUES (10,'ACCOUNTING','NEW YORK');
INSERT INTO DEPT VALUES (20,'RESEARCH','DALLAS');
INSERT INTO DEPT VALUES (30,'SALES','CHICAGO');
INSERT INTO DEPT VALUES (40,'OPERATIONS','BOSTON');

CREATE TABLE EMP (
 EMPNO               integer NOT NULL,
 ENAME               varchar(10),
 JOB                 varchar(9),
 MGR                 integer CONSTRAINT EMP_SELF_KEY REFERENCES EMP (EMPNO),
 HIREDATE            DATEtime,
 SAL                 money,
 COMM                money,
 DEPTNO              integer NOT NULL,
 CONSTRAINT EMP_FOREIGN_KEY FOREIGN KEY (DEPTNO) REFERENCES DEPT (DEPTNO),
 CONSTRAINT EMP_PRIMARY_KEY PRIMARY KEY (EMPNO));

INSERT INTO EMP VALUES (7839,'KING','PRESIDENT',NULL,'17-NOV-81',5000,NULL,10);
INSERT INTO EMP VALUES (7698,'BLAKE','MANAGER',7839,'1-MAY-81',2850,NULL,30);
INSERT INTO EMP VALUES (7782,'CLARK','MANAGER',7839,'9-JUN-81',2450,NULL,10);
INSERT INTO EMP VALUES (7566,'JONES','MANAGER',7839,'2-APR-81',2975,NULL,20);
INSERT INTO EMP VALUES (7654,'MARTIN','SALESMAN',7698,'28-SEP-81',1250,1400,30);
INSERT INTO EMP VALUES (7499,'ALLEN','SALESMAN',7698,'20-FEB-81',1600,300,30);
INSERT INTO EMP VALUES (7844,'TURNER','SALESMAN',7698,'8-SEP-81',1500,0,30);
INSERT INTO EMP VALUES (7900,'JAMES','CLERK',7698,'3-DEC-81',950,NULL,30);
INSERT INTO EMP VALUES (7521,'WARD','SALESMAN',7698,'22-FEB-81',1250,500,30);
INSERT INTO EMP VALUES (7902,'FORD','ANALYST',7566,'3-DEC-81',3000,NULL,20);
INSERT INTO EMP VALUES (7369,'SMITH','CLERK',7902,'17-DEC-80',800,NULL,20);
INSERT INTO EMP VALUES (7788,'SCOTT','ANALYST',7566,'09-DEC-82',3000,NULL,20);
INSERT INTO EMP VALUES (7876,'ADAMS','CLERK',7788,'12-JAN-83',1100,NULL,20);
INSERT INTO EMP VALUES (7934,'MILLER','CLERK',7782,'23-JAN-82',1300,NULL,10);

select * from EMP;

/*Display all employees in ascending order of name
dislay all employees in dpet 10
display all employees in dept 10,20
display all emps who are clerks*/

select * from EMP order by ENAME;

select * from EMP where DEPTNO = 10;

select * from EMP where DEPTNO = 10 OR DEPTNO = 20;

select * from EMP where JOB = 'clerk';

/*DISPLAY THE EMP JOINING DATE AND THE TENURE FROM JOINING
DISPLAY ALL EMPLOYEES WHO HAVE SAME JOB DESIGNATION AS "SMITH"
DISPLAYY ALL EMPLOYEES WORKING IN DEPT OF SCOTT */

select HIREDATE, DATEDIFF(YEAR,HIREDATE,GETDATE()) As Tenure from EMP

select * from EMP where JOB = (select job from emp where ename='smith');

select * from EMP where DEPTNO = (select DEPTNO from emp where ENAME = 'scott');

/*DISPLAY ALL THE DEPTMENTS , WITH EMPLOYEES IF ANY (IF NO EMPS THEN DISPLAY NULL)*/

select DEPT.DNAME, EMP.ENAME from DEPT left join EMP on emp.DEPTNO = DEPT.DEPTNO;

/*display all depatments which have no emp*/
select DEPT.DNAME from DEPT where DEPT.DEPTNO not in(select DEPTNO from EMP); 

/*DISPLAY THE DEPTWISE, HEADCOUNT*/
select DNAME,COUNT(*) AS 'No of Employee' from DEPT inner join EMP on EMP.DEPTNO = DEPT.DEPTNO group by DEPT.DNAME;

/*DISPLAY NO OF EMPLOYEES*/
select COUNT(*) AS 'No of Employee' from EMP;

/*DISPLAY SUM OF SALARIES OF EMPLOYEEESS*/
select SUM(EMP.SAL) AS 'Sum of Salaries of Employees' from EMP;

/*DISPLAY AVG OF SALARIES OF EMPLOYEEESS*/
select AVG(EMP.SAL) AS 'Avarage Salaries of Employees' from EMP;

/*DISPLAY SUM,AVG,COUNT OF EMPLOYEES*/
/*select SUM(EMPNO) AS 'Total EMPs', AVG(EMPNO) AS 'Average EMPs', COUNT(EMPNO) AS 'No of Employee' from EMP*/

/*DISPLAY THE JOBWIE HEADOCUNT*/
select JOB, COUNT(*) AS 'No of Employee' from EMP inner join DEPT on EMP.DEPTNO = DEPT.DEPTNO group by EMP.JOB;

/*DISPLAY THE DEPTWISE, JOBWIE HEADOCUNT*/
select DNAME,JOB, COUNT(*) AS 'No of Employee' from EMP inner join DEPT on EMP.DEPTNO = DEPT.DEPTNO group by EMP.JOB,DEPT.DNAME;

/*DISPLAY THE DEPTWISE EMPLOYEES WHOSE COUNT GREATER THAN 2 
AND WHO ARE IN DEPT 10 ,20.SORTY THE RESULT BY DESCENDING ORDER OF COUNT*/

select DEPT.DNAME, COUNT(*) AS 'No of Employee' from DEPT left join EMP on EMP.DEPTNO = DEPT.DEPTNO 
group by DEPT.DEPTNO,DEPT.DNAME having COUNT(*) > 2 AND DEPT.DEPTNO in (10,20) order by [No of Employee] DESC;


INSERT INTO EMP VALUES (7980,'JOHN','CLERK',7782,'23-JAN-82',1300,NULL,10);

INSERT INTO EMP VALUES (7981,'Rohan','CLERK',7782,'23-JAN-82',1300,NULL,10);


