USE `rappitest`;
DROP procedure IF EXISTS `Core_UpdateCube`;

DELIMITER $$
USE `rappitest`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `Core_UpdateCube`(
		  pX tinyint,
	 	  pY tinyint,
	 	  pZ tinyint,
	 	  pNodeValue bigint,
	 	  pID bigint
	     )
BEGIN

	Declare count INT;

	SELECT 
		COUNT(1) INTO count 
	FROM 
		cube 
	WHERE X = pX AND Y = pY AND Z = pZ;

	IF count = 1  THEN
		UPDATE
			cube
		SET
			NodeValue = pNodeValue
	  	WHERE X = pX AND Y = pY AND Z = pZ;
	ELSE
		CALL `Core_CreateCube`(pX, pY, pZ, pNodeValue, pID);
	END IF;

END$$

DELIMITER ;

