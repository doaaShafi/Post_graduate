INSERT INTO Payment(amount,noOfInstallments ,fundPercentage )
Values(7000,2,0.3)
INSERT INTO Payment(amount,noOfInstallments,fundPercentage )
Values(7639,2,0.25)
INSERT INTO Payment(amount,noOfInstallments,fundPercentage )
Values(9300,3,0.15)
INSERT INTO Payment(amount,noOfInstallments,fundPercentage )
Values(7025,2,0.1)
INSERT INTO Payment(amount,noOfInstallments,fundPercentage )
Values(8976,3,0.3)

insert into Payment (amount,noOfInstallments, fundPercentage) 
values(3000,3,0.2);
insert into payment (amount,noOfInstallments, fundPercentage)
values (500, 3, 0.8)
insert into payment (amount,noOfInstallments, fundPercentage)
values (600, 2, 0.86)
insert into payment (amount,noOfInstallments, fundPercentage)
values (4500, 3, 0.9)
insert into payment (amount,noOfInstallments, fundPercentage)
values (5500, 2, 0.5)
insert into payment (amount,noOfInstallments, fundPercentage)
values (340, 2, 0.8)

insert into Payment (amount,noOfInstallments, fundPercentage) values(3300,3,0.3);

insert into Payment (amount, noOfInstallments, fundPercentage) values(5000,5,0.4);
insert into Payment (amount, noOfInstallments, fundPercentage) values(6000,3,0.4);
insert into Payment (amount,noOfInstallments, fundPercentage) values(2000,1,0);
insert into Payment (amount,noOfInstallments, fundPercentage) values(2000,1,0);
insert into Payment(amount,noOfInstallments, fundPercentage) values(2000,2,0);







--6
INSERT INTO Thesis(field,type , title ,startDate ,endDate , defenseDate,grade ,payment_id ,noOfExtensions )
Values('Computer Science' ,'MS','Analysis of Algorithms' ,'2019/12/3','2020/12/15','2021/1/12',87,6,2)
--7
INSERT INTO Thesis(field,type , title ,startDate ,endDate , defenseDate,grade ,payment_id ,noOfExtensions )
Values('Biology','MS' ,'Animal behavior ecology.' ,'2019/06/15','2021/1/16','2021/5/21',80,8,3)

--8
INSERT INTO Thesis(field,type , title ,startDate ,endDate , defenseDate,grade ,payment_id ,noOfExtensions )
Values('Law','MS' ,'Forced Migration ' ,'2017/7/23','2018/12/15','2020/1/12',92,7,2)

--9
INSERT INTO Thesis(field,type , title ,startDate ,endDate , defenseDate,grade ,payment_id ,noOfExtensions )
Values('Computer Science' ,'MS','Analysis of Algorithms' ,'2019/4/16','2020/12/15','2021/1/12',73,9,1)

--10
INSERT INTO Thesis(field,type , title ,startDate ,endDate , defenseDate,grade ,payment_id ,noOfExtensions )
Values('Management' ,'MS','  Employee Commitment  ' ,'2019/09/12','2020/12/15','2021/1/12',87,10,2)


--11
insert into Thesis ( field, type, title, startDate, endDate, defenseDate, grade,
payment_id, noOfExtensions) 
values('Mathematics','Phd','Th11','2021/12/22 00:12:00', '2022/12/22 00:12:00' , '2023/1/22 00:12:00' , 90,11,2)

--12
insert into Thesis ( field, type, title, startDate, endDate, defenseDate, grade,
payment_id, noOfExtensions) 
values('Chemistry','Phd','Th12','2021/8/22 00:12:00', '2022/7/22 00:12:00' , '2023/1/22 00:12:00' , 75,12,5)

--13

insert into Thesis (field, type, title, startDate, endDate, defenseDate, grade,
payment_id, noOfExtensions) 
values('Science','Phd','Th13','2021/9/22 00:12:00', '2022/9/22 00:12:00' , '2023/1/22 00:12:00' , 50,13,3)

