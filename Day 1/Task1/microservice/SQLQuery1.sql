--BACKUP DATABASE ReturnManagementSystem
--TO DISK = 'C:\MigrationTraining\ReturnManagementSystem.bak';

--RESTORE FILELISTONLY
--FROM DISK = '/var/opt/mssql/backup/ReturnManagementSystem.bak';

RESTORE DATABASE ReturnManagementSystem
FROM DISK = '/var/opt/mssql/backup/ReturnManagementSystem.bak'
WITH MOVE 'ReturnManagementSystem' TO '/var/opt/mssql/data/ReturnManagementSystem.mdf',
     MOVE 'ReturnManagementSystem_Log' TO '/var/opt/mssql/data/ReturnManagementSystem_log.ldf';