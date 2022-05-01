insert into [dbo].[Customer](Name,Address,PhoneNumber,CreationTime,PaymentStatus) 
   values ('DayaNand Malhi','Umerkort','3332835054',CONVERT(date, getdate()),'Unpaid');
insert into Invoice (ConsumerId,BillNo,DueAmount,SubmitAmount,TotalAmount,ReturnDueAmountDate,PurchaseDate) 
   values((select id from customer where name = 'DayaNand Malhi'), 'INR302',20000,45000,25000,CONVERT(date, getdate()+5),CONVERT(date, getdate()+5));



SELECT  C.NAME, C.PhoneNumber, I.DueAmount,I.ReturnDueAmountDate ,C.PaymentStatus  FROM Customer as C inner join Invoice as I on C.Id = I.ConsumerId and I.BillNo != '' and I.ReturnDueAmountDate < SYSDATE() order by I.DueAmount;
;
SELECT * FROM 'USER' U WHERE U.username = '' and U.password;

select  *  from Customer;
select  * from Invoice;



insert into [dbo].[Customer](Name,Address,PhoneNumber,CreationTime,PaymentStatus) 
   values ('test2','Umerkort','3332835054',SYSDATETIME(),'Paid');
insert into Invoice (ConsumerId,BillNo,DueAmount,SubmitAmount,TotalAmount,ReturnDueAmountDate,PurchaseDate) 
   values((select id from customer where name = 'test2'), '12345',600,800,1400,SYSDATE(),SYSDATE());


update Invoice 
SET ReturnDueAmountDate = '2021-09-06 20:41:09.2108445'
where ConsumerId = '2';





CREATE PROCEDURE spGetDueAmountCustomer
AS
BEGIN
	SELECT  C.NAME, C.PhoneNumber, I.DueAmount,I.ReturnDueAmountDate ,C.PaymentStatus  FROM Customer as C inner join Invoice as I on C.Id = I.ConsumerId and I.BillNo != '' and I.ReturnDueAmountDate < SYSDATE() order by I.DueAmount
END

EXEC spGetDueAmountCustomer










drop table customer
drop table Invoice
drop table [dbo].[User]

CREATE TABLE [dbo].[User] (
    [Id]            bigint NOT NULL IDENTITY,
    [Username]          VARCHAR (50) NOT NULL,
    [Password]       VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


CREATE TABLE [dbo].[Customer] (
    [Id]            BIGINT       IDENTITY (1, 1) NOT NULL,
    [Name]          VARCHAR (50) NOT NULL,
    [Address]       VARCHAR (50) NOT NULL,
    [PhoneNumber]   VARCHAR (50) NOT NULL,
    [CreationTime]  VARCHAR (50) NOT NULL,
    [PaymentStatus] CHAR (10)     NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Invoice] (
    [Id]                  BIGINT       IDENTITY (1, 1) NOT NULL,
	[ConsumerId]          Bigint,
	[BillNo]              VARCHAR (50) NOT NULL,
    [DueAmount]           INT          NOT NULL,
    [SubmitAmount]        INT          NOT NULL,
    [TotalAmount]         INT          NOT NULL,
    [ReturnDueAmountDate] VARCHAR (50) NOT NULL,
    [PurchaseDate]        VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_CustomerInvoice] FOREIGN KEY ([ConsumerId]) REFERENCES [dbo].[Customer] ([Id]),
    UNIQUE NONCLUSTERED ([BillNo] ASC)
);