--14

insert into Thesis ( field, type, title, startDate, endDate, defenseDate, grade,
payment_id, noOfExtensions) 
values('Mathematics','MSc','Th14','2021/10/22 00:12:00', '2023/2/22 00:12:00' , '2024/1/22 00:12:00' , 80,14,2)

--15

insert into Thesis ( field, type, title, startDate, endDate, defenseDate, grade,
payment_id, noOfExtensions) 
values('Engineering','MSc','Th15','2021/2/22 00:12:00', '2024/12/22 00:12:00' , '2025/1/22 00:12:00' , 40,15,2)

--1
insert into Thesis ( field, type, title, startDate, endDate,defenseDate,grade,
payment_id, noOfExtensions) values ('math','Phd','integration','2020/1/1','2021/1/1','2021/1/3',90,1,2);

--2
insert into Thesis (field, type, title, startDate, endDate,defenseDate,grade,
payment_id, noOfExtensions) values('physics','MS','electricity','2019/3/1','2020/3/1','2020/4/1',95,2,4);


--3
insert into Thesis ( field, type, title, startDate, endDate,defenseDate,grade,
payment_id, noOfExtensions) values('chemistry','MS','atom','2019/5/1','2020/6/1','2020/8/1',96,3,3);


--4
insert into Thesis ( field, type, title, startDate, endDate,defenseDate,grade,
payment_id, noOfExtensions) values('cs','MS','data strctures','2012/5/1','2014/6/1','2015/8/1',80,4,3);


--5
insert into Thesis ( field, type, title, startDate, endDate,defenseDate,grade,
payment_id, noOfExtensions) values('data base','Phd','sql','2019/7/1','2020/7/1','2020/9/1',50,5,5);

--16
insert into Thesis( field, type, title, startDate, endDate,defenseDate,grade,
payment_id, noOfExtensions) Values ('Pharmacy','MS','Nanotechnology','2013/1/1','2014/1/1','2014/6/1',92,16,2)





-----------------------------------------

--B)USERS
insert into PostGradUser ( email, password)
values ('aaa@hotmail.com', 'Annoying')
insert into PostGradUser ( email, password)
values ('bbb@hotmail.com', 'Boring')

insert into GucianStudent(id,firstName, lastName, type, faculty, address, GPA, undergradID)
values(1,'Ahmed','Mohamed','Phd','Medicine','Al-rehab' , 0.8, 36123)

insert into GucianStudent(id,firstName, lastName, type, faculty, address, GPA, undergradID)
values(2,'Haitham','Mohamed','MSc','Engineering','Al-rehab' , 1.5, 33653)

insert into PostGradUser ( email, password)
values ('mai@hotmail.com', 'Blablabla')
insert into PostGradUser ( email, password)
values ('noura@hotmail.com', 'sighh')

insert into NonGucianStudent( id,firstName, lastName, type,faculty,address,GPA )
values (3,'Mai', 'Ali' , 'Phd', 'Pharmacy' , 'Nasr city', 1.6)

insert into NonGucianStudent( id,firstName, lastName, type,faculty,address,GPA )
values (4,'Noura', 'Mahmoud' , 'Phd', 'Architecture' , 'Nasr city', 1.8)


insert into PostGradUser ( email, password)
values ('mohsen@hotmail.com', 'Hello')
insert into PostGradUser ( email, password)
values ('maria@hotmail.com', 'Hiii')
insert into PostGradUser ( email, password)
values ('mostafa@hotmail.com', 'ByeBye')

insert into Supervisor (id, name, faculty)
values (5,'Mohsen Ashraf', 'Medicine')

insert into Supervisor (id, name, faculty)
values (6,'Maria Habib', 'Pharmacy')

insert into Supervisor (id, name, faculty)
values (7,'Mostafa Ezzat', 'Engineering')




