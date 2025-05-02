INSERT INTO AspNetUsers (Id, First_Name, Last_Name, Join_Date, MembershipTpyeID, MembershipTypeID,Email, Phone_Number, WorkoutID, UserName, NormalizedUserName, NormalizedEmail,EmailConfirmed, PasswordHash, SecurityStamp, ConcurrencyStamp, PhoneNumber, PhoneNumberConfirmed, TwoFactorEnabled, LockoutEnd, LockoutEnabled, AccessFailedCount) 
VALUES
('1', 'John', 'Doe', '2025-05-02', 1, 1, 'john.doe@example.com', '123-456-7890', 101, 'johndoe', 
 'JOHNDOE', 'JOHN.DOE@EXAMPLE.COM', 1, 'hashedpassword123', 'securitystamp123', 
 'concurrency123', '123-456-7890', 1, 0, NULL, 0, 0),
 
('2', 'Jane', 'Smith', '2025-04-20', 2, 2, 'jane.smith@example.com', '234-567-8901', 102, 'janesmith', 
 'JANESMITH', 'JANE.SMITH@EXAMPLE.COM', 1, 'hashedpassword456', 'securitystamp456', 
 'concurrency456', '234-567-8901', 1, 0, '2025-06-01T00:00:00+00:00', 0, 3),

('3', 'Alice', 'Johnson', '2025-03-15', 1, 1, 'alice.johnson@example.com', '345-678-9012', 103, 'alicejohnson', 
 'ALICEJOHNSON', 'ALICE.JOHNSON@EXAMPLE.COM', 1, 'hashedpassword789', 'securitystamp789', 
 'concurrency789', '345-678-9012', 1, 1, NULL, 1, 2),

('4', 'Bob', 'Brown', '2025-01-10', 3, 3, 'bob.brown@example.com', '456-789-0123', 104, 'bobbrown', 
 'BOBBROWN', 'BOB.BROWN@EXAMPLE.COM', 1, 'hashedpassword101', 'securitystamp101', 
 'concurrency101', '456-789-0123', 0, 1, NULL, 0, 1);


select* from AspNetUsers