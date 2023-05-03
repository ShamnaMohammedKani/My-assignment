create table banktb(AccNo int,AccHolderName varchar(30),Balance int,RefAccNo int,NameOfReferrer varchar(20))
Insert into banktb values(101,'akshara','5000',54,'shyam'),(102,'sandhya','6000',37,'kevin'),(103,'shamna','9000',64,'shahid'),
(104,'sredha','9000',75,'manu')
select* from banktb;
 select a.AccNo as ACNO,a.AccHolderName as[Account Name],a.Balance,a.RefAccNo as[RefAcno],r.AccHolderName as [NAme obanktbf referrer]
 from banktb a join banktb r
 on r.RefAccno = a.Accno;