insert into PostGradUser (email, password) values('ali.esam@gmail.com','koko12');
insert into GucianStudent( id,firstName, lastName, type, faculty, address, GPA, undergradID)
values(8,'ali','esam','MS','cs','cairo',.75,494678);

insert into PostGradUser (email, password) values('nesrin.helmy@gmail.com','koko13');
insert into GucianStudent( id,firstName, lastName, type, faculty, address, GPA, undergradID)
values(9,'nesrin','helmy','Phd','iet','cairo',.85,494679);

insert into PostGradUser (email, password) values('emad.shafi@gmail.com','memom16');
insert into NonGucianStudent( id,firstName, lastName, type, faculty, address, GPA)
values(10,'emad','shafi','MS','power','giza',3);

insert into PostGradUser (email, password) values('hala.eyad@gmail.com','htht16');
insert into NonGucianStudent( id,firstName, lastName, type, faculty, address, GPA)
values(11,'hala','eyad','MS','mechatronics','cairo',2.5);

insert into PostGradUser (email, password) values('adham.ali@gmail.com','lolo');
insert into Admin(id) values(12);

insert into PostGradUser (email, password) values('ahmed.ali@gmail.com','ahlam');
insert into Admin(id) values(13);

INSERT INTO PostGradUser (email, password) values('kamal.elsherif@gmail.com','5444635');
Insert into  GucianStudent( id,firstName, lastName, type, faculty, address, GPA, undergradID)
values(14,'Kamal','elsherif','MS','iet','cairo',.85,28-4679);

INSERT INTO PostGradUser (email, password) values('amgad.tarek@gmail.com','564735');
Insert into  GucianStudent( id,firstName, lastName, type, faculty, address, GPA, undergradID)
values(15,'Amgad','Tarek','Phd','iet','cairo',.85,37-4679);

INSERT INTO PostGradUser (email, password) values('Kareem.tawfik@gmail.com','hgudjhg5');
INSERT INTO Examiner  Values (16,'Kareem Tawfik', 'Computer Science',1)

INSERT INTO PostGradUser (email, password) values('Kareem.tawfik@gmail.com','hgudjhg5');
INSERT INTO Examiner Values (17,'Amir Monir', 'Biology',1)

INSERT INTO PostGradUser (email, password) values('Kareem.tawfik@gmail.com','hgudjhg5');
INSERT INTO Examiner Values (18,'Samia Fahmy', 'Management',1)

INSERT INTO PostGradUser (email, password) values('Kareem.tawfik@gmail.com','hgudjhg5');
INSERT INTO Examiner Values (19,'Angela Mark', 'Law',0)


insert into Course (fees,creditHours, code) values(3000,4,'cs1010');

insert into Course (fees,creditHours, code) values(4000,6,'cs590');

insert into Course (fees,creditHours, code) 
values(4000,4,'CSEN 102')

insert into Course (fees,creditHours, code) 
values(6000,4,'DMET 501')


insert into NonGucianStudentTakeCourse(sid,cid,grade)values(3,1,90);
insert into NonGucianStudentTakeCourse(sid,cid,grade)values(3,3,90);
insert into NonGucianStudentTakeCourse(sid,cid,grade)values(4,1,90);
insert into NonGucianStudentTakeCourse(sid,cid,grade)values(4,2,90);


--Non GUCians

insert into NonGUCianStudentRegisterThesis (sid, supid, serial_no) 
values (3,5,1)
insert into NonGUCianStudentRegisterThesis (sid, supid, serial_no) 
values (4,5,2)
insert into NonGUCianStudentRegisterThesis (sid, supid, serial_no) 
values (3,5,3)

select * from NonGUCianStudent
--GUCians
INSERT INTO GUCianStudentRegisterThesis (sid, supid , serial_no) values(1,5,12);

INSERT INTO GUCianStudentRegisterThesis (sid, supid , serial_no) values(1,5,13);


select * from Payment