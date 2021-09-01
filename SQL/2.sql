
--Соединяем 2 таблицы Brands и Cars с помощью внутреннего соединения на основе условия
--совпадения первичного ключа  ID таблицы Brands и внешнего ключа BrandID таблицы Cars
--Потом группируем по колонке Brands.Name
--и внутри группы делаем фильтрацию значений по количеству строк в данной группе, которые должны быть >3
SELECT Brands.Name  FROM dbo.Brands 
INNER JOIN dbo.Cars
ON dbo.Brands.ID = dbo.Cars.BrandID
GROUP BY dbo.Brands.Name
HAVING COUNT(dbo.Cars.ID) > 3