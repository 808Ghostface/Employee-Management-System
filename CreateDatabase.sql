CREATE TABLE [dbo].[WorkersInfo] (
    [Id]            INT           IDENTITY (1, 1) NOT NULL,
    [first]         NVARCHAR (50) NULL,
    [last]          NVARCHAR (50) NULL,
    [job_role]      NVARCHAR (50) NULL,
    [address]       NVARCHAR (50) NULL,
    [postcode]      NVARCHAR (50) NULL,
    [email_address] NVARCHAR (50) NULL,
    [hire_date]     DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


CREATE TABLE [dbo].[ManagementInfo] (
    [TagID]   INT            IDENTITY (1, 1) NOT NULL,
    [Id]      INT            NULL,
    [Date]    DATETIME       NULL,
    [Comment] NVARCHAR (MAX) NULL,
    CONSTRAINT [ManagementInfoFK] FOREIGN KEY ([Id]) REFERENCES [dbo].[WorkersInfo] ([Id])
);

CREATE PROCEDURE [dbo].[ComWorkandManage]
	@Combine int = 0
AS
	SELECT WorkersInfo.Id, WorkersInfo.first, WorkersInfo.last, ManagementInfo.Date, ManagementInfo.Comment
	FROM WorkersInfo
	JOIN ManagementInfo 
        ON WorkersInfo.Id = ManagementInfo.Id
    WHERE WorkersInfo.Id = @Combine
RETURN 0

CREATE PROCEDURE [dbo].[GetWorkerByID]
	@GetWorkerID int = 0
AS
	SELECT WorkersInfo.Id, WorkersInfo.first, WorkersInfo.last, WorkersInfo.job_role, WorkersInfo.hire_date
	FROM WorkersInfo
	JOIN ManagementInfo
	ON WorkersInfo.Id = ManagementInfo.Id
	WHERE WorkersInfo.Id = @GetWorkerID
RETURN 0

CREATE PROCEDURE [dbo].[ViewID] 

AS
BEGIN

	SELECT WorkersInfo.Id, WorkersInfo.first, WorkersInfo.last, WorkersInfo.job_role, WorkersInfo.hire_date
	FROM WorkersInfo

	SET NOCOUNT ON;

END
