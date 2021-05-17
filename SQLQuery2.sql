create table [dbo].[CUSTOMER_TYPE]
(
   [ID] INT NOT NULL,
   [TYPE] VARCHAR (20) not null unique,
   PRIMARY KEY CLUSTERED ([ID] ASC),
   [dbo].[CUSTOMER_TYPE] integer not null default 1,
);



