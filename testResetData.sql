usp_testingResetDataDELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_testingResetData`()
BEGIN

-- disable foreign key constraints first
	set foreign_key_checks=0;
    set sql_safe_updates=0;
	delete from app_user;
	
INSERT app_user (app_user_id, name) VALUES (1, 'TEST1');
INSERT app_user (app_user_id, name) VALUES (2, 'TEST2');
INSERT app_user (app_user_id, name) VALUES (3, 'TEST3');
INSERT app_user (app_user_id, name) VALUES (4, 'TEST4');
INSERT app_user (app_user_id, name) VALUES (5, 'TEST5');

-- enable foreign key constraints
	set foreign_key_checks=1;
	set sql_safe_updates=1;
END$$
DELIMITER ;