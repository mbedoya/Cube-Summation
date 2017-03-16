USE rappitest;

DROP procedure IF EXISTS `Core_GetAllCube`;
-- --------------------------------------------------------------------------------
-- Routine DDL
-- Note: comments before and after the routine body will not be stored by the server
-- --------------------------------------------------------------------------------
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `Core_GetAllCube`()
BEGIN
	SELECT
		  X,
	 	  Y,
	 	  Z,
	 	  NodeValue,
	 	  ID
	  	FROM 
        cube;
END$$

DELIMITER ;


 

DROP procedure IF EXISTS `Core_GetCubeById`;
-- --------------------------------------------------------------------------------
-- Routine DDL
-- Note: comments before and after the routine body will not be stored by the server
-- --------------------------------------------------------------------------------
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `Core_GetCubeById`(pId bigint )
BEGIN
	SELECT
		  X,
	 	  Y,
	 	  Z,
	 	  NodeValue,
	 	  ID
	  	FROM 
        cube
	WHERE
		ID = pId;
END$$

DELIMITER ;





DROP procedure IF EXISTS `Core_UpdateCube`;
-- --------------------------------------------------------------------------------
-- Routine DDL
-- Note: comments before and after the routine body will not be stored by the server
-- --------------------------------------------------------------------------------
DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `Core_UpdateCube`(
		  pX tinyint,
	 	  pY tinyint,
	 	  pZ tinyint,
	 	  pNodeValue bigint,
	 	  pID bigint
	     )
BEGIN

	UPDATE
	    cube
	SET 		
			  X = pX,
	 	  Y = pY,
	 	  Z = pZ,
	 	  NodeValue = pNodeValue,
	 	  ID = pID
	  	WHERE ID = pID;

END$$

DELIMITER ;

DROP procedure IF EXISTS `Core_CreateCube`;
-- --------------------------------------------------------------------------------
-- Routine DDL
-- Note: comments before and after the routine body will not be stored by the server
-- --------------------------------------------------------------------------------
DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `Core_CreateCube`(
		  pX tinyint,
	 	  pY tinyint,
	 	  pZ tinyint,
	 	  pNodeValue bigint,
	 	  pID bigint
	     )
BEGIN

	INSERT INTO
	    cube
	(		  X,
		 		  Y,
		 		  Z,
		 		  NodeValue,
		 )
	VALUES
	(		  pX,
		 		  pY,
		 		  pZ,
		 		  pNodeValue,
		 );	
	
   SELECT LAST_INSERT_ID() AS ID;

END$$

DELIMITER ;

 

DROP procedure IF EXISTS `Core_DeleteCube`;
-- --------------------------------------------------------------------------------
-- Routine DDL
-- Note: comments before and after the routine body will not be stored by the server
-- --------------------------------------------------------------------------------
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `Core_DeleteCube`(pId bigint )
BEGIN

	DELETE
	FROM 
        cube
	WHERE
		ID = pId;
END$$

DELIMITER ;

