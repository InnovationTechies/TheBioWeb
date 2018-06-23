Create Table UserProfile  
    (  
        UserId int primary key identity(1, 1),  
        UserName varchar(50),  
        Password varchar(50),  
        IsActive bit  
    ) 