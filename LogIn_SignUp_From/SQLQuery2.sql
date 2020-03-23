--Go
--Create Procedure EmailidValidation_SP
--@_emailID nvarchar(50)
--as
--begin
--	select emailid from [Table] where emailid Like @_emailID;
--end;

--drop procedure if exists PasswordValidation_SP;


Go
Create Procedure PasswordValidation_SP
@_password nvarchar(50)
as
begin
	select password from [Table] where password like @_password;	
end;