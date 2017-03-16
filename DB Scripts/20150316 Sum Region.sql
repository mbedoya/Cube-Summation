USE `rappitest`;
DROP procedure IF EXISTS `Core_SumCubeRegion`;

DELIMITER $$
USE `rappitest`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `Core_SumCubeRegion`(
	pX1 tinyint,
	pY1 tinyint,
	pZ1 tinyint,
	pX2 tinyint,
	pY2 tinyint,
	pZ2 tinyint
)
BEGIN
	SELECT 
		IFNULL(SUM(NodeValue), 0) as Sum
	FROM 
		rappitest.cube
	WHERE
		X >= pX1 AND Y>= pY1 AND Z <= pZ1 AND
		X <= pX2 AND Y<= pY2 AND Z <= pZ2;
END$$

DELIMITER ;

