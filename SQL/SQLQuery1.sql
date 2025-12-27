CREATE TABLE Members(
member_ID INT IDENTITY(1,1) PRIMARY KEY,
Username NVARCHAR(50) NOT NULL UNIQUE,
MemberType NVARCHAR(20) NOT NULL,
PasswordHash NVARCHAR(255) NOT NULL
);

ALTER TABLE Members
ADD CONSTRAINT CK_Members_MemberType
CHECK (MemberType IN ('Student', 'Guest', 'Faculty', 'Staff'));
