

--C помощью внутреннего соединения таблицы Cars с самой собой находим пересечение нужных значений указанных в условии
SELECT Cars.Name, Cars.BaseID  FROM dbo.Cars 
INNER JOIN dbo.Cars AS c
ON  Cars.BaseID = c.ID AND Cars.BrandID = c.BrandID
