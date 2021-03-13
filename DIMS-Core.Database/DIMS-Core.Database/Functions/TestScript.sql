-- tests for functions --
-- GetFullAge
DECLARE @BirthOfDate DATETIME;

SET @BirthOfDate = '1993-10-28';

SELECT dbo.GetFullAge(@BirthOfDate)

-- add here next one function with sample how to chek it