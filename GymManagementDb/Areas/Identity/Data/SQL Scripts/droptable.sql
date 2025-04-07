ALTER TABLE Workouts
ADD CONSTRAINT FK_Workouts_Trainers
FOREIGN KEY (TrainerID) REFERENCES Trainers(TrainerID);