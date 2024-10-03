 //Task 1: Create a New Pluggable Database (PDB)
CREATE PLUGGABLE DATABASE plsql_class2024db;
ADMIN USER sa_plsqlauca IDENTIFIED BY sangwa123;
FILE_NAME_CONVERT = ('/path/to/your/seed/', '/path/to/your/plsql_class2024db/');
// Task 2: Create and Delete a Pluggable Database
Create PDB sa_to_delete_pdb;
CREATE PLUGGABLE DATABASE sa_to_delete_pdb;
ADMIN USER sa_plsqlauca IDENTIFIED BY sangwa123;
FILE_NAME_CONVERT = ('/path/to/your/seed/', '/path/to/your/sa_to_delete_pdb/');

-- Delete PDB sa_to_delete_pdb
DROP PLUGGABLE DATABASE sa_to_delete_pdb INCLUDING DATAFILES;
