CREATE TABLE [dbo].[CUSTOMER] (
    [ID]  INT   IDENTITY (1, 1) NOT NULL,
    [NAME] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
       CUSTOMER_TYPE integer NOT NULL default 1,
   constraint fk_user_customer_type foreign key (CUSTOMER_TYPE) references [DBO].[CUSTOMER_TYPE] (ID)
);