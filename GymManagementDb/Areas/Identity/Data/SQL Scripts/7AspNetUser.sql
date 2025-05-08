INSERT INTO AspNetUsers(
    Id, FirstName, LastName, Join_Date, Email, Phone, WorkoutID, UserName,
    NormalizedUserName, NormalizedEmail, EmailConfirmed, PasswordHash,
    SecurityStamp, ConcurrencyStamp, PhoneNumber, PhoneNumberConfirmed,
    TwoFactorEnabled, LockoutEnd, LockoutEnabled, AccessFailedCount
) 
VALUES
('1', 'John', 'Doe', '2025-05-02', 'john.doe@example.com', '123-456-7890', 1, 'johndoe', 
 'JOHNDOE', 'JOHN.DOE@EXAMPLE.COM', 1, 'hashedpassword123', 'securitystamp123', 
 'concurrency123', '123-456-7890', 1, 0, NULL, 0, 0),

('2', 'Jane', 'Smith', '2025-04-20', 'jane.smith@example.com', '234-567-8901', 2, 'janesmith', 
 'JANESMITH', 'JANE.SMITH@EXAMPLE.COM', 1, 'hashedpassword456', 'securitystamp456', 
 'concurrency456', '234-567-8901', 1, 0, '2025-06-01T00:00:00+00:00', 0, 3),

('3', 'Alice', 'Johnson', '2025-03-15', 'alice.johnson@example.com', '345-678-9012', 3, 'alicejohnson', 
 'ALICEJOHNSON', 'ALICE.JOHNSON@EXAMPLE.COM', 1, 'hashedpassword789', 'securitystamp789', 
 'concurrency789', '345-678-9012', 1, 1, NULL, 1, 2),

('4', 'Bob', 'Brown', '2025-01-10', 'bob.brown@example.com', '456-789-0123', 4, 'bobbrown', 
 'BOBBROWN', 'BOB.BROWN@EXAMPLE.COM', 1, 'hashedpassword101', 'securitystamp101', 
 'concurrency101', '456-789-0123', 0, 1, NULL, 0, 1);

 
select* from AspNetUsers