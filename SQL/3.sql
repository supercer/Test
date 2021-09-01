
--Соединяем 2 таблицы Brands и Cars с помощью внутреннего соединения на основе условия
--совпадения первичного ключа  ID таблицы Brands и внешнего ключа BrandID таблицы Cars
--С помощью агрегатной функции SUMM по колонке Cars.Price находим сумму цен автомобилей в группах разделенных по маркам 
-- группируем по колонке Brands.Name
SELECT Brands.Name, SUM(dbo.Cars.Price) AS SummaPrice FROM dbo.Brands 
INNER JOIN dbo.Cars
ON dbo.Brands.ID = dbo.Cars.BrandID
GROUP BY dbo.Brands.Name