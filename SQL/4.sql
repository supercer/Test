
--Соединяем 3 таблицы Cars , Brands и Countries с помощью внутреннего соединения на основе условий
--С помощью агрегатной функции AVG по колонке Cars.Pow находим среднию мощность автомобилей в группах разделенных по названию стран 
-- группируем по колонке Countries.Name
--Сортируем по убыванию относительно средней мощности

SELECT TOP 2 Countries.Name, AVG(Cars.Pow) AS AveragePower FROM dbo.Cars 
INNER JOIN dbo.Brands ON Cars.BrandID = Brands.ID INNER JOIN dbo.Countries ON Brands.CountryID = Countries.ID
GROUP BY Countries.Name
ORDER BY AVG(Cars.Pow) DESC