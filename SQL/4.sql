
--��������� 3 ������� Cars , Brands � Countries � ������� ����������� ���������� �� ������ �������
--� ������� ���������� ������� AVG �� ������� Cars.Pow ������� ������� �������� ����������� � ������� ����������� �� �������� ����� 
-- ���������� �� ������� Countries.Name
--��������� �� �������� ������������ ������� ��������

SELECT TOP 2 Countries.Name, AVG(Cars.Pow) AS AveragePower FROM dbo.Cars 
INNER JOIN dbo.Brands ON Cars.BrandID = Brands.ID INNER JOIN dbo.Countries ON Brands.CountryID = Countries.ID
GROUP BY Countries.Name
ORDER BY AVG(Cars.Pow) DESC