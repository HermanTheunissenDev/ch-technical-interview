USE MyCompany
CREATE LOGIN MyUser WITH PASSWORD = '12345';
create user MyUser for login MyUser

EXEC sp_addrolemember N'db_owner', N'MyUser'
