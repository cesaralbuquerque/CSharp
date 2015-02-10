
----------------------------------------------------
EXEC sp_MSForEachTable 'ALTER TABLE webpages_UsersInRoles NOCHECK CONSTRAINT ALL' 
GO 

EXEC sp_MSForEachTable 'TRUNCATE TABLE webpages_UsersInRoles' 
GO 

EXEC sp_MSForEachTable 'ALTER TABLE webpages_UsersInRoles CHECK CONSTRAINT ALL' 
GO


----------------------------------------------------
EXEC sp_MSForEachTable 'ALTER TABLE webpages_OAuthMembership NOCHECK CONSTRAINT ALL' 
GO 

EXEC sp_MSForEachTable 'TRUNCATE TABLE webpages_OAuthMembership' 
GO 

EXEC sp_MSForEachTable 'ALTER TABLE webpages_OAuthMembership CHECK CONSTRAINT ALL' 
GO



----------------------------------------------------
EXEC sp_MSForEachTable 'ALTER TABLE webpages_Membership NOCHECK CONSTRAINT ALL' 
GO 

EXEC sp_MSForEachTable 'TRUNCATE TABLE webpages_Membership' 
GO 

EXEC sp_MSForEachTable 'ALTER TABLE webpages_Membership CHECK CONSTRAINT ALL' 
GO


----------------------------------------------------
EXEC sp_MSForEachTable 'ALTER TABLE Fornecedores NOCHECK CONSTRAINT ALL' 
GO 

EXEC sp_MSForEachTable 'TRUNCATE TABLE Fornecedores' 
GO 

EXEC sp_MSForEachTable 'ALTER TABLE Fornecedores CHECK CONSTRAINT ALL' 
GO


----------------------------------------------------
EXEC sp_MSForEachTable 'ALTER TABLE webpages_Roles NOCHECK CONSTRAINT ALL' 
GO 

EXEC sp_MSForEachTable 'TRUNCATE TABLE webpages_Roles' 
GO 

EXEC sp_MSForEachTable 'ALTER TABLE webpages_Roles CHECK CONSTRAINT ALL' 
GO



----------------------------------------------------
EXEC sp_MSForEachTable 'ALTER TABLE UserProfile NOCHECK CONSTRAINT ALL' 
GO 

EXEC sp_MSForEachTable 'TRUNCATE TABLE UserProfile' 
GO 

EXEC sp_MSForEachTable 'ALTER TABLE UserProfile CHECK CONSTRAINT ALL' 
GO
