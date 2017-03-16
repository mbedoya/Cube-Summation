USE `rappitest`;
DROP procedure IF EXISTS `Core_DeleteCube`;

DELIMITER $$
USE `rappitest`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `Core_DeleteCube`()
BEGIN

	DELETE
	FROM 
        cube;
END$$

DELIMITER ;
