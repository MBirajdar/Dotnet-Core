select * from student 
alter table student add PhoneNo int
select * from student
update student set  PhoneNo=111111 where RollNo=1  
update student set PhoneNo=222222 where RollNo=2
update student set PhoneNo=333333 where RollNo=3 
update student set PhoneNo=444444 where RollNo=4   
update student set PhoneNo=555555 where RollNo=5
select * from student 
alter table student add  constraint topper check(Marks>=70)
select * from student
insert into student (RollNo,StdName ,Gender ,Marks ,Gmail  )
values (6,'Mahesh', 'Male',70,'mahesg@gmail.com')
select COUNT (*) from student 
select RollNo  from